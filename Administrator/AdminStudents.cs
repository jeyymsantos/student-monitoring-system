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
    public partial class AdminStudents : UserControl
    {
        MySqlConnection DBConnect = new MySqlConnection("datasource=localhost; username=root; password=; database=studentmonitoringsystem;");
        MySqlCommand command = new MySqlCommand();

        string query, username;
        public AdminStudents(string name, string type, string img, string username)
        {
            InitializeComponent();
            lblName.Text = name;
            lblType.Text = type;
            this.username = username;
            imgProfile.ImageLocation = img;
            getNoOfStudents();
        }


        private void getNoOfStudents()
        {
            int grade11 = 0, grade12 = 0;

            DBConnect.Open();
            query = "SELECT gradeLevel FROM students";
            command = new MySqlCommand(query, DBConnect);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetString(0) == "Grade 11")
                    {
                        grade11++;
                    }
                    else
                    {
                        grade12++;
                    }   
                }
            }

            DBConnect.Close();
            lblGrade11.Text = grade11.ToString();
            lblGrade12.Text = grade12.ToString();
            lblTotal.Text = (grade11 + grade12).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Students.AddStudent AddStudent = new Students.AddStudent(username);
            AddStudent.ShowDialog();
            getNoOfStudents();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Students.SearchStudent search = new Students.SearchStudent();
            string x = search.Search();

            if(x != "")
            {
                Alerts.ConfirmAlert Confirm = new Alerts.ConfirmAlert();
                Alerts.PasswordAlert Password = new Alerts.PasswordAlert();
                Alerts.AlertForm Alert = new Alerts.AlertForm();

                if (Confirm.ShowConfirmAlert("Are you sure you want to update: " + x + "?") == true)
                {
                    SaveMethods methods = new SaveMethods();
                    string password = methods.GetPass(lblName.Text);
                    string y = Password.ShowPasswordAlert(username);

                    if (y == "true")
                    {
                        Students.EditStudent Edit = new Students.EditStudent(username);
                        Edit.ShowEdit(x);
                    }
                    else if (y == "false")
                    {
                        Alert.showAlert("Invalid password!", Alerts.AlertForm.enmType.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Students.SearchStudent search = new Students.SearchStudent();
            string x = search.Search();

            if (x != "")
            {
                Alerts.ConfirmAlert Confirm = new Alerts.ConfirmAlert();
                Alerts.PasswordAlert Password = new Alerts.PasswordAlert();
                Alerts.AlertForm Alert = new Alerts.AlertForm();

                if (Confirm.ShowConfirmAlert("Are you sure you want to delete: "+ x +"?") == true)
                {
                    SaveMethods methods = new SaveMethods();
                    string password = methods.GetPass(lblName.Text);
                    string y = Password.ShowPasswordAlert(username);

                    if (y == "true")
                    {
                        SaveMethods method = new SaveMethods();
                        method.DeleteStudent(x);
                    }
                    else if(y == "false")
                    {
                        Alert.showAlert("Invalid password!", Alerts.AlertForm.enmType.Error);
                    }
                }
                
            }

            getNoOfStudents();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SaveMethods method = new SaveMethods();
            if(method.CheckMissingField(txtContent) == true)
            {
                Alerts.AlertForm alert = new Alerts.AlertForm();
                alert.showAlert("Check missing field!", Alerts.AlertForm.enmType.Warning);
            }
            else
            {
                Alerts.ConfirmAlert Confirm = new Alerts.ConfirmAlert();
                Alerts.PasswordAlert Password = new Alerts.PasswordAlert();
                Alerts.AlertForm Alert = new Alerts.AlertForm();

                if (Confirm.ShowConfirmAlert("Are you sure you want to post it?") == true)
                {
                    string y = Password.ShowPasswordAlert(this.username);
                    if (y == "true")
                    {
                        method.PostMessage(lblType.Text, txtContent.Text, lblName.Text);
                        txtContent.Text = "";
                    }
                    else if (y == "false")
                    {
                        Alert.showAlert("Invalid password!", Alerts.AlertForm.enmType.Error);
                    }
                    else
                    {
                        Alert.showAlert("Your message was cancelled.", Alerts.AlertForm.enmType.Info);
                        txtContent.Clear();
                    }
                }
                else
                {
                    Alert.showAlert("Your message wasn't posted.", Alerts.AlertForm.enmType.Info);
                    txtContent.Clear();
                }
            }
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Students.ViewStudents View = new Students.ViewStudents(username);
            View.ShowDialog();
            getNoOfStudents();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Attendance.AttendanceForm Attend = new Attendance.AttendanceForm();
            Attend.ShowDialog();
        }
    }
}
