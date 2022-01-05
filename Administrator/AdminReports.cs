using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Monitoring_System.Administrator
{
    public partial class AdminReports : UserControl
    {
        public AdminReports()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MyReports.DisplayStrandAttendance x = new MyReports.DisplayStrandAttendance();
            x.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MyReports.DisplayGradeAttendance x = new MyReports.DisplayGradeAttendance();
            x.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MyReports.DisplayAllAttendance x = new MyReports.DisplayAllAttendance();
            x.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            MyReports.DisplayStrand x = new MyReports.DisplayStrand();
            x.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            MyReports.DisplayGrade x = new MyReports.DisplayGrade();
            x.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToLongDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
