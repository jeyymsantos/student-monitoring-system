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

namespace Student_Monitoring_System.Administrator
{
    public partial class AdminSettings : UserControl
    {

        MySqlConnection DBConnect = new MySqlConnection("datasource = localhost; username = root; password=; database = studentmonitoringsystem;");
        MySqlCommand command = new MySqlCommand();
        string query, imgLocation, password, username;

        public AdminSettings(string username, string type)
        {
            InitializeComponent();

            txtType.Text = type;
            setData(username);
        }

        private void imgProfile_Click(object sender, EventArgs e)
        {

        }

        private void setData(string username)
        {
            DBConnect.Open();
            query = "SELECT username, password, img, name FROM accounts WHERE username = @username";
            command = new MySqlCommand(query, DBConnect);

            command.Parameters.AddWithValue("@username", username);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtUsername.Text = reader.GetString(0);
                    this.username = reader.GetString(0);
                    password = reader.GetString(1);
                    txtPassword.Text = "";

                    for(int x = 0; x < password.Length; x++)
                    {
                        txtPassword.Text = "•" + txtPassword.Text;
                    }

                    imgProfile.ImageLocation = reader.GetString(2);
                    txtName.Text = reader.GetString(3);
                }
            }

            DBConnect.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminEditDetails editdetails = new AdminEditDetails(txtUsername.Text, password, txtName.Text, txtType.Text);
            editdetails.ShowDialog();
            setData(username);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Alerts.ConfirmAlert Confirm = new Alerts.ConfirmAlert();
                Alerts.PasswordAlert Password = new Alerts.PasswordAlert();
                Alerts.AlertForm Alert = new Alerts.AlertForm();

                SaveMethods methods = new SaveMethods();

                if (Confirm.ShowConfirmAlert("Are you sure you want to update profile picture?") == true)
                {
                    string password = methods.GetPass(txtUsername.Text);
                    string y = Password.ShowPasswordAlert(username);

                    if (y == "true")
                    {
                        imgLocation = dialog.FileName;
                        imgProfile.ImageLocation = imgLocation;

                        DBConnect.Open();
                        query = "UPDATE accounts SET img = @imgLocation WHERE username = @username";
                        command = new MySqlCommand(query, DBConnect);

                        command.Parameters.AddWithValue("@imgLocation", imgLocation);
                        command.Parameters.AddWithValue("@username", txtUsername.Text);

                        command.ExecuteNonQuery();
                        DBConnect.Close();

                        Alert.showAlert("Changes Saved!", Alerts.AlertForm.enmType.Success);
                    }
                    else if (y == "false")
                    {
                        Alert.showAlert("Invalid password!", Alerts.AlertForm.enmType.Error);
                    }
                }
                
            }
        }
    }
}
