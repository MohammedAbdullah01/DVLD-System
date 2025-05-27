namespace DVLDPresentationLayer.Applications
{
    partial class frmLocalDrivingLicense
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.LocalDrivingLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrivingClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassedTests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labRecords = new System.Windows.Forms.Label();
            this.labValueCountRecords = new System.Windows.Forms.Label();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.ctrLocalDrivingLicenseFilterBy1 = new DVLDPresentationLayer.Applications.Controls.ctrLocalDrivingLicenseFilterBy();
            this.ctrHeaderTitleControl1 = new DVLDPresentationLayer.Controls.ctrHeaderTitleControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocalDrivingLicenseID,
            this.DrivingClass,
            this.NationalNo,
            this.FullName,
            this.ApplicationDate,
            this.PassedTests,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1262, 420);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddApplication.Location = new System.Drawing.Point(1141, 92);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(133, 28);
            this.btnAddApplication.TabIndex = 3;
            this.btnAddApplication.Text = "Add Application";
            this.btnAddApplication.UseVisualStyleBackColor = true;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // LocalDrivingLicenseID
            // 
            this.LocalDrivingLicenseID.HeaderText = "L.D.L.AppID";
            this.LocalDrivingLicenseID.Name = "LocalDrivingLicenseID";
            // 
            // DrivingClass
            // 
            this.DrivingClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DrivingClass.HeaderText = "Driving Class";
            this.DrivingClass.Name = "DrivingClass";
            // 
            // NationalNo
            // 
            this.NationalNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NationalNo.HeaderText = "National No";
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.Width = 112;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            // 
            // ApplicationDate
            // 
            this.ApplicationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ApplicationDate.HeaderText = "Application Date";
            this.ApplicationDate.Name = "ApplicationDate";
            // 
            // PassedTests
            // 
            this.PassedTests.HeaderText = "Passed Tests";
            this.PassedTests.Name = "PassedTests";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // labRecords
            // 
            this.labRecords.AutoSize = true;
            this.labRecords.Location = new System.Drawing.Point(12, 562);
            this.labRecords.Name = "labRecords";
            this.labRecords.Size = new System.Drawing.Size(91, 18);
            this.labRecords.TabIndex = 5;
            this.labRecords.Text = "# Records:";
            // 
            // labValueCountRecords
            // 
            this.labValueCountRecords.AutoSize = true;
            this.labValueCountRecords.Location = new System.Drawing.Point(109, 564);
            this.labValueCountRecords.Name = "labValueCountRecords";
            this.labValueCountRecords.Size = new System.Drawing.Size(35, 18);
            this.labValueCountRecords.TabIndex = 6;
            this.labValueCountRecords.Text = "???";
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(1196, 552);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(78, 30);
            this.ctrButtonClose1.TabIndex = 4;
            // 
            // ctrLocalDrivingLicenseFilterBy1
            // 
            this.ctrLocalDrivingLicenseFilterBy1.Location = new System.Drawing.Point(12, 79);
            this.ctrLocalDrivingLicenseFilterBy1.Name = "ctrLocalDrivingLicenseFilterBy1";
            this.ctrLocalDrivingLicenseFilterBy1.Size = new System.Drawing.Size(525, 41);
            this.ctrLocalDrivingLicenseFilterBy1.TabIndex = 2;
            // 
            // ctrHeaderTitleControl1
            // 
            this.ctrHeaderTitleControl1.Location = new System.Drawing.Point(326, 13);
            this.ctrHeaderTitleControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrHeaderTitleControl1.Name = "ctrHeaderTitleControl1";
            this.ctrHeaderTitleControl1.Size = new System.Drawing.Size(635, 62);
            this.ctrHeaderTitleControl1.TabIndex = 0;
            this.ctrHeaderTitleControl1.Title = "Local Driving License Applications";
            // 
            // frmLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 589);
            this.Controls.Add(this.labValueCountRecords);
            this.Controls.Add(this.labRecords);
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.btnAddApplication);
            this.Controls.Add(this.ctrLocalDrivingLicenseFilterBy1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ctrHeaderTitleControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmLocalDrivingLicense";
            this.Text = "Local Driving License Applications";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DVLDPresentationLayer.Controls.ctrHeaderTitleControl ctrHeaderTitleControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Controls.ctrLocalDrivingLicenseFilterBy ctrLocalDrivingLicenseFilterBy1;
        private System.Windows.Forms.Button btnAddApplication;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalDrivingLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrivingClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassedTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label labRecords;
        private System.Windows.Forms.Label labValueCountRecords;
    }
}