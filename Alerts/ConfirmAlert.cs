using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Monitoring_System.Alerts
{
    public partial class ConfirmAlert : Form
    {
        public ConfirmAlert()
        {
            InitializeComponent();
        }

        public bool ShowConfirmAlert(string msg)
        {
            lblMessage.Text = msg;
            btnYes.Checked = false;
            btnNo.Checked = false;

            this.ShowDialog();

            if(btnYes.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        void SelectedButton(Guna.UI2.WinForms.Guna2Button button)
        {
            btnYes.Checked = false;
            btnNo.Checked = false;

            button.Checked = true;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            SelectedButton(btnYes);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            SelectedButton(btnNo);
        }
    }
}
