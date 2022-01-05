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
    public partial class MainSplashScreen : Form
    {
        public MainSplashScreen()
        {
            InitializeComponent();
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MainSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(guna2ProgressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
            else
            {
                guna2ProgressBar1.Value += 1;
                lblPercentage.Text = guna2ProgressBar1.Value.ToString() + "%";
            }
            
        }
    }
}
