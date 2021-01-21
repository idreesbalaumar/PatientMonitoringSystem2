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
    public partial class managePatientsUserControl : UserControl
    {
        Random random = new Random();
        static int InitialInterval = 500;
        System.Timers.Timer t = new System.Timers.Timer(InitialInterval);
        System.Timers.Timer tHb = new System.Timers.Timer(InitialInterval);

        public managePatientsUserControl()
        {
            InitializeComponent();
        }

        private double GetRandomTemp()
        {
            return Math.Round(random.NextDouble() * (40 - 30) + 30, 1); 
        }


        private void AddPatientbutton_Click(object sender, EventArgs e)
        {
            patientTableAdapter.Update(pmsDataSet.patient);
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            MessageBox.Show("row selected");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            patientTableAdapter.Update(pmsDataSet.patient);
            MessageBox.Show("Record saved");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetPatientName();
            HandleTimerForStats();
        }

        private void managePatientsUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                patientTableAdapter.FillBy(this.pmsDataSet.patient);
            }
            catch (Exception)
            {

            }
        }

        private void SetPatientName()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string patientName = Convert.ToString(selectedRow.Cells[1].Value);
                lblCurrentPatient.Text = patientName;
            }
        }
        private void HandleTimerForStats()
        {
            RestartTimer();

            t.Elapsed += (s, te) => {
                patientDetailsUserControl1.SetTemp(GetRandomTemp());
                patientDetailsUserControl1.SetBp(random.Next(80, 180), random.Next(60, 120));
                t.Interval = 3000;
                //t.Stop();
            };
            t.Start();

            tHb.Elapsed += (s, tHbe) => {
                patientDetailsUserControl1.SetHeartRate(random.Next(60, 100));
                patientDetailsUserControl1.SetWeight(random.Next(50, 150));
                patientDetailsUserControl1.SetLastUpdate(DateTime.Now.ToString("D"));
                tHb.Interval = 60000;
                //tHb.Stop();
            };
            tHb.Start();
        }
        private void RestartTimer()
        {
            t.Stop();
            tHb.Stop();
            t = new System.Timers.Timer(InitialInterval);
            tHb = new System.Timers.Timer(InitialInterval);
        }
    }
}
