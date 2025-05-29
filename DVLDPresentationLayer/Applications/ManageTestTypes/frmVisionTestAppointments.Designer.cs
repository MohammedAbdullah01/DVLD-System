namespace DVLDPresentationLayer.Applications
{
    partial class frmVisionTestAppointments
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
            this.ctrDrivingLicenseApplicationInfo1 = new DVLDPresentationLayer.Applications.Controls.ctrDrivingLicenseApplicationInfo();
            this.ctrApplicationBasicInfo1 = new DVLDPresentationLayer.Applications.Controls.ctrApplicationBasicInfo();
            this.ctrAppointments1 = new DVLDPresentationLayer.Applications.Controls.ctrAppointments();
            this.SuspendLayout();
            // 
            // ctrHeaderTitleControl1
            // 
            this.ctrHeaderTitleControl1.Location = new System.Drawing.Point(160, 7);
            this.ctrHeaderTitleControl1.Name = "ctrHeaderTitleControl1";
            this.ctrHeaderTitleControl1.Size = new System.Drawing.Size(476, 53);
            this.ctrHeaderTitleControl1.TabIndex = 0;
            this.ctrHeaderTitleControl1.Title = "Vision Test Appointments";
            // 
            // ctrDrivingLicenseApplicationInfo1
            // 
            this.ctrDrivingLicenseApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(12, 72);
            this.ctrDrivingLicenseApplicationInfo1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrDrivingLicenseApplicationInfo1.Name = "ctrDrivingLicenseApplicationInfo1";
            this.ctrDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(725, 129);
            this.ctrDrivingLicenseApplicationInfo1.TabIndex = 1;
            // 
            // ctrApplicationBasicInfo1
            // 
            this.ctrApplicationBasicInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrApplicationBasicInfo1.Location = new System.Drawing.Point(12, 213);
            this.ctrApplicationBasicInfo1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrApplicationBasicInfo1.Name = "ctrApplicationBasicInfo1";
            this.ctrApplicationBasicInfo1.Size = new System.Drawing.Size(725, 267);
            this.ctrApplicationBasicInfo1.TabIndex = 2;
            // 
            // ctrAppointments1
            // 
            this.ctrAppointments1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrAppointments1.Location = new System.Drawing.Point(12, 492);
            this.ctrAppointments1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrAppointments1.Name = "ctrAppointments1";
            this.ctrAppointments1.Size = new System.Drawing.Size(725, 352);
            this.ctrAppointments1.TabIndex = 3;
            // 
            // frmVisionTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 852);
            this.Controls.Add(this.ctrAppointments1);
            this.Controls.Add(this.ctrApplicationBasicInfo1);
            this.Controls.Add(this.ctrDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.ctrHeaderTitleControl1);
            this.Name = "frmVisionTestAppointments";
            this.Text = "Vision Test Appointments";
            this.ResumeLayout(false);

        }

        #endregion

        private DVLDPresentationLayer.Controls.ctrHeaderTitleControl ctrHeaderTitleControl1;
        private Controls.ctrDrivingLicenseApplicationInfo ctrDrivingLicenseApplicationInfo1;
        private Controls.ctrApplicationBasicInfo ctrApplicationBasicInfo1;
        private Controls.ctrAppointments ctrAppointments1;
    }
}