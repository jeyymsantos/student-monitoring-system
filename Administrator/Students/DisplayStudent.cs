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
    public partial class DisplayStudent : Form
    {

        MySqlConnection DBConnect = new MySqlConnection("datasource= localhost; username=root; password=; database = studentmonitoringsystem");
        MySqlCommand command = new MySqlCommand();

        string query, myusername;

        public DisplayStudent(string username)
        {
            InitializeComponent();
            this.myusername = username;
        }

        public void DisplayStud(string studNumber)
        {

            query = "SELECT CONCAT(lastName, ', ', firstName, ' ', middleName) AS fullName, strand, studPhone, studID, gradeLevel, sex, citizenship, CONCAT(LOWER(lastname), '.', RIGHT(studID, 6), '@metawin.solutions') AS email, school, yearGraduated, address, motherName, motherPhone, motherEmail, fatherName, fatherPhone, fatherEmail, guardianName, guardianPhone, guardianEmail, reqForm138, reqForm137, reqGoodMoral, reqJHComp, reqPSA, reqVoucher, profilePicture FROM students WHERE studID = @id";

            DBConnect.Open();
            command = new MySqlCommand(query, DBConnect);

            command.Parameters.AddWithValue("@id", studNumber);

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    name.Text = reader.GetString(0);
                    strand.Text = reader.GetString(1);
                    phone.Text = reader.GetString(2);
                    idNumber.Text = reader.GetString(3);
                    grade.Text = reader.GetString(4);
                    gender.Text = reader.GetString(5);
                    citizenship.Text = reader.GetString(6);
                    email.Text = reader.GetString(7);
                    school.Text = reader.GetString(8);
                    year.Text = reader.GetString(9);
                    address.Text = reader.GetString(10);

                    mother.Text = reader.GetString(11);
                    motherNo.Text = reader.GetString(12);
                    motherEmail.Text = reader.GetString(13);

                    father.Text = reader.GetString(14);
                    fatherNo.Text = reader.GetString(15);
                    fatherEmail.Text = reader.GetString(16);

                    guardian.Text = reader.GetString(17);
                    guardianNo.Text = reader.GetString(18);
                    guardianEmail.Text = reader.GetString(19);

                    requirementChecker(reader.GetInt32(20), form138);
                    requirementChecker(reader.GetInt32(21), form137);
                    requirementChecker(reader.GetInt32(22), goodMoral);
                    requirementChecker(reader.GetInt32(23), jhsCompletion);
                    requirementChecker(reader.GetInt32(24), psaCert);
                    requirementChecker(reader.GetInt32(25), voucher);

                    imgProfile.ImageLocation = reader.GetString(26);

                }
            }

            DBConnect.Close();
            this.ShowDialog();
        }

        private void requirementChecker(int i, Guna.UI2.WinForms.Guna2CirclePictureBox box)
        {
            if (i == 1)
            {
                box.Image = Properties.Resources.dot;
            }
            else
            {
                box.Image = Properties.Resources.close;
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            Alerts.ConfirmAlert Confirm = new Alerts.ConfirmAlert();
            Alerts.PasswordAlert Password = new Alerts.PasswordAlert();
            Alerts.AlertForm Alert = new Alerts.AlertForm();

            if (Confirm.ShowConfirmAlert("Are you sure you want to edit student?") == true)
            {
                SaveMethods methods = new SaveMethods();
                string password = methods.GetPass(myusername);
                string y = Password.ShowPasswordAlert(myusername);

                if (y == "true")
                    {
                        EditStudent Edit = new EditStudent(myusername);
                        Edit.ShowEdit(idNumber.Text);

                        this.Close();
                    }
                else if (y == "false")
                {
                        Alert.showAlert("Invalid password!", Alerts.AlertForm.enmType.Error);
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Alerts.ConfirmAlert Confirm = new Alerts.ConfirmAlert();
            Alerts.PasswordAlert Password = new Alerts.PasswordAlert();
            Alerts.AlertForm Alert = new Alerts.AlertForm();

            if (Confirm.ShowConfirmAlert("Are you sure you want to delete: " + idNumber.Text + "?") == true)
            {
                SaveMethods methods = new SaveMethods();
                string password = methods.GetPass(myusername);
                string y = Password.ShowPasswordAlert(myusername);

                if (y == "true")
                {
                    SaveMethods method = new SaveMethods();
                    method.DeleteStudent(idNumber.Text);

                    this.Close();
                }
                else if (y == "false")
                {
                    Alert.showAlert("Invalid password!", Alerts.AlertForm.enmType.Error);
                }
            }
        }
    }
}
