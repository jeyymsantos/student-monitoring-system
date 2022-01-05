using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Monitoring_System.Developer
{
    public partial class MainDeveloper : Form
    {
        MySqlConnection DBConnect = new MySqlConnection("datasource = localhost; username = root; password=; database = studentmonitoringsystem;");
        MySqlCommand command = new MySqlCommand();
        string query, tempusername, username;

        public MainDeveloper(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddAdmin add = new AddAdmin(this.username);
            add.ShowDialog();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            
     
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Alerts.ConfirmAlert Confirm = new Alerts.ConfirmAlert();
            Alerts.AlertForm Alert = new Alerts.AlertForm();

            if (Confirm.ShowConfirmAlert("Are you sure you want to logout?") == true)
            {
                this.Close();
                Loading.MainSplashScreen Logout = new Loading.MainSplashScreen();
                Logout.Show();
            }

            }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search.SearchUser FindUser = new Search.SearchUser();
            this.tempusername = FindUser.Search();

            if (tempusername != "")
            {
                DBConnect.Open();
                query = "SELECT username, password, img, name, type FROM accounts WHERE username = @username";
                command = new MySqlCommand(query, DBConnect);

                command.Parameters.AddWithValue("@username", this.tempusername);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtUsername.Text = reader.GetString(0);
                        txtPassword.Text = reader.GetString(1);
                        imgProfile.ImageLocation = reader.GetString(2);
                        txtName.Text = reader.GetString(3);
                        txtType.Text = reader.GetString(4);
                    }
                }

                DBConnect.Close();
            }
        }
    }
}
