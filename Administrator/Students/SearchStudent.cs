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

namespace Student_Monitoring_System.Administrator.Students
{
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        MySqlConnection DBConnect = new MySqlConnection("datasource = localhost; username=root; password=; database=studentmonitoringsystem;");
        MySqlCommand command = new MySqlCommand();

        string query;

        public string Search()
        {
            this.ShowDialog();
            string fullname = "";
            string studID = "";

            if (btnSearch.Checked == true)
            {
                string details = txtDetails.Text;
                DBConnect.Open();

                if (cbChoice.SelectedIndex == 0)
                {
                    query = "SELECT CONCAT(lastName, ', ', firstName, ' ', middleName) AS fullName, studID FROM students WHERE studID = @details";
                }
                else if (cbChoice.SelectedIndex == 1)
                {
                    query = "SELECT CONCAT(lastName, ', ', firstName, ' ', middleName) AS fullName, studID FROM students WHERE RFID = @details";
                }

                command = new MySqlCommand(query, DBConnect);
                command.Parameters.AddWithValue("@details", details);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        fullname = reader.GetString(0);
                        studID = reader.GetString(1);

                    }
                }

                DBConnect.Close();

                if (studID != "")
                {
                    return studID;
                }
                else
                {
                    Alerts.AlertForm alert = new Alerts.AlertForm();
                    alert.showAlert("Student not found!", Alerts.AlertForm.enmType.Error);

                    txtDetails.BorderColor = Color.OrangeRed;
                    return "";
                }  
            }

            else
            {
                return "";
            }
            
        }

        private void cbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbChoice.SelectedIndex;

            switch (index)
            {
                case 0:
                    lblMessage.Text = "Enter Student's ID:";
                    break;
                case 1:
                    lblMessage.Text = "Enter Student's RFID:";
                    break;
            }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSearch.Checked = false;
            btnCancel.Checked = true;

            this.Close();
        }
    }

}
