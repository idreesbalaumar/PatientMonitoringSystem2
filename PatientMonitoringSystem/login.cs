using System;
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
    public partial class login : Form
    {
        private readonly string userName = "admin";
        private readonly string password = "password";
        
        public login()
        {
            InitializeComponent();
            txtUsername.GotFocus += RemoveText;
            txtPassword.GotFocus += RemoveText;
            txtUsername.LostFocus += AddText;
            txtPassword.LostFocus += AddText;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.pms_img3;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.pms_img5;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.pms_img5;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(checkLogin())
            {
                dashboard df = new dashboard();
                df.Show();
                Hide();
            } 
            else
            {
                MessageBox.Show("Login Invalid");
            }
            
        }

        public void RemoveText(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Name == txtUsername.Name)
            {
                txtUsername.Text = string.Empty;
            }
            else
            {
                txtPassword.Text = string.Empty;
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Name == txtUsername.Name)
            {
                if (!string.IsNullOrEmpty(txtUsername.Text)) return;
                txtUsername.Text = "Username";
            }
            else
            {
                if (!string.IsNullOrEmpty(txtPassword.Text)) return;
                txtPassword.Text = "Password";
            }
        }

        private bool checkLogin()
        {
            if (txtUsername.Text != userName) return false;
            if (txtPassword.Text != password) return false;

            return true;
        }
    }
}
