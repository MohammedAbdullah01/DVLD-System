namespace DVLDPresentationLayer.DetainLicenses
{
    partial class frmListDetainedLicenses
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
            this.dGVListDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.DetainID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FineFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetainDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRelease = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnLicenseDetaine = new System.Windows.Forms.Button();
            this.btnReleaseDetaine = new System.Windows.Forms.Button();
            this.labRecords = new System.Windows.Forms.Label();
            this.labValueCountRecords = new System.Windows.Forms.Label();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.ctrListDetainedLicensesFilterBy1 = new DVLDPresentationLayer.DetainLicenses.Controls.ctrListDetainedLicensesFilterBy();
            this.ctrHeaderTitleControl1 = new DVLDPresentationLayer.Controls.ctrHeaderTitleControl();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListDetainedLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVListDetainedLicenses
            // 
            this.dGVListDetainedLicenses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGVListDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListDetainedLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetainID,
            this.LicenseID,
            this.NationalNo,
            this.ReleaseApplicationID,
            this.FineFees,
            this.DetainDate,
            this.ReleaseDate,
            this.FullName,
            this.IsRelease});
            this.dGVListDetainedLicenses.Location = new System.Drawing.Point(10, 145);
            this.dGVListDetainedLicenses.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dGVListDetainedLicenses.Name = "dGVListDetainedLicenses";
            this.dGVListDetainedLicenses.Size = new System.Drawing.Size(1082, 242);
            this.dGVListDetainedLicenses.TabIndex = 1;
            // 
            // DetainID
            // 
            this.DetainID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DetainID.HeaderText = "D.ID";
            this.DetainID.Name = "DetainID";
            this.DetainID.Width = 66;
            // 
            // LicenseID
            // 
            this.LicenseID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LicenseID.HeaderText = "L.ID";
            this.LicenseID.Name = "LicenseID";
            this.LicenseID.Width = 63;
            // 
            // NationalNo
            // 
            this.NationalNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NationalNo.HeaderText = "N.No";
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.Width = 72;
            // 
            // ReleaseApplicationID
            // 
            this.ReleaseApplicationID.HeaderText = "Release Apo.ID";
            this.ReleaseApplicationID.Name = "ReleaseApplicationID";
            this.ReleaseApplicationID.Width = 120;
            // 
            // FineFees
            // 
            this.FineFees.HeaderText = "Fine Fees";
            this.FineFees.Name = "FineFees";
            // 
            // DetainDate
            // 
            this.DetainDate.HeaderText = "D.Date";
            this.DetainDate.Name = "DetainDate";
            this.DetainDate.Width = 120;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Width = 120;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            // 
            // IsRelease
            // 
            this.IsRelease.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IsRelease.HeaderText = "Is Release";
            this.IsRelease.Name = "IsRelease";
            this.IsRelease.Width = 84;
            // 
            // btnLicenseDetaine
            // 
            this.btnLicenseDetaine.Location = new System.Drawing.Point(956, 106);
            this.btnLicenseDetaine.Name = "btnLicenseDetaine";
            this.btnLicenseDetaine.Size = new System.Drawing.Size(136, 32);
            this.btnLicenseDetaine.TabIndex = 3;
            this.btnLicenseDetaine.Text = "License Detaine";
            this.btnLicenseDetaine.UseVisualStyleBackColor = true;
            this.btnLicenseDetaine.Click += new System.EventHandler(this.btnLicenseDetaine_Click);
            // 
            // btnReleaseDetaine
            // 
            this.btnReleaseDetaine.Location = new System.Drawing.Point(810, 106);
            this.btnReleaseDetaine.Name = "btnReleaseDetaine";
            this.btnReleaseDetaine.Size = new System.Drawing.Size(140, 32);
            this.btnReleaseDetaine.TabIndex = 5;
            this.btnReleaseDetaine.Text = "Release Detaine";
            this.btnReleaseDetaine.UseVisualStyleBackColor = true;
            this.btnReleaseDetaine.Click += new System.EventHandler(this.btnReleaseDetaine_Click);
            // 
            // labRecords
            // 
            this.labRecords.AutoSize = true;
            this.labRecords.Location = new System.Drawing.Point(12, 400);
            this.labRecords.Name = "labRecords";
            this.labRecords.Size = new System.Drawing.Size(91, 18);
            this.labRecords.TabIndex = 6;
            this.labRecords.Text = "# Records:";
            // 
            // labValueCountRecords
            // 
            this.labValueCountRecords.AutoSize = true;
            this.labValueCountRecords.Location = new System.Drawing.Point(109, 401);
            this.labValueCountRecords.Name = "labValueCountRecords";
            this.labValueCountRecords.Size = new System.Drawing.Size(35, 18);
            this.labValueCountRecords.TabIndex = 7;
            this.labValueCountRecords.Text = "???";
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(1009, 394);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(83, 32);
            this.ctrButtonClose1.TabIndex = 4;
            // 
            // ctrListDetainedLicensesFilterBy1
            // 
            this.ctrListDetainedLicensesFilterBy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrListDetainedLicensesFilterBy1.Location = new System.Drawing.Point(14, 100);
            this.ctrListDetainedLicensesFilterBy1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrListDetainedLicensesFilterBy1.Name = "ctrListDetainedLicensesFilterBy1";
            this.ctrListDetainedLicensesFilterBy1.Size = new System.Drawing.Size(518, 37);
            this.ctrListDetainedLicensesFilterBy1.TabIndex = 2;
            // 
            // ctrHeaderTitleControl1
            // 
            this.ctrHeaderTitleControl1.Location = new System.Drawing.Point(337, 17);
            this.ctrHeaderTitleControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrHeaderTitleControl1.Name = "ctrHeaderTitleControl1";
            this.ctrHeaderTitleControl1.Size = new System.Drawing.Size(428, 57);
            this.ctrHeaderTitleControl1.TabIndex = 0;
            this.ctrHeaderTitleControl1.Title = "List Detained Licenses";
            // 
            // frmListDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 429);
            this.Controls.Add(this.labValueCountRecords);
            this.Controls.Add(this.labRecords);
            this.Controls.Add(this.btnReleaseDetaine);
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.btnLicenseDetaine);
            this.Controls.Add(this.ctrListDetainedLicensesFilterBy1);
            this.Controls.Add(this.dGVListDetainedLicenses);
            this.Controls.Add(this.ctrHeaderTitleControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmListDetainedLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Detained Licenses";
            ((System.ComponentModel.ISupportInitialize)(this.dGVListDetainedLicenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DVLDPresentationLayer.Controls.ctrHeaderTitleControl ctrHeaderTitleControl1;
        private System.Windows.Forms.DataGridView dGVListDetainedLicenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetainID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FineFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetainDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsRelease;
        private Controls.ctrListDetainedLicensesFilterBy ctrListDetainedLicensesFilterBy1;
        private System.Windows.Forms.Button btnLicenseDetaine;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
        private System.Windows.Forms.Button btnReleaseDetaine;
        private System.Windows.Forms.Label labRecords;
        private System.Windows.Forms.Label labValueCountRecords;
    }
}