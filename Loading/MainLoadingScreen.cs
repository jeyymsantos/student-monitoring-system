using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Monitoring_System.Loading
{
    public partial class MainLoadingScreen : Form
    {
        public MainLoadingScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(guna2CircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                this.Close();
            }
            else
            {
                guna2CircleProgressBar1.Value += 1;
                int a = guna2CircleProgressBar1.Value;

                switch (a)
                {
                    case 10:
                        lblLoading.Text = "Loading.";
                        break;
                    case 15:
                        lblLoading.Text = "Loading..";
                        break;
                    case 20:
                        lblLoading.Text = "Loading...";
                        break;
                    case 25:
                        lblLoading.Text = "Loading.";
                        break;
                    case 30:
                        lblLoading.Text = "Loading..";
                        break;
                    case 35:
                        lblLoading.Text = "Please wait";
                        break;
                    case 40:
                        lblLoading.Text = "Please wait.";
                        break;
                    case 45:
                        lblLoading.Text = "Please wait..";
                        break;
                    case 50:
                        lblLoading.Text = "Please wait...";
                        break;
                    case 55:
                        lblLoading.Text = "Please wait.";
                        break;
                    case 60:
                        lblLoading.Text = "Please wait..";
                        break;
                    case 65:
                        lblLoading.Text = "Please wait...";
                        break;
                    case 70:
                        lblLoading.Text = "Fetching data";
                        break;
                    case 75:
                        lblLoading.Text = "Fetching data.";
                        break;
                    case 80:
                        lblLoading.Text = "Fetching data..";
                        break;
                    case 85:
                        lblLoading.Text = "Fetching data...";
                        break;
                    case 95:
                        lblLoading.Text = "Success!";
                        break;
                }

                lblPercentage.Text = guna2CircleProgressBar1.Value.ToString() + "%";
            }
        }

        private void MainLoadingScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void LoadScreen(string type, string username)
        {
            if(type == "Admin")
            {
                this.ShowDialog();
                Administrator.AdminForm Admin = new Administrator.AdminForm(username);
                Admin.Show();
            }
            else if(type == "Developer")
            {
                this.ShowDialog();
                Developer.MainDeveloper Develop = new Developer.MainDeveloper(username);
                Develop.Show();
            }
        }
    }
}
