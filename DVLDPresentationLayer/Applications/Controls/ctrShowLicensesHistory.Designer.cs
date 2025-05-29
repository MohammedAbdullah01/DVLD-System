namespace DVLDPresentationLayer.Applications.Controls
{
    partial class ctrShowLicensesHistory
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
            this.linkLabShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabShowLicensesHistory
            // 
            this.linkLabShowLicensesHistory.AutoSize = true;
            this.linkLabShowLicensesHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabShowLicensesHistory.Location = new System.Drawing.Point(-3, 3);
            this.linkLabShowLicensesHistory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkLabShowLicensesHistory.Name = "linkLabShowLicensesHistory";
            this.linkLabShowLicensesHistory.Size = new System.Drawing.Size(181, 18);
            this.linkLabShowLicensesHistory.TabIndex = 8;
            this.linkLabShowLicensesHistory.TabStop = true;
            this.linkLabShowLicensesHistory.Text = "Show Licenses History";
            this.linkLabShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabShowLicensesHistory_LinkClicked);
            // 
            // ctrShowLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabShowLicensesHistory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ctrShowLicensesHistory";
            this.Size = new System.Drawing.Size(174, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabShowLicensesHistory;
    }
}
