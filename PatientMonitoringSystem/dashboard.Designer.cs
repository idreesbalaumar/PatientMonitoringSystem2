
namespace PatientMonitoringSystem
{
    partial class dashboard
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.devicesButton = new System.Windows.Forms.Button();
            this.nursesButton = new System.Windows.Forms.Button();
            this.doctorsButton = new System.Windows.Forms.Button();
            this.patientButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.dashbordLogoText = new System.Windows.Forms.Label();
            this.dashboardLogo = new System.Windows.Forms.PictureBox();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.dashTabPanel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.navIcon = new System.Windows.Forms.PictureBox();
            this.navHeaderLebel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.footerStatusLabel = new System.Windows.Forms.Label();
            this.CopyRightLabel = new System.Windows.Forms.Label();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pmsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pmsDataSet = new PatientMonitoringSystem.pmsDataSet();
            this.patientTableAdapter = new PatientMonitoringSystem.pmsDataSetTableAdapters.patientTableAdapter();
            this.manageDevicesUserControl1 = new PatientMonitoringSystem.manageDevicesUserControl();
            this.manageNursesUserControl1 = new PatientMonitoringSystem.manageNursesUserControl();
            this.manageDoctorsUserControl2 = new PatientMonitoringSystem.manageDoctorsUserControl();
            this.dasboardTabPanel1 = new PatientMonitoringSystem.dasboardTabPanel();
            this.manageDoctorsUserControl1 = new PatientMonitoringSystem.manageDoctorsUserControl();
            this.managePatientsUserControl1 = new PatientMonitoringSystem.managePatientsUserControl();
            this.sidePanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardLogo)).BeginInit();
            this.dashboardPanel.SuspendLayout();
            this.dashTabPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.White;
            this.sidePanel.Controls.Add(this.settingsButton);
            this.sidePanel.Controls.Add(this.reportsButton);
            this.sidePanel.Controls.Add(this.devicesButton);
            this.sidePanel.Controls.Add(this.nursesButton);
            this.sidePanel.Controls.Add(this.doctorsButton);
            this.sidePanel.Controls.Add(this.patientButton);
            this.sidePanel.Controls.Add(this.dashboardButton);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(230, 629);
            this.sidePanel.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.White;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.settingsButton.Location = new System.Drawing.Point(0, 540);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(230, 80);
            this.settingsButton.TabIndex = 16;
            this.settingsButton.Text = "               Settings";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Visible = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.BackColor = System.Drawing.Color.White;
            this.reportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsButton.FlatAppearance.BorderSize = 0;
            this.reportsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.reportsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.reportsButton.Location = new System.Drawing.Point(0, 460);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(230, 80);
            this.reportsButton.TabIndex = 15;
            this.reportsButton.Text = "               Reports";
            this.reportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.UseVisualStyleBackColor = false;
            this.reportsButton.Visible = false;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // devicesButton
            // 
            this.devicesButton.BackColor = System.Drawing.Color.White;
            this.devicesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.devicesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.devicesButton.FlatAppearance.BorderSize = 0;
            this.devicesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.devicesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.devicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devicesButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devicesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.devicesButton.Location = new System.Drawing.Point(0, 380);
            this.devicesButton.Name = "devicesButton";
            this.devicesButton.Size = new System.Drawing.Size(230, 80);
            this.devicesButton.TabIndex = 14;
            this.devicesButton.Text = "               Devices";
            this.devicesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.devicesButton.UseVisualStyleBackColor = false;
            this.devicesButton.Click += new System.EventHandler(this.devicesButton_Click);
            // 
            // nursesButton
            // 
            this.nursesButton.BackColor = System.Drawing.Color.White;
            this.nursesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nursesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.nursesButton.FlatAppearance.BorderSize = 0;
            this.nursesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.nursesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.nursesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nursesButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nursesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.nursesButton.Location = new System.Drawing.Point(0, 300);
            this.nursesButton.Name = "nursesButton";
            this.nursesButton.Size = new System.Drawing.Size(230, 80);
            this.nursesButton.TabIndex = 13;
            this.nursesButton.Text = "               Nurses";
            this.nursesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nursesButton.UseVisualStyleBackColor = false;
            this.nursesButton.Click += new System.EventHandler(this.nursesButton_Click);
            // 
            // doctorsButton
            // 
            this.doctorsButton.BackColor = System.Drawing.Color.White;
            this.doctorsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doctorsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctorsButton.FlatAppearance.BorderSize = 0;
            this.doctorsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.doctorsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.doctorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.doctorsButton.Location = new System.Drawing.Point(0, 220);
            this.doctorsButton.Name = "doctorsButton";
            this.doctorsButton.Size = new System.Drawing.Size(230, 80);
            this.doctorsButton.TabIndex = 12;
            this.doctorsButton.Text = "               Doctors";
            this.doctorsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorsButton.UseVisualStyleBackColor = false;
            this.doctorsButton.Click += new System.EventHandler(this.doctorsButton_Click_1);
            // 
            // patientButton
            // 
            this.patientButton.BackColor = System.Drawing.Color.White;
            this.patientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientButton.FlatAppearance.BorderSize = 0;
            this.patientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.patientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.patientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.patientButton.Location = new System.Drawing.Point(0, 140);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(230, 80);
            this.patientButton.TabIndex = 11;
            this.patientButton.Text = "               Patients";
            this.patientButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientButton.UseVisualStyleBackColor = false;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.SystemColors.Window;
            this.dashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.dashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.dashboardButton.Location = new System.Drawing.Point(0, 60);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(230, 80);
            this.dashboardButton.TabIndex = 10;
            this.dashboardButton.Text = "               Dashboard";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click_1);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.logoPanel.Controls.Add(this.dashbordLogoText);
            this.logoPanel.Controls.Add(this.dashboardLogo);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(230, 60);
            this.logoPanel.TabIndex = 0;
            this.logoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.logoPanel_Paint);
            // 
            // dashbordLogoText
            // 
            this.dashbordLogoText.AutoSize = true;
            this.dashbordLogoText.BackColor = System.Drawing.Color.Transparent;
            this.dashbordLogoText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbordLogoText.ForeColor = System.Drawing.Color.White;
            this.dashbordLogoText.Location = new System.Drawing.Point(106, 6);
            this.dashbordLogoText.Name = "dashbordLogoText";
            this.dashbordLogoText.Size = new System.Drawing.Size(78, 48);
            this.dashbordLogoText.TabIndex = 2;
            this.dashbordLogoText.Text = "Patient\r\nMonitoring\r\nSystem";
            // 
            // dashboardLogo
            // 
            this.dashboardLogo.BackColor = System.Drawing.Color.Transparent;
            this.dashboardLogo.Image = global::PatientMonitoringSystem.Properties.Resources.pms_img8;
            this.dashboardLogo.Location = new System.Drawing.Point(26, 10);
            this.dashboardLogo.Name = "dashboardLogo";
            this.dashboardLogo.Size = new System.Drawing.Size(88, 43);
            this.dashboardLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dashboardLogo.TabIndex = 2;
            this.dashboardLogo.TabStop = false;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.dashboardPanel.Controls.Add(this.dashTabPanel);
            this.dashboardPanel.Controls.Add(this.progressBar1);
            this.dashboardPanel.Controls.Add(this.panel2);
            this.dashboardPanel.Controls.Add(this.sidePanel);
            this.dashboardPanel.Location = new System.Drawing.Point(12, 35);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(1176, 629);
            this.dashboardPanel.TabIndex = 2;
            // 
            // dashTabPanel
            // 
            this.dashTabPanel.BackColor = System.Drawing.Color.White;
            this.dashTabPanel.Controls.Add(this.manageDevicesUserControl1);
            this.dashTabPanel.Controls.Add(this.manageNursesUserControl1);
            this.dashTabPanel.Controls.Add(this.manageDoctorsUserControl2);
            this.dashTabPanel.Controls.Add(this.dasboardTabPanel1);
            this.dashTabPanel.Controls.Add(this.manageDoctorsUserControl1);
            this.dashTabPanel.Controls.Add(this.managePatientsUserControl1);
            this.dashTabPanel.Location = new System.Drawing.Point(236, 66);
            this.dashTabPanel.Name = "dashTabPanel";
            this.dashTabPanel.Size = new System.Drawing.Size(937, 554);
            this.dashTabPanel.TabIndex = 17;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar1.Location = new System.Drawing.Point(-1, 624);
            this.progressBar1.MarqueeAnimationSpeed = 15;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1182, 3);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 16;
            this.progressBar1.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.navIcon);
            this.panel2.Controls.Add(this.navHeaderLebel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(230, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 60);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::PatientMonitoringSystem.Properties.Resources.pms_logut1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(800, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 40);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // navIcon
            // 
            this.navIcon.BackColor = System.Drawing.Color.Transparent;
            this.navIcon.Image = global::PatientMonitoringSystem.Properties.Resources.pms_ni_dash;
            this.navIcon.Location = new System.Drawing.Point(18, 11);
            this.navIcon.Name = "navIcon";
            this.navIcon.Size = new System.Drawing.Size(40, 40);
            this.navIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.navIcon.TabIndex = 17;
            this.navIcon.TabStop = false;
            // 
            // navHeaderLebel
            // 
            this.navHeaderLebel.AutoSize = true;
            this.navHeaderLebel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navHeaderLebel.ForeColor = System.Drawing.Color.DimGray;
            this.navHeaderLebel.Location = new System.Drawing.Point(64, 19);
            this.navHeaderLebel.Name = "navHeaderLebel";
            this.navHeaderLebel.Size = new System.Drawing.Size(113, 22);
            this.navHeaderLebel.TabIndex = 19;
            this.navHeaderLebel.Text = "Dashboard";
            this.navHeaderLebel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(1119, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(31, 31);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "-";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseHover += new System.EventHandler(this.closeButton_MouseHover);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(1156, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(31, 31);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 130;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // footerStatusLabel
            // 
            this.footerStatusLabel.AutoSize = true;
            this.footerStatusLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footerStatusLabel.ForeColor = System.Drawing.Color.White;
            this.footerStatusLabel.Location = new System.Drawing.Point(16, 669);
            this.footerStatusLabel.Name = "footerStatusLabel";
            this.footerStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.footerStatusLabel.TabIndex = 17;
            // 
            // CopyRightLabel
            // 
            this.CopyRightLabel.AutoSize = true;
            this.CopyRightLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyRightLabel.ForeColor = System.Drawing.Color.White;
            this.CopyRightLabel.Location = new System.Drawing.Point(491, 670);
            this.CopyRightLabel.Name = "CopyRightLabel";
            this.CopyRightLabel.Size = new System.Drawing.Size(0, 16);
            this.CopyRightLabel.TabIndex = 18;
            this.CopyRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "patient";
            this.patientBindingSource.DataSource = this.pmsDataSetBindingSource;
            // 
            // pmsDataSetBindingSource
            // 
            this.pmsDataSetBindingSource.DataSource = this.pmsDataSet;
            this.pmsDataSetBindingSource.Position = 0;
            // 
            // pmsDataSet
            // 
            this.pmsDataSet.DataSetName = "pmsDataSet";
            this.pmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // manageDevicesUserControl1
            // 
            this.manageDevicesUserControl1.Location = new System.Drawing.Point(1, 4);
            this.manageDevicesUserControl1.Name = "manageDevicesUserControl1";
            this.manageDevicesUserControl1.Size = new System.Drawing.Size(908, 530);
            this.manageDevicesUserControl1.TabIndex = 6;
            // 
            // manageNursesUserControl1
            // 
            this.manageNursesUserControl1.Location = new System.Drawing.Point(0, 4);
            this.manageNursesUserControl1.Name = "manageNursesUserControl1";
            this.manageNursesUserControl1.Size = new System.Drawing.Size(908, 530);
            this.manageNursesUserControl1.TabIndex = 5;
            // 
            // manageDoctorsUserControl2
            // 
            this.manageDoctorsUserControl2.Location = new System.Drawing.Point(1, 4);
            this.manageDoctorsUserControl2.Name = "manageDoctorsUserControl2";
            this.manageDoctorsUserControl2.Size = new System.Drawing.Size(908, 530);
            this.manageDoctorsUserControl2.TabIndex = 4;
            // 
            // dasboardTabPanel1
            // 
            this.dasboardTabPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.dasboardTabPanel1.Location = new System.Drawing.Point(1, 0);
            this.dasboardTabPanel1.Name = "dasboardTabPanel1";
            this.dasboardTabPanel1.Size = new System.Drawing.Size(908, 530);
            this.dasboardTabPanel1.TabIndex = 3;
            // 
            // manageDoctorsUserControl1
            // 
            this.manageDoctorsUserControl1.Location = new System.Drawing.Point(3, 0);
            this.manageDoctorsUserControl1.Name = "manageDoctorsUserControl1";
            this.manageDoctorsUserControl1.Size = new System.Drawing.Size(908, 530);
            this.manageDoctorsUserControl1.TabIndex = 2;
            // 
            // managePatientsUserControl1
            // 
            this.managePatientsUserControl1.Location = new System.Drawing.Point(1, 0);
            this.managePatientsUserControl1.Name = "managePatientsUserControl1";
            this.managePatientsUserControl1.Size = new System.Drawing.Size(921, 551);
            this.managePatientsUserControl1.TabIndex = 1;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1200, 691);
            this.Controls.Add(this.CopyRightLabel);
            this.Controls.Add(this.footerStatusLabel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dashboardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.sidePanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardLogo)).EndInit();
            this.dashboardPanel.ResumeLayout(false);
            this.dashTabPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button devicesButton;
        private System.Windows.Forms.Button nursesButton;
        private System.Windows.Forms.Button doctorsButton;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox dashboardLogo;
        private System.Windows.Forms.Label dashbordLogoText;
        private System.Windows.Forms.Label footerStatusLabel;
        private System.Windows.Forms.Label CopyRightLabel;
        private System.Windows.Forms.PictureBox navIcon;
        private System.Windows.Forms.Label navHeaderLebel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private pmsDataSet pmsDataSet;
        private System.Windows.Forms.Panel dashTabPanel;
        private System.Windows.Forms.BindingSource pmsDataSetBindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private pmsDataSetTableAdapters.patientTableAdapter patientTableAdapter;
        private managePatientsUserControl managePatientsUserControl1;
        private manageDoctorsUserControl manageDoctorsUserControl1;
        private dasboardTabPanel dasboardTabPanel1;
        private manageDoctorsUserControl manageDoctorsUserControl2;
        private manageNursesUserControl manageNursesUserControl1;
        private manageDevicesUserControl manageDevicesUserControl1;
    }
}