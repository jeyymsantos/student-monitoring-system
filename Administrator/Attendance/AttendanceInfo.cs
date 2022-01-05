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
    public partial class AttendanceInfo : UserControl
    {
        public AttendanceInfo(string name, string status, string time, string imgLocation)
        {
            InitializeComponent();
            imgProfile.ImageLocation = imgLocation;
            txtName.Text = name;

            if(status == "LOGGED IN")
            {
                this.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                this.BackColor = Color.Crimson;
            }

            txtStatusTime.Text = status + ": " + time;
        }

        private void AttendanceInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
