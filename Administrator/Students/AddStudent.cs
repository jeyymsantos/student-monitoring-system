using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Monitoring_System.Administrator.Students
{
    public partial class AddStudent : Form
    {

        MySqlConnection DBConnect = new MySqlConnection("datasource = localhost; username = root; password=; database = studentmonitoringsystem;");
        MySqlCommand command = new MySqlCommand();
        string query, imgLocation, saveLocation, imgName, username;

        SaveMethods Method = new SaveMethods();

        public AddStudent(string username)
        {
            InitializeComponent();
            this.username = username;
            imgProfile.ImageLocation = @"E:\Student Monitoring System\Para sa System\student.png";
        }

        OpenFileDialog dialog = new OpenFileDialog();
        private void btnUpload_Click(object sender, EventArgs e)
        {
            saveLocation = @"E:\\\VS Studio 2019 - Grade 12\\\Student Monitoring System\\\pictures\\\Profile Picture\\\";
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName;
                imgProfile.ImageLocation = imgLocation;
            }
        }

        private void txtStudID_TextChanged(object sender, EventArgs e)
        {
            Method.IsNumber(txtStudID);
        }

        private void txtRFID_TextChanged(object sender, EventArgs e)
        {
            Method.IsNumber(txtRFID);
        }


        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtLastName);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtFirstName);
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtMiddleName);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtAddress);
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            Method.IsPhone(txtPhoneNumber);
        }

        private void txtSchool_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtSchool);
        }

        private void txtCitizenship_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtCitizenship);

        }

        private void txtMother_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtMother);
            checkGuardian();
        }

        private void checkGuardian()
        {
            if(cbGuardian.Text == "Mother")
            {
                txtGuardian.Text = txtMother.Text;
                txtGuardianNo.Text = txtMotherNo.Text;
                txtGuardianEmail.Text = txtMotherEmail.Text;
            }
            else if (cbGuardian.Text == "Father")
            {
                txtGuardian.Text = txtFather.Text;
                txtGuardianNo.Text = txtFatherNo.Text;
                txtGuardianEmail.Text = txtFatherEmail.Text;
            }
        }

        private void txtMotherNo_TextChanged(object sender, EventArgs e)
        {
            Method.IsPhone(txtMotherNo);
            checkGuardian();
        }

        private void txtMotherEmail_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtMotherEmail);
            checkGuardian();
        }

        private void txtFather_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtFather);
            checkGuardian();
        }

        private void txtFatherNo_TextChanged(object sender, EventArgs e)
        {
            Method.IsPhone(txtFatherNo);
            checkGuardian();
        }

        private void txtFatherEmail_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtFatherEmail);
            checkGuardian();
        }

        private void txtGuardian_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtGuardian);
        }

        private void txtGuardianNo_TextChanged(object sender, EventArgs e)
        {
            Method.IsPhone(txtGuardianNo);
        }

        private void txtGuardianEmail_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtGuardianEmail);
        }

        private void cbGuardian_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGuardian.Text.Equals("Mother"))
            {
                txtGuardian.Enabled = false;
                txtGuardianEmail.Enabled = false;
                txtGuardianNo.Enabled = false;

                txtGuardian.Text = txtMother.Text;
                txtGuardianEmail.Text = txtMotherEmail.Text;
                txtGuardianNo.Text = txtMotherNo.Text;
            }
            else if (cbGuardian.Text.Equals("Father"))
            {
                txtGuardian.Enabled = false;
                txtGuardianEmail.Enabled = false;
                txtGuardianNo.Enabled = false;

                txtGuardian.Text = txtFather.Text;
                txtGuardianEmail.Text = txtFatherEmail.Text;
                txtGuardianNo.Text = txtFatherNo.Text;
            }
            else
            {
                txtGuardian.Enabled = true;
                txtGuardianEmail.Enabled = true;
                txtGuardianNo.Enabled = true;

                txtGuardian.Text = "";
                txtGuardianEmail.Text = "";
                txtGuardianNo.Text = "";
            }
        }

        

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            Alerts.AlertForm alert = new Alerts.AlertForm();
            Alerts.ConfirmAlert Confirm = new Alerts.ConfirmAlert();
            Alerts.PasswordAlert Password = new Alerts.PasswordAlert();

            if (validInput() == true)
            {
                SaveMethods methods = new SaveMethods();
                string password = methods.GetPass(username);
                string y = Password.ShowPasswordAlert(username);

                if (y == "true")
                {
                    if(Confirm.ShowConfirmAlert("Are you sure you want to enroll student?") == true)
                    {
                        EnrollStudent();
                        alert.showAlert("Student successfully added!", Alerts.AlertForm.enmType.Success);
                        this.Close();
                    }
                    else
                    {
                        alert.showAlert("Student enrollment cancelled!", Alerts.AlertForm.enmType.Info);
                        this.Close();
                    }
                }
                else if(y == "false")
                {
                    alert.showAlert("Incorrect password!", Alerts.AlertForm.enmType.Error);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(new Alerts.ConfirmAlert().ShowConfirmAlert("Are you sure you want to cancel?") == true)
            {
                this.Close();
            }
        }

        public void EnrollStudent()
        {

            int reqForm138 = Method.reqValidate(checkForm138);
            int reqGoodMoral = Method.reqValidate(checkGoodMoral);
            int reqJHComp = Method.reqValidate(checkCompletion);
            int reqPSA = Method.reqValidate(checkPSA);
            int reqForm137 = Method.reqValidate(checkForm137);
            int reqVoucher = Method.reqValidate(checkVoucher);

            try
            {
                DBConnect.Open();

                query = "INSERT INTO students (studID, RFID, gradeLevel, semester, strand, profilePicture, lastName, firstName, middleName, sex, birthdate, address, studPhone, school, yearGraduated, citizenship, motherName, motherPhone, motherEmail, fatherName, fatherPhone, fatherEmail, guardianOption, guardianName, guardianPhone, guardianEmail, reqForm138, reqGoodMoral, reqJHComp, reqPSA, reqForm137, reqVoucher) VALUES ('" + txtStudID.Text + "','" + txtRFID.Text + "','" + cbGrade.Text + "','" + cbSemester.Text + "','" + cbStrand.Text + "', @img, '" + txtLastName.Text + "','" + txtFirstName.Text + "','" + txtMiddleName.Text + "', '" + cbSex.Text + "','" + dateBirthdate.Text + "','" + txtAddress.Text + "','" + txtPhoneNumber.Text + "','" + txtSchool.Text + "','" + cbGraduateYear.Text + "','" + txtCitizenship.Text + "', '" + txtMother.Text + "', '" + txtMotherNo.Text + "', '" + txtMotherEmail.Text + "', '" + txtFather.Text + "', '" + txtFatherNo.Text + "', '" + txtFatherEmail.Text + "', '" + cbGuardian.Text + "', '" + txtGuardian.Text + "', '" + txtGuardianNo.Text + "', '" + txtGuardianEmail.Text + "', '" + reqForm138 + "', '" + reqGoodMoral + "', '" + reqJHComp + "', '" + reqPSA + "', '" + reqForm137 + "', '" + reqVoucher + "');";

                command = new MySqlCommand(query, DBConnect);
                command.Parameters.AddWithValue("@img", SavePicture());
                command.ExecuteNonQuery();
                DBConnect.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        /*private string SavePicture()
        {
            imgName = txtStudID.Text + ".png";
            File.Copy(imgLocation, Path.Combine(saveLocation, imgName), true);

            string location = saveLocation + imgName;
            return location;
        }*/

        private string SavePicture()
        {
            return imgProfile.ImageLocation;
        }

        private bool validInput()
        {
            int ctr = 0;

            // Number Validators

            if (Method.IsNumber(txtStudID) == 0)
            {
                //Existing Validator
                ctr += Method.ExistingStudNumber(txtStudID, 1);
            }
            else { ctr++; }

            if (Method.IsNumber(txtRFID) == 0)
            {
                //Existing Validator
                ctr += Method.ExistingStudNumber(txtRFID, 2);
            }
            else { ctr++; }

            ctr += Method.IsPhone(txtPhoneNumber);
            ctr += Method.IsPhone(txtMotherNo);
            ctr += Method.IsPhone(txtFatherNo);
            ctr += Method.IsPhone(txtGuardianNo);

            // Empty Textboxes
            ctr += Method.IsEmpty(txtLastName);
            ctr += Method.IsEmpty(txtFirstName);
            ctr += Method.IsEmpty(txtMiddleName);
            ctr += Method.IsEmpty(txtSchool);
            ctr += Method.IsEmpty(txtAddress);
            ctr += Method.IsEmpty(txtCitizenship);

            ctr += Method.IsEmpty(txtMother);
            ctr += Method.IsEmpty(txtMotherEmail);
            ctr += Method.IsEmpty(txtFather);
            ctr += Method.IsEmpty(txtFatherEmail);
            ctr += Method.IsEmpty(txtGuardian);
            ctr += Method.IsEmpty(txtGuardianEmail);

            // Picture has no input

            if (imgProfile.ImageLocation == null)
            {
                imgProfile.BackColor = Color.Orange;
                ctr++;
            }
            else
            {
                imgProfile.BackColor = Color.FromArgb(53, 64, 87);
            }

            Alerts.AlertForm alert = new Alerts.AlertForm();

            if (ctr != 0)
            {
                if (ctr >= 500)
                {
                    alert.showAlert("ID already exist!", Alerts.AlertForm.enmType.Error);
                }
                else
                {
                    alert.showAlert("Please check your input!", Alerts.AlertForm.enmType.Warning);
                }
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }
}
