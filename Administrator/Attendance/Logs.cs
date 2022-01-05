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

namespace Student_Monitoring_System.Administrator.Attendance
{
    public partial class Logs : UserControl
    {
        MySqlConnection DBConnect = new MySqlConnection("datasource = localhost; username=root; password=; database=studentmonitoringsystem;");
        MySqlCommand command = new MySqlCommand();

        string query;

        public Logs()
        {
            InitializeComponent();
            DisplayLogs();
        }

        private void DisplayLogs()
        {
            DBConnect.Open();

            string now = DateTime.Now.ToShortDateString();
            query = "SELECT fullName, timeIN, timeOUT, imgLocation FROM logs WHERE date = @now ORDER BY timeIN DESC";

            command = new MySqlCommand(query, DBConnect);
            command.Parameters.AddWithValue("@now", now);

            MySqlDataReader reader = command.ExecuteReader();

            DateTime timeIN, timeOUT;
            string fullName = "";
            string profilePicture = "";
            string tempIN = "", tempOUT = "";

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    timeIN = DateTime.Parse(reader.GetString(1));
                    if(reader.GetString(2) != "")
                    {
                        timeOUT = DateTime.Parse(reader.GetString(2));
                        tempOUT = timeOUT.ToShortTimeString();
                    }
                    else
                    {
                        tempOUT = "Not yet.";
                    }

                    tempIN = timeIN.ToShortTimeString();

                    fullName = reader.GetString(0);
                    profilePicture = reader.GetString(3);

                    LogsPanel.Controls.Add(new LogsInfo(fullName, tempIN, tempOUT, profilePicture));
                }
            }

        }
    }
}
