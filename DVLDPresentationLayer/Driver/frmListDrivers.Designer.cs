namespace DVLDPresentationLayer.Driver
{
    partial class frmListDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListDrivers));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labRecords = new System.Windows.Forms.Label();
            this.labValueCountRecords = new System.Windows.Forms.Label();
            this.DriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveLicenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.ctrListDriverFilterBy1 = new DVLDPresentationLayer.Driver.Control.ctrListDriverFilterBy();
            this.ctrHeaderTitleControl1 = new DVLDPresentationLayer.Controls.ctrHeaderTitleControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriverID,
            this.PersonID,
            this.NationalNo,
            this.FullName,
            this.Date,
            this.ActiveLicenses});
            this.dataGridView1.Location = new System.Drawing.Point(10, 127);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(934, 208);
            this.dataGridView1.TabIndex = 2;
            // 
            // labRecords
            // 
            this.labRecords.AutoSize = true;
            this.labRecords.Location = new System.Drawing.Point(7, 347);
            this.labRecords.Name = "labRecords";
            this.labRecords.Size = new System.Drawing.Size(91, 18);
            this.labRecords.TabIndex = 4;
            this.labRecords.Text = "# Records:";
            // 
            // labValueCountRecords
            // 
            this.labValueCountRecords.AutoSize = true;
            this.labValueCountRecords.Location = new System.Drawing.Point(104, 347);
            this.labValueCountRecords.Name = "labValueCountRecords";
            this.labValueCountRecords.Size = new System.Drawing.Size(35, 18);
            this.labValueCountRecords.TabIndex = 5;
            this.labValueCountRecords.Text = "???";
            // 
            // DriverID
            // 
            this.DriverID.HeaderText = "Driver ID";
            this.DriverID.Name = "DriverID";
            // 
            // PersonID
            // 
            this.PersonID.HeaderText = "Person ID";
            this.PersonID.Name = "PersonID";
            this.PersonID.Width = 110;
            // 
            // NationalNo
            // 
            this.NationalNo.HeaderText = "National No";
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.Width = 120;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 140;
            // 
            // ActiveLicenses
            // 
            this.ActiveLicenses.HeaderText = "Active Licenses";
            this.ActiveLicenses.Name = "ActiveLicenses";
            this.ActiveLicenses.Width = 150;
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(861, 342);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(83, 32);
            this.ctrButtonClose1.TabIndex = 6;
            // 
            // ctrListDriverFilterBy1
            // 
            this.ctrListDriverFilterBy1.Location = new System.Drawing.Point(10, 84);
            this.ctrListDriverFilterBy1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrListDriverFilterBy1.Name = "ctrListDriverFilterBy1";
            this.ctrListDriverFilterBy1.Size = new System.Drawing.Size(658, 35);
            this.ctrListDriverFilterBy1.TabIndex = 3;
            // 
            // ctrHeaderTitleControl1
            // 
            this.ctrHeaderTitleControl1.Location = new System.Drawing.Point(331, 17);
            this.ctrHeaderTitleControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrHeaderTitleControl1.Name = "ctrHeaderTitleControl1";
            this.ctrHeaderTitleControl1.Size = new System.Drawing.Size(304, 55);
            this.ctrHeaderTitleControl1.TabIndex = 0;
            this.ctrHeaderTitleControl1.Title = "Manage Drivers";
            // 
            // frmListDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(955, 380);
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.labValueCountRecords);
            this.Controls.Add(this.labRecords);
            this.Controls.Add(this.ctrListDriverFilterBy1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ctrHeaderTitleControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmListDrivers";
            this.Text = "List Drivers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrHeaderTitleControl ctrHeaderTitleControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Control.ctrListDriverFilterBy ctrListDriverFilterBy1;
        private System.Windows.Forms.Label labRecords;
        private System.Windows.Forms.Label labValueCountRecords;
        private Controls.ctrButtonClose ctrButtonClose1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveLicenses;
    }
}