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
    public partial class AddAdmin : Form
    {
        MySqlConnection DBConnect = new MySqlConnection("datasource = localhost; username = root; password=; database = studentmonitoringsystem;");
        MySqlCommand command = new MySqlCommand();
        string query;

        string imgLocation = "", username;
        public AddAdmin(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName;
                imgProfile.ImageLocation = imgLocation;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked == false)
            {
                txtPassword.PasswordChar = '•';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
            }
        }
        SaveMethods method = new SaveMethods();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Alerts.ConfirmAlert Confirm = new Alerts.ConfirmAlert();
            Alerts.PasswordAlert Password = new Alerts.PasswordAlert();
            Alerts.AlertForm Alert = new Alerts.AlertForm();

            if(method.CheckMissingField(txtName) == false && method.CheckMissingField(txtPassword) == false && method.CheckMissingField(txtType) == false && method.CheckMissingField(txtUsername) == false && imgLocation != "")
            {
                if (Confirm.ShowConfirmAlert("Are you sure you want to update information?") == true)
                {
                    string y = Password.ShowPasswordAlert(this.username);

                    if (y == "true")
                    {
                        MessageBox.Show(this.username);
                        if(CheckUsername(txtUsername.Text) == false)
                        {
                            DBConnect.Open();

                            query = "INSERT INTO accounts (username, password, name, type, img) VALUES " +
                                "(@username, @password, @name, @type, @img)";
                            command = new MySqlCommand(query, DBConnect);

                            command.Parameters.AddWithValue("@username", txtUsername.Text);
                            command.Parameters.AddWithValue("@password", txtPassword.Text);
                            command.Parameters.AddWithValue("@name", txtName.Text);
                            command.Parameters.AddWithValue("@type", txtType.Text);
                            command.Parameters.AddWithValue("@img", imgLocation);

                            command.ExecuteNonQuery();
                            DBConnect.Close();

                            Alert.showAlert("Admin added successfully!", Alerts.AlertForm.enmType.Success);
                            this.Close();
                        }
                        else
                        {
                            Alert.showAlert("Username taken already!", Alerts.AlertForm.enmType.Error);
                        } 
                    }
                    else if (y == "false")
                    {
                        Alert.showAlert("Invalid password!", Alerts.AlertForm.enmType.Error);
                    }
                }
                else
                {
                    Alert.showAlert("Changes not saved!", Alerts.AlertForm.enmType.Info);
                    this.Close();
                }
            }
            else
            {
                Alert.showAlert("Check for missing fields!", Alerts.AlertForm.enmType.Info);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            method.CheckMissingField(txtName);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            method.CheckMissingField(txtUsername);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            method.CheckMissingField(txtPassword);
        }

        private bool CheckUsername(string username)
        {
            DBConnect.Open();
            bool x = false;
            query = "SELECT username FROM accounts WHERE username = @username";
            command = new MySqlCommand(query, DBConnect);

            command.Parameters.AddWithValue("@username", txtUsername.Text);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    x = true;
                }
            }
            DBConnect.Close();
            return x;
        }
    }
}
