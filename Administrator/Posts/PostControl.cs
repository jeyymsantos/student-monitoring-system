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

namespace Student_Monitoring_System.Administrator.Posts
{
    public partial class PostControl : UserControl
    {
        MySqlConnection DBConnect = new MySqlConnection("datasource=localhost; username=root; password=; database=studentmonitoringsystem;");
        MySqlCommand command = new MySqlCommand();
        string query;

        public PostControl(string name, string type, string content)
        {
            InitializeComponent();
            lblName.Text = name;
            lblType.Text = type;
            lblContent.Text = content;

            DBConnect.Open();
            query = "SELECT img FROM accounts WHERE name = @name";
            command = new MySqlCommand(query, DBConnect);

            command.Parameters.AddWithValue("@name", name);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    imgProfile.ImageLocation = reader.GetString(0);
                }
            }

            DBConnect.Close();
        }
    }
}
