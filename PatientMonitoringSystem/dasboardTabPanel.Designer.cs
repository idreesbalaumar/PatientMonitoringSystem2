
namespace PatientMonitoringSystem
{
    partial class dasboardTabPanel
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.todayDateLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.totalDevLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.totalNurseLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalDocsLabel = new System.Windows.Forms.Label();
            this.totalDocs = new System.Windows.Forms.Label();
            this.UserInfoPanel = new System.Windows.Forms.Panel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.patientsStatsPanel = new System.Windows.Forms.Panel();
            this.PatientsStartLabelT = new System.Windows.Forms.Label();
            this.PatientsStartLabel = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.UserInfoPanel.SuspendLayout();
            this.patientsStatsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = global::PatientMonitoringSystem.Properties.Resources.pms_pi_time;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.timeLabel);
            this.panel7.Controls.Add(this.todayDateLabel);
            this.panel7.Controls.Add(this.dateLabel);
            this.panel7.Location = new System.Drawing.Point(559, 337);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(334, 190);
            this.panel7.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(153, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "5 : 05 PM";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(153, 111);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(64, 18);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "TIME IS :";
            // 
            // todayDateLabel
            // 
            this.todayDateLabel.AutoSize = true;
            this.todayDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayDateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDateLabel.ForeColor = System.Drawing.Color.White;
            this.todayDateLabel.Location = new System.Drawing.Point(153, 64);
            this.todayDateLabel.Name = "todayDateLabel";
            this.todayDateLabel.Size = new System.Drawing.Size(154, 21);
            this.todayDateLabel.TabIndex = 4;
            this.todayDateLabel.Text = "18, JANUARY 2021";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(153, 44);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(82, 18);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "TODAY IS :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::PatientMonitoringSystem.Properties.Resources.pms_pi_rec;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(11, 337);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(542, 190);
            this.panel6.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.dateAdded,
            this.addedBy,
            this.action});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 190);
            this.dataGridView1.TabIndex = 3;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // title
            // 
            this.title.HeaderText = "TITLE";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // dateAdded
            // 
            this.dateAdded.HeaderText = "DATE ADDED";
            this.dateAdded.Name = "dateAdded";
            this.dateAdded.ReadOnly = true;
            // 
            // addedBy
            // 
            this.addedBy.HeaderText = "ADDED BY";
            this.addedBy.Name = "addedBy";
            this.addedBy.ReadOnly = true;
            // 
            // action
            // 
            this.action.HeaderText = "ACTION";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(135, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Latest Records";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::PatientMonitoringSystem.Properties.Resources.pms_pi_dev;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.totalDevLabel);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(603, 192);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 124);
            this.panel5.TabIndex = 3;
            // 
            // totalDevLabel
            // 
            this.totalDevLabel.AutoSize = true;
            this.totalDevLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalDevLabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDevLabel.ForeColor = System.Drawing.Color.White;
            this.totalDevLabel.Location = new System.Drawing.Point(136, 54);
            this.totalDevLabel.Name = "totalDevLabel";
            this.totalDevLabel.Size = new System.Drawing.Size(75, 42);
            this.totalDevLabel.TabIndex = 4;
            this.totalDevLabel.Text = "230";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "TOTAL DEVICES";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::PatientMonitoringSystem.Properties.Resources.pms_pi_nurses;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.totalNurseLabel);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(307, 192);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 124);
            this.panel4.TabIndex = 5;
            // 
            // totalNurseLabel
            // 
            this.totalNurseLabel.AutoSize = true;
            this.totalNurseLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalNurseLabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNurseLabel.ForeColor = System.Drawing.Color.DimGray;
            this.totalNurseLabel.Location = new System.Drawing.Point(141, 54);
            this.totalNurseLabel.Name = "totalNurseLabel";
            this.totalNurseLabel.Size = new System.Drawing.Size(75, 42);
            this.totalNurseLabel.TabIndex = 4;
            this.totalNurseLabel.Text = "230";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(126, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "TOTAL NURSES";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::PatientMonitoringSystem.Properties.Resources.pms_pi_doc;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.totalDocsLabel);
            this.panel3.Controls.Add(this.totalDocs);
            this.panel3.Location = new System.Drawing.Point(11, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 124);
            this.panel3.TabIndex = 4;
            // 
            // totalDocsLabel
            // 
            this.totalDocsLabel.AutoSize = true;
            this.totalDocsLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalDocsLabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDocsLabel.ForeColor = System.Drawing.Color.White;
            this.totalDocsLabel.Location = new System.Drawing.Point(146, 54);
            this.totalDocsLabel.Name = "totalDocsLabel";
            this.totalDocsLabel.Size = new System.Drawing.Size(75, 42);
            this.totalDocsLabel.TabIndex = 2;
            this.totalDocsLabel.Text = "230";
            // 
            // totalDocs
            // 
            this.totalDocs.AutoSize = true;
            this.totalDocs.BackColor = System.Drawing.Color.Transparent;
            this.totalDocs.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDocs.ForeColor = System.Drawing.Color.White;
            this.totalDocs.Location = new System.Drawing.Point(122, 38);
            this.totalDocs.Name = "totalDocs";
            this.totalDocs.Size = new System.Drawing.Size(124, 20);
            this.totalDocs.TabIndex = 1;
            this.totalDocs.Text = "TOTAL DOCTORS";
            // 
            // UserInfoPanel
            // 
            this.UserInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.UserInfoPanel.BackgroundImage = global::PatientMonitoringSystem.Properties.Resources.pms_pi_user;
            this.UserInfoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserInfoPanel.Controls.Add(this.UsernameLabel);
            this.UserInfoPanel.Location = new System.Drawing.Point(482, 9);
            this.UserInfoPanel.Name = "UserInfoPanel";
            this.UserInfoPanel.Size = new System.Drawing.Size(411, 167);
            this.UserInfoPanel.TabIndex = 3;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.UsernameLabel.Location = new System.Drawing.Point(64, 121);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(224, 33);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Dr. Musa Hamza";
            // 
            // patientsStatsPanel
            // 
            this.patientsStatsPanel.BackColor = System.Drawing.Color.Transparent;
            this.patientsStatsPanel.BackgroundImage = global::PatientMonitoringSystem.Properties.Resources.pms_pi_patirnts;
            this.patientsStatsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.patientsStatsPanel.Controls.Add(this.PatientsStartLabelT);
            this.patientsStatsPanel.Controls.Add(this.PatientsStartLabel);
            this.patientsStatsPanel.Location = new System.Drawing.Point(7, 9);
            this.patientsStatsPanel.Name = "patientsStatsPanel";
            this.patientsStatsPanel.Size = new System.Drawing.Size(454, 167);
            this.patientsStatsPanel.TabIndex = 0;
            // 
            // PatientsStartLabelT
            // 
            this.PatientsStartLabelT.AutoSize = true;
            this.PatientsStartLabelT.BackColor = System.Drawing.Color.Transparent;
            this.PatientsStartLabelT.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsStartLabelT.ForeColor = System.Drawing.Color.White;
            this.PatientsStartLabelT.Location = new System.Drawing.Point(59, 79);
            this.PatientsStartLabelT.Name = "PatientsStartLabelT";
            this.PatientsStartLabelT.Size = new System.Drawing.Size(75, 42);
            this.PatientsStartLabelT.TabIndex = 2;
            this.PatientsStartLabelT.Text = "230";
            // 
            // PatientsStartLabel
            // 
            this.PatientsStartLabel.AutoSize = true;
            this.PatientsStartLabel.BackColor = System.Drawing.Color.Transparent;
            this.PatientsStartLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsStartLabel.ForeColor = System.Drawing.Color.White;
            this.PatientsStartLabel.Location = new System.Drawing.Point(33, 43);
            this.PatientsStartLabel.Name = "PatientsStartLabel";
            this.PatientsStartLabel.Size = new System.Drawing.Size(135, 36);
            this.PatientsStartLabel.TabIndex = 1;
            this.PatientsStartLabel.Text = "PATIENTS";
            // 
            // dasboardTabPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.UserInfoPanel);
            this.Controls.Add(this.patientsStatsPanel);
            this.Name = "dasboardTabPanel";
            this.Size = new System.Drawing.Size(908, 530);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.UserInfoPanel.ResumeLayout(false);
            this.UserInfoPanel.PerformLayout();
            this.patientsStatsPanel.ResumeLayout(false);
            this.patientsStatsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel patientsStatsPanel;
        private System.Windows.Forms.Label PatientsStartLabelT;
        private System.Windows.Forms.Label PatientsStartLabel;
        private System.Windows.Forms.Panel UserInfoPanel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label totalDocsLabel;
        private System.Windows.Forms.Label totalDocs;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label totalNurseLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalDevLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedBy;
        private System.Windows.Forms.DataGridViewLinkColumn action;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label todayDateLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timeLabel;
    }
}
