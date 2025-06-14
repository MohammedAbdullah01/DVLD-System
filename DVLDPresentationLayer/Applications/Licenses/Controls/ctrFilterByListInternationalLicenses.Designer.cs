namespace DVLDPresentationLayer.Applications.Controls
{
    partial class ctrFilterByListInternationalLicenses
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
            this.txbInternationalLicensesFilterBy = new System.Windows.Forms.TextBox();
            this.cmbInternationalLicensesFilterBy = new System.Windows.Forms.ComboBox();
            this.labFilterBy = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbActive = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txbInternationalLicensesFilterBy
            // 
            this.txbInternationalLicensesFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInternationalLicensesFilterBy.Location = new System.Drawing.Point(302, 10);
            this.txbInternationalLicensesFilterBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txbInternationalLicensesFilterBy.MaximumSize = new System.Drawing.Size(200, 24);
            this.txbInternationalLicensesFilterBy.Name = "txbInternationalLicensesFilterBy";
            this.txbInternationalLicensesFilterBy.Size = new System.Drawing.Size(200, 24);
            this.txbInternationalLicensesFilterBy.TabIndex = 21;
            this.txbInternationalLicensesFilterBy.Visible = false;
            this.txbInternationalLicensesFilterBy.TextChanged += new System.EventHandler(this.txbInternationalLicensesFilterBy_TextChanged);
            // 
            // cmbInternationalLicensesFilterBy
            // 
            this.cmbInternationalLicensesFilterBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbInternationalLicensesFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInternationalLicensesFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInternationalLicensesFilterBy.FormattingEnabled = true;
            this.cmbInternationalLicensesFilterBy.Location = new System.Drawing.Point(90, 9);
            this.cmbInternationalLicensesFilterBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbInternationalLicensesFilterBy.MaximumSize = new System.Drawing.Size(200, 0);
            this.cmbInternationalLicensesFilterBy.Name = "cmbInternationalLicensesFilterBy";
            this.cmbInternationalLicensesFilterBy.Size = new System.Drawing.Size(200, 24);
            this.cmbInternationalLicensesFilterBy.TabIndex = 20;
            this.cmbInternationalLicensesFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbInternationalLicensesFilterBy_SelectedIndexChanged);
            // 
            // labFilterBy
            // 
            this.labFilterBy.AutoSize = true;
            this.labFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFilterBy.Location = new System.Drawing.Point(5, 12);
            this.labFilterBy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labFilterBy.MaximumSize = new System.Drawing.Size(75, 18);
            this.labFilterBy.Name = "labFilterBy";
            this.labFilterBy.Size = new System.Drawing.Size(75, 18);
            this.labFilterBy.TabIndex = 22;
            this.labFilterBy.Text = "Filter By:";
            // 
            // cmbActive
            // 
            this.cmbActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActive.FormattingEnabled = true;
            this.cmbActive.Location = new System.Drawing.Point(302, 10);
            this.cmbActive.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.Size = new System.Drawing.Size(200, 24);
            this.cmbActive.TabIndex = 19;
            this.cmbActive.Visible = false;
            this.cmbActive.SelectedIndexChanged += new System.EventHandler(this.cmbActive_SelectedIndexChanged);
            // 
            // ctrFilterByListInternationalLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbInternationalLicensesFilterBy);
            this.Controls.Add(this.cmbInternationalLicensesFilterBy);
            this.Controls.Add(this.labFilterBy);
            this.Controls.Add(this.cmbActive);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ctrFilterByListInternationalLicenses";
            this.Size = new System.Drawing.Size(507, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbInternationalLicensesFilterBy;
        private System.Windows.Forms.ComboBox cmbInternationalLicensesFilterBy;
        private System.Windows.Forms.Label labFilterBy;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbActive;
    }
}
