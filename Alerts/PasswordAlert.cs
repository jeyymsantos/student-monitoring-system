using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Monitoring_System.Alerts
{
    public partial class PasswordAlert : Form
    {

        MySqlConnection DBConnect = new MySqlConnection("datasource= localhost; username=root; password=; database= studentmonitoringsystem");
        MySqlCommand command;

        string query;

        public PasswordAlert()
        {
            InitializeComponent();
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPassword.Checked == false)
            {
                txtPassword.PasswordChar = '•';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        SaveMethods method = new SaveMethods();
        
        public string ShowPasswordAlert(string username)
        {
            btnConfirm.Checked = false;
            btnCancel.Checked = false;
            txtPassword.Text = "";
            txtPassword.BorderColor = Color.Black;

            this.ShowDialog();

            if(btnConfirm.Checked == true)
            {
                bool checker = method.ConfirmPassword(username, txtPassword.Text);
                if(checker == true)
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            else
            {
                return "Cancel";
            }
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnConfirm.Checked = true;
            btnCancel.Checked = false;

            if(txtPassword.Text == "")
            {
                AlertForm alert = new AlertForm();
                alert.showAlert("Empty field!", AlertForm.enmType.Error);

                txtPassword.BorderColor = Color.OrangeRed;
                btnConfirm.Checked = false;
            }
            else
            {
                txtPassword.BorderColor = Color.Black;
                this.Close();
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnConfirm.Checked = false;
            btnCancel.Checked = true;

            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.BorderColor = Color.OrangeRed;
            }
            else
            {
                txtPassword.BorderColor = Color.Black;
            }
        }
    }
}
