
namespace Student_Monitoring_System.Administrator.Students
{
    partial class ViewStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudents));
            this.cbStrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.imgProfile = new System.Windows.Forms.PictureBox();
            this.cbGrade = new Guna.UI2.WinForms.Guna2ComboBox();
            this.studGuardian = new Guna.UI2.WinForms.Guna2TextBox();
            this.guardianEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guardianPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.rowStrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studSection = new Guna.UI2.WinForms.Guna2TextBox();
            this.studNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.studPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.studSex = new Guna.UI2.WinForms.Guna2TextBox();
            this.studGrade = new Guna.UI2.WinForms.Guna2TextBox();
            this.studName = new Guna.UI2.WinForms.Guna2TextBox();
            this.rowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.DataStudent = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.header = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataStudent)).BeginInit();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbStrand
            // 
            this.cbStrand.BackColor = System.Drawing.Color.Transparent;
            this.cbStrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStrand.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStrand.FocusedState.Parent = this.cbStrand;
            this.cbStrand.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.cbStrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbStrand.HoverState.Parent = this.cbStrand;
            this.cbStrand.ItemHeight = 30;
            this.cbStrand.Items.AddRange(new object[] {
            "ABM, HE, HUMSS, ICT, STEM",
            "ABM - Accountancy, Business, and Management",
            "HE - Home Economics (Culinary Arts)",
            "HE - Home Economics (Tourism Operations)",
            "HUMSS - Humanities and Social Sciences",
            "ICT - Information & Communications Technology (Mobile App & Web Development)",
            "ICT - Information & Communications Technology (Digital Arts)",
            "STEM - Science, Techonology, Engineering & Mathematics"});
            this.cbStrand.ItemsAppearance.Parent = this.cbStrand;
            this.cbStrand.Location = new System.Drawing.Point(467, 52);
            this.cbStrand.Name = "cbStrand";
            this.cbStrand.ShadowDecoration.Parent = this.cbStrand;
            this.cbStrand.Size = new System.Drawing.Size(202, 36);
            this.cbStrand.StartIndex = 0;
            this.cbStrand.TabIndex = 14;
            this.cbStrand.SelectedIndexChanged += new System.EventHandler(this.cbStrand_SelectedIndexChanged);
            // 
            // imgProfile
            // 
            this.imgProfile.Image = global::Student_Monitoring_System.Properties.Resources.student;
            this.imgProfile.Location = new System.Drawing.Point(42, 11);
            this.imgProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgProfile.Name = "imgProfile";
            this.imgProfile.Size = new System.Drawing.Size(198, 163);
            this.imgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProfile.TabIndex = 4;
            this.imgProfile.TabStop = false;
            // 
            // cbGrade
            // 
            this.cbGrade.BackColor = System.Drawing.Color.Transparent;
            this.cbGrade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrade.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGrade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGrade.FocusedState.Parent = this.cbGrade;
            this.cbGrade.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.cbGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGrade.HoverState.Parent = this.cbGrade;
            this.cbGrade.ItemHeight = 30;
            this.cbGrade.Items.AddRange(new object[] {
            "11 & 12",
            "Grade 11",
            "Grade 12"});
            this.cbGrade.ItemsAppearance.Parent = this.cbGrade;
            this.cbGrade.Location = new System.Drawing.Point(364, 52);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.ShadowDecoration.Parent = this.cbGrade;
            this.cbGrade.Size = new System.Drawing.Size(97, 36);
            this.cbGrade.StartIndex = 0;
            this.cbGrade.TabIndex = 15;
            this.cbGrade.SelectedIndexChanged += new System.EventHandler(this.cbGrade_SelectedIndexChanged);
            // 
            // studGuardian
            // 
            this.studGuardian.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studGuardian.DefaultText = "Guardian";
            this.studGuardian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studGuardian.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studGuardian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studGuardian.DisabledState.Parent = this.studGuardian;
            this.studGuardian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studGuardian.Enabled = false;
            this.studGuardian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studGuardian.FocusedState.Parent = this.studGuardian;
            this.studGuardian.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.studGuardian.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studGuardian.HoverState.Parent = this.studGuardian;
            this.studGuardian.Location = new System.Drawing.Point(22, 450);
            this.studGuardian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studGuardian.Name = "studGuardian";
            this.studGuardian.PasswordChar = '\0';
            this.studGuardian.PlaceholderText = "";
            this.studGuardian.SelectedText = "";
            this.studGuardian.SelectionStart = 8;
            this.studGuardian.ShadowDecoration.Parent = this.studGuardian;
            this.studGuardian.Size = new System.Drawing.Size(239, 31);
            this.studGuardian.TabIndex = 5;
            this.studGuardian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guardianEmail
            // 
            this.guardianEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guardianEmail.DefaultText = "leonorasantos@gmail.com";
            this.guardianEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guardianEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guardianEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guardianEmail.DisabledState.Parent = this.guardianEmail;
            this.guardianEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guardianEmail.Enabled = false;
            this.guardianEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guardianEmail.FocusedState.Parent = this.guardianEmail;
            this.guardianEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.guardianEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guardianEmail.HoverState.Parent = this.guardianEmail;
            this.guardianEmail.Location = new System.Drawing.Point(22, 520);
            this.guardianEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guardianEmail.Name = "guardianEmail";
            this.guardianEmail.PasswordChar = '\0';
            this.guardianEmail.PlaceholderText = "";
            this.guardianEmail.SelectedText = "";
            this.guardianEmail.SelectionStart = 23;
            this.guardianEmail.ShadowDecoration.Parent = this.guardianEmail;
            this.guardianEmail.Size = new System.Drawing.Size(239, 31);
            this.guardianEmail.TabIndex = 5;
            this.guardianEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guardianPhone
            // 
            this.guardianPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guardianPhone.DefaultText = "Guardian Number";
            this.guardianPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guardianPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guardianPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guardianPhone.DisabledState.Parent = this.guardianPhone;
            this.guardianPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guardianPhone.Enabled = false;
            this.guardianPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guardianPhone.FocusedState.Parent = this.guardianPhone;
            this.guardianPhone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.guardianPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guardianPhone.HoverState.Parent = this.guardianPhone;
            this.guardianPhone.Location = new System.Drawing.Point(22, 485);
            this.guardianPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guardianPhone.Name = "guardianPhone";
            this.guardianPhone.PasswordChar = '\0';
            this.guardianPhone.PlaceholderText = "";
            this.guardianPhone.SelectedText = "";
            this.guardianPhone.SelectionStart = 15;
            this.guardianPhone.ShadowDecoration.Parent = this.guardianPhone;
            this.guardianPhone.Size = new System.Drawing.Size(239, 31);
            this.guardianPhone.TabIndex = 5;
            this.guardianPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowStrand
            // 
            this.rowStrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rowStrand.DataPropertyName = "strand";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rowStrand.DefaultCellStyle = dataGridViewCellStyle8;
            this.rowStrand.FillWeight = 216.4089F;
            this.rowStrand.HeaderText = "Strand";
            this.rowStrand.Name = "rowStrand";
            this.rowStrand.ReadOnly = true;
            this.rowStrand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rowStrand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rowStrand.Width = 368;
            // 
            // rowGrade
            // 
            this.rowGrade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rowGrade.DataPropertyName = "gradeLevel";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rowGrade.DefaultCellStyle = dataGridViewCellStyle9;
            this.rowGrade.FillWeight = 70.06639F;
            this.rowGrade.HeaderText = "Grade";
            this.rowGrade.Name = "rowGrade";
            this.rowGrade.ReadOnly = true;
            this.rowGrade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rowGrade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rowGrade.Width = 118;
            // 
            // rowName
            // 
            this.rowName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rowName.DataPropertyName = "fullName";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rowName.DefaultCellStyle = dataGridViewCellStyle10;
            this.rowName.FillWeight = 158.1351F;
            this.rowName.HeaderText = "Student Name";
            this.rowName.Name = "rowName";
            this.rowName.ReadOnly = true;
            this.rowName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rowName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rowName.Width = 330;
            // 
            // studSection
            // 
            this.studSection.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studSection.DefaultText = "Strand";
            this.studSection.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studSection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studSection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studSection.DisabledState.Parent = this.studSection;
            this.studSection.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studSection.Enabled = false;
            this.studSection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studSection.FocusedState.Parent = this.studSection;
            this.studSection.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.studSection.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studSection.HoverState.Parent = this.studSection;
            this.studSection.Location = new System.Drawing.Point(22, 387);
            this.studSection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studSection.Name = "studSection";
            this.studSection.PasswordChar = '\0';
            this.studSection.PlaceholderText = "";
            this.studSection.SelectedText = "";
            this.studSection.SelectionStart = 6;
            this.studSection.ShadowDecoration.Parent = this.studSection;
            this.studSection.Size = new System.Drawing.Size(239, 31);
            this.studSection.TabIndex = 5;
            this.studSection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // studNumber
            // 
            this.studNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studNumber.DefaultText = "Student Number";
            this.studNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studNumber.DisabledState.Parent = this.studNumber;
            this.studNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studNumber.Enabled = false;
            this.studNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studNumber.FocusedState.Parent = this.studNumber;
            this.studNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.studNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studNumber.HoverState.Parent = this.studNumber;
            this.studNumber.Location = new System.Drawing.Point(22, 235);
            this.studNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studNumber.Name = "studNumber";
            this.studNumber.PasswordChar = '\0';
            this.studNumber.PlaceholderText = "";
            this.studNumber.SelectedText = "";
            this.studNumber.SelectionStart = 14;
            this.studNumber.ShadowDecoration.Parent = this.studNumber;
            this.studNumber.Size = new System.Drawing.Size(239, 31);
            this.studNumber.TabIndex = 5;
            this.studNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // studPhone
            // 
            this.studPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studPhone.DefaultText = "Phone Number";
            this.studPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studPhone.DisabledState.Parent = this.studPhone;
            this.studPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studPhone.Enabled = false;
            this.studPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studPhone.FocusedState.Parent = this.studPhone;
            this.studPhone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.studPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studPhone.HoverState.Parent = this.studPhone;
            this.studPhone.Location = new System.Drawing.Point(114, 269);
            this.studPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studPhone.Name = "studPhone";
            this.studPhone.PasswordChar = '\0';
            this.studPhone.PlaceholderText = "";
            this.studPhone.SelectedText = "";
            this.studPhone.SelectionStart = 12;
            this.studPhone.ShadowDecoration.Parent = this.studPhone;
            this.studPhone.Size = new System.Drawing.Size(137, 31);
            this.studPhone.TabIndex = 5;
            this.studPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // studSex
            // 
            this.studSex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studSex.DefaultText = "Sex";
            this.studSex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studSex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studSex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studSex.DisabledState.Parent = this.studSex;
            this.studSex.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studSex.Enabled = false;
            this.studSex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studSex.FocusedState.Parent = this.studSex;
            this.studSex.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.studSex.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studSex.HoverState.Parent = this.studSex;
            this.studSex.Location = new System.Drawing.Point(30, 269);
            this.studSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studSex.Name = "studSex";
            this.studSex.PasswordChar = '\0';
            this.studSex.PlaceholderText = "";
            this.studSex.SelectedText = "";
            this.studSex.SelectionStart = 3;
            this.studSex.ShadowDecoration.Parent = this.studSex;
            this.studSex.Size = new System.Drawing.Size(79, 31);
            this.studSex.TabIndex = 5;
            this.studSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // studGrade
            // 
            this.studGrade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studGrade.DefaultText = "Grade Level";
            this.studGrade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studGrade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studGrade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studGrade.DisabledState.Parent = this.studGrade;
            this.studGrade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studGrade.Enabled = false;
            this.studGrade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studGrade.FocusedState.Parent = this.studGrade;
            this.studGrade.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.studGrade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studGrade.HoverState.Parent = this.studGrade;
            this.studGrade.Location = new System.Drawing.Point(22, 339);
            this.studGrade.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.studGrade.Name = "studGrade";
            this.studGrade.PasswordChar = '\0';
            this.studGrade.PlaceholderText = "";
            this.studGrade.SelectedText = "";
            this.studGrade.SelectionStart = 11;
            this.studGrade.ShadowDecoration.Parent = this.studGrade;
            this.studGrade.Size = new System.Drawing.Size(239, 44);
            this.studGrade.TabIndex = 5;
            this.studGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // studName
            // 
            this.studName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studName.DefaultText = "CLICK A STUDENT";
            this.studName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studName.DisabledState.Parent = this.studName;
            this.studName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studName.Enabled = false;
            this.studName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studName.FocusedState.Parent = this.studName;
            this.studName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.studName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studName.HoverState.Parent = this.studName;
            this.studName.Location = new System.Drawing.Point(22, 188);
            this.studName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.studName.Name = "studName";
            this.studName.PasswordChar = '\0';
            this.studName.PlaceholderText = "";
            this.studName.SelectedText = "";
            this.studName.SelectionStart = 15;
            this.studName.ShadowDecoration.Parent = this.studName;
            this.studName.Size = new System.Drawing.Size(239, 44);
            this.studName.TabIndex = 5;
            this.studName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowID
            // 
            this.rowID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rowID.DataPropertyName = "studID";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rowID.DefaultCellStyle = dataGridViewCellStyle11;
            this.rowID.FillWeight = 54.85557F;
            this.rowID.HeaderText = "ID Number";
            this.rowID.Name = "rowID";
            this.rowID.ReadOnly = true;
            this.rowID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rowID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rowID.Width = 120;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.studGuardian);
            this.guna2Panel1.Controls.Add(this.guardianEmail);
            this.guna2Panel1.Controls.Add(this.guardianPhone);
            this.guna2Panel1.Controls.Add(this.studSection);
            this.guna2Panel1.Controls.Add(this.studNumber);
            this.guna2Panel1.Controls.Add(this.studPhone);
            this.guna2Panel1.Controls.Add(this.studSex);
            this.guna2Panel1.Controls.Add(this.studGrade);
            this.guna2Panel1.Controls.Add(this.studName);
            this.guna2Panel1.Controls.Add(this.imgProfile);
            this.guna2Panel1.Location = new System.Drawing.Point(958, 36);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(276, 675);
            this.guna2Panel1.TabIndex = 12;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Student_Monitoring_System.Properties.Resources.find;
            this.guna2Button1.Location = new System.Drawing.Point(53, 611);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "View Student";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // DataStudent
            // 
            this.DataStudent.AllowUserToAddRows = false;
            this.DataStudent.AllowUserToDeleteRows = false;
            this.DataStudent.AllowUserToResizeColumns = false;
            this.DataStudent.AllowUserToResizeRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DataStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataStudent.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataStudent.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DataStudent.ColumnHeadersHeight = 40;
            this.DataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowID,
            this.rowName,
            this.rowGrade,
            this.rowStrand});
            this.DataStudent.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataStudent.DefaultCellStyle = dataGridViewCellStyle14;
            this.DataStudent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataStudent.EnableHeadersVisualStyles = false;
            this.DataStudent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataStudent.Location = new System.Drawing.Point(13, 96);
            this.DataStudent.Margin = new System.Windows.Forms.Padding(4);
            this.DataStudent.Name = "DataStudent";
            this.DataStudent.ReadOnly = true;
            this.DataStudent.RowHeadersVisible = false;
            this.DataStudent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataStudent.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataStudent.RowTemplate.Height = 40;
            this.DataStudent.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataStudent.ShowCellErrors = false;
            this.DataStudent.ShowEditingIcon = false;
            this.DataStudent.ShowRowErrors = false;
            this.DataStudent.Size = new System.Drawing.Size(938, 614);
            this.DataStudent.TabIndex = 11;
            this.DataStudent.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataStudent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.DataStudent.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataStudent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataStudent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataStudent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataStudent.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DataStudent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataStudent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataStudent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataStudent.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.DataStudent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataStudent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataStudent.ThemeStyle.HeaderStyle.Height = 40;
            this.DataStudent.ThemeStyle.ReadOnly = true;
            this.DataStudent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataStudent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataStudent.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.DataStudent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataStudent.ThemeStyle.RowsStyle.Height = 40;
            this.DataStudent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataStudent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataStudent_CellContentClick);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(20, 52);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(337, 33);
            this.guna2HtmlLabel1.TabIndex = 10;
            this.guna2HtmlLabel1.Text = "SELECT CUSTOM VIEW:";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(212)))));
            this.header.Controls.Add(this.btnClose);
            this.header.Controls.Add(this.label5);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1246, 30);
            this.header.TabIndex = 83;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(1218, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(28, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Student Monitoring System - Students\' List";
            // 
            // ViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1246, 719);
            this.Controls.Add(this.header);
            this.Controls.Add(this.cbStrand);
            this.Controls.Add(this.cbGrade);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.DataStudent);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStudents";
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataStudent)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbStrand;
        private System.Windows.Forms.PictureBox imgProfile;
        private Guna.UI2.WinForms.Guna2ComboBox cbGrade;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox studGuardian;
        private Guna.UI2.WinForms.Guna2TextBox guardianEmail;
        private Guna.UI2.WinForms.Guna2TextBox guardianPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowStrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowName;
        private Guna.UI2.WinForms.Guna2TextBox studSection;
        private Guna.UI2.WinForms.Guna2TextBox studNumber;
        private Guna.UI2.WinForms.Guna2TextBox studPhone;
        private Guna.UI2.WinForms.Guna2TextBox studSex;
        private Guna.UI2.WinForms.Guna2TextBox studGrade;
        private Guna.UI2.WinForms.Guna2TextBox studName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowID;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataStudent;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Panel header;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.Label label5;
    }
}