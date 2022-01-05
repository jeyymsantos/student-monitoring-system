
namespace Student_Monitoring_System.Administrator.Posts
{
    partial class PostControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostControl));
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.imgProfile = new System.Windows.Forms.PictureBox();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Panel5.Controls.Add(this.imgProfile);
            this.guna2Panel5.Controls.Add(this.lblContent);
            this.guna2Panel5.Controls.Add(this.lblType);
            this.guna2Panel5.Controls.Add(this.lblName);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel5.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(254, 149);
            this.guna2Panel5.TabIndex = 1;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(7, 43);
            this.lblContent.Margin = new System.Windows.Forms.Padding(0);
            this.lblContent.MaximumSize = new System.Drawing.Size(230, 90);
            this.lblContent.MinimumSize = new System.Drawing.Size(235, 90);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(235, 90);
            this.lblContent.TabIndex = 16;
            this.lblContent.Text = "This is a sample post. Kunyari nagpost si admin ng announcement ganorn. Dapat dit" +
    "o lalabas, So kapag hindi aba, ayusin mo yan girl. Dapat dito lalabas, So kapag " +
    "hindi aba, ayusin.\r\n";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Black;
            this.lblType.Location = new System.Drawing.Point(41, 20);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(50, 17);
            this.lblType.TabIndex = 14;
            this.lblType.Text = "Admin";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(41, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 18);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Jeyym Santos";
            // 
            // imgProfile
            // 
            this.imgProfile.Image = ((System.Drawing.Image)(resources.GetObject("imgProfile.Image")));
            this.imgProfile.Location = new System.Drawing.Point(3, 0);
            this.imgProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgProfile.Name = "imgProfile";
            this.imgProfile.Size = new System.Drawing.Size(36, 40);
            this.imgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProfile.TabIndex = 35;
            this.imgProfile.TabStop = false;
            // 
            // PostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel5);
            this.Name = "PostControl";
            this.Size = new System.Drawing.Size(254, 149);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox imgProfile;
    }
}
