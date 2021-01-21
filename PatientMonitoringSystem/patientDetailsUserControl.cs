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
    public partial class patientDetailsUserControl : UserControl
    {
        delegate void SetWeightCallback(int temp);
        delegate void SetTempCallback(double temp);
        delegate void SetHeartCallback(int temp);
        delegate void SetBpCallback(int upper, int lower);
        delegate void SetLastUpdateCallback(string lastUpdate);
        public patientDetailsUserControl()
        {
            InitializeComponent();
        }

        public void SetWeight(int weight)
        {             
            string text = $"{weight.ToString()}";

            if (lblTemp.InvokeRequired)
            {

                SetWeightCallback d = new SetWeightCallback(SetWeight);
                Invoke(d, new object[] { weight });
            }
            else
            {
                lblWeight.Text = text;
            }
        }

        public void SetTemp(double temp)
        {
            string text = $"{temp.ToString()}";
            if (lblTemp.InvokeRequired)
            {                
                SetTempCallback d = new SetTempCallback(SetTemp);
                Invoke(d, new object[] { temp });
            }
            else
            {
                lblTemp.Text = text;
            }            
        }

        public void SetHeartRate(int heartrate)
        {
           
            string text = $"{heartrate}";

            if (lblTemp.InvokeRequired)
            {
                SetHeartCallback d = new SetHeartCallback(SetHeartRate);
                Invoke(d, new object[] { heartrate });
            }
            else
            {
                lblHeartbeat.Text = text;
            }
        }

        public void SetBp(int upper, int lower)
        {
            
            string text = $"{upper}/{lower}";
            if (lblTemp.InvokeRequired)
            {

                SetBpCallback d = new SetBpCallback(SetBp);
                Invoke(d, new object[] { upper, lower });
            }
            else
            {
                lblBp.Text = text;
            }
        }
        
        public void SetLastUpdate(string lastUpdate)
        {            
            if (lblTemp.InvokeRequired)
            {
                SetLastUpdateCallback d = new SetLastUpdateCallback(SetLastUpdate);
                Invoke(d, new object[] { lastUpdate });
            }
            else
            {
                lblLastUpdate.Text = $"Last Updated: {lastUpdate}";
            }
        }
    }
}
