
namespace Student_Monitoring_System.Administrator.Attendance
{
    partial class AttendanceInfo
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
            this.txtName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtStatusTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.imgProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(108, 8);
            this.txtName.MaximumSize = new System.Drawing.Size(403, 36);
            this.txtName.MinimumSize = new System.Drawing.Size(403, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(403, 36);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "MENDOZA, JEREMY SUNDAY";
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStatusTime
            // 
            this.txtStatusTime.BackColor = System.Drawing.Color.Transparent;
            this.txtStatusTime.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusTime.ForeColor = System.Drawing.Color.White;
            this.txtStatusTime.Location = new System.Drawing.Point(161, 40);
            this.txtStatusTime.MaximumSize = new System.Drawing.Size(403, 36);
            this.txtStatusTime.Name = "txtStatusTime";
            this.txtStatusTime.Size = new System.Drawing.Size(276, 30);
            this.txtStatusTime.TabIndex = 10;
            this.txtStatusTime.Text = "Jeremy Sunday Mendoza";
            this.txtStatusTime.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgProfile
            // 
            this.imgProfile.Image = global::Student_Monitoring_System.Properties.Resources.user;
            this.imgProfile.Location = new System.Drawing.Point(27, 6);
            this.imgProfile.Name = "imgProfile";
            this.imgProfile.Size = new System.Drawing.Size(75, 66);
            this.imgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProfile.TabIndex = 8;
            this.imgProfile.TabStop = false;
            // 
            // AttendanceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.txtStatusTime);
            this.Controls.Add(this.imgProfile);
            this.Controls.Add(this.txtName);
            this.Name = "AttendanceInfo";
            this.Size = new System.Drawing.Size(532, 78);
            this.Load += new System.EventHandler(this.AttendanceInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgProfile;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtName;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtStatusTime;
    }
}
