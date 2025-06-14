namespace DVLDPresentationLayer.Applications
{
    partial class frmNewLocalDrivingLicenseApplication
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
            this.tabControlNewLocalDrivingLicense = new System.Windows.Forms.TabControl();
            this.PersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ApplicationInfo = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.labDLApplicationID = new System.Windows.Forms.Label();
            this.labApplicationDate = new System.Windows.Forms.Label();
            this.labLicenseClass = new System.Windows.Forms.Label();
            this.labApplicationFees = new System.Windows.Forms.Label();
            this.labCreatedBy = new System.Windows.Forms.Label();
            this.labValueDLApplicationID = new System.Windows.Forms.Label();
            this.labValueApplicationDate = new System.Windows.Forms.Label();
            this.labValueApplicationFees = new System.Windows.Forms.Label();
            this.labValueCreatedBy = new System.Windows.Forms.Label();
            this.cmbLicenseClass = new System.Windows.Forms.ComboBox();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.ctrHeaderTitleControl1 = new DVLDPresentationLayer.Controls.ctrHeaderTitleControl();
            this.ctrPersonCardWithFilter1 = new DVLDPresentationLayer.UserControls.ctrPersonCardWithFilter();
            this.tabControlNewLocalDrivingLicense.SuspendLayout();
            this.PersonalInfo.SuspendLayout();
            this.ApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlNewLocalDrivingLicense
            // 
            this.tabControlNewLocalDrivingLicense.Controls.Add(this.PersonalInfo);
            this.tabControlNewLocalDrivingLicense.Controls.Add(this.ApplicationInfo);
            this.tabControlNewLocalDrivingLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlNewLocalDrivingLicense.Location = new System.Drawing.Point(13, 92);
            this.tabControlNewLocalDrivingLicense.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControlNewLocalDrivingLicense.Name = "tabControlNewLocalDrivingLicense";
            this.tabControlNewLocalDrivingLicense.SelectedIndex = 0;
            this.tabControlNewLocalDrivingLicense.Size = new System.Drawing.Size(850, 493);
            this.tabControlNewLocalDrivingLicense.TabIndex = 0;
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.Controls.Add(this.btnNext);
            this.PersonalInfo.Controls.Add(this.ctrPersonCardWithFilter1);
            this.PersonalInfo.Location = new System.Drawing.Point(4, 27);
            this.PersonalInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PersonalInfo.Name = "PersonalInfo";
            this.PersonalInfo.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PersonalInfo.Size = new System.Drawing.Size(842, 462);
            this.PersonalInfo.TabIndex = 0;
            this.PersonalInfo.Text = "Personal Info";
            this.PersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Navy;
            this.btnNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(767, 423);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(67, 32);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ApplicationInfo
            // 
            this.ApplicationInfo.Controls.Add(this.cmbLicenseClass);
            this.ApplicationInfo.Controls.Add(this.labValueCreatedBy);
            this.ApplicationInfo.Controls.Add(this.labValueApplicationFees);
            this.ApplicationInfo.Controls.Add(this.labValueApplicationDate);
            this.ApplicationInfo.Controls.Add(this.labValueDLApplicationID);
            this.ApplicationInfo.Controls.Add(this.labCreatedBy);
            this.ApplicationInfo.Controls.Add(this.labApplicationFees);
            this.ApplicationInfo.Controls.Add(this.labLicenseClass);
            this.ApplicationInfo.Controls.Add(this.labApplicationDate);
            this.ApplicationInfo.Controls.Add(this.labDLApplicationID);
            this.ApplicationInfo.Controls.Add(this.btnBack);
            this.ApplicationInfo.Location = new System.Drawing.Point(4, 27);
            this.ApplicationInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ApplicationInfo.Name = "ApplicationInfo";
            this.ApplicationInfo.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ApplicationInfo.Size = new System.Drawing.Size(842, 462);
            this.ApplicationInfo.TabIndex = 1;
            this.ApplicationInfo.Text = "Application Info";
            this.ApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(787, 592);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Navy;
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(767, 423);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 32);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labDLApplicationID
            // 
            this.labDLApplicationID.AutoSize = true;
            this.labDLApplicationID.Location = new System.Drawing.Point(72, 44);
            this.labDLApplicationID.Name = "labDLApplicationID";
            this.labDLApplicationID.Size = new System.Drawing.Size(147, 18);
            this.labDLApplicationID.TabIndex = 3;
            this.labDLApplicationID.Text = "D.L.Application ID:";
            // 
            // labApplicationDate
            // 
            this.labApplicationDate.AutoSize = true;
            this.labApplicationDate.Location = new System.Drawing.Point(72, 94);
            this.labApplicationDate.Name = "labApplicationDate";
            this.labApplicationDate.Size = new System.Drawing.Size(135, 18);
            this.labApplicationDate.TabIndex = 4;
            this.labApplicationDate.Text = "Application Date:";
            // 
            // labLicenseClass
            // 
            this.labLicenseClass.AutoSize = true;
            this.labLicenseClass.Location = new System.Drawing.Point(72, 144);
            this.labLicenseClass.Name = "labLicenseClass";
            this.labLicenseClass.Size = new System.Drawing.Size(119, 18);
            this.labLicenseClass.TabIndex = 5;
            this.labLicenseClass.Text = "License Class:";
            // 
            // labApplicationFees
            // 
            this.labApplicationFees.AutoSize = true;
            this.labApplicationFees.Location = new System.Drawing.Point(72, 202);
            this.labApplicationFees.Name = "labApplicationFees";
            this.labApplicationFees.Size = new System.Drawing.Size(137, 18);
            this.labApplicationFees.TabIndex = 6;
            this.labApplicationFees.Text = "Application Fees:";
            // 
            // labCreatedBy
            // 
            this.labCreatedBy.AutoSize = true;
            this.labCreatedBy.Location = new System.Drawing.Point(72, 252);
            this.labCreatedBy.Name = "labCreatedBy";
            this.labCreatedBy.Size = new System.Drawing.Size(96, 18);
            this.labCreatedBy.TabIndex = 7;
            this.labCreatedBy.Text = "Created By:";
            // 
            // labValueDLApplicationID
            // 
            this.labValueDLApplicationID.AutoSize = true;
            this.labValueDLApplicationID.Location = new System.Drawing.Point(237, 44);
            this.labValueDLApplicationID.Name = "labValueDLApplicationID";
            this.labValueDLApplicationID.Size = new System.Drawing.Size(35, 18);
            this.labValueDLApplicationID.TabIndex = 8;
            this.labValueDLApplicationID.Text = "???";
            // 
            // labValueApplicationDate
            // 
            this.labValueApplicationDate.AutoSize = true;
            this.labValueApplicationDate.Location = new System.Drawing.Point(237, 94);
            this.labValueApplicationDate.Name = "labValueApplicationDate";
            this.labValueApplicationDate.Size = new System.Drawing.Size(35, 18);
            this.labValueApplicationDate.TabIndex = 9;
            this.labValueApplicationDate.Text = "???";
            // 
            // labValueApplicationFees
            // 
            this.labValueApplicationFees.AutoSize = true;
            this.labValueApplicationFees.Location = new System.Drawing.Point(237, 202);
            this.labValueApplicationFees.Name = "labValueApplicationFees";
            this.labValueApplicationFees.Size = new System.Drawing.Size(35, 18);
            this.labValueApplicationFees.TabIndex = 10;
            this.labValueApplicationFees.Text = "???";
            // 
            // labValueCreatedBy
            // 
            this.labValueCreatedBy.AutoSize = true;
            this.labValueCreatedBy.Location = new System.Drawing.Point(237, 252);
            this.labValueCreatedBy.Name = "labValueCreatedBy";
            this.labValueCreatedBy.Size = new System.Drawing.Size(35, 18);
            this.labValueCreatedBy.TabIndex = 11;
            this.labValueCreatedBy.Text = "???";
            // 
            // cmbLicenseClass
            // 
            this.cmbLicenseClass.FormattingEnabled = true;
            this.cmbLicenseClass.Location = new System.Drawing.Point(240, 144);
            this.cmbLicenseClass.Name = "cmbLicenseClass";
            this.cmbLicenseClass.Size = new System.Drawing.Size(250, 26);
            this.cmbLicenseClass.TabIndex = 12;
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(702, 591);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(79, 30);
            this.ctrButtonClose1.TabIndex = 2;
            // 
            // ctrHeaderTitleControl1
            // 
            this.ctrHeaderTitleControl1.Location = new System.Drawing.Point(92, 12);
            this.ctrHeaderTitleControl1.Name = "ctrHeaderTitleControl1";
            this.ctrHeaderTitleControl1.Size = new System.Drawing.Size(692, 65);
            this.ctrHeaderTitleControl1.TabIndex = 1;
            this.ctrHeaderTitleControl1.Title = "New Local Driving License Application";
            // 
            // ctrPersonCardWithFilter1
            // 
            this.ctrPersonCardWithFilter1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrPersonCardWithFilter1.Location = new System.Drawing.Point(7, 7);
            this.ctrPersonCardWithFilter1.Name = "ctrPersonCardWithFilter1";
            this.ctrPersonCardWithFilter1.Size = new System.Drawing.Size(829, 420);
            this.ctrPersonCardWithFilter1.TabIndex = 0;
            // 
            // frmNewLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 628);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.ctrHeaderTitleControl1);
            this.Controls.Add(this.tabControlNewLocalDrivingLicense);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmNewLocalDrivingLicenseApplication";
            this.Text = "New Local Driving License Application";
            this.tabControlNewLocalDrivingLicense.ResumeLayout(false);
            this.PersonalInfo.ResumeLayout(false);
            this.ApplicationInfo.ResumeLayout(false);
            this.ApplicationInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlNewLocalDrivingLicense;
        private System.Windows.Forms.TabPage PersonalInfo;
        private System.Windows.Forms.TabPage ApplicationInfo;
        private DVLDPresentationLayer.Controls.ctrHeaderTitleControl ctrHeaderTitleControl1;
        private UserControls.ctrPersonCardWithFilter ctrPersonCardWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labValueCreatedBy;
        private System.Windows.Forms.Label labValueApplicationFees;
        private System.Windows.Forms.Label labValueApplicationDate;
        private System.Windows.Forms.Label labValueDLApplicationID;
        private System.Windows.Forms.Label labCreatedBy;
        private System.Windows.Forms.Label labApplicationFees;
        private System.Windows.Forms.Label labLicenseClass;
        private System.Windows.Forms.Label labApplicationDate;
        private System.Windows.Forms.Label labDLApplicationID;
        private System.Windows.Forms.ComboBox cmbLicenseClass;
    }
}