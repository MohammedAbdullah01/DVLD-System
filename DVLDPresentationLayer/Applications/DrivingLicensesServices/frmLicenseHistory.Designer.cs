namespace DVLDPresentationLayer.Applications
{
    partial class frmLicenseHistory
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
            this.ctrPersonCardWithFilter1 = new DVLDPresentationLayer.UserControls.ctrPersonCardWithFilter();
            this.ctrHeaderTitleControl1 = new DVLDPresentationLayer.Controls.ctrHeaderTitleControl();
            this.ctrDriverLicenses1 = new DVLDPresentationLayer.Applications.Controls.ctrDriverLicenses();
            this.SuspendLayout();
            // 
            // ctrPersonCardWithFilter1
            // 
            this.ctrPersonCardWithFilter1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrPersonCardWithFilter1.Location = new System.Drawing.Point(101, 68);
            this.ctrPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrPersonCardWithFilter1.Name = "ctrPersonCardWithFilter1";
            this.ctrPersonCardWithFilter1.Size = new System.Drawing.Size(842, 415);
            this.ctrPersonCardWithFilter1.TabIndex = 0;
            // 
            // ctrHeaderTitleControl1
            // 
            this.ctrHeaderTitleControl1.Location = new System.Drawing.Point(373, 3);
            this.ctrHeaderTitleControl1.Name = "ctrHeaderTitleControl1";
            this.ctrHeaderTitleControl1.Size = new System.Drawing.Size(299, 58);
            this.ctrHeaderTitleControl1.TabIndex = 1;
            this.ctrHeaderTitleControl1.Title = "License History";
            // 
            // ctrDriverLicenses1
            // 
            this.ctrDriverLicenses1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrDriverLicenses1.Location = new System.Drawing.Point(11, 501);
            this.ctrDriverLicenses1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrDriverLicenses1.Name = "ctrDriverLicenses1";
            this.ctrDriverLicenses1.Size = new System.Drawing.Size(1023, 393);
            this.ctrDriverLicenses1.TabIndex = 2;
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 892);
            this.Controls.Add(this.ctrDriverLicenses1);
            this.Controls.Add(this.ctrHeaderTitleControl1);
            this.Controls.Add(this.ctrPersonCardWithFilter1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmLicenseHistory";
            this.Text = "License History";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ctrPersonCardWithFilter ctrPersonCardWithFilter1;
        private DVLDPresentationLayer.Controls.ctrHeaderTitleControl ctrHeaderTitleControl1;
        private Controls.ctrDriverLicenses ctrDriverLicenses1;
    }
}