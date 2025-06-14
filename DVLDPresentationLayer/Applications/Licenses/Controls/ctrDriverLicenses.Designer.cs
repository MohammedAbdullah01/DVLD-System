namespace DVLDPresentationLayer.Applications.Controls
{
    partial class ctrDriverLicenses
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
            this.grbDriverLicenses = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dGVLocalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.tabControlDriverLicenses = new System.Windows.Forms.TabControl();
            this.tabPageLocal = new System.Windows.Forms.TabPage();
            this.tabPageInternational = new System.Windows.Forms.TabPage();
            this.LicID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labRecords = new System.Windows.Forms.Label();
            this.labValueCountRecords = new System.Windows.Forms.Label();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.labLocalHistory = new System.Windows.Forms.Label();
            this.dGVInternationalHistory = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labInternationalHistory = new System.Windows.Forms.Label();
            this.grbDriverLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLocalLicensesHistory)).BeginInit();
            this.tabControlDriverLicenses.SuspendLayout();
            this.tabPageLocal.SuspendLayout();
            this.tabPageInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInternationalHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDriverLicenses
            // 
            this.grbDriverLicenses.Controls.Add(this.tabControlDriverLicenses);
            this.grbDriverLicenses.Location = new System.Drawing.Point(5, 4);
            this.grbDriverLicenses.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbDriverLicenses.Name = "grbDriverLicenses";
            this.grbDriverLicenses.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbDriverLicenses.Size = new System.Drawing.Size(1006, 344);
            this.grbDriverLicenses.TabIndex = 0;
            this.grbDriverLicenses.TabStop = false;
            this.grbDriverLicenses.Text = "Driver Licenses";
            // 
            // dGVLocalLicensesHistory
            // 
            this.dGVLocalLicensesHistory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGVLocalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLocalLicensesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LicID,
            this.AppID,
            this.ClassName,
            this.IssueDate,
            this.ExpirationDate,
            this.IsActive});
            this.dGVLocalLicensesHistory.Location = new System.Drawing.Point(18, 40);
            this.dGVLocalLicensesHistory.Name = "dGVLocalLicensesHistory";
            this.dGVLocalLicensesHistory.Size = new System.Drawing.Size(944, 197);
            this.dGVLocalLicensesHistory.TabIndex = 0;
            // 
            // tabControlDriverLicenses
            // 
            this.tabControlDriverLicenses.Controls.Add(this.tabPageLocal);
            this.tabControlDriverLicenses.Controls.Add(this.tabPageInternational);
            this.tabControlDriverLicenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlDriverLicenses.Location = new System.Drawing.Point(9, 26);
            this.tabControlDriverLicenses.Name = "tabControlDriverLicenses";
            this.tabControlDriverLicenses.SelectedIndex = 0;
            this.tabControlDriverLicenses.Size = new System.Drawing.Size(989, 308);
            this.tabControlDriverLicenses.TabIndex = 1;
            // 
            // tabPageLocal
            // 
            this.tabPageLocal.Controls.Add(this.labLocalHistory);
            this.tabPageLocal.Controls.Add(this.btnNext);
            this.tabPageLocal.Controls.Add(this.labValueCountRecords);
            this.tabPageLocal.Controls.Add(this.labRecords);
            this.tabPageLocal.Controls.Add(this.dGVLocalLicensesHistory);
            this.tabPageLocal.Location = new System.Drawing.Point(4, 27);
            this.tabPageLocal.Name = "tabPageLocal";
            this.tabPageLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocal.Size = new System.Drawing.Size(981, 277);
            this.tabPageLocal.TabIndex = 0;
            this.tabPageLocal.Text = "Local";
            this.tabPageLocal.UseVisualStyleBackColor = true;
            // 
            // tabPageInternational
            // 
            this.tabPageInternational.Controls.Add(this.labInternationalHistory);
            this.tabPageInternational.Controls.Add(this.dGVInternationalHistory);
            this.tabPageInternational.Controls.Add(this.btnBack);
            this.tabPageInternational.Location = new System.Drawing.Point(4, 27);
            this.tabPageInternational.Name = "tabPageInternational";
            this.tabPageInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInternational.Size = new System.Drawing.Size(981, 277);
            this.tabPageInternational.TabIndex = 1;
            this.tabPageInternational.Text = "International";
            this.tabPageInternational.UseVisualStyleBackColor = true;
            // 
            // LicID
            // 
            this.LicID.HeaderText = "Lic.ID";
            this.LicID.Name = "LicID";
            // 
            // AppID
            // 
            this.AppID.HeaderText = "App.ID";
            this.AppID.Name = "AppID";
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClassName.HeaderText = "Class Name";
            this.ClassName.Name = "ClassName";
            this.ClassName.Width = 300;
            // 
            // IssueDate
            // 
            this.IssueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IssueDate.HeaderText = "Issue Date";
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Width = 150;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ExpirationDate.HeaderText = "Expiration Date";
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.Width = 150;
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Is Active";
            this.IsActive.Name = "IsActive";
            this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // labRecords
            // 
            this.labRecords.AutoSize = true;
            this.labRecords.Location = new System.Drawing.Point(15, 238);
            this.labRecords.Name = "labRecords";
            this.labRecords.Size = new System.Drawing.Size(91, 18);
            this.labRecords.TabIndex = 1;
            this.labRecords.Text = "# Records:";
            // 
            // labValueCountRecords
            // 
            this.labValueCountRecords.AutoSize = true;
            this.labValueCountRecords.Location = new System.Drawing.Point(112, 239);
            this.labValueCountRecords.Name = "labValueCountRecords";
            this.labValueCountRecords.Size = new System.Drawing.Size(35, 18);
            this.labValueCountRecords.TabIndex = 2;
            this.labValueCountRecords.Text = "???";
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(927, 355);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(84, 32);
            this.ctrButtonClose1.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Navy;
            this.btnNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(896, 240);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(67, 32);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Navy;
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(895, 239);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 32);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labLocalHistory
            // 
            this.labLocalHistory.AutoSize = true;
            this.labLocalHistory.Location = new System.Drawing.Point(15, 12);
            this.labLocalHistory.Name = "labLocalHistory";
            this.labLocalHistory.Size = new System.Drawing.Size(185, 18);
            this.labLocalHistory.TabIndex = 4;
            this.labLocalHistory.Text = "Local Licenses History:";
            // 
            // dGVInternationalHistory
            // 
            this.dGVInternationalHistory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGVInternationalHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVInternationalHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVInternationalHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.dGVInternationalHistory.Location = new System.Drawing.Point(18, 40);
            this.dGVInternationalHistory.Name = "dGVInternationalHistory";
            this.dGVInternationalHistory.Size = new System.Drawing.Size(944, 197);
            this.dGVInternationalHistory.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Lic.ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "App.ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.HeaderText = "Class Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.HeaderText = "Issue Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.HeaderText = "Expiration Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Is Active";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // labInternationalHistory
            // 
            this.labInternationalHistory.AutoSize = true;
            this.labInternationalHistory.Location = new System.Drawing.Point(23, 12);
            this.labInternationalHistory.Name = "labInternationalHistory";
            this.labInternationalHistory.Size = new System.Drawing.Size(236, 18);
            this.labInternationalHistory.TabIndex = 5;
            this.labInternationalHistory.Text = "International Licenses History:";
            // 
            // ctrDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.grbDriverLicenses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ctrDriverLicenses";
            this.Size = new System.Drawing.Size(1023, 393);
            this.grbDriverLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLocalLicensesHistory)).EndInit();
            this.tabControlDriverLicenses.ResumeLayout(false);
            this.tabPageLocal.ResumeLayout(false);
            this.tabPageLocal.PerformLayout();
            this.tabPageInternational.ResumeLayout(false);
            this.tabPageInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInternationalHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDriverLicenses;
        private System.Windows.Forms.DataGridView dGVLocalLicensesHistory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControlDriverLicenses;
        private System.Windows.Forms.TabPage tabPageLocal;
        private System.Windows.Forms.TabPage tabPageInternational;
        private System.Windows.Forms.Label labRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.Label labValueCountRecords;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labLocalHistory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dGVInternationalHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label labInternationalHistory;
    }
}
