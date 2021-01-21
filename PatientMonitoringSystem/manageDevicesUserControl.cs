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
    public partial class manageDevicesUserControl : UserControl
    {
        public manageDevicesUserControl()
        {
            InitializeComponent();
        }

        private void manageDevicesUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                deviceTableAdapter.Fill(pmsDataSet.device);
            }
            catch (Exception)
            {

            }
        }

        private void AddPatientbutton_Click(object sender, EventArgs e)
        {
            deviceTableAdapter.Update(pmsDataSet.device);
            MessageBox.Show("Record saved");
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.deviceTableAdapter.Fill(this.pmsDataSet.device);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
