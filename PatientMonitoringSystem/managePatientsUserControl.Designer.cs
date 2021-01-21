
namespace PatientMonitoringSystem
{
    partial class managePatientsUserControl
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pmsDataSet = new PatientMonitoringSystem.pmsDataSet();
            this.patientL = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientTableAdapter = new PatientMonitoringSystem.pmsDataSetTableAdapters.patientTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentPatient = new System.Windows.Forms.Label();
            this.patientDetailsUserControl1 = new PatientMonitoringSystem.patientDetailsUserControl();
            this.PLpanel.SuspendLayout();
            this.patientsListP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PLpanel
            // 
            this.PLpanel.BackColor = System.Drawing.Color.White;
            this.PLpanel.Controls.Add(this.patientsListP);
            this.PLpanel.Controls.Add(this.patientL);
            this.PLpanel.Location = new System.Drawing.Point(12, 12);
            this.PLpanel.Name = "PLpanel";
            this.PLpanel.Size = new System.Drawing.Size(878, 571);
            this.PLpanel.TabIndex = 1;
            // 
            // patientsListP
            // 
            this.patientsListP.Controls.Add(this.lblCurrentPatient);
            this.patientsListP.Controls.Add(this.label1);
            this.patientsListP.Controls.Add(this.btnSave);
            this.patientsListP.Controls.Add(this.patientDetailsUserControl1);
            this.patientsListP.Controls.Add(this.dataGridView1);
            this.patientsListP.Location = new System.Drawing.Point(22, 58);
            this.patientsListP.Name = "patientsListP";
            this.patientsListP.Size = new System.Drawing.Size(845, 513);
            this.patientsListP.TabIndex = 36;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(113, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 39);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 203);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "Patient Name";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "Patient Name";
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "Date Added";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "Date Added";
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "patient";
            this.patientBindingSource.DataSource = this.pmsDataSet;
            // 
            // pmsDataSet
            // 
            this.pmsDataSet.DataSetName = "pmsDataSet";
            this.pmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientL
            // 
            this.patientL.AutoSize = true;
            this.patientL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientL.ForeColor = System.Drawing.Color.DimGray;
            this.patientL.Location = new System.Drawing.Point(21, 20);
            this.patientL.Name = "patientL";
            this.patientL.Size = new System.Drawing.Size(138, 19);
            this.patientL.TabIndex = 21;
            this.patientL.Text = "Manage Patients";
            this.patientL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Current Patient:";
            // 
            // lblCurrentPatient
            // 
            this.lblCurrentPatient.AutoSize = true;
            this.lblCurrentPatient.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPatient.Location = new System.Drawing.Point(167, 287);
            this.lblCurrentPatient.Name = "lblCurrentPatient";
            this.lblCurrentPatient.Size = new System.Drawing.Size(0, 23);
            this.lblCurrentPatient.TabIndex = 39;
            // 
            // patientDetailsUserControl1
            // 
            this.patientDetailsUserControl1.Location = new System.Drawing.Point(359, -21);
            this.patientDetailsUserControl1.Name = "patientDetailsUserControl1";
            this.patientDetailsUserControl1.Size = new System.Drawing.Size(483, 516);
            this.patientDetailsUserControl1.TabIndex = 3;
            // 
            // managePatientsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PLpanel);
            this.Name = "managePatientsUserControl";
            this.Size = new System.Drawing.Size(893, 595);
            this.Load += new System.EventHandler(this.managePatientsUserControl_Load);
            this.PLpanel.ResumeLayout(false);
            this.PLpanel.PerformLayout();
            this.patientsListP.ResumeLayout(false);
            this.patientsListP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PLpanel;
        private System.Windows.Forms.Panel patientsListP;
        private System.Windows.Forms.Label patientL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private pmsDataSet pmsDataSet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private pmsDataSetTableAdapters.patientTableAdapter patientTableAdapter;
        private patientDetailsUserControl patientDetailsUserControl1;
        private System.Windows.Forms.Label lblCurrentPatient;
        private System.Windows.Forms.Label label1;
    }
}
