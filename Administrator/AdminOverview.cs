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
    public partial class AdminOverview : UserControl
    {

        MySqlConnection DBConnect = new MySqlConnection("datasource=localhost; username=root; password=; database=studentmonitoringsystem;");
        MySqlCommand command = new MySqlCommand();

        string query, name, content, type, img;

        public AdminOverview()
        {
            InitializeComponent();
            timer1.Start();
            getPosts();
            getNoOfStudents();
            getInOut();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToLongDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }

        public void getPosts()
        {
            DBConnect.Open();
            query = "SELECT name, content, type, img FROM posts ORDER BY id DESC";
            command = new MySqlCommand(query, DBConnect);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    this.name = reader.GetString(0);
                    this.content = reader.GetString(1);
                    this.type = reader.GetString(2);
                    this.img = reader.GetString(3);
                    flowPanel.Controls.Add(new Posts.PostControl(name, type, content));
                }
            }
            
            DBConnect.Close();
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
            lblTotal.Text = (grade11 + grade12).ToString();
        }

        private void getInOut()
        {
            int inside = 0, outside = 0;
            DBConnect.Open();
            query = "SELECT timeIN, timeOUT FROM logs WHERE date = @myDate";
            command = new MySqlCommand(query, DBConnect);

            command.Parameters.AddWithValue("@myDate", DateTime.Now.ToShortDateString());

            DateTime today = DateTime.Now;
            DateTime dateIN;

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetString(1) == "")
                    {
                        inside++;
                    }
                    else
                    {
                        outside++;
                    }
                }
            }

            DBConnect.Close();
            txtInside.Text = inside.ToString();
            txtOutside.Text = outside.ToString();
        }
    }
}
