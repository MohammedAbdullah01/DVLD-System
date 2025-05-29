namespace DVLDPresentationLayer.Applications.Controls
{
    partial class ctrFilterByLicenseID
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
            this.labLicenseID = new System.Windows.Forms.Label();
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbLicenseID = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // labLicenseID
            // 
            this.labLicenseID.AutoSize = true;
            this.labLicenseID.Location = new System.Drawing.Point(23, 35);
            this.labLicenseID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labLicenseID.Name = "labLicenseID";
            this.labLicenseID.Size = new System.Drawing.Size(92, 18);
            this.labLicenseID.TabIndex = 0;
            this.labLicenseID.Text = "License ID:";
            // 
            // grbFilter
            // 
            this.grbFilter.Controls.Add(this.btnSearch);
            this.grbFilter.Controls.Add(this.txbLicenseID);
            this.grbFilter.Controls.Add(this.labLicenseID);
            this.grbFilter.Location = new System.Drawing.Point(3, 2);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(432, 88);
            this.grbFilter.TabIndex = 1;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(332, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbLicenseID
            // 
            this.txbLicenseID.Location = new System.Drawing.Point(123, 35);
            this.txbLicenseID.Name = "txbLicenseID";
            this.txbLicenseID.Size = new System.Drawing.Size(203, 24);
            this.txbLicenseID.TabIndex = 1;
            // 
            // ctrFilterByLicenseID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ctrFilterByLicenseID";
            this.Size = new System.Drawing.Size(438, 93);
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labLicenseID;
        private System.Windows.Forms.GroupBox grbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbLicenseID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
