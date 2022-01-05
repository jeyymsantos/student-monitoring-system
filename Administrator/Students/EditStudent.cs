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
    public partial class EditStudent : Form
    {
        string username;
        public EditStudent(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        MySqlConnection DBConnect = new MySqlConnection("datasource=localhost; username=root; password=; database=studentmonitoringsystem;");
        MySqlCommand command = new MySqlCommand();

        string query, number, tempo, number2, imgLocation, imgName;
        string saveLocation = @"E:\VS Studio 2019 - Grade 12\Student Monitoring System\pictures\Profile Picture\";

        SaveMethods Method = new SaveMethods();

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

        private void txtSchool_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtSchool);
        }

        private void checkGuardian()
        {
            if (cbGuardian.Text == "Mother")
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


        private void txtMother_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtMother);
            checkGuardian();
        }

        private void txtFather_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtFather);
            checkGuardian();
        }

        private void txtGuardian_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtGuardian);
        }

        private void txtCitizenship_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtCitizenship);
        }

        private void txtMotherEmail_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtMotherEmail);
            checkGuardian();
        }

        private void txtFatherEmail_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtFatherEmail);
            checkGuardian();
        }

        private void txtGuardianEmail_TextChanged(object sender, EventArgs e)
        {
            Method.IsEmpty(txtGuardianEmail);
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
                    if (Confirm.ShowConfirmAlert("Are you sure you want to update student?") == true)
                    {
                        EnrollStudent();
                        alert.showAlert("Student successfully updated!", Alerts.AlertForm.enmType.Success);
                        this.Close();
                    }
                    else
                    {
                        alert.showAlert("Changes not saved!", Alerts.AlertForm.enmType.Info);
                        this.Close();
                    }
                }
                else if(y == "false")
                {
                    alert.showAlert("Incorrect password!", Alerts.AlertForm.enmType.Error);
                }
            }
        }

        private int reqValidate(Guna.UI2.WinForms.Guna2CheckBox checkbox)
        {
            if (checkbox.Checked == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void EnrollStudent()
        {

            int reqForm138 = reqValidate(checkForm138);
            int reqGoodMoral = reqValidate(checkGoodMoral);
            int reqJHComp = reqValidate(checkCompletion);
            int reqPSA = reqValidate(checkPSA);
            int reqForm137 = reqValidate(checkForm137);
            int reqVoucher = reqValidate(checkVoucher);

            try
            {
                DBConnect.Open();

                query = "UPDATE students SET studID = @studID, RFID = @rfid, gradeLevel = @grade, semester = @semester, strand = @strand, profilePicture = @profile, lastName = @last, firstName = @first, middleName = @middle, sex = @sex, birthdate = @birth, address = @address, studPhone = @phone, school = @school, yearGraduated = @year, citizenship = @citizen, motherName = @mother, motherPhone = @motherNo, motherEmail = @motherEm, fatherName = @father, fatherPhone = @fatherNo, fatherEmail = @fatherEm, guardianOption = @guardOp, guardianName = @guardName, guardianPhone = @guardNo, guardianEmail = @guardEm, reqForm138 = @req138, reqGoodMoral = @reqGood, reqJHComp = @reqJHComp, reqPSA = @reqPSA, reqForm137 = @req137, reqVoucher = @reqVoucher WHERE studID= @stID;";

                command = new MySqlCommand(query, DBConnect);

                command.Parameters.AddWithValue("@studID", txtStudID.Text);
                command.Parameters.AddWithValue("@rfid", txtRFID.Text);
                command.Parameters.AddWithValue("@grade", cbGrade.Text);
                command.Parameters.AddWithValue("@semester", cbSemester.Text);
                command.Parameters.AddWithValue("@strand", cbStrand.Text);
                command.Parameters.AddWithValue("@profile", SavePicture());
                command.Parameters.AddWithValue("@last", txtLastName.Text);
                command.Parameters.AddWithValue("@first", txtFirstName.Text);
                command.Parameters.AddWithValue("@middle", txtMiddleName.Text);
                command.Parameters.AddWithValue("@sex", cbSex.Text);
                command.Parameters.AddWithValue("@birth", dateBirthdate.Text);
                command.Parameters.AddWithValue("@address", txtAddress.Text);
                command.Parameters.AddWithValue("@phone", txtPhoneNumber.Text);
                command.Parameters.AddWithValue("@school", txtSchool.Text);
                command.Parameters.AddWithValue("@year", cbGraduateYear.Text);
                command.Parameters.AddWithValue("@citizen", txtCitizenship.Text);

                command.Parameters.AddWithValue("@mother", txtMother.Text);
                command.Parameters.AddWithValue("@motherNo", txtMotherNo.Text);
                command.Parameters.AddWithValue("@motherEm", txtMotherEmail.Text);

                command.Parameters.AddWithValue("@father", txtFather.Text);
                command.Parameters.AddWithValue("@fatherNo", txtFatherNo.Text);
                command.Parameters.AddWithValue("@fatherEm", txtFatherEmail.Text);

                command.Parameters.AddWithValue("@guardOp", cbGuardian.Text);
                command.Parameters.AddWithValue("@guardName", txtGuardian.Text);
                command.Parameters.AddWithValue("@guardNo", txtGuardianNo.Text);
                command.Parameters.AddWithValue("@guardEm", txtGuardianEmail.Text);

                command.Parameters.AddWithValue("@req138", reqForm138);
                command.Parameters.AddWithValue("@reqGood", reqGoodMoral);
                command.Parameters.AddWithValue("@reqJHComp", reqJHComp);
                command.Parameters.AddWithValue("@reqPSA", reqPSA);
                command.Parameters.AddWithValue("@req137", reqForm137);
                command.Parameters.AddWithValue("@reqVoucher", reqVoucher);

                command.Parameters.AddWithValue("@stID", txtStudID.Text);

                command.ExecuteNonQuery();
                DBConnect.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private string SavePicture()
        {
            imgName = txtStudID.Text + ".png";
            string location = saveLocation + imgName;

            if (imgLocation == tempo)
            {
                return tempo;
            }
            else
            {
                imgLocation = imgProfile.ImageLocation;
                return imgLocation;
            }

        }

        private bool validInput()
        {

            int ctr = 0;

            // Number Validators

            if(Method.IsNumber(txtStudID) == 0)
            {
                //Existing Validator
                ctr += ExistingStudNumber(txtStudID, 1);
            }
            else { ctr++; }

            if (Method.IsNumber(txtRFID) == 0)
            {
                //Existing Validator
                ctr += ExistingStudNumber(txtRFID, 2);
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

        private int ExistingStudNumber(Guna.UI2.WinForms.Guna2TextBox theID, int id)
        {

            int errors = 0;

            if (id == 1)
            {
                query = "SELECT studID FROM students WHERE studID=@theID";
            }
            else
            {
                query = "SELECT RFID FROM students WHERE RFID=@theID";
            }

            DBConnect.Open();

            command = new MySqlCommand(query, DBConnect);
            command.Parameters.AddWithValue("@theID", theID.Text);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (id == 1)
                    {
                        if (reader.GetString(0) != number)
                        {
                            theID.BorderColor = Color.Red;
                            errors = 500;
                        }
                    }
                    else
                    {
                        if (reader.GetString(0) != number2)
                        {
                            theID.BorderColor = Color.Red;
                            errors = 500;
                        }
                    }
                }
            }
            else
            {
                theID.BorderColor = Color.FromArgb(213, 218, 223);
            }

            DBConnect.Close();
            return errors;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Alerts.ConfirmAlert Confirm = new Alerts.ConfirmAlert();
            if(Confirm.ShowConfirmAlert("Are you sure you want to cancel?") == true)
            {
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMotherNo_TextChanged(object sender, EventArgs e)
        {
            Method.IsPhone(txtMotherNo);
            checkGuardian();
        }

        private void txtFatherNo_TextChanged(object sender, EventArgs e)
        {
            Method.IsPhone(txtFatherNo);
            checkGuardian();
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
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

        public void ShowEdit(string studID)
        {
            number = studID;

            query = "SELECT lastName, firstName, middleName, strand, studPhone, studID, rfid, gradeLevel, sex, citizenship, school, yearGraduated, address, motherName, motherPhone, motherEmail, fatherName, fatherPhone, fatherEmail, guardianName, guardianPhone, guardianEmail, reqForm138, reqForm137, reqGoodMoral, reqJHComp, reqPSA, reqVoucher, profilePicture, birthdate FROM students WHERE studID = @id";

            DBConnect.Open();

            command = new MySqlCommand(query, DBConnect);
            command.Parameters.AddWithValue("@id", studID);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtLastName.Text = reader.GetString(0);
                    txtFirstName.Text = reader.GetString(1);
                    txtMiddleName.Text = reader.GetString(2);
                    cbStrand.Text = reader.GetString(3);
                    txtPhoneNumber.Text = reader.GetString(4);
                    txtStudID.Text = reader.GetString(5);
                    txtRFID.Text = reader.GetString(6);
                    cbGrade.Text = reader.GetString(7);
                    cbSex.Text = reader.GetString(8);

                    string tempr = reader.GetString(9);
                    txtCitizenship.Text = tempr;
                    txtSchool.Text = reader.GetString(10);
                    cbGraduateYear.Text = reader.GetString(11);
                    txtAddress.Text = reader.GetString(12);
                    txtMother.Text = reader.GetString(13);
                    txtMotherNo.Text = reader.GetString(14);
                    txtMotherEmail.Text = reader.GetString(15);
                    txtFather.Text = reader.GetString(16);
                    txtFatherNo.Text = reader.GetString(17);
                    txtFatherEmail.Text = reader.GetString(18);

                    if (reader.GetString(19) == txtMother.Text)
                    {
                        cbGuardian.Text = "Mother";
                        txtGuardian.Text = txtMother.Text;
                        txtGuardianNo.Text = txtMotherNo.Text;
                        txtGuardianEmail.Text = txtMotherEmail.Text;
                    }
                    else if (reader.GetString(19) == txtFather.Text)
                    {
                        cbGuardian.Text = "Father";
                        txtGuardian.Text = txtFather.Text;
                        txtGuardianNo.Text = txtFatherNo.Text;
                        txtGuardianEmail.Text = txtFatherEmail.Text;
                    }
                    else
                    {
                        cbGuardian.Text = "Other";
                        txtGuardian.Text = reader.GetString(19);
                        txtGuardianNo.Text = reader.GetString(20);
                        txtGuardianEmail.Text = reader.GetString(21);
                    }

                    requirementChecker(reader.GetInt32(22), checkForm138);
                    requirementChecker(reader.GetInt32(23), checkForm137);
                    requirementChecker(reader.GetInt32(24), checkGoodMoral);
                    requirementChecker(reader.GetInt32(25), checkCompletion);
                    requirementChecker(reader.GetInt32(26), checkPSA);
                    requirementChecker(reader.GetInt32(27), checkVoucher);

                    imgProfile.ImageLocation = reader.GetString(28);
                    tempo = imgProfile.ImageLocation;

                    try
                    {
                        dateBirthdate.Text = reader.GetString(29);
                    }
                    catch (Exception e)
                    {

                    }
                    number2 = txtRFID.Text;
                }
            }

            DBConnect.Close();
            this.ShowDialog();
        }

        private void requirementChecker(int i, Guna.UI2.WinForms.Guna2CheckBox box)
        {
            if (i == 1)
            {
                box.Checked = true;
            }
            else
            {
                box.Checked = false;
            }
        }


    }
}
