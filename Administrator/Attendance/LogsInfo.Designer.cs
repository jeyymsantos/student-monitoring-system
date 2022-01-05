
namespace Student_Monitoring_System.Administrator.Attendance
{
    partial class LogsInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtStatusTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.imgProfile = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTimeIN = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTimeOUT = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStatusTime
            // 
            this.txtStatusTime.BackColor = System.Drawing.Color.Transparent;
            this.txtStatusTime.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusTime.ForeColor = System.Drawing.Color.White;
            this.txtStatusTime.Location = new System.Drawing.Point(127, 37);
            this.txtStatusTime.MaximumSize = new System.Drawing.Size(403, 36);
            this.txtStatusTime.Name = "txtStatusTime";
            this.txtStatusTime.Size = new System.Drawing.Size(107, 30);
            this.txtStatusTime.TabIndex = 13;
            this.txtStatusTime.Text = "Time IN:";
            this.txtStatusTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(97, 6);
            this.txtName.MaximumSize = new System.Drawing.Size(403, 36);
            this.txtName.MinimumSize = new System.Drawing.Size(403, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(403, 36);
            this.txtName.TabIndex = 12;
            this.txtName.Text = "MENDOZA, JEREMY SUNDAY";
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgProfile
            // 
            this.imgProfile.Image = global::Student_Monitoring_System.Properties.Resources.user;
            this.imgProfile.Location = new System.Drawing.Point(19, 6);
            this.imgProfile.Name = "imgProfile";
            this.imgProfile.Size = new System.Drawing.Size(88, 91);
            this.imgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProfile.TabIndex = 11;
            this.imgProfile.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(127, 67);
            this.guna2HtmlLabel1.MaximumSize = new System.Drawing.Size(403, 36);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(120, 30);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "Time OUT:";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimeIN
            // 
            this.txtTimeIN.BackColor = System.Drawing.Color.Transparent;
            this.txtTimeIN.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeIN.ForeColor = System.Drawing.Color.White;
            this.txtTimeIN.Location = new System.Drawing.Point(257, 37);
            this.txtTimeIN.MaximumSize = new System.Drawing.Size(403, 36);
            this.txtTimeIN.Name = "txtTimeIN";
            this.txtTimeIN.Size = new System.Drawing.Size(94, 30);
            this.txtTimeIN.TabIndex = 13;
            this.txtTimeIN.Text = "7:06 PM";
            this.txtTimeIN.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimeOUT
            // 
            this.txtTimeOUT.BackColor = System.Drawing.Color.Transparent;
            this.txtTimeOUT.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeOUT.ForeColor = System.Drawing.Color.White;
            this.txtTimeOUT.Location = new System.Drawing.Point(257, 67);
            this.txtTimeOUT.MaximumSize = new System.Drawing.Size(403, 36);
            this.txtTimeOUT.Name = "txtTimeOUT";
            this.txtTimeOUT.Size = new System.Drawing.Size(94, 30);
            this.txtTimeOUT.TabIndex = 13;
            this.txtTimeOUT.Text = "10:30PM";
            this.txtTimeOUT.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtTimeOUT);
            this.Controls.Add(this.txtTimeIN);
            this.Controls.Add(this.txtStatusTime);
            this.Controls.Add(this.imgProfile);
            this.Controls.Add(this.txtName);
            this.Name = "LogsInfo";
            this.Size = new System.Drawing.Size(509, 104);
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel txtStatusTime;
        private System.Windows.Forms.PictureBox imgProfile;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTimeIN;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTimeOUT;
    }
}
