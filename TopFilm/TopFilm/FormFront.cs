using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
// "Data Source=DESKTOP-1OE5FC5\\BIGDATA;Initial Catalog=TopFilm_Database;Integrated Security=True";
namespace TopFilm
{
    public partial class TopFilm : Form
    {
        private string nickLoggedIn;
        private static string dataSourceServerName = "DESKTOP-1OE5FC5\\BIGDATA";
         private static string conString = "Data Source="+ dataSourceServerName +";Initial Catalog=TopFilmDatabase;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);                       // con = conn
        SqlCommand command;
        SqlCommand command_amount;
        SqlDataAdapter reader;
        ImageList List_of_Icons = new ImageList();
        private string sql;
        // Tytuł filmu, na który wskazuje kursor
        string titleOfSelectedMovie;
        // ID użytkownika
        int _UserID;
        // ID filmu
        private int MovieID;
        // Nazwa filmu
        private string titleOfMovie;
        // Ocena filmu
        private int rating;
        // suma ocen jakie wystawił użytkownik - potrzebne to definicji tablicy
        private int x;
        // tablica z ID filmu i jego oceną wystawioną przez użytkownika
        private int[,] rates;
        // liczba wystawionych ocen dla poszczególnego filmu
        private int numberOfRatings;
        // zmienna przechowujaca wpiany text w wyszukiwarkę
        private string searchEngineText;

        public TopFilm(int UserID = 0, string ifLoggedIn = "0")
        {
            InitializeComponent();
            
            nickLoggedIn = ifLoggedIn;

            if (nickLoggedIn != "0")
            {
                buttonLog.Visible = false;
                buttonRegister.Visible = false;
                label_logged_in.Visible = true;
                label_logged_in.Text = $"Zalogowano jako {nickLoggedIn}";
                buttonLogout.Visible = true;
            }
            _UserID = UserID;
        }

