namespace DVLDPresentationLayer.Applications
{
    partial class frmListInternationalLicensesApplication
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
            this.dGVInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.ctrHeaderTitleControl1 = new DVLDPresentationLayer.Controls.ctrHeaderTitleControl();
            this.IntLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ctrFilterByListInternationalLicenses1 = new DVLDPresentationLayer.Applications.Controls.ctrFilterByListInternationalLicenses();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.btnAddInternationalLicense = new System.Windows.Forms.Button();
            this.labRecords = new System.Windows.Forms.Label();
            this.labValueCountRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInternationalLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVInternationalLicenses
            // 
            this.dGVInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVInternationalLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IntLicenseID,
            this.ApplicationID,
            this.DriverID,
            this.LoLicenseID,
            this.IssueDate,
            this.ExpirationDate,
            this.IsActive});
            this.dGVInternationalLicenses.Location = new System.Drawing.Point(13, 130);
            this.dGVInternationalLicenses.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dGVInternationalLicenses.Name = "dGVInternationalLicenses";
            this.dGVInternationalLicenses.Size = new System.Drawing.Size(934, 208);
            this.dGVInternationalLicenses.TabIndex = 0;
            // 
            // ctrHeaderTitleControl1
            // 
            this.ctrHeaderTitleControl1.Location = new System.Drawing.Point(168, 13);
            this.ctrHeaderTitleControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrHeaderTitleControl1.Name = "ctrHeaderTitleControl1";
            this.ctrHeaderTitleControl1.Size = new System.Drawing.Size(622, 58);
            this.ctrHeaderTitleControl1.TabIndex = 1;
            this.ctrHeaderTitleControl1.Title = "International Licenses Application";
            // 
            // IntLicenseID
            // 
            this.IntLicenseID.HeaderText = "Int.License ID";
            this.IntLicenseID.Name = "IntLicenseID";
            this.IntLicenseID.Width = 140;
            // 
            // ApplicationID
            // 
            this.ApplicationID.HeaderText = "Application ID";
            this.ApplicationID.Name = "ApplicationID";
            this.ApplicationID.Width = 140;
            // 
            // DriverID
            // 
            this.DriverID.HeaderText = "Driver ID";
            this.DriverID.Name = "DriverID";
            // 
            // LoLicenseID
            // 
            this.LoLicenseID.HeaderText = "Lo.License ID";
            this.LoLicenseID.Name = "LoLicenseID";
            this.LoLicenseID.Width = 140;
            // 
            // IssueDate
            // 
            this.IssueDate.HeaderText = "Issue Date";
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Width = 120;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.HeaderText = "Expiration Date";
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.Width = 150;
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Is Active";
            this.IsActive.Name = "IsActive";
            // 
            // ctrFilterByListInternationalLicenses1
            // 
            this.ctrFilterByListInternationalLicenses1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrFilterByListInternationalLicenses1.Location = new System.Drawing.Point(13, 79);
            this.ctrFilterByListInternationalLicenses1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrFilterByListInternationalLicenses1.Name = "ctrFilterByListInternationalLicenses1";
            this.ctrFilterByListInternationalLicenses1.Size = new System.Drawing.Size(507, 43);
            this.ctrFilterByListInternationalLicenses1.TabIndex = 2;
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(864, 345);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(83, 32);
            this.ctrButtonClose1.TabIndex = 3;
            // 
            // btnAddInternationalLicense
            // 
            this.btnAddInternationalLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddInternationalLicense.Location = new System.Drawing.Point(740, 91);
            this.btnAddInternationalLicense.Name = "btnAddInternationalLicense";
            this.btnAddInternationalLicense.Size = new System.Drawing.Size(207, 32);
            this.btnAddInternationalLicense.TabIndex = 4;
            this.btnAddInternationalLicense.Text = "Add International License";
            this.btnAddInternationalLicense.UseVisualStyleBackColor = true;
            this.btnAddInternationalLicense.Click += new System.EventHandler(this.btnAddInternationalLicense_Click);
            // 
            // labRecords
            // 
            this.labRecords.AutoSize = true;
            this.labRecords.Location = new System.Drawing.Point(12, 345);
            this.labRecords.Name = "labRecords";
            this.labRecords.Size = new System.Drawing.Size(91, 18);
            this.labRecords.TabIndex = 5;
            this.labRecords.Text = "# Records:";
            // 
            // labValueCountRecords
            // 
            this.labValueCountRecords.AutoSize = true;
            this.labValueCountRecords.Location = new System.Drawing.Point(109, 345);
            this.labValueCountRecords.Name = "labValueCountRecords";
            this.labValueCountRecords.Size = new System.Drawing.Size(35, 18);
            this.labValueCountRecords.TabIndex = 6;
            this.labValueCountRecords.Text = "???";
            // 
            // frmListInternationalLicensesApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(961, 382);
            this.Controls.Add(this.labValueCountRecords);
            this.Controls.Add(this.labRecords);
            this.Controls.Add(this.btnAddInternationalLicense);
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.ctrFilterByListInternationalLicenses1);
            this.Controls.Add(this.ctrHeaderTitleControl1);
            this.Controls.Add(this.dGVInternationalLicenses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmListInternationalLicensesApplication";
            this.Text = "List International Licenses Application";
            ((System.ComponentModel.ISupportInitialize)(this.dGVInternationalLicenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVInternationalLicenses;
        private DVLDPresentationLayer.Controls.ctrHeaderTitleControl ctrHeaderTitleControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private Controls.ctrFilterByListInternationalLicenses ctrFilterByListInternationalLicenses1;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
        private System.Windows.Forms.Button btnAddInternationalLicense;
        private System.Windows.Forms.Label labRecords;
        private System.Windows.Forms.Label labValueCountRecords;
    }
}