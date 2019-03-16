using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TopFilm
{
    public partial class FormLog : Form
    {
        private static string Data_Source_ServerName = "DESKTOP-1OE5FC5\\BIGDATA";
        private static string conString = "Data Source=" + Data_Source_ServerName + ";Initial Catalog=TopFilmDatabase;Integrated Security=True";

        SqlConnection con = new SqlConnection(conString);

        // tworzenie zmiennych, ktore beda przechowywaly nick i haslo wpisane w textboxy
        private string userNick;
        private string userPassword;

        public FormLog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja wywoływana pdoczas próby wyjścia z aplikacji, pyta użytkownika czy jest pewny
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Log_FormClosing(object sender, FormClosingEventArgs e)
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
        /// Funkcja sprawdza czy użytkownik wpisał poprawne dane do logowania
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_login_Click(object sender, EventArgs e)
        {
            userNick = textBoxNick.Text;
            userPassword = maskedTextBoxPassword.Text;
            // jezeli login i haslo zostaly dopasowane to zapytanie pobiera ID użytkownika, jeżeli podane dane nie zostały dopasowane to zapytanie zwraca 0
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"IF EXISTS( SELECT [UserID] FROM [dbo].[Users] WHERE [Nickname] = '{userNick}' and [Password] = '{userPassword}' ) " +
                $"BEGIN SELECT [UserID] FROM [dbo].[Users] WHERE [Nickname] = '{userNick}' and [Password] = '{userPassword}' END " +
                $"ELSE BEGIN SELECT 0 END;", con);
            DataTable dataTable = new DataTable();
            
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows[0][0].ToString() != "0")
            {
                con.Open();
                SqlCommand command = new SqlCommand($"INSERT INTO [dbo].[LoginDate] ([UserID], [LoginDate]) VALUES ({dataTable.Rows[0][0]}, GETDATE());", con);
                SqlDataReader reader = command.ExecuteReader();
                con.Close();
                TopFilm window = new TopFilm(Int32.Parse(dataTable.Rows[0][0].ToString()), textBoxNick.Text);
                window.Show();
                this.Hide();                
            }
            else if (dataTable.Rows[0][0].ToString() == "0")
            {
                MessageBox.Show("Niepoprawny login lub hasło!");
            }
            else
            { 
                MessageBox.Show("Nie udało się zalogować!");
            }
        }

        private void button_login_Click_1(object sender, EventArgs e)
        {
            FormRegister newWindowRegister = new FormRegister();
            newWindowRegister.Show();
            this.Hide();
        }
        
    }
}



