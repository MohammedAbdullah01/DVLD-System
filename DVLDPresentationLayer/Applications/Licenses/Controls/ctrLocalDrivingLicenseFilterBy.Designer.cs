namespace DVLDPresentationLayer.Applications.Controls
{
    partial class ctrLocalDrivingLicenseFilterBy
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
            this.txbLocalDrivingLicenseFilterBy = new System.Windows.Forms.TextBox();
            this.cmbLocalDrivingLicenseFilterBy = new System.Windows.Forms.ComboBox();
            this.labFilterBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbLocalDrivingLicenseFilterBy
            // 
            this.txbLocalDrivingLicenseFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLocalDrivingLicenseFilterBy.Location = new System.Drawing.Point(309, 8);
            this.txbLocalDrivingLicenseFilterBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txbLocalDrivingLicenseFilterBy.Name = "txbLocalDrivingLicenseFilterBy";
            this.txbLocalDrivingLicenseFilterBy.Size = new System.Drawing.Size(200, 24);
            this.txbLocalDrivingLicenseFilterBy.TabIndex = 21;
            this.txbLocalDrivingLicenseFilterBy.TextChanged += new System.EventHandler(this.txbPersonFilterBy_TextChanged);
            // 
            // cmbLocalDrivingLicenseFilterBy
            // 
            this.cmbLocalDrivingLicenseFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalDrivingLicenseFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalDrivingLicenseFilterBy.FormattingEnabled = true;
            this.cmbLocalDrivingLicenseFilterBy.Location = new System.Drawing.Point(97, 8);
            this.cmbLocalDrivingLicenseFilterBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbLocalDrivingLicenseFilterBy.Name = "cmbLocalDrivingLicenseFilterBy";
            this.cmbLocalDrivingLicenseFilterBy.Size = new System.Drawing.Size(200, 24);
            this.cmbLocalDrivingLicenseFilterBy.TabIndex = 20;
            this.cmbLocalDrivingLicenseFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbLocalDrivingLicenseFilterBy_SelectedIndexChanged);
            // 
            // labFilterBy
            // 
            this.labFilterBy.AutoSize = true;
            this.labFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFilterBy.Location = new System.Drawing.Point(10, 9);
            this.labFilterBy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labFilterBy.Name = "labFilterBy";
            this.labFilterBy.Size = new System.Drawing.Size(75, 18);
            this.labFilterBy.TabIndex = 22;
            this.labFilterBy.Text = "Filter By:";
            // 
            // ctrLocalDrivingLicenseFilterBy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txbLocalDrivingLicenseFilterBy);
            this.Controls.Add(this.cmbLocalDrivingLicenseFilterBy);
            this.Controls.Add(this.labFilterBy);
            this.Name = "ctrLocalDrivingLicenseFilterBy";
            this.Size = new System.Drawing.Size(518, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbLocalDrivingLicenseFilterBy;
        private System.Windows.Forms.ComboBox cmbLocalDrivingLicenseFilterBy;
        private System.Windows.Forms.Label labFilterBy;
    }
}
