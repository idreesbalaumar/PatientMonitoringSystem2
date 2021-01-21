
namespace PatientMonitoringSystem
{
    partial class manageDoctorsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PLpanel = new System.Windows.Forms.Panel();
            this.patientsListP = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specilizationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pmsDataSet = new PatientMonitoringSystem.pmsDataSet();
            this.AddPatientbutton = new System.Windows.Forms.Button();
            this.patientL = new System.Windows.Forms.Label();
            this.doctorTableAdapter = new PatientMonitoringSystem.pmsDataSetTableAdapters.doctorTableAdapter();
            this.PLpanel.SuspendLayout();
            this.patientsListP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PLpanel
            // 
            this.PLpanel.BackColor = System.Drawing.Color.White;
            this.PLpanel.Controls.Add(this.patientsListP);
            this.PLpanel.Controls.Add(this.AddPatientbutton);
            this.PLpanel.Controls.Add(this.patientL);
            this.PLpanel.Location = new System.Drawing.Point(12, 12);
            this.PLpanel.Name = "PLpanel";
            this.PLpanel.Size = new System.Drawing.Size(884, 507);
            this.PLpanel.TabIndex = 2;
            // 
            // patientsListP
            // 
            this.patientsListP.Controls.Add(this.dataGridView1);
            this.patientsListP.Location = new System.Drawing.Point(22, 58);
            this.patientsListP.Name = "patientsListP";
            this.patientsListP.Size = new System.Drawing.Size(849, 434);
            this.patientsListP.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.specilizationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 434);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // specilizationDataGridViewTextBoxColumn
            // 
            this.specilizationDataGridViewTextBoxColumn.DataPropertyName = "Specilization";
            this.specilizationDataGridViewTextBoxColumn.HeaderText = "Specilization";
            this.specilizationDataGridViewTextBoxColumn.Name = "specilizationDataGridViewTextBoxColumn";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "doctor";
            this.doctorBindingSource.DataSource = this.pmsDataSet;
            // 
            // pmsDataSet
            // 
            this.pmsDataSet.DataSetName = "pmsDataSet";
            this.pmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddPatientbutton
            // 
            this.AddPatientbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.AddPatientbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPatientbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatientbutton.ForeColor = System.Drawing.Color.White;
            this.AddPatientbutton.Location = new System.Drawing.Point(771, 13);
            this.AddPatientbutton.Name = "AddPatientbutton";
            this.AddPatientbutton.Size = new System.Drawing.Size(100, 39);
            this.AddPatientbutton.TabIndex = 35;
            this.AddPatientbutton.Text = "Save";
            this.AddPatientbutton.UseVisualStyleBackColor = false;
            this.AddPatientbutton.Click += new System.EventHandler(this.AddPatientbutton_Click);
            // 
            // patientL
            // 
            this.patientL.AutoSize = true;
            this.patientL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientL.ForeColor = System.Drawing.Color.DimGray;
            this.patientL.Location = new System.Drawing.Point(21, 20);
            this.patientL.Name = "patientL";
            this.patientL.Size = new System.Drawing.Size(136, 19);
            this.patientL.TabIndex = 21;
            this.patientL.Text = "Manage Doctors";
            this.patientL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // manageDoctorsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PLpanel);
            this.Name = "manageDoctorsUserControl";
            this.Size = new System.Drawing.Size(908, 530);
            this.Load += new System.EventHandler(this.manageDoctorsUserControl_Load);
            this.PLpanel.ResumeLayout(false);
            this.PLpanel.PerformLayout();
            this.patientsListP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PLpanel;
        private System.Windows.Forms.Panel patientsListP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddPatientbutton;
        private System.Windows.Forms.Label patientL;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specilizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private pmsDataSet pmsDataSet;
        private pmsDataSetTableAdapters.doctorTableAdapter doctorTableAdapter;
    }
}
