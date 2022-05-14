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
using MySql.Data.MySqlClient;
using System.Configuration;

namespace TestMovies
{
    public partial class Form1 : Form
    {
        private int ListCount=1;
        private int LimitCountsMovies = 10;        
        private int CountMovies=0;
        private Point lastPoint;
        private MySqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        void AddMoviesTable(TableLayoutPanel tableLayoutPanel)
        {
            lastList.Visible = true;
            nextList.Visible = true;
            ListCountLabel.Text = "Страница: " + ListCount.ToString();
            tableLayoutPanel.Controls.Clear();
           
            List<int> Idlist = new List<int>();
            MySqlCommand sqlCommand1 = new MySqlCommand($"SELECT * FROM MoviesTab WHERE Id>={CountMovies} AND Id<{LimitCountsMovies}", sqlConnection);
            MySqlDataReader reader = sqlCommand1.ExecuteReader();
            while (reader.Read())
            {
               Idlist.Add(Convert.ToInt32(reader["Id"]));
            }
            IEnumerable<int> ids =Idlist.ToArray();           
            foreach(int tuple in ids)
            {
                MoviesTab movies = new MoviesTab();
                movies.ImportInfoMovie(tuple);
                movies.Click += (sender, e) => Mouse_Click(sender, e,tuple);
                tableLayoutPanel.Controls.Add(movies);
            }
            reader.Close();           
        }
        void SearchMoviesTable(TableLayoutPanel tableLayoutPanel,string command)
        {            
            lastList.Visible = false;
            nextList.Visible = false;
            tableLayoutPanel.Controls.Clear();
            List<int> Idlist = new List<int>();
            MySqlCommand sqlCommand1 = new MySqlCommand(command, sqlConnection);
            MySqlDataReader reader = sqlCommand1.ExecuteReader();
            while (reader.Read())
            {
                Idlist.Add(Convert.ToInt32(reader["Id"]));
            }
            IEnumerable<int> ids = Idlist.ToArray();
            foreach (int tuple in ids)
            {
                MoviesTab movies = new MoviesTab();
                movies.ImportInfoMovie(tuple);
                movies.Click += (sender, e) => Mouse_Click(sender, e, tuple);
                tableLayoutPanel.Controls.Add(movies);
            }
            reader.Close();

        }
        void Mouse_Click(object sender , EventArgs e,int Id)
        {
            MoviesInfoPanel.Controls.Clear();
            MoviesInfo moviesInfo = new MoviesInfo();
            moviesInfo.Dock = DockStyle.Fill;
            moviesInfo.ImportMoviesTab(Id);
            MoviesInfoPanel.Controls.Add(moviesInfo);
            bunifuPages1.SelectedTab = MoviesInfoPage;
        }
        private void SearchInComboBox( ComboBox comboBox,string NameColumn)
        {
            string command;
            int ItemCount = comboBox.SelectedIndex;
            string ItemName = comboBox.Items[ItemCount].ToString();
            if (comboBox.SelectedIndex == 0) { return; }
            command = $"select * from MoviesTab WHERE "+NameColumn+" like N'%" + ItemName + "%'";
            SearchMoviesTable(tableLayoutPanel1, command);
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void MenuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MoviesButton_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedTab = MoviesPage;
            AddMoviesTable(tableLayoutPanel1);
            GenresComboBox.SelectedIndex = 0;
            YearComboBox.SelectedIndex = 0;
            CountryComboBox.SelectedIndex = 0;
            RatingComboBox.SelectedIndex = 0;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedTab = SettingPage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PC
            //sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\GitHubProjects\DataBase\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            //laptop
            sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString);
            sqlConnection.Open();           
            MoviesButton_Click(sender, e);
            
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LimitCountsMovies += 10;
            CountMovies += 10;
            ListCount++;
            AddMoviesTable(tableLayoutPanel1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (LimitCountsMovies == 10 && CountMovies == 0) { return; }           
            LimitCountsMovies -= 10;
            CountMovies -= 10;
            ListCount--; 
            AddMoviesTable(tableLayoutPanel1);
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (bunifuPages1.SelectedTab != MoviesPage)
                {
                    bunifuPages1.SelectedTab = MoviesPage;
                }
                string command = $"select * from MoviesTab WHERE Name like N'%" + SearchTextBox.Text + "%' REGEXP N'[а-яА-Я]'";
                if (SearchTextBox.Text != "")
                {
                    SearchMoviesTable(tableLayoutPanel1, command);
                }
               
            }    
        }

        private void SearchTextBox_TextChange(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "") 
            {
                AddMoviesTable(tableLayoutPanel1); ListCount = 1;
                LimitCountsMovies = 10;
                CountMovies = 0;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedTab = MoviesPage;
        }
        

        private void GenresComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchInComboBox(GenresComboBox,"Genres");
        }

        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchInComboBox(YearComboBox,"Year");
        }

        private void CountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchInComboBox(CountryComboBox, "Country");
        }

        private void Form1_Leave(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sqlConnection.Close();
        }
    }
}
