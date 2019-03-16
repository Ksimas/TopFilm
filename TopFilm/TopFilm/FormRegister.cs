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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        private static string Data_Source_ServerName = "DESKTOP-1OE5FC5\\BIGDATA";
        private static string conString = "Data Source=" + Data_Source_ServerName + ";Initial Catalog=TopFilmDatabase;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);


        /// <summary>
        /// Funkcja odpowiedzialna za przycisk logujący
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_login_Click(object sender, EventArgs e)
        {
            FormLog window = new FormLog();
            window.Show();
            this.Hide();

        }
        /// <summary>
        ///  Funkcja uruchamiana przy próbie wyjścia z aplikacji, pyta użytkownika czy jest pewny 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
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
        /// Funkcja dodaje użytkownika do bazy danych użytkowników
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_register_Click(object sender, EventArgs e)
        {
            // sprawdzenie czy wszystkie textBoxy zostały wypełnione przynajmniej 2 znakamim
            if (textBox_Nick.Text.Length > 1 && TextBox_Password.Text.Length > 1 && textBox_email.Text.Length > 1)
            {
                // sprawdzenie czy użytkownik o takim nicku już istnieje w bazie 
                SqlDataAdapter SDA1 = new SqlDataAdapter("SELECT COUNT(*) FROM [dbo].[Users] WHERE Nickname ='" + textBox_Nick.Text + "'", con);
                DataTable DT = new DataTable();
                SDA1.Fill(DT);
                // jezeli takiego nick uw bazie nie ma to dane sa wpisaywane do bazy
                if (DT.Rows[0][0].ToString() == "0")
                {
                    SqlDataAdapter SDA2 = new SqlDataAdapter("INSERT INTO [dbo].[Users] ([Nickname], [Password], [E-mail]) " +
                        "VALUES " +
                        "('"+ textBox_Nick.Text + "','" + TextBox_Password.Text + "','" + textBox_email.Text + "')", con);
                    DataTable DT2 = new DataTable();
                    SDA2.Fill(DT2);
                    MessageBox.Show("Zarejstrowano!");

                }
                else
                    MessageBox.Show("Rejestracja zakończona niepowodzeniem! Użytkownik o takim nicku już istenieje!");
            }
            else
                MessageBox.Show("Rejstracja zakończona niepowodzeniem, Nick oraz hasło musi składać się z przynajmniej 2 znaków");

        }
    }
}        