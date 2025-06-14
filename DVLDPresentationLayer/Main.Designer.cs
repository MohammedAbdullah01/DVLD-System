namespace DVLDPresentationLayer
{
    partial class frmMain
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
            this.menuStripApp = new System.Windows.Forms.MenuStrip();
            this.MenuItemApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRnewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemReplacementLostOrDamaged = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemReleaseDetainedDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLocalDrivingLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInternationalLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemDetainLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemManageDetainedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPersons = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStripApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripApp
            // 
            this.menuStripApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStripApp.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemApplications,
            this.MenuItemPersons,
            this.MenuItemUsers,
            this.MenuItemAccountSettings});
            this.menuStripApp.Location = new System.Drawing.Point(0, 0);
            this.menuStripApp.Name = "menuStripApp";
            this.menuStripApp.Size = new System.Drawing.Size(1277, 56);
            this.menuStripApp.TabIndex = 2;
            this.menuStripApp.Text = "menuStrip1";
            // 
            // MenuItemApplications
            // 
            this.MenuItemApplications.BackColor = System.Drawing.SystemColors.Menu;
            this.MenuItemApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageApplicationsToolStripMenuItem,
            this.toolStripSeparator2,
            this.MenuItemManageApplications,
            this.toolStripSeparator1,
            this.MenuItemDetainLicenses,
            this.toolStripSeparator3,
            this.MenuItemManageApplicationTypes,
            this.MenuItemManageTestTypes});
            this.MenuItemApplications.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuItemApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuItemApplications.Name = "MenuItemApplications";
            this.MenuItemApplications.Padding = new System.Windows.Forms.Padding(4);
            this.MenuItemApplications.Size = new System.Drawing.Size(208, 52);
            this.MenuItemApplications.Text = "Applications";
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNewDrivingLicense,
            this.MenuItemRnewDrivingLicense,
            this.toolStripSeparator6,
            this.MenuItemReplacementLostOrDamaged,
            this.toolStripSeparator5,
            this.MenuItemReleaseDetainedDrivingLicense,
            this.MenuItemRetakeTest});
            this.manageApplicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.manageApplicationsToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // MenuItemNewDrivingLicense
            // 
            this.MenuItemNewDrivingLicense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemLocalLicense,
            this.MenuItemInternationalLicense});
            this.MenuItemNewDrivingLicense.Name = "MenuItemNewDrivingLicense";
            this.MenuItemNewDrivingLicense.Size = new System.Drawing.Size(403, 26);
            this.MenuItemNewDrivingLicense.Text = "New Driving License";
            // 
            // MenuItemLocalLicense
            // 
            this.MenuItemLocalLicense.Name = "MenuItemLocalLicense";
            this.MenuItemLocalLicense.Size = new System.Drawing.Size(240, 26);
            this.MenuItemLocalLicense.Text = "Local License";
            this.MenuItemLocalLicense.Click += new System.EventHandler(this.MenuItemLocalLicense_Click);
            // 
            // MenuItemInternationalLicense
            // 
            this.MenuItemInternationalLicense.Name = "MenuItemInternationalLicense";
            this.MenuItemInternationalLicense.Size = new System.Drawing.Size(240, 26);
            this.MenuItemInternationalLicense.Text = "International License";
            this.MenuItemInternationalLicense.Click += new System.EventHandler(this.MenuItemInternationalLicense_Click);
            // 
            // MenuItemRnewDrivingLicense
            // 
            this.MenuItemRnewDrivingLicense.Name = "MenuItemRnewDrivingLicense";
            this.MenuItemRnewDrivingLicense.Size = new System.Drawing.Size(403, 26);
            this.MenuItemRnewDrivingLicense.Text = "Rnew Driving License";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(400, 6);
            // 
            // MenuItemReplacementLostOrDamaged
            // 
            this.MenuItemReplacementLostOrDamaged.Name = "MenuItemReplacementLostOrDamaged";
            this.MenuItemReplacementLostOrDamaged.Size = new System.Drawing.Size(403, 26);
            this.MenuItemReplacementLostOrDamaged.Text = "Replacement For Lost Or Damaged License";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(400, 6);
            // 
            // MenuItemReleaseDetainedDrivingLicense
            // 
            this.MenuItemReleaseDetainedDrivingLicense.Name = "MenuItemReleaseDetainedDrivingLicense";
            this.MenuItemReleaseDetainedDrivingLicense.Size = new System.Drawing.Size(403, 26);
            this.MenuItemReleaseDetainedDrivingLicense.Text = "Release Detained Driving License";
            // 
            // MenuItemRetakeTest
            // 
            this.MenuItemRetakeTest.Name = "MenuItemRetakeTest";
            this.MenuItemRetakeTest.Size = new System.Drawing.Size(403, 26);
            this.MenuItemRetakeTest.Text = "Retake Test";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(286, 6);
            // 
            // MenuItemManageApplications
            // 
            this.MenuItemManageApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemLocalDrivingLicenseApplications,
            this.MenuItemInternationalLicenseApplications});
            this.MenuItemManageApplications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemManageApplications.Name = "MenuItemManageApplications";
            this.MenuItemManageApplications.Size = new System.Drawing.Size(289, 26);
            this.MenuItemManageApplications.Text = "Manage Applications";
            // 
            // MenuItemLocalDrivingLicenseApplications
            // 
            this.MenuItemLocalDrivingLicenseApplications.Name = "MenuItemLocalDrivingLicenseApplications";
            this.MenuItemLocalDrivingLicenseApplications.Size = new System.Drawing.Size(341, 26);
            this.MenuItemLocalDrivingLicenseApplications.Text = "Local Driving License Applications";
            this.MenuItemLocalDrivingLicenseApplications.Click += new System.EventHandler(this.MenuItemLocalDrivingLicenseApplications_Click);
            // 
            // MenuItemInternationalLicenseApplications
            // 
            this.MenuItemInternationalLicenseApplications.Name = "MenuItemInternationalLicenseApplications";
            this.MenuItemInternationalLicenseApplications.Size = new System.Drawing.Size(341, 26);
            this.MenuItemInternationalLicenseApplications.Text = "International License Applications";
            this.MenuItemInternationalLicenseApplications.Click += new System.EventHandler(this.MenuItemInternationalLicenseApplications_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(286, 6);
            // 
            // MenuItemDetainLicenses
            // 
            this.MenuItemDetainLicenses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemManageDetainedLicenses,
            this.MenuItemDetainLicense,
            this.MenuItemReleaseDetainedLicense});
            this.MenuItemDetainLicenses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemDetainLicenses.Name = "MenuItemDetainLicenses";
            this.MenuItemDetainLicenses.Size = new System.Drawing.Size(289, 26);
            this.MenuItemDetainLicenses.Text = "Detain Licenses";
            // 
            // MenuItemManageDetainedLicenses
            // 
            this.MenuItemManageDetainedLicenses.Name = "MenuItemManageDetainedLicenses";
            this.MenuItemManageDetainedLicenses.Size = new System.Drawing.Size(283, 26);
            this.MenuItemManageDetainedLicenses.Text = "Manage Detained Licenses";
            this.MenuItemManageDetainedLicenses.Click += new System.EventHandler(this.MenuItemManageDetainedLicenses_Click);
            // 
            // MenuItemDetainLicense
            // 
            this.MenuItemDetainLicense.Name = "MenuItemDetainLicense";
            this.MenuItemDetainLicense.Size = new System.Drawing.Size(283, 26);
            this.MenuItemDetainLicense.Text = "Detain License";
            this.MenuItemDetainLicense.Click += new System.EventHandler(this.MenuItemDetainLicense_Click);
            // 
            // MenuItemReleaseDetainedLicense
            // 
            this.MenuItemReleaseDetainedLicense.Name = "MenuItemReleaseDetainedLicense";
            this.MenuItemReleaseDetainedLicense.Size = new System.Drawing.Size(283, 26);
            this.MenuItemReleaseDetainedLicense.Text = "Release Detained License";
            this.MenuItemReleaseDetainedLicense.Click += new System.EventHandler(this.MenuItemReleaseDetainedLicense_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(286, 6);
            // 
            // MenuItemManageApplicationTypes
            // 
            this.MenuItemManageApplicationTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuItemManageApplicationTypes.Name = "MenuItemManageApplicationTypes";
            this.MenuItemManageApplicationTypes.Size = new System.Drawing.Size(289, 26);
            this.MenuItemManageApplicationTypes.Text = "Manage Application Types";
            this.MenuItemManageApplicationTypes.Click += new System.EventHandler(this.MenuItemManageApplicationTypes_Click);
            // 
            // MenuItemManageTestTypes
            // 
            this.MenuItemManageTestTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuItemManageTestTypes.Name = "MenuItemManageTestTypes";
            this.MenuItemManageTestTypes.Size = new System.Drawing.Size(289, 26);
            this.MenuItemManageTestTypes.Text = "Manage Test Types";
            this.MenuItemManageTestTypes.Click += new System.EventHandler(this.MenuItemManageTestTypes_Click);
            // 
            // MenuItemPersons
            // 
            this.MenuItemPersons.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MenuItemPersons.Name = "MenuItemPersons";
            this.MenuItemPersons.Size = new System.Drawing.Size(141, 52);
            this.MenuItemPersons.Text = "Persons";
            this.MenuItemPersons.Click += new System.EventHandler(this.MenuItemPersons_Click);
            // 
            // MenuItemUsers
            // 
            this.MenuItemUsers.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MenuItemUsers.Name = "MenuItemUsers";
            this.MenuItemUsers.Size = new System.Drawing.Size(107, 52);
            this.MenuItemUsers.Text = "Users";
            this.MenuItemUsers.Click += new System.EventHandler(this.MenuItemUsers_Click);
            // 
            // MenuItemAccountSettings
            // 
            this.MenuItemAccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCurrentUserInfo,
            this.MenuItemChangePassword,
            this.toolStripSeparator7,
            this.MenuItemSignOut});
            this.MenuItemAccountSettings.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MenuItemAccountSettings.Name = "MenuItemAccountSettings";
            this.MenuItemAccountSettings.Size = new System.Drawing.Size(269, 52);
            this.MenuItemAccountSettings.Text = "Account Settings";
            // 
            // MenuItemCurrentUserInfo
            // 
            this.MenuItemCurrentUserInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemCurrentUserInfo.Name = "MenuItemCurrentUserInfo";
            this.MenuItemCurrentUserInfo.Size = new System.Drawing.Size(262, 34);
            this.MenuItemCurrentUserInfo.Text = "Current User Info";
            this.MenuItemCurrentUserInfo.Click += new System.EventHandler(this.MenuItemCurrentUserInfo_Click);
            // 
            // MenuItemChangePassword
            // 
            this.MenuItemChangePassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemChangePassword.Name = "MenuItemChangePassword";
            this.MenuItemChangePassword.Size = new System.Drawing.Size(262, 34);
            this.MenuItemChangePassword.Text = "Change Password";
            this.MenuItemChangePassword.Click += new System.EventHandler(this.MenuItemChangePassword_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(259, 6);
            // 
            // MenuItemSignOut
            // 
            this.MenuItemSignOut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemSignOut.Name = "MenuItemSignOut";
            this.MenuItemSignOut.Size = new System.Drawing.Size(262, 34);
            this.MenuItemSignOut.Text = "Sign Out";
            this.MenuItemSignOut.Click += new System.EventHandler(this.MenuItemSignOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DVLDPresentationLayer.Properties.Resources.DriverLicense;
            this.pictureBox1.Location = new System.Drawing.Point(0, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1277, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1277, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStripApp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripApp;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripApp.ResumeLayout(false);
            this.menuStripApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripApp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPersons;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUsers;
        private System.Windows.Forms.ToolStripMenuItem MenuItemApplications;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemManageApplications;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDetainLicenses;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRnewDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReplacementLostOrDamaged;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReleaseDetainedDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRetakeTest;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSignOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLocalDrivingLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInternationalLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem MenuItemManageDetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDetainLicense;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReleaseDetainedLicense;
        private System.Windows.Forms.ToolStripMenuItem MenuItemManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem MenuItemManageTestTypes;
    }
}

