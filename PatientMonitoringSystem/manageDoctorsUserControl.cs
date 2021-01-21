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
    public partial class manageDoctorsUserControl : UserControl
    {
        public manageDoctorsUserControl()
        {
            InitializeComponent();
        }

        private void manageDoctorsUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                doctorTableAdapter.FillBy(pmsDataSet.doctor);
            }
            catch (Exception)
            {

            }
        }

        private void AddPatientbutton_Click(object sender, EventArgs e)
        {
            doctorTableAdapter.Update(pmsDataSet.doctor);
            MessageBox.Show("Record saved");
        }
    }
}
