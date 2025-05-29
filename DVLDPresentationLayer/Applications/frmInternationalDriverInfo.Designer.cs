namespace DVLDPresentationLayer.Applications
{
    partial class frmInternationalDriverInfo
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
            this.ctrHeaderTitleControl1 = new DVLDPresentationLayer.Controls.ctrHeaderTitleControl();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.ctrDriverInternationalLicenseInfo1 = new DVLDPresentationLayer.Applications.Controls.ctrDriverInternationalLicenseInfo();
            this.SuspendLayout();
            // 
            // ctrHeaderTitleControl1
            // 
            this.ctrHeaderTitleControl1.Location = new System.Drawing.Point(117, 12);
            this.ctrHeaderTitleControl1.Name = "ctrHeaderTitleControl1";
            this.ctrHeaderTitleControl1.Size = new System.Drawing.Size(592, 54);
            this.ctrHeaderTitleControl1.TabIndex = 0;
            this.ctrHeaderTitleControl1.Title = "Driver International License Info";
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(730, 391);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(83, 32);
            this.ctrButtonClose1.TabIndex = 1;
            // 
            // ctrDriverInternationalLicenseInfo1
            // 
            this.ctrDriverInternationalLicenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrDriverInternationalLicenseInfo1.Location = new System.Drawing.Point(2, 76);
            this.ctrDriverInternationalLicenseInfo1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrDriverInternationalLicenseInfo1.Name = "ctrDriverInternationalLicenseInfo1";
            this.ctrDriverInternationalLicenseInfo1.Size = new System.Drawing.Size(813, 310);
            this.ctrDriverInternationalLicenseInfo1.TabIndex = 2;
            // 
            // frmInternationalDriverInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 427);
            this.Controls.Add(this.ctrDriverInternationalLicenseInfo1);
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.ctrHeaderTitleControl1);
            this.Name = "frmInternationalDriverInfo";
            this.Text = "International Driver Info";
            this.ResumeLayout(false);

        }

        #endregion

        private DVLDPresentationLayer.Controls.ctrHeaderTitleControl ctrHeaderTitleControl1;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
        private Controls.ctrDriverInternationalLicenseInfo ctrDriverInternationalLicenseInfo1;
    }
}