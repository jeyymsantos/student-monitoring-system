using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Monitoring_System
{
    class SaveMethods
    {
        MySqlConnection DBConnect = new MySqlConnection("datasource=localhost; username=root; password=; database=studentmonitoringsystem;");
        MySqlCommand command = new MySqlCommand();

        string query;
        private string userID, username, password, name, type, img;


        public string GetPass(string username)
        {
            string password = "";

            DBConnect.Open();
            query = "SELECT password FROM accounts WHERE username = @username";
            command = new MySqlCommand(query, DBConnect);

            command.Parameters.AddWithValue("@username", username);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    password = reader.GetString(0);
                }
            }

            return password;
        }

        public string getImg(string username)
        {

            DBConnect.Open();
            query = "SELECT img FROM accounts WHERE username = @uname";

            command = new MySqlCommand(query, DBConnect);
            command.Parameters.AddWithValue("@uname", username);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    this.img = reader.GetString(0);
                }
            }
            DBConnect.Close();
            return this.img;
        }

        public string getName(string username)
        {

            DBConnect.Open();
            query = "SELECT name FROM accounts WHERE username = @uname";

            command = new MySqlCommand(query, DBConnect);
            command.Parameters.AddWithValue("@uname", username);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    this.name = reader.GetString(0);
                }
            }
            DBConnect.Close();
            return this.name;
        }

        public string getUserID(string username)
        {

            DBConnect.Open();
            query = "SELECT userID FROM accounts WHERE username = @uname";

            command = new MySqlCommand(query, DBConnect);
            command.Parameters.AddWithValue("@uname", username);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                   this.userID = reader.GetString(0);
                }
            }
            DBConnect.Close();
            return this.userID;
        }

        public string getPassword(string username)
        {

            DBConnect.Open();
            query = "SELECT password FROM accounts WHERE username = @uname";

            command = new MySqlCommand(query, DBConnect);
            command.Parameters.AddWithValue("@uname", username);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    this.password = reader.GetString(0);
                }
            }
            DBConnect.Close();
            return this.password;
        }

        public void DeleteStudent(string id)
        {
            query = "DELETE FROM students WHERE studID = @stID";

            DBConnect.Open();
            command = new MySqlCommand(query, DBConnect);
            command.Parameters.AddWithValue("@stID", id);

            command.ExecuteNonQuery();
            DBConnect.Close();

            Alerts.AlertForm alert = new Alerts.AlertForm();
            alert.showAlert("Student deleted successfully!", Alerts.AlertForm.enmType.Success);
        }


        public bool ConfirmPassword(string username, string password)
        {
            try
            {
                DBConnect.Open();
                query = "SELECT username, password, userID, type, name, img FROM accounts WHERE username = @uname";

                command = new MySqlCommand(query, DBConnect);
                command.Parameters.AddWithValue("@uname", username);

                MySqlDataReader reader = command.ExecuteReader();

                int Checker = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(1) == password)
                        {
                            Checker = 1;
                            this.username = reader.GetString(0);
                            this.password = reader.GetString(1);
                            this.userID = reader.GetString(2);
                            this.type = reader.GetString(3);
                            this.name = reader.GetString(4);
                            this.img = reader.GetString(5);
                        }
                    }
                }

                DBConnect.Close();

                if (Checker == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch(Exception e)
            {
                DBConnect.Close();
                Alerts.AlertForm alert = new Alerts.AlertForm();
                alert.showAlert("Encountered an internal issue! Try again!", Alerts.AlertForm.enmType.Info);

                return false;
            }
            
        }

        Alerts.AlertForm Error = new Alerts.AlertForm();
        public bool CheckMissingField(Guna.UI2.WinForms.Guna2TextBox textbox)
        {
            if(textbox.Text == "")
            {
                textbox.BorderColor = Color.OrangeRed;
                return true;
            }
            else
            {
                textbox.BorderColor = Color.FromArgb(213, 218, 223);
                return false;
            }
        }

        public string GetType(string username)
        {
            string type = "";

            DBConnect.Open();
            query = "SELECT type FROM accounts WHERE username = @uname";

            command = new MySqlCommand(query, DBConnect);
            command.Parameters.AddWithValue("@uname", username);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    type = reader.GetString(0);
                }
            }
            DBConnect.Close();
            return type;
        }

        public bool IsNumeric(string text)
        {
            return double.TryParse(text, out _);
        }

        public int IsNumber(Guna.UI2.WinForms.Guna2TextBox textbox)
        {

            if(textbox.Name == "txtStudID")
            {
                if (IsNumeric(textbox.Text) == false || textbox.Text.Length != 11)
                {
                    textbox.BorderColor = Color.Red;
                    return 1;
                }
                else
                {
                    textbox.BorderColor = Color.FromArgb(213, 218, 223);
                    return 0;
                }
            }
            else
            {
                if (IsNumeric(textbox.Text) == false || textbox.Text.Length != 10)
                {
                    textbox.BorderColor = Color.Red;
                    return 1;
                }
                else
                {
                    textbox.BorderColor = Color.FromArgb(213, 218, 223);
                    return 0;
                }
            }
        }

        public int IsPhone(Guna.UI2.WinForms.Guna2TextBox textbox)
        {
            if (textbox.Text.Length != 11)
            {
                textbox.BorderColor = Color.Red;
                return 1;
            }
            else if (textbox.Text.Substring(0, 2) != "09")
            {
                textbox.BorderColor = Color.Red;
                return 2;
            }
            else if(IsNumeric(textbox.Text) == false)
            {
                textbox.BorderColor = Color.Red;
                return 3;
            }
            else {
                textbox.BorderColor = Color.FromArgb(213, 218, 223);
                return 0;
            }
        }

        public int IsEmpty(Guna.UI2.WinForms.Guna2TextBox textbox)
        {
            if (textbox.Text == "")
            {
                textbox.BorderColor = Color.Red;
                return 1;
            }
            else
            {
                textbox.BorderColor = Color.FromArgb(213, 218, 223);
                return 0;
            }
        }

        public int ExistingStudNumber(Guna.UI2.WinForms.Guna2TextBox theID, int id)
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

                    theID.BorderColor = Color.Red;
                    errors = 500;

                }
            }
            else
            {
                theID.BorderColor = Color.FromArgb(213, 218, 223);
            }

            DBConnect.Close();
            return errors;
        }

        public int reqValidate(Guna.UI2.WinForms.Guna2CheckBox checkbox)
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

        public void PostMessage(string type, string content, string name)
        {
            try
            {
                DBConnect.Open();
                query = "INSERT INTO posts (userID, name, type, content) VALUES ('" + userID + "', '" + name + "', '" + type + "', '" + content + "')";
                command = new MySqlCommand(query, DBConnect);
                command.ExecuteNonQuery();
                DBConnect.Close();

                Alerts.AlertForm alerts = new Alerts.AlertForm();
                alerts.showAlert("Posted successfuly!", Alerts.AlertForm.enmType.Success);
            }
            catch(Exception e)
            {
                Alerts.AlertForm alert = new Alerts.AlertForm();
                alert.showAlert("There are invalid characters!", Alerts.AlertForm.enmType.Warning);
                DBConnect.Close();
            }
        }
    }

}
