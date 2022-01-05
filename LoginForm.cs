using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Monitoring_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SaveMethods Methods = new SaveMethods();
        Alerts.ConfirmAlert ConfirmAlert = new Alerts.ConfirmAlert();
        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //bool x = confirm.ShowConfirmAlert("Are you sure you want to cancel?");
            //MessageBox.Show(x.ToString());

            Alerts.PasswordAlert pass = new Alerts.PasswordAlert();
            string x = pass.ShowPasswordAlert("admin");

            if (x == "true")
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (ConfirmAlert.ShowConfirmAlert("Are you sure you want to exit?") == true)
            {
                Application.Exit();
            }
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            Methods.CheckMissingField(txtUsername);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Methods.CheckMissingField(txtPassword);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool a = false;
            if (Methods.CheckMissingField(txtUsername) == true)
            {
                a = true;
            }
            if (Methods.CheckMissingField(txtPassword) == true)
            {
                a = true;
            }

            if(a == true)
            {
                Alerts.AlertForm Alert = new Alerts.AlertForm();
                Alert.showAlert("There are missing fields!", Alerts.AlertForm.enmType.Warning);
            }
            else
            {
                if (Methods.ConfirmPassword(txtUsername.Text, txtPassword.Text) == true)
                {
                    string type = Methods.GetType(txtUsername.Text);
                    string name = Methods.getName(txtUsername.Text);
                    Loading.MainLoadingScreen LoadScreen = new Loading.MainLoadingScreen();

                    string username = txtUsername.Text;
                    this.Close();
                    LoadScreen.LoadScreen(type, username);

                }
                else
                {
                    Alerts.AlertForm Alert = new Alerts.AlertForm();
                    Alert.showAlert("Invalid username/password!", Alerts.AlertForm.enmType.Error);
                }
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Administrator.Posts.ForgotPassword forgot = new Administrator.Posts.ForgotPassword();
            forgot.ShowDialog();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
