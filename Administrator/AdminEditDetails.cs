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
    public partial class AdminEditDetails : Form
    {
        MySqlConnection DBConnect = new MySqlConnection("datasource = localhost; username=root; password=; database=studentmonitoringsystem;");
        MySqlCommand command = new MySqlCommand();

        string query, username, tempName;

        public bool thePass(Guna.UI2.WinForms.Guna2TextBox textbox)
        {
            if (textbox.Text == "")
            {
                textbox.BorderColor = Color.FromArgb(213, 218, 223);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Alerts.ConfirmAlert Confirm = new Alerts.ConfirmAlert();
            Alerts.PasswordAlert Password = new Alerts.PasswordAlert();
            Alerts.AlertForm Alert = new Alerts.AlertForm();
            SaveMethods method = new SaveMethods();

            if (thePass(txtPassword) == false || method.CheckMissingField(txtName) == false)
            {
                if (Confirm.ShowConfirmAlert("Are you sure you want to update information?") == true)
                {

                    string y = Password.ShowPasswordAlert(username);

                    if (y == "true")
                    {
                        if (tempName == txtName.Text && txtPassword.Text != "")
                        {
                            if (CheckPass(txtPassword.Text) == false)
                            {

                                DBConnect.Open();

                                if (txtPassword.Text != "")
                                {
                                    query = "UPDATE accounts SET name = @name, username = @newusername, password = @password WHERE username = @username";
                                    command = new MySqlCommand(query, DBConnect);

                                    command.Parameters.AddWithValue("@newusername", txtUsername.Text);
                                    command.Parameters.AddWithValue("@password", txtPassword.Text);
                                    command.Parameters.AddWithValue("@name", txtName.Text);
                                    command.Parameters.AddWithValue("@username", username);
                                }

                                else
                                {
                                    query = "UPDATE accounts SET name = @name WHERE username = @username";
                                    command = new MySqlCommand(query, DBConnect);

                                    command.Parameters.AddWithValue("@password", txtPassword.Text);
                                    command.Parameters.AddWithValue("@name", txtName.Text);
                                    command.Parameters.AddWithValue("@username", username);
                                }
                                command.ExecuteNonQuery();
                                DBConnect.Close();

                                Alert.showAlert("Changes saved!", Alerts.AlertForm.enmType.Success);

                                this.Close();
                            }
                            else
                            {
                                Alert.showAlert("Same with old password!", Alerts.AlertForm.enmType.Error);
                            }
                        }
                        else if (tempName == txtName.Text && txtPassword.Text == "")
                        {
                            Alert.showAlert("Nothing has been updated!", Alerts.AlertForm.enmType.Info);
                            this.Close();
                        }
                        else
                        {
                            DBConnect.Open();

                            if (txtPassword.Text != "")
                            {
                                query = "UPDATE accounts SET name = @name, username = @newusername, password = @password WHERE username = @username";
                                command = new MySqlCommand(query, DBConnect);

                                command.Parameters.AddWithValue("@newusername", txtUsername.Text);
                                command.Parameters.AddWithValue("@password", txtPassword.Text);
                                command.Parameters.AddWithValue("@name", txtName.Text);
                                command.Parameters.AddWithValue("@username", username);
                            }

                            else
                            {
                                query = "UPDATE accounts SET name = @name WHERE username = @username";
                                command = new MySqlCommand(query, DBConnect);

                                command.Parameters.AddWithValue("@password", txtPassword.Text);
                                command.Parameters.AddWithValue("@name", txtName.Text);
                                command.Parameters.AddWithValue("@username", username);
                            }
                            command.ExecuteNonQuery();
                            DBConnect.Close();

                            Alert.showAlert("Changes saved!", Alerts.AlertForm.enmType.Success);
                            this.Close();
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
                Alert.showAlert("Check fields!", Alerts.AlertForm.enmType.Error);
            }
        }

        private bool CheckPass(string password)
        {
            bool x = false;

            DBConnect.Open();
            query = "SELECT password FROM accounts WHERE username = @username";
            command = new MySqlCommand(query, DBConnect);

            command.Parameters.AddWithValue("@username", username);

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if(reader.GetString(0) == password)
                    {
                        x = true;
                    }
                }
            }
            DBConnect.Close();

            return x;
        }


        public AdminEditDetails(string username, string password, string name, string type)
        {
            InitializeComponent();
            txtUsername.Text = username;
            txtName.Text = name;
            txtType.Text = type;

            this.tempName = name;
            this.username = username;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
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

        private void txtType_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtType_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
