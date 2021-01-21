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
    public partial class manageNursesUserControl : UserControl
    {
        public manageNursesUserControl()
        {
            InitializeComponent();
        }

        private void manageNursesUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                nurseTableAdapter.FillBy(pmsDataSet.nurse);
            }
            catch (Exception)
            {

            }
        }

        private void AddPatientbutton_Click(object sender, EventArgs e)
        {
            nurseTableAdapter.Update(pmsDataSet.nurse);
            MessageBox.Show("Record saved");
        }
    }
}
