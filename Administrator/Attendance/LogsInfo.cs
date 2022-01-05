using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Monitoring_System.Administrator.Attendance
{
    public partial class LogsInfo : UserControl
    {
        public LogsInfo(string name, string timein, string timeout, string profile)
        {
            InitializeComponent();

            txtName.Text = name;
            txtTimeIN.Text = timein;
            txtTimeOUT.Text = timeout;
            imgProfile.ImageLocation = profile;

            if (timeout == "Not yet.")
            {
                this.BackColor = Color.RoyalBlue;
            }
            else
            {
                this.BackColor = Color.MediumSeaGreen;
            }
        }

    }
}
