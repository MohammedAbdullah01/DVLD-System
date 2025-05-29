namespace DVLDPresentationLayer.Applications.Controls
{
    partial class ctrShowNewLicenseInfo
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
            this.linkLabShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabShowNewLicenseInfo
            // 
            this.linkLabShowNewLicenseInfo.AutoSize = true;
            this.linkLabShowNewLicenseInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabShowNewLicenseInfo.Location = new System.Drawing.Point(-2, 3);
            this.linkLabShowNewLicenseInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkLabShowNewLicenseInfo.Name = "linkLabShowNewLicenseInfo";
            this.linkLabShowNewLicenseInfo.Size = new System.Drawing.Size(184, 18);
            this.linkLabShowNewLicenseInfo.TabIndex = 9;
            this.linkLabShowNewLicenseInfo.TabStop = true;
            this.linkLabShowNewLicenseInfo.Text = "Show New License Info";
            this.linkLabShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabShowNewLicenseInfo_LinkClicked);
            // 
            // ctrShowNewLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabShowNewLicenseInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ctrShowNewLicenseInfo";
            this.Size = new System.Drawing.Size(181, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabShowNewLicenseInfo;
    }
}
