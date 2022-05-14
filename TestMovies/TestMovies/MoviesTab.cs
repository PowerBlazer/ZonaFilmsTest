using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMovies
{
    public partial class MoviesTab : UserControl
    {
        MySqlConnection sqlConnection;

        public MoviesTab()
        {
            InitializeComponent();
            //PC
            //sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\GitHubProjects\DataBase\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            //laptop
            try
            {
                sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString);
                sqlConnection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Больше одного пользователя не потяну");
            }
        }
        public void ImportInfoMovie(int id)
        {
            string ImageByte="";
            MySqlCommand sqlCommand = new MySqlCommand($"SELECT * FROM MoviesTab WHERE Id={id}", sqlConnection);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                NameLabel.Text = reader["Name"].ToString();
                YearLabel.Text = "Год: "+reader["Year"].ToString();
                RatingLabel.Text= reader["Rating"].ToString();
                ImageByte = reader["Image"].ToString();
            }       
            var image = Image.FromStream(new MemoryStream(Convert.FromBase64String(ImageByte)));
            ImageMovie.Image = image;
            reader.Close();

        }

        private void MoviesTab_Leave(object sender, EventArgs e)
        {
            sqlConnection.Close();
        }
    }
}
