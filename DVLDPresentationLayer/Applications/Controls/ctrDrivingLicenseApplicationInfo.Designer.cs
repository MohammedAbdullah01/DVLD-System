namespace DVLDPresentationLayer.Applications.Controls
{
    partial class ctrDrivingLicenseApplicationInfo
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
            this.grbDrivingLicenseApplicationInfo = new System.Windows.Forms.GroupBox();
            this.labValuePassedTests = new System.Windows.Forms.Label();
            this.labPassedTests = new System.Windows.Forms.Label();
            this.labValueAppliedLicense = new System.Windows.Forms.Label();
            this.labAppliedLicense = new System.Windows.Forms.Label();
            this.labValueDLAppID = new System.Windows.Forms.Label();
            this.labDLAppID = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbDrivingLicenseApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDrivingLicenseApplicationInfo
            // 
            this.grbDrivingLicenseApplicationInfo.Controls.Add(this.labValuePassedTests);
            this.grbDrivingLicenseApplicationInfo.Controls.Add(this.labPassedTests);
            this.grbDrivingLicenseApplicationInfo.Controls.Add(this.labValueAppliedLicense);
            this.grbDrivingLicenseApplicationInfo.Controls.Add(this.labAppliedLicense);
            this.grbDrivingLicenseApplicationInfo.Controls.Add(this.labValueDLAppID);
            this.grbDrivingLicenseApplicationInfo.Controls.Add(this.labDLAppID);
            this.grbDrivingLicenseApplicationInfo.Location = new System.Drawing.Point(7, 4);
            this.grbDrivingLicenseApplicationInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbDrivingLicenseApplicationInfo.Name = "grbDrivingLicenseApplicationInfo";
            this.grbDrivingLicenseApplicationInfo.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbDrivingLicenseApplicationInfo.Size = new System.Drawing.Size(711, 121);
            this.grbDrivingLicenseApplicationInfo.TabIndex = 0;
            this.grbDrivingLicenseApplicationInfo.TabStop = false;
            this.grbDrivingLicenseApplicationInfo.Text = "Driving License Application Info";
            // 
            // labValuePassedTests
            // 
            this.labValuePassedTests.AutoSize = true;
            this.labValuePassedTests.Location = new System.Drawing.Point(649, 37);
            this.labValuePassedTests.Name = "labValuePassedTests";
            this.labValuePassedTests.Size = new System.Drawing.Size(35, 18);
            this.labValuePassedTests.TabIndex = 5;
            this.labValuePassedTests.Text = "???";
            // 
            // labPassedTests
            // 
            this.labPassedTests.AutoSize = true;
            this.labPassedTests.Location = new System.Drawing.Point(517, 37);
            this.labPassedTests.Name = "labPassedTests";
            this.labPassedTests.Size = new System.Drawing.Size(116, 18);
            this.labPassedTests.TabIndex = 4;
            this.labPassedTests.Text = "Passed Tests:";
            // 
            // labValueAppliedLicense
            // 
            this.labValueAppliedLicense.AutoSize = true;
            this.labValueAppliedLicense.Location = new System.Drawing.Point(428, 81);
            this.labValueAppliedLicense.Name = "labValueAppliedLicense";
            this.labValueAppliedLicense.Size = new System.Drawing.Size(35, 18);
            this.labValueAppliedLicense.TabIndex = 3;
            this.labValueAppliedLicense.Text = "???";
            // 
            // labAppliedLicense
            // 
            this.labAppliedLicense.AutoSize = true;
            this.labAppliedLicense.Location = new System.Drawing.Point(251, 81);
            this.labAppliedLicense.Name = "labAppliedLicense";
            this.labAppliedLicense.Size = new System.Drawing.Size(161, 18);
            this.labAppliedLicense.TabIndex = 2;
            this.labAppliedLicense.Text = "Applied For License:";
            // 
            // labValueDLAppID
            // 
            this.labValueDLAppID.AutoSize = true;
            this.labValueDLAppID.Location = new System.Drawing.Point(162, 37);
            this.labValueDLAppID.Name = "labValueDLAppID";
            this.labValueDLAppID.Size = new System.Drawing.Size(35, 18);
            this.labValueDLAppID.TabIndex = 1;
            this.labValueDLAppID.Text = "???";
            // 
            // labDLAppID
            // 
            this.labDLAppID.AutoSize = true;
            this.labDLAppID.Location = new System.Drawing.Point(52, 37);
            this.labDLAppID.Name = "labDLAppID";
            this.labDLAppID.Size = new System.Drawing.Size(93, 18);
            this.labDLAppID.TabIndex = 0;
            this.labDLAppID.Text = "D.L.App ID:";
            // 
            // ctrDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbDrivingLicenseApplicationInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ctrDrivingLicenseApplicationInfo";
            this.Size = new System.Drawing.Size(725, 129);
            this.grbDrivingLicenseApplicationInfo.ResumeLayout(false);
            this.grbDrivingLicenseApplicationInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDrivingLicenseApplicationInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labPassedTests;
        private System.Windows.Forms.Label labValueAppliedLicense;
        private System.Windows.Forms.Label labAppliedLicense;
        private System.Windows.Forms.Label labValueDLAppID;
        private System.Windows.Forms.Label labDLAppID;
        private System.Windows.Forms.Label labValuePassedTests;
    }
}
