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
    public partial class MoviesInfo : UserControl
    {
        private string site = null;
        MySqlConnection sqlConnection;
       
        public MoviesInfo()
        {
            InitializeComponent();
            //PC G
            //Laptop D
            sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString);
            sqlConnection.Open();
            //mySqlConnection = new MySqlConnection("server=sql11.freesqldatabase.com;port=3306;username=sql11492137;password=ID7VprPkW6;database=sql11492137;SSL Mode=None");
            //mySqlConnection.Open();
        }
        public void ImportMoviesTab(int id)
        {
            string ImageByte = "";
            MySqlCommand sqlCommand = new MySqlCommand($"SELECT * FROM MoviesTab WHERE Id={id}", sqlConnection);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                NameLabel.Text = reader["Name"].ToString();
                YearLabel.Text = reader["Year"].ToString();
                RatingLabel.Text = reader["Rating"].ToString();
                ImageByte = reader["Image"].ToString();
                CountryLabel.Text = reader["Country"].ToString();
                screenplayLabel.Text = reader["ScreenPlay"].ToString();
                TheActorsLabel.Text = reader["Actors"].ToString();
                descriptionLabel.Text= reader["Description"].ToString();
                site = reader["Site"].ToString();
                DirectorLabel.Text = reader["Director"].ToString();
                GenresLabel.Text = reader["Genres"].ToString();
                
            }
            var image = Image.FromStream(new MemoryStream(Convert.FromBase64String(ImageByte)));
            pictureBox1.Image = image;
            reader.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(site);
        }

        private void MoviesInfo_Leave(object sender, EventArgs e)
        {
            sqlConnection.Close();
        }
    }
}
