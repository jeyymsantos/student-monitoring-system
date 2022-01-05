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

namespace Student_Monitoring_System.Developer.Search
{
    public partial class SearchUser : Form
    {
        MySqlConnection DBConnect = new MySqlConnection("datasource=localhost; username=root; password=; database=studentmonitoringsystem;");
        MySqlCommand command = new MySqlCommand();

        string query, username;

        public SearchUser()
        {
            InitializeComponent();
            this.username = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSearch.Checked = false;
            btnCancel.Checked = true;

            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Checked = true;
            btnCancel.Checked = false;

            if (txtDetails.Text == "")
            {
                Alerts.AlertForm alert = new Alerts.AlertForm();
                alert.showAlert("Empty field!", Alerts.AlertForm.enmType.Error);

                txtDetails.BorderColor = Color.OrangeRed;
                btnSearch.Checked = false;
            }
            else
            {
                txtDetails.BorderColor = Color.Black;
                this.Close();
            }
        }

        public string Search()
        {
            this.ShowDialog();

            if (btnSearch.Checked == true)
            {
                DBConnect.Open();

                query = "SELECT username FROM accounts WHERE username = @username";
                command = new MySqlCommand(query, DBConnect);

                command.Parameters.AddWithValue("@username", txtDetails.Text);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.username = reader.GetString(0);
                    }
                }

                DBConnect.Close();

                if (this.username != "")
                {
                    return this.username;
                }
                else
                {
                    Alerts.AlertForm alert = new Alerts.AlertForm();
                    alert.showAlert("User not found!", Alerts.AlertForm.enmType.Error);

                    txtDetails.BorderColor = Color.OrangeRed;
                    return "";
                }
            }

            else
            {
                return "";
            }

        }

    }
}
