namespace DVLDPresentationLayer.DetainLicenses
{
    partial class frmReleaseDetainedLicense
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
            this.ctrReleaseDetainInfo = new DVLDPresentationLayer.DetainLicenses.Controls.ctrReleaseDetainInfo();
            this.ctrLicenseInfo1 = new DVLDPresentationLayer.Applications.Controls.ctrLicenseInfo();
            this.ctrFilterByLicenseID1 = new DVLDPresentationLayer.Applications.Controls.ctrFilterByLicenseID();
            this.ctrHeaderTitleControl1 = new DVLDPresentationLayer.Controls.ctrHeaderTitleControl();
            this.ctrShowLicensesHistory1 = new DVLDPresentationLayer.Applications.Controls.ctrShowLicensesHistory();
            this.ctrShowNewLicenseInfo1 = new DVLDPresentationLayer.Applications.Controls.ctrShowNewLicenseInfo();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.btnRelease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrReleaseDetainInfo
            // 
            this.ctrReleaseDetainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrReleaseDetainInfo.Location = new System.Drawing.Point(8, 614);
            this.ctrReleaseDetainInfo.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ctrReleaseDetainInfo.Name = "ctrReleaseDetainInfo";
            this.ctrReleaseDetainInfo.Size = new System.Drawing.Size(901, 193);
            this.ctrReleaseDetainInfo.TabIndex = 3;
            // 
            // ctrLicenseInfo1
            // 
            this.ctrLicenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrLicenseInfo1.Location = new System.Drawing.Point(8, 184);
            this.ctrLicenseInfo1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ctrLicenseInfo1.Name = "ctrLicenseInfo1";
            this.ctrLicenseInfo1.Size = new System.Drawing.Size(900, 418);
            this.ctrLicenseInfo1.TabIndex = 2;
            // 
            // ctrFilterByLicenseID1
            // 
            this.ctrFilterByLicenseID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrFilterByLicenseID1.Location = new System.Drawing.Point(239, 80);
            this.ctrFilterByLicenseID1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ctrFilterByLicenseID1.Name = "ctrFilterByLicenseID1";
            this.ctrFilterByLicenseID1.Size = new System.Drawing.Size(439, 92);
            this.ctrFilterByLicenseID1.TabIndex = 1;
            // 
            // ctrHeaderTitleControl1
            // 
            this.ctrHeaderTitleControl1.Location = new System.Drawing.Point(213, 13);
            this.ctrHeaderTitleControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrHeaderTitleControl1.Name = "ctrHeaderTitleControl1";
            this.ctrHeaderTitleControl1.Size = new System.Drawing.Size(490, 57);
            this.ctrHeaderTitleControl1.TabIndex = 0;
            this.ctrHeaderTitleControl1.Title = "Release Detained License";
            // 
            // ctrShowLicensesHistory1
            // 
            this.ctrShowLicensesHistory1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrShowLicensesHistory1.Location = new System.Drawing.Point(14, 817);
            this.ctrShowLicensesHistory1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrShowLicensesHistory1.Name = "ctrShowLicensesHistory1";
            this.ctrShowLicensesHistory1.Size = new System.Drawing.Size(174, 24);
            this.ctrShowLicensesHistory1.TabIndex = 3;
            // 
            // ctrShowNewLicenseInfo1
            // 
            this.ctrShowNewLicenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrShowNewLicenseInfo1.Location = new System.Drawing.Point(198, 817);
            this.ctrShowNewLicenseInfo1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrShowNewLicenseInfo1.Name = "ctrShowNewLicenseInfo1";
            this.ctrShowNewLicenseInfo1.Size = new System.Drawing.Size(181, 25);
            this.ctrShowNewLicenseInfo1.TabIndex = 2;
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(733, 813);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(83, 32);
            this.ctrButtonClose1.TabIndex = 1;
            // 
            // btnRelease
            // 
            this.btnRelease.BackColor = System.Drawing.Color.OliveDrab;
            this.btnRelease.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRelease.Location = new System.Drawing.Point(822, 813);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(83, 32);
            this.btnRelease.TabIndex = 6;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = false;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // frmReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 847);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.ctrShowNewLicenseInfo1);
            this.Controls.Add(this.ctrShowLicensesHistory1);
            this.Controls.Add(this.ctrReleaseDetainInfo);
            this.Controls.Add(this.ctrLicenseInfo1);
            this.Controls.Add(this.ctrFilterByLicenseID1);
            this.Controls.Add(this.ctrHeaderTitleControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmReleaseDetainedLicense";
            this.Text = "Release Detained License";
            this.ResumeLayout(false);

        }

        #endregion

        private DVLDPresentationLayer.Controls.ctrHeaderTitleControl ctrHeaderTitleControl1;
        private Applications.Controls.ctrFilterByLicenseID ctrFilterByLicenseID1;
        private Applications.Controls.ctrLicenseInfo ctrLicenseInfo1;
        private Controls.ctrReleaseDetainInfo ctrReleaseDetainInfo;
        private Applications.Controls.ctrShowLicensesHistory ctrShowLicensesHistory1;
        private Applications.Controls.ctrShowNewLicenseInfo ctrShowNewLicenseInfo1;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
        private System.Windows.Forms.Button btnRelease;
    }
}