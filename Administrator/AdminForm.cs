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
    public partial class AdminForm : Form 
    {
        MySqlConnection DBConnect = new MySqlConnection("datasource = localhost; username = root; password=; database = studentmonitoringsystem;");
        MySqlCommand command = new MySqlCommand();
        string query, username;
        public AdminForm(string username)
        {
            InitializeComponent();
            this.username = username;
            setData(username);
            //timer1.Start();
        }

        public void setData(string username)
        {
            DBConnect.Open();
            query = "SELECT name, type, img FROM accounts WHERE username = @username";
            command = new MySqlCommand(query, DBConnect);

            command.Parameters.AddWithValue("@username", username);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lblName.Text = reader.GetString(0);
                    lblType.Text = reader.GetString(1);
                    imgProfile.ImageLocation = reader.GetString(2);
                }
            }

            DBConnect.Close();
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            if (pnlSideMenu.Width == 190)
            {
                this.Width = ActiveForm.Width - 140;
                this.CenterToScreen();

                pnlSideMenu.Visible = false;
                btnBurger.Image = Properties.Resources.menu;
                pnlSideMenu.Width = 50;
                PanelTransition.ShowSync(pnlSideMenu);

            }
            else
            {
                this.Width = ActiveForm.Width + 140;
                this.CenterToScreen();

                pnlSideMenu.Visible = false;
                btnBurger.Image = Properties.Resources.back;
                pnlSideMenu.Width = 190;
                PanelTransition.ShowSync(pnlSideMenu);

                
            }
        }

        void setState(Guna.UI2.WinForms.Guna2Button button)
        {
            timer1.Stop();

            btnOverview.Checked = false;
            btnStudents.Checked = false;
            btnAttendance.Checked = false;
            btnReports.Checked = false;
            btnSettings.Checked = false;

            button.Checked = true;
            lblMenuHeader.Text = button.Text;
            lblMenuHeaderRight.Text = "Admin / " + button.Text;

            switch (button.Text)
            {
                case "Overview":
                    PanelContent.Controls.Clear();

                    PanelContent.Controls.Add(new AdminOverview());
                    PanelContent.Visible = false;
                    PanelTransition.ShowSync(PanelContent);
                    
                    break;
                case "Students":
                    PanelContent.Controls.Clear();

                    PanelContent.Controls.Add(new AdminStudents(lblName.Text, lblType.Text, imgProfile.ImageLocation, username));
                    PanelContent.Visible = false;
                    PanelTransition.ShowSync(PanelContent);
                    break;
                case "Attendance":
                    PanelContent.Controls.Clear();

                    PanelContent.Controls.Add(new Attendance.Logs());
                    PanelContent.Visible = false;
                    PanelTransition.ShowSync(PanelContent);
                    break;
                case "Reports":
                    PanelContent.Controls.Clear();

                    PanelContent.Controls.Add(new AdminReports());
                    PanelContent.Visible = false;
                    PanelTransition.ShowSync(PanelContent);
                    break;
                case "Settings":
                    PanelContent.Controls.Clear();

                    PanelContent.Controls.Add(new AdminSettings(username, lblType.Text));
                    PanelContent.Visible = false;
                    PanelTransition.ShowSync(PanelContent);

                    timer1.Start();
                    break;
            }
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            setState(btnOverview);
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            setState(btnStudents);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            setState(btnAttendance);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            setState(btnReports);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            setState(btnSettings);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Alerts.ConfirmAlert ConfirmLogout = new Alerts.ConfirmAlert();
            
            if(ConfirmLogout.ShowConfirmAlert("Are you sure you want to logout?") == true)
            {
                this.Close();
                Loading.MainSplashScreen Logout = new Loading.MainSplashScreen();
                Logout.Show();
            }
        }

        private void adminOverview1_Load(object sender, EventArgs e)
        {

        }

        private void imgProfile_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setData(username);
        }
    }
}
