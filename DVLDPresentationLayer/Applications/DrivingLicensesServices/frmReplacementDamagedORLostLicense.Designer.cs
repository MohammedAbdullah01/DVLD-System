namespace DVLDPresentationLayer.Applications
{
    partial class frmReplacementDamagedORLostLicense
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
            this.grbReplacementFor = new System.Windows.Forms.GroupBox();
            this.radBtnDamaged = new System.Windows.Forms.RadioButton();
            this.radBtnLost = new System.Windows.Forms.RadioButton();
            this.btnIssueReplacement = new System.Windows.Forms.Button();
            this.ctrShowNewLicenseInfo1 = new DVLDPresentationLayer.Applications.Controls.ctrShowNewLicenseInfo();
            this.ctrShowLicensesHistory1 = new DVLDPresentationLayer.Applications.Controls.ctrShowLicensesHistory();
            this.ctrApplicationInfoLicenseReplacement1 = new DVLDPresentationLayer.Applications.Controls.ctrApplicationInfoLicenseReplacement();
            this.ctrLicenseInfo1 = new DVLDPresentationLayer.Applications.Controls.ctrLicenseInfo();
            this.ctrFilterByLicenseID1 = new DVLDPresentationLayer.Applications.Controls.ctrFilterByLicenseID();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.ctrHeaderTitleControl1 = new DVLDPresentationLayer.Controls.ctrHeaderTitleControl();
            this.grbReplacementFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbReplacementFor
            // 
            this.grbReplacementFor.Controls.Add(this.radBtnLost);
            this.grbReplacementFor.Controls.Add(this.radBtnDamaged);
            this.grbReplacementFor.Location = new System.Drawing.Point(556, 96);
            this.grbReplacementFor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbReplacementFor.Name = "grbReplacementFor";
            this.grbReplacementFor.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbReplacementFor.Size = new System.Drawing.Size(249, 88);
            this.grbReplacementFor.TabIndex = 3;
            this.grbReplacementFor.TabStop = false;
            this.grbReplacementFor.Text = "Replacement For";
            // 
            // radBtnDamaged
            // 
            this.radBtnDamaged.AutoSize = true;
            this.radBtnDamaged.Location = new System.Drawing.Point(8, 27);
            this.radBtnDamaged.Name = "radBtnDamaged";
            this.radBtnDamaged.Size = new System.Drawing.Size(160, 22);
            this.radBtnDamaged.TabIndex = 0;
            this.radBtnDamaged.TabStop = true;
            this.radBtnDamaged.Text = "Damaged License";
            this.radBtnDamaged.UseVisualStyleBackColor = true;
            this.radBtnDamaged.CheckedChanged += new System.EventHandler(this.radBtnDamaged_CheckedChanged);
            // 
            // radBtnLost
            // 
            this.radBtnLost.AutoSize = true;
            this.radBtnLost.Location = new System.Drawing.Point(8, 55);
            this.radBtnLost.Name = "radBtnLost";
            this.radBtnLost.Size = new System.Drawing.Size(122, 22);
            this.radBtnLost.TabIndex = 1;
            this.radBtnLost.TabStop = true;
            this.radBtnLost.Text = "Lost License";
            this.radBtnLost.UseVisualStyleBackColor = true;
            this.radBtnLost.CheckedChanged += new System.EventHandler(this.radBtnLost_CheckedChanged);
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.BackColor = System.Drawing.Color.OliveDrab;
            this.btnIssueReplacement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssueReplacement.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIssueReplacement.Location = new System.Drawing.Point(733, 773);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(172, 32);
            this.btnIssueReplacement.TabIndex = 6;
            this.btnIssueReplacement.Text = "Issue Replacement";
            this.btnIssueReplacement.UseVisualStyleBackColor = false;
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
            // 
            // ctrShowNewLicenseInfo1
            // 
            this.ctrShowNewLicenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrShowNewLicenseInfo1.Location = new System.Drawing.Point(198, 772);
            this.ctrShowNewLicenseInfo1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrShowNewLicenseInfo1.Name = "ctrShowNewLicenseInfo1";
            this.ctrShowNewLicenseInfo1.Size = new System.Drawing.Size(181, 25);
            this.ctrShowNewLicenseInfo1.TabIndex = 8;
            // 
            // ctrShowLicensesHistory1
            // 
            this.ctrShowLicensesHistory1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrShowLicensesHistory1.Location = new System.Drawing.Point(14, 773);
            this.ctrShowLicensesHistory1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrShowLicensesHistory1.Name = "ctrShowLicensesHistory1";
            this.ctrShowLicensesHistory1.Size = new System.Drawing.Size(174, 24);
            this.ctrShowLicensesHistory1.TabIndex = 7;
            // 
            // ctrApplicationInfoLicenseReplacement1
            // 
            this.ctrApplicationInfoLicenseReplacement1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrApplicationInfoLicenseReplacement1.Location = new System.Drawing.Point(14, 620);
            this.ctrApplicationInfoLicenseReplacement1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrApplicationInfoLicenseReplacement1.Name = "ctrApplicationInfoLicenseReplacement1";
            this.ctrApplicationInfoLicenseReplacement1.Size = new System.Drawing.Size(894, 146);
            this.ctrApplicationInfoLicenseReplacement1.TabIndex = 5;
            // 
            // ctrLicenseInfo1
            // 
            this.ctrLicenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrLicenseInfo1.Location = new System.Drawing.Point(9, 196);
            this.ctrLicenseInfo1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrLicenseInfo1.Name = "ctrLicenseInfo1";
            this.ctrLicenseInfo1.Size = new System.Drawing.Size(899, 416);
            this.ctrLicenseInfo1.TabIndex = 4;
            // 
            // ctrFilterByLicenseID1
            // 
            this.ctrFilterByLicenseID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrFilterByLicenseID1.Location = new System.Drawing.Point(101, 92);
            this.ctrFilterByLicenseID1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ctrFilterByLicenseID1.Name = "ctrFilterByLicenseID1";
            this.ctrFilterByLicenseID1.Size = new System.Drawing.Size(442, 94);
            this.ctrFilterByLicenseID1.TabIndex = 2;
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(643, 774);
            this.ctrButtonClose1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(82, 31);
            this.ctrButtonClose1.TabIndex = 1;
            // 
            // ctrHeaderTitleControl1
            // 
            this.ctrHeaderTitleControl1.Location = new System.Drawing.Point(104, 17);
            this.ctrHeaderTitleControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrHeaderTitleControl1.Name = "ctrHeaderTitleControl1";
            this.ctrHeaderTitleControl1.Size = new System.Drawing.Size(708, 65);
            this.ctrHeaderTitleControl1.TabIndex = 0;
            this.ctrHeaderTitleControl1.Title = "Replacement For Lost License";
            // 
            // frmReplacementDamagedORLostLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 812);
            this.Controls.Add(this.ctrShowNewLicenseInfo1);
            this.Controls.Add(this.ctrShowLicensesHistory1);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.ctrApplicationInfoLicenseReplacement1);
            this.Controls.Add(this.ctrLicenseInfo1);
            this.Controls.Add(this.grbReplacementFor);
            this.Controls.Add(this.ctrFilterByLicenseID1);
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.ctrHeaderTitleControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmReplacementDamagedORLostLicense";
            this.Text = "Replacement For var License";
            this.Load += new System.EventHandler(this.frmReplacementDamagedORLostLicense_Load);
            this.grbReplacementFor.ResumeLayout(false);
            this.grbReplacementFor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DVLDPresentationLayer.Controls.ctrHeaderTitleControl ctrHeaderTitleControl1;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
        private Controls.ctrFilterByLicenseID ctrFilterByLicenseID1;
        private System.Windows.Forms.GroupBox grbReplacementFor;
        private System.Windows.Forms.RadioButton radBtnLost;
        private System.Windows.Forms.RadioButton radBtnDamaged;
        private Controls.ctrLicenseInfo ctrLicenseInfo1;
        private Controls.ctrApplicationInfoLicenseReplacement ctrApplicationInfoLicenseReplacement1;
        private System.Windows.Forms.Button btnIssueReplacement;
        private Controls.ctrShowLicensesHistory ctrShowLicensesHistory1;
        private Controls.ctrShowNewLicenseInfo ctrShowNewLicenseInfo1;
    }
}