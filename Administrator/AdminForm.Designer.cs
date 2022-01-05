
namespace Student_Monitoring_System.Administrator
{
    partial class AdminForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imgProfile = new System.Windows.Forms.PictureBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMenuHeaderRight = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMenuHeader = new System.Windows.Forms.Label();
            this.PanelTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnBurger = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnAttendance = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudents = new Guna.UI2.WinForms.Guna2Button();
            this.btnOverview = new Guna.UI2.WinForms.Guna2Button();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.adminOverview1 = new Student_Monitoring_System.Administrator.AdminOverview();
            this.AnimatePanel = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.header.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.pnlSideMenu.SuspendLayout();
            this.PanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.ContainerControl = this;
            this.DragControl.TargetControl = this.header;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(212)))));
            this.header.Controls.Add(this.label5);
            this.PanelTransition.SetDecoration(this.header, Guna.UI2.AnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(722, 30);
            this.header.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.PanelTransition.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Student Monitoring System";
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.PanelTransition.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(694, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(28, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.PanelTransition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Academify Solutions";
            // 
            // guna2Separator1
            // 
            this.PanelTransition.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.Location = new System.Drawing.Point(-19, 400);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(216, 13);
            this.guna2Separator1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.imgProfile);
            this.panel3.Controls.Add(this.lblType);
            this.panel3.Controls.Add(this.lblName);
            this.PanelTransition.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 410);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 55);
            this.panel3.TabIndex = 1;
            // 
            // imgProfile
            // 
            this.PanelTransition.SetDecoration(this.imgProfile, Guna.UI2.AnimatorNS.DecorationType.None);
            this.imgProfile.Image = ((System.Drawing.Image)(resources.GetObject("imgProfile.Image")));
            this.imgProfile.Location = new System.Drawing.Point(10, 4);
            this.imgProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgProfile.Name = "imgProfile";
            this.imgProfile.Size = new System.Drawing.Size(36, 40);
            this.imgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProfile.TabIndex = 33;
            this.imgProfile.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblType, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(47, 24);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(36, 17);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(47, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(131, 18);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name Logged In";
            // 
            // lblMenuHeaderRight
            // 
            this.lblMenuHeaderRight.AutoSize = true;
            this.lblMenuHeaderRight.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.lblMenuHeaderRight, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblMenuHeaderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMenuHeaderRight.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuHeaderRight.ForeColor = System.Drawing.Color.Black;
            this.lblMenuHeaderRight.Location = new System.Drawing.Point(416, 0);
            this.lblMenuHeaderRight.Name = "lblMenuHeaderRight";
            this.lblMenuHeaderRight.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblMenuHeaderRight.Size = new System.Drawing.Size(116, 19);
            this.lblMenuHeaderRight.TabIndex = 3;
            this.lblMenuHeaderRight.Text = "Admin / Overview";
            this.lblMenuHeaderRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.lblMenuHeaderRight);
            this.guna2Panel1.Controls.Add(this.lblMenuHeader);
            this.PanelTransition.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(190, 30);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(532, 24);
            this.guna2Panel1.TabIndex = 5;
            // 
            // lblMenuHeader
            // 
            this.lblMenuHeader.AutoSize = true;
            this.lblMenuHeader.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.lblMenuHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblMenuHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuHeader.ForeColor = System.Drawing.Color.Black;
            this.lblMenuHeader.Location = new System.Drawing.Point(5, 4);
            this.lblMenuHeader.Name = "lblMenuHeader";
            this.lblMenuHeader.Size = new System.Drawing.Size(68, 16);
            this.lblMenuHeader.TabIndex = 3;
            this.lblMenuHeader.Text = "Overview";
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind;
            this.PanelTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation2;
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlSideMenu.Controls.Add(this.btnBurger);
            this.pnlSideMenu.Controls.Add(this.label1);
            this.pnlSideMenu.Controls.Add(this.guna2Separator1);
            this.pnlSideMenu.Controls.Add(this.panel3);
            this.pnlSideMenu.Controls.Add(this.btnLogout);
            this.pnlSideMenu.Controls.Add(this.btnSettings);
            this.pnlSideMenu.Controls.Add(this.btnReports);
            this.pnlSideMenu.Controls.Add(this.btnAttendance);
            this.pnlSideMenu.Controls.Add(this.btnStudents);
            this.pnlSideMenu.Controls.Add(this.btnOverview);
            this.PanelTransition.SetDecoration(this.pnlSideMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 30);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(190, 465);
            this.pnlSideMenu.TabIndex = 3;
            // 
            // btnBurger
            // 
            this.btnBurger.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBurger.CheckedState.Parent = this.btnBurger;
            this.PanelTransition.SetDecoration(this.btnBurger, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBurger.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnBurger.HoverState.Parent = this.btnBurger;
            this.btnBurger.Image = global::Student_Monitoring_System.Properties.Resources.back;
            this.btnBurger.ImageRotate = 0F;
            this.btnBurger.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBurger.Location = new System.Drawing.Point(6, 13);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.btnBurger.PressedState.Parent = this.btnBurger;
            this.btnBurger.Size = new System.Drawing.Size(20, 20);
            this.btnBurger.TabIndex = 3;
            this.btnBurger.Click += new System.EventHandler(this.btnBurger_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.OrangeRed;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.PanelTransition.SetDecoration(this.btnLogout, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogout.FillColor = System.Drawing.Color.OrangeRed;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = global::Student_Monitoring_System.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Location = new System.Drawing.Point(6, 362);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(184, 38);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Animated = true;
            this.btnSettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(212)))));
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.PanelTransition.SetDecoration(this.btnSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = global::Student_Monitoring_System.Properties.Resources.settings;
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.Location = new System.Drawing.Point(6, 318);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(184, 38);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnReports
            // 
            this.btnReports.Animated = true;
            this.btnReports.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(212)))));
            this.btnReports.CheckedState.Parent = this.btnReports;
            this.btnReports.CustomImages.Parent = this.btnReports;
            this.PanelTransition.SetDecoration(this.btnReports, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnReports.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReports.FillColor = System.Drawing.Color.Transparent;
            this.btnReports.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.HoverState.Parent = this.btnReports;
            this.btnReports.Image = global::Student_Monitoring_System.Properties.Resources.reports;
            this.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReports.Location = new System.Drawing.Point(6, 173);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReports.ShadowDecoration.Parent = this.btnReports;
            this.btnReports.Size = new System.Drawing.Size(184, 38);
            this.btnReports.TabIndex = 0;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Animated = true;
            this.btnAttendance.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(212)))));
            this.btnAttendance.CheckedState.Parent = this.btnAttendance;
            this.btnAttendance.CustomImages.Parent = this.btnAttendance;
            this.PanelTransition.SetDecoration(this.btnAttendance, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAttendance.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAttendance.FillColor = System.Drawing.Color.Transparent;
            this.btnAttendance.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.HoverState.Parent = this.btnAttendance;
            this.btnAttendance.Image = global::Student_Monitoring_System.Properties.Resources.attendance;
            this.btnAttendance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAttendance.Location = new System.Drawing.Point(6, 134);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAttendance.ShadowDecoration.Parent = this.btnAttendance;
            this.btnAttendance.Size = new System.Drawing.Size(184, 38);
            this.btnAttendance.TabIndex = 0;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Animated = true;
            this.btnStudents.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(212)))));
            this.btnStudents.CheckedState.Parent = this.btnStudents;
            this.btnStudents.CustomImages.Parent = this.btnStudents;
            this.PanelTransition.SetDecoration(this.btnStudents, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnStudents.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStudents.FillColor = System.Drawing.Color.Transparent;
            this.btnStudents.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.HoverState.Parent = this.btnStudents;
            this.btnStudents.Image = global::Student_Monitoring_System.Properties.Resources.students;
            this.btnStudents.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudents.Location = new System.Drawing.Point(6, 95);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnStudents.ShadowDecoration.Parent = this.btnStudents;
            this.btnStudents.Size = new System.Drawing.Size(184, 38);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "Students";
            this.btnStudents.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.Animated = true;
            this.btnOverview.BackColor = System.Drawing.Color.Transparent;
            this.btnOverview.Checked = true;
            this.btnOverview.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(212)))));
            this.btnOverview.CheckedState.Parent = this.btnOverview;
            this.btnOverview.CustomImages.Parent = this.btnOverview;
            this.PanelTransition.SetDecoration(this.btnOverview, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnOverview.FillColor = System.Drawing.Color.Transparent;
            this.btnOverview.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnOverview.ForeColor = System.Drawing.Color.White;
            this.btnOverview.HoverState.Parent = this.btnOverview;
            this.btnOverview.Image = global::Student_Monitoring_System.Properties.Resources.overview;
            this.btnOverview.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOverview.Location = new System.Drawing.Point(6, 56);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnOverview.ShadowDecoration.Parent = this.btnOverview;
            this.btnOverview.Size = new System.Drawing.Size(184, 38);
            this.btnOverview.TabIndex = 0;
            this.btnOverview.Text = "Overview";
            this.btnOverview.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.adminOverview1);
            this.PanelTransition.SetDecoration(this.PanelContent, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(190, 54);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(532, 441);
            this.PanelContent.TabIndex = 6;
            // 
            // adminOverview1
            // 
            this.PanelTransition.SetDecoration(this.adminOverview1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.adminOverview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminOverview1.Location = new System.Drawing.Point(0, 0);
            this.adminOverview1.Name = "adminOverview1";
            this.adminOverview1.Size = new System.Drawing.Size(532, 441);
            this.adminOverview1.TabIndex = 0;
            // 
            // AnimatePanel
            // 
            this.AnimatePanel.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.AnimatePanel.Interval = 1000;
            this.AnimatePanel.TargetForm = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 495);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.header);
            this.PanelTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSideMenu.PerformLayout();
            this.PanelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Transition PanelTransition;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblMenuHeaderRight;
        private System.Windows.Forms.Label lblMenuHeader;
        private System.Windows.Forms.Panel pnlSideMenu;
        private Guna.UI2.WinForms.Guna2ImageButton btnBurger;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private Guna.UI2.WinForms.Guna2Button btnAttendance;
        private Guna.UI2.WinForms.Guna2Button btnStudents;
        private Guna.UI2.WinForms.Guna2Button btnOverview;
        private System.Windows.Forms.Panel header;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2AnimateWindow AnimatePanel;
        private System.Windows.Forms.Panel PanelContent;
        private AdminOverview adminOverview1;
        private System.Windows.Forms.PictureBox imgProfile;
        private System.Windows.Forms.Timer timer1;
    }
}