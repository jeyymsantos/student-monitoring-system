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

    public partial class ViewStudents : Form
    {

        static string connectionString = "datasource = localhost; username = root; password=; database = studentmonitoringsystem;";
        MySqlConnection DBconnect = new MySqlConnection(connectionString);
        MySqlCommand command = new MySqlCommand();
        string query, username;

        public ViewStudents(string username)
        {
            InitializeComponent();
            getData();
            this.username = username;
        }

        private void getData()
        {
            query = "SELECT studID, CONCAT(lastName, ', ', firstName, ' ', middleName) as fullName, sex, gradeLevel, strand FROM `students` ORDER BY fullName";

            command = new MySqlCommand(query, DBconnect);
            DBconnect.Open();

            MySqlDataReader sdr = command.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);

            DataStudent.DataSource = dtRecords;

            DBconnect.Close();
        }

        private void clearDisplay()
        {
            imgProfile.Image = Properties.Resources.student;
            imgProfile.Refresh();

            studName.Text = "CLICK A STUDENT";
            studNumber.Text = "Student Number";
            studSex.Text = "Student's Sex";
            studPhone.Text = "Student's Phone";

            studGrade.Text = "Grade Level";
            studSection.Text = "Section";

            studGuardian.Text = "Guardian's Name";
            guardianEmail.Text = "Guardian's Email";
            guardianPhone.Text = "Guardian's Phone";

        }

        private void customDisplay()
        {

            clearDisplay();

            string grade = cbGrade.Text;
            if (grade == "11 & 12")
            {
                grade = "gradeLevel";
            }
            string strand = cbStrand.Text;
            if (strand == "ABM, HE, HUMSS, ICT, STEM")
            {
                strand = "strand";
            }

            DBconnect.Open();

            // ALL ALL
            if (grade == "gradeLevel" && strand == "strand")
            {
                query = "SELECT studID, CONCAT(lastName, ', ', firstName, ' ', middleName) as fullName, sex, gradeLevel, strand FROM students ORDER BY fullName";

                command = new MySqlCommand(query, DBconnect);

            }

            else
            {
                if (grade == "gradeLevel")
                {
                    query = "SELECT studID, CONCAT(lastName, ', ', firstName, ' ', middleName) as fullName, sex, gradeLevel, strand FROM students WHERE gradeLevel = gradeLevel AND strand = @strand ORDER BY fullName";

                    command = new MySqlCommand(query, DBconnect);

                    command.Parameters.AddWithValue("@strand", strand);
                }
                else if (strand == "strand")
                {
                    query = "SELECT studID, CONCAT(lastName, ', ', firstName, ' ', middleName) as fullName, sex, gradeLevel, strand FROM students WHERE gradeLevel =@grade AND strand = strand ORDER BY fullName";

                    command = new MySqlCommand(query, DBconnect);

                    command.Parameters.AddWithValue("@grade", grade);
                }
                else
                {
                    query = "SELECT studID, CONCAT(lastName, ', ', firstName, ' ', middleName) as fullName, sex, gradeLevel, strand FROM students WHERE gradeLevel =@grade AND strand =@strand ORDER BY fullName";

                    command = new MySqlCommand(query, DBconnect);

                    command.Parameters.AddWithValue("@grade", grade);
                    command.Parameters.AddWithValue("@strand", strand);
                }
            }


            MySqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            DataStudent.DataSource = table;
            DBconnect.Close();
        }

        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            customDisplay();
        }

        private void cbStrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            customDisplay();
        }

        private void DataStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index >= 0)
            {
                string getStudID = DataStudent.Rows[index].Cells[0].Value.ToString();

                query = "SELECT studID, CONCAT(lastName, ', ', firstName, ' ', middleName) as fullName, sex, gradeLevel, studPhone, strand, guardianName, guardianPhone, guardianEmail, profilePicture FROM `students` WHERE studID = @studID";

                DBconnect.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@studID", getStudID);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        studNumber.Text = reader.GetString(0);
                        studName.Text = reader.GetString(1);
                        studSex.Text = reader.GetString(2);
                        studGrade.Text = reader.GetString(3);
                        studPhone.Text = reader.GetString(4);
                        studSection.Text = reader.GetString(5);
                        studGuardian.Text = reader.GetString(6);
                        guardianPhone.Text = reader.GetString(7);
                        guardianEmail.Text = reader.GetString(8);
                        imgProfile.ImageLocation = reader.GetString(9);
                    }
                }

                command.Parameters.Clear();
                DBconnect.Close();
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (studNumber.Text.Equals("Student Number"))
            {
                Alerts.AlertForm alert = new Alerts.AlertForm();
                alert.showAlert("Click a student!", Alerts.AlertForm.enmType.Warning);
            }
            else
            {
                DisplayStudent disp = new DisplayStudent(username);
                disp.DisplayStud(studNumber.Text);
                this.Close();
            }
        }
    }
}
