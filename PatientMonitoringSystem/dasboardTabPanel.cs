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
    public partial class dasboardTabPanel : UserControl
    {
        public dasboardTabPanel()
        {
            InitializeComponent();
        }

        private void dasboardTabPanel_Load(object sender, EventArgs e)
        {
           
        }

        public void SetStatValues((int patients, int doctors, int nurses, int devices) stats)
        {
            lblPatientCount.Text = stats.patients.ToString();
            lblTotalDoctors.Text = stats.doctors.ToString();
            lblTotalNurses.Text = stats.nurses.ToString();
            lblTotalDevices.Text = stats.devices.ToString();
            lblDate.Text = DateTime.Today.ToString("D");
            lblTime.Text = DateTime.Now.ToString("t");
        }
    }
}