        /// <summary>
        /// Funkcja ustawia parametry listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopFilm_Load(object sender, EventArgs e)
        {
            // kolor
            listViewMovies.BackColor = Color.FloralWhite;
            // dodaje listę ikon do listView
            listViewMovies.SmallImageList = List_of_Icons;

            // LV PROPERTIES 
            listViewMovies.View = View.Details;
            List_of_Icons.ImageSize = new Size(256, 256);

            // CONSTRUCT COLUMNS
            listViewMovies.Columns.Add("Film", 500);
            listViewMovies.Columns.Add("Średnia ocen", 150);
            listViewMovies.Columns.Add("Twoja ocena", 150);

            listView_Load();

        }
        /// <summary>
        /// Funkcja pobierająca dane z bazy dany do wyświetlenia w listGrid
        /// </summary>
        private void listView_Load()
        {
            // wyczyszczenie tabeli
            listViewMovies.Items.Clear();
            List_of_Icons.Images.Clear();
            // wywolanie funkcji sprawdzajacej ile uzytkownik ocenil filmow
            x = Number_Of_Rates_Of_User();
            // wywoluje funkcje sprawdzajacej ktore filmy ocenil uzytkownik i jakie oceny im wystawil
            rates = RatesOfUser();
            // sprawdza czy jest wpisany tekst w wyszukiwarke
            try
            {
                searchEngineText = textBoxSearchEngine.Text;
                if (searchEngineText == "")
                {
                    sql = "SELECT COUNT(*) FROM Movie";
                }
                else
                {
                    sql = $"SELECT COUNT (*) FROM Movie WHERE MovieName LIKE '%{searchEngineText}%'";
                }
                if (con.State != ConnectionState.Open)
                    con.Open();
                command_amount = new SqlCommand(sql, con);
                SqlDataReader reader_amount = command_amount.ExecuteReader();
                reader_amount.Read();
                string amount = reader_amount[0].ToString();
                con.Close();

                if (searchEngineText == "")
                {
                    sql = " SELECT [MovieID],[MovieName],[Avg_Rating],[IconFile], [Number_Of_Ratings]FROM [dbo].[Movie] ORDER BY [Avg_Rating] DESC";
                }
                else
                {
                    sql = $" SELECT [MovieID],[MovieName],[Avg_Rating],[IconFile], [Number_Of_Ratings]FROM [dbo].[Movie] WHERE MovieName LIKE '%{searchEngineText}%' ORDER BY [Avg_Rating] DESC";
                }
                if (con.State != ConnectionState.Open)
                    con.Open();
                command = new SqlCommand(sql, con);
                SqlDataReader reader = command.ExecuteReader();


                reader.Read();
                if (reader.HasRows)
                {
                    for (int i = 0; i < Convert.ToInt32(amount); i++)
                    {
                        // ID filmu
                        MovieID = Convert.ToInt32(reader[0]);
                        // Nazwa filmu
                        titleOfMovie = reader[1].ToString();
                        // Ocena filmu
                        rating = Convert.ToInt32(reader[2]);
                        // Ikona filmu
                        byte[] img = (byte[])reader[3];
                        MemoryStream MS = new MemoryStream(img);
                        List_of_Icons.Images.Add(Image.FromStream(MS));
                        // Liczba ocen filmu
                        numberOfRatings = Convert.ToInt32(reader[4]);

                        // Tworzy listę itemu, który zawiera  tytul filmu, jego ocene i ikonę
                        // Nastepnie dodaje ten item do listView

                        // tworzenie listy danych o obiekcie
                        ListViewItem item = new ListViewItem(titleOfMovie);
                        // ikona filmu
                        item.ImageIndex = i;
                        // druga kolumna zawiera ocenę filmu i liczbę głosów
                        item.SubItems.Add("       " + rating.ToString() + "   głosów: " + numberOfRatings.ToString());
                        // if czy użytkownik jest zalogowany 
                        // jeżeli tak to wyświetla także jego oceny filmów
                        bool rated = false;
                        // jeżeli użytkownik jest zalogowany to sprawdza czy użytkownik ocenił dany film
                        if (nickLoggedIn != "0")
                        {
                            for (int r = 0; r < x; r++)
                            {
                                if (rates[r, 0] == MovieID)
                                {
                                    item.SubItems.Add("               " + rates[r, 1].ToString());
                                    rated = true;
                                }
                            }
                        }
                        // jeżeli użytkownik jest zalogowany lecz nie ocenił danego filmu  LUB  nie jest zalogowany
                        if (nickLoggedIn != "0" && rated == false || nickLoggedIn == "0")
                        {
                            item.SubItems.Add("          -".ToString());
                        }
                        if (i % 2 == 0)
                            item.BackColor = Color.Cornsilk;
                        listViewMovies.Items.Add(item);
                        // dodanie ID filmu po wrzuceniu danych do tabeli, tak aby ta informacja nie została wyświetlana
                        item.SubItems.Add(MovieID.ToString());
                        reader.Read();
                    }

                }
                else
                {
                    MessageBox.Show("Problem z odczytaniem danych z bazy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        /// <summary>
        /// Funkcja zwracjaca liczbę ocen jaką użytkownik wystawił
        /// </summary>
        /// <returns></returns>
        private int Number_Of_Rates_Of_User()
        {
            int number = 1;
            string sql = " SELECT COUNT([Rating]) FROM [dbo].[UserRating]" +
                  "JOIN [dbo].[Users] ON [UserRating].IDUser = [Users].[UserID] " +
                  "WHERE " +
                  $"IDUser = '{_UserID}' ";
            if(con.State != ConnectionState.Open)
            con.Open();
            SqlCommand command5 = new SqlCommand(sql, con);
            SqlDataReader reader5 = command5.ExecuteReader();
            reader5.Read();
            if (reader5.HasRows)
            {
                number = Convert.ToInt32(reader5[0]);
            }
            con.Close();
            return number;
        }
        /// <summary>
        /// Funkcja pobiera dane z bazy na temat wystawionych ocen przez zalogowane użytkownika,
        /// zwraca tablicę z ID filmu i wystawioną mu oceną
        /// </summary>
        /// <returns></returns>
        private int[,] RatesOfUser()
        {
            int[,] rates = new int[x, 2];

            if (nickLoggedIn != "0")
            {

                string sql = " SELECT [IDMovie], [Rating] FROM [dbo].[UserRating]" +
                      "JOIN [dbo].[Users] ON [UserRating].IDUser = [Users].[UserID] " +
                      "WHERE " +
                      $"IDUser = '{_UserID}' ";
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand command5 = new SqlCommand(sql, con);
                SqlDataReader reader5 = command5.ExecuteReader();
                reader5.Read();

                if (reader5.HasRows)
                {
                    for (int i = 0; i < x; i++)
                    {
                        rates[i, 0] = Convert.ToInt32(reader5[0]);
                        rates[i, 1] = Convert.ToInt32(reader5[1]);
                        reader5.Read();
                    }
                    
                }
                con.Close();
            }
            return rates;
        }
        /// <summary>
        /// Funkcj odpowiedzialna za przycisk z logowaniem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_zaloguj(object sender, EventArgs e)
        {
            FormLog window = new FormLog();
            window.Show();
            this.Hide();
        }
        /// <summary>
        /// Przycisk odpowiedzialny za przycisk rejestracji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_register_Click(object sender, EventArgs e)
        {
            FormRegister windows2 = new FormRegister();
            windows2.Show();
            this.Hide();
        }
        /// <summary>
        /// Funkcja wyświetlająca okienko, w któym można dokonać oceny filmu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            // spradzenie czy jest już otwarte inne okno tej klasy, jeżeli tak to je zamyka
            if (nickLoggedIn != "0")
            {
                Form formRatingOpen = Application.OpenForms["Rating"];
                if (formRatingOpen != null)
                    formRatingOpen.Close();
                // sprawdza lokalizację kursora
                if (Cursor.Position.X - this.Location.X < 280)
                {
                    // tworzy listę 
                    ListViewItem itemo = GetItemFromPoint(listViewMovies, Cursor.Position);
                    // dodaje od listy tytul filmu na ktory wskazuje kursor
                    titleOfSelectedMovie = itemo.SubItems[0].Text;
                    // dodaje do listy ocenę filmu,na który wskazuje kursor wystawioną przez zalogowanego użytkownika 
                    string rateOfSelectedMovie = itemo.SubItems[2].Text; 
                    // jeżeli 
                    if (rateOfSelectedMovie == "          -")
                    {
                        rateOfSelectedMovie = "0";
                    }
                    int IDOfSelectedMovie = Convert.ToInt32(itemo.SubItems[3].Text);
                    MessageBox.Show("ID mOVIE: "+ IDOfSelectedMovie.ToString());
                    FormRating windows3 = new FormRating(_UserID, IDOfSelectedMovie, titleOfSelectedMovie, Int32.Parse(rateOfSelectedMovie));
                    windows3.Load += delegate
                    {
                        windows3.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
                    };
                    windows3.Show();

                }
            }
        }


        // funkcja ustalajaca na jaki film wskazuje kursor myszy
        private ListViewItem GetItemFromPoint(ListView listView, Point mousePosition)
        {
            Point localPoint = listView.PointToClient(mousePosition);
            return listView.GetItemAt(localPoint.X, localPoint.Y);
        }

        /// <summary>
        /// Funkcja uruchamiana podczas próby wyjścia z aplikacji
        /// Pyta czy użytkownik jest pewny czy chce wyjść
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopFilm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Jesteś pewien, że chcesz wyłączyć aplikację?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    Application.Exit();
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }
        /// <summary>
        /// Wyświetla filmy na podstawie wpisanej frazy w textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_engine_TextChanged(object sender, EventArgs e)
        {
            listView_Load();
        }

        /// <summary>
        /// Funkcja odpowiedzialna za przycisk wyloguj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Logout_button_Click(object sender, EventArgs e)
        {
            TopFilm front = new TopFilm();
            front.Show();
            this.Hide();
        }
        
        /// <summary>
        /// Funkcja obslugujaca przycisk odswiezajacy dane wyswietlane w tabeli glownej
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listView_Load();
        }
    }
}



