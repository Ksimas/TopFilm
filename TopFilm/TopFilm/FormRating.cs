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
    public partial class FormRating : Form
    {
        private static string dataSourceServerName = "DESKTOP-1OE5FC5\\BIGDATA";
        private static string conString = "Data Source=" + dataSourceServerName + ";Initial Catalog=TopFilmDatabase;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);                       // con = conn
        SqlCommand command;

        private string _titleOfMovie;
        private int _userID;
        private int _movieID;
        private int _rateOfMovie;

        public FormRating(int UserID, int MovieID,  string titleOfMovie, int rateOfMovie)
        {
            InitializeComponent();
            
            comboBoxRate.Items.Add("1");
            comboBoxRate.Items.Add("2");
            comboBoxRate.Items.Add("3");
            comboBoxRate.Items.Add("4");
            comboBoxRate.Items.Add("5");
            comboBoxRate.Items.Add("6");
            comboBoxRate.Items.Add("7");
            comboBoxRate.Items.Add("8");
            comboBoxRate.Items.Add("9");
            comboBoxRate.Items.Add("10");
            comboBoxRate.Items.Add("11");
            comboBoxRate.Items.Add("12");
            comboBoxRate.Items.Add("13");
            comboBoxRate.Items.Add("14");

            _titleOfMovie = titleOfMovie;
            _userID = UserID;
            _movieID = MovieID;
            _rateOfMovie = rateOfMovie;
            this.Text = "Oceń film " + _titleOfMovie;

            buttonConfirm.Text = "Zatwierdź ocenę";
        }

        /// <summary>
        /// Funkcja obsługująca wciśnięcie klawisza potwierdzającego ocenę filmu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Confirm_button_Click(object sender, EventArgs e)
        {
            // użytkownik pierwszy raz ocenia ten film
            if (_rateOfMovie == 0)
            {
                // komenda, która dopisze ocenę do bazy
                string sql = " UPDATE [dbo].[Movie] " +
                    "SET " +
                    "Number_Of_Ratings = Number_Of_Ratings + 1 " +
                    ",Sum_Of_Ratings = Sum_Of_Ratings +" + comboBoxRate.Text + "" +
                    $"where MovieName = '{_titleOfMovie}'";
                if (con.State != ConnectionState.Open)
                    con.Open();
                command = new SqlCommand(sql, con);
                SqlDataReader reader = command.ExecuteReader();
                con.Close();

                // komenda, która zapisze, że ten użytkownik już ocenił ten film
                sql = "INSERT INTO [dbo].[UserRating]" +
                    "(IDUser, IDMovie, Rating) VALUES" +
                    $"(' {_userID}' , '{_movieID}','" + comboBoxRate.Text + "');";

                con.Open();
                SqlCommand command2 = new SqlCommand(sql, con);
                SqlDataReader reader2 = command2.ExecuteReader();
                con.Close();
                MessageBox.Show("Ocena została wprowadzona");
                this.Close();
            }

            // użytkownik chce zmienić ocenę dla tego filmu
            if (_rateOfMovie != 0)
            {
                // komenda zmieniająca ocenę 
                string sql = " UPDATE [dbo].[Movie] " +
                 "SET " +
                 " Sum_Of_Ratings = Sum_Of_Ratings +" + comboBoxRate.Text + " - " + _rateOfMovie +
                 " where MovieName = '" + _titleOfMovie + "'";
                if (con.State != ConnectionState.Open)
                    con.Open();
                command = new SqlCommand(sql, con);
                SqlDataReader reader = command.ExecuteReader();
                con.Close();

                // komenda, która zapisze, że ten użytkownik już ocenił ten film
                sql = "UPDATE [dbo].[UserRating]  SET" +
                    " Rating = " + comboBoxRate.Text +
                    " WHERE IDUser = " + _userID +
                    " and IDMovie = " + _movieID ;

                con.Open();
                SqlCommand command2 = new SqlCommand(sql, con);
                SqlDataReader reader2 = command2.ExecuteReader();
                con.Close();

                MessageBox.Show("Ocena została zmieniona", "Powiadomienie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        
    }
}
