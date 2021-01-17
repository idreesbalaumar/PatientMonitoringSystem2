using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientMonitoringSystem
{
    public partial class dashboard : Form
    {
        static dashboard _obj;

        public static dashboard Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new dashboard();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return dashTabPanel; }
            set { dashTabPanel = value; }
        }

        /*public Button BackButton
        {
            get { return btnBack; }
            set { btnBack = value; }
        }*/

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public dashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void logoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void doctorsButton_Click(object sender, EventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizeBtn_MouseHover(object sender, EventArgs e)
        {
            //minimizeBtn.BackColor = Color.Blue;
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Visible = true;

            this.progressBar1.Value = this.progressBar1.Value + 5;
            if (this.progressBar1.Value == 5)
            {
                footerStatusLabel.Text = "Preparing modules...";
            }
            else if (this.progressBar1.Value == 40)
            {
                footerStatusLabel.Text = "Loading Loading modules...";
            }
            else if (this.progressBar1.Value == 65)
            {
                footerStatusLabel.Text = "Done Loading modules...";
            }
            else if (this.progressBar1.Value == 80)
            {
                footerStatusLabel.Text = "Done Loading modules...";
            }
            else if (this.progressBar1.Value == 100)
            {
                footerStatusLabel.Text = "";
                this.progressBar1.Hide();
                //this.Hide();
                timer1.Enabled = false;
                //loginForm LF = new loginForm();
                //LF.Show();
            }
        }

        private void dashboardButton_Click_1(object sender, EventArgs e)
        {
            //dasboardTabPanel1.Controls.Clear();
            managePatientsUserControl1.Visible = false;
            dasboardTabPanel1.Visible = true;
            dasboardTabPanel uc = new dasboardTabPanel();
            uc.Show();
            //loadModule();
            navIcon.Image = Properties.Resources.pms_ni_dash;
            navHeaderLebel.Text = "Dashboard";
            //dasboardTabPanel.Visible = false;

           /* _obj = this;
            dasboardTabPanel uc = new dasboardTabPanel();
            uc.Dock = DockStyle.Fill;
            dashTabPanel.Controls.Add(uc);*/



        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            //dasboardTabPanel1.Controls.Clear();
            managePatientsUserControl1.Visible = true;
            //dasboardTabPanel.Visible = false;
            //loadModule();
            navIcon.Image = Properties.Resources.pms_ni_pateint;
            navHeaderLebel.Text = "Patients";

            

        }

        private void doctorsButton_Click_1(object sender, EventArgs e)
        {
            //loadModule();
            navIcon.Image = Properties.Resources.pms_ni_doc;
            navHeaderLebel.Text = "Doctors";
        }

        private void nursesButton_Click(object sender, EventArgs e)
        {
            //loadModule();
            navIcon.Image = Properties.Resources.pms_ni_nurse;
            navHeaderLebel.Text = "Nurses";
        }

        private void devicesButton_Click(object sender, EventArgs e)
        {
            //loadModule();
            navIcon.Image = Properties.Resources.pms_ni_dev1;
            navHeaderLebel.Text = "Devices";
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            //loadModule();
            navIcon.Image = Properties.Resources.pms_ni_reports;
            navHeaderLebel.Text = "Reports";
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            //loadModule();
            navIcon.Image = Properties.Resources.pms_ni_settings;
            navHeaderLebel.Text = "Settings";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            login lf = new login();
            lf.Show();
            this.Hide();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.pms_logut1;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.pms_logut2;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.pms_logut2;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.pms_logut1;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            _obj = this;
            dasboardTabPanel uc = new dasboardTabPanel();
            uc.Dock = DockStyle.Fill;
            dashTabPanel.Controls.Add(uc);
        }
    }
}
