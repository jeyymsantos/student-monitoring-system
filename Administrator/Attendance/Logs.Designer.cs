
namespace Student_Monitoring_System.Administrator.Attendance
{
    partial class Logs
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
            this.LogsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LogsPanel
            // 
            this.LogsPanel.AutoScroll = true;
            this.LogsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogsPanel.Location = new System.Drawing.Point(0, 0);
            this.LogsPanel.Name = "LogsPanel";
            this.LogsPanel.Size = new System.Drawing.Size(532, 441);
            this.LogsPanel.TabIndex = 0;
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.LogsPanel);
            this.Name = "Logs";
            this.Size = new System.Drawing.Size(532, 441);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LogsPanel;
    }
}
