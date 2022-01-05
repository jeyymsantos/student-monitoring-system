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
    public partial class AttendanceForm : Form
    {
        MySqlConnection DBConnect = new MySqlConnection("datasource = localhost; username=root; password=; database=studentmonitoringsystem;");
        MySqlCommand command = new MySqlCommand();

        string query;

        public AttendanceForm()
        {
            InitializeComponent();
            setTime();
        }

        public void setTime()
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToLongTimeString();
            txtDate.Text = DateTime.Now.ToLongDateString();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRFID_TextChanged(object sender, EventArgs e)
        {
            if(txtRFID.TextLength == 10)
            {
                CheckDB();
                txtRFID.Clear();
            }

        }


        private void CheckDB()
        {
            DBConnect.Open();
            query = "SELECT RFID, CONCAT(lastName, ', ', firstName) AS fullName, gradeLevel, strand, guardianPhone, profilePicture FROM students WHERE RFID = @rfid";

            command = new MySqlCommand(query, DBConnect);
            command.Parameters.AddWithValue("@rfid", txtRFID.Text);

            MySqlDataReader reader = command.ExecuteReader();

            string tempRFID = "";
            string tempfullName = "";
            string tempGradeLevel = "";
            string tempStrand = "";
            string tempGuardianPhone = "";
            string profilePicture = "";

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tempRFID = reader.GetString(0);
                    tempfullName = reader.GetString(1);
                    tempGradeLevel = reader.GetString(2);
                    tempStrand = reader.GetString(3);
                    tempGuardianPhone = reader.GetString(4);
                    profilePicture = reader.GetString(5);

                    txtName.Text = tempfullName;
                    imgProfile.ImageLocation = profilePicture;
                }
            }
            DBConnect.Close();

            DBConnect.Open();

            query = "SELECT * FROM logs WHERE rfid = @rfid AND timeOUT = ''";

            command = new MySqlCommand(query, DBConnect);
            command.Parameters.AddWithValue("@rfid", txtRFID.Text);

            MySqlDataReader reader2 = command.ExecuteReader();
            int x = 0;

            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    x++;
                }
            }
            DBConnect.Close();

            if (x == 0 && tempfullName != "")
            {
                DBConnect.Open();
                query = "INSERT INTO logs " +
                    "(RFID, fullName, phoneNumber, gradeLevel, strand, date, timeIN, imgLocation, shortTimeIN) " +
                    "VALUES " +
                    "(@rfid, @name, @number, @grade, @strand, @date, @timein, @image, @shortTimeIN)";

                command = new MySqlCommand(query, DBConnect);
                command.Parameters.AddWithValue("@rfid", tempRFID);
                command.Parameters.AddWithValue("@name", tempfullName);
                command.Parameters.AddWithValue("@number", tempGuardianPhone);
                command.Parameters.AddWithValue("@grade", tempGradeLevel);
                command.Parameters.AddWithValue("@strand", tempStrand);
                command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
                command.Parameters.AddWithValue("@timein", DateTime.Now.ToString());
                command.Parameters.AddWithValue("@image", profilePicture);
                command.Parameters.AddWithValue("@shortTimeIN", DateTime.Now.ToShortTimeString());

                command.ExecuteNonQuery();
                DBConnect.Close();

                txtStatus.BackColor = Color.MediumSeaGreen;
                txtStatus.Text = tempfullName + " has ENTERED.";

                LogsPanel.Controls.Add(new AttendanceInfo(tempfullName, "LOGGED IN", DateTime.Now.ToShortTimeString(), profilePicture));
            }
            else if (x > 0 && tempfullName != "")
            {

                DBConnect.Open();
                query = "SELECT timeIN FROM logs WHERE RFID = @rfid";

                command = new MySqlCommand(query, DBConnect);
                command.Parameters.AddWithValue("@rfid", tempRFID);

                MySqlDataReader read = command.ExecuteReader();

                DateTime timeIN = new DateTime();
                DateTime duration = DateTime.Now.AddMinutes(-1);

                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        timeIN = DateTime.Parse(read.GetString(0));
                    }
                }

                DBConnect.Close();

                if (duration >= timeIN)
                {
                    DBConnect.Open();
                    query = "UPDATE logs SET timeOUT = @timeOUT, shortTimeOUT = @shortTimeOUT WHERE RFID = @rfid";

                    command = new MySqlCommand(query, DBConnect);
                    command.Parameters.AddWithValue("@rfid", tempRFID);
                    command.Parameters.AddWithValue("@timeOUT", DateTime.Now.ToString());
                    command.Parameters.AddWithValue("@shortTimeOUT", DateTime.Now.ToShortTimeString());

                    command.ExecuteNonQuery();
                    DBConnect.Close();

                    txtStatus.BackColor = Color.Crimson;
                    txtStatus.Text = tempfullName + " has EXITED.";

                    LogsPanel.Controls.Add(new AttendanceInfo(tempfullName, "LOGGED OUT", DateTime.Now.ToShortTimeString(), profilePicture));
                }
                else
                {
                    txtStatus.Text = "WAIT 1 MINUTE TO LOGOUT!";
                    txtStatus.BackColor = Color.OrangeRed;
                    txtRFID.Clear();
                }  
            }

            else
            {
                txtStatus.Text = "Student Not Found!";
                txtStatus.BackColor = Color.OrangeRed;
                txtName.Text = "Contact Administrator!";
                imgProfile.Image = Properties.Resources.user;
                txtRFID.Clear();
            }
        }

        private void time()
        {
            DateTime now = DateTime.Now;
            MessageBox.Show(now.ToString());

            DateTime future = now.AddMinutes(15.0);

            if(DateTime.Now < future)
            {
                MessageBox.Show("15 minutes before!");
            }
        }
    }
}
