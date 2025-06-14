namespace DVLDPresentationLayer.DetainLicenses.Controls
{
    partial class ctrListDetainedLicensesFilterBy
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
            this.txbDetainedFilterBy = new System.Windows.Forms.TextBox();
            this.cmbDetainedFilterBy = new System.Windows.Forms.ComboBox();
            this.cmbIsReleased = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txbDetainedFilterBy
            // 
            this.txbDetainedFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDetainedFilterBy.Location = new System.Drawing.Point(301, 4);
            this.txbDetainedFilterBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txbDetainedFilterBy.MaximumSize = new System.Drawing.Size(200, 24);
            this.txbDetainedFilterBy.Name = "txbDetainedFilterBy";
            this.txbDetainedFilterBy.Size = new System.Drawing.Size(200, 24);
            this.txbDetainedFilterBy.TabIndex = 20;
            this.txbDetainedFilterBy.Visible = false;
            this.txbDetainedFilterBy.TextChanged += new System.EventHandler(this.txbDetainedFilterBy_TextChanged);
            // 
            // cmbDetainedFilterBy
            // 
            this.cmbDetainedFilterBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDetainedFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDetainedFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDetainedFilterBy.FormattingEnabled = true;
            this.cmbDetainedFilterBy.Location = new System.Drawing.Point(91, 4);
            this.cmbDetainedFilterBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbDetainedFilterBy.MaximumSize = new System.Drawing.Size(200, 0);
            this.cmbDetainedFilterBy.Name = "cmbDetainedFilterBy";
            this.cmbDetainedFilterBy.Size = new System.Drawing.Size(200, 24);
            this.cmbDetainedFilterBy.TabIndex = 19;
            this.cmbDetainedFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbDetainedFilterBy_SelectedIndexChanged);
            // 
            // cmbIsReleased
            // 
            this.cmbIsReleased.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbIsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIsReleased.FormattingEnabled = true;
            this.cmbIsReleased.Items.AddRange(new object[] {"Yes","No"});
            this.cmbIsReleased.Location = new System.Drawing.Point(301, 4);
            this.cmbIsReleased.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbIsReleased.Name = "cmbIsReleased";
            this.cmbIsReleased.Size = new System.Drawing.Size(200, 24);
            this.cmbIsReleased.TabIndex = 18;
            this.cmbIsReleased.Visible = false;
            this.cmbIsReleased.SelectedIndexChanged += new System.EventHandler(this.cmbIsReleased_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Filter By:";
            // 
            // ctrListDetainedLicensesFilterBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbDetainedFilterBy);
            this.Controls.Add(this.cmbDetainedFilterBy);
            this.Controls.Add(this.cmbIsReleased);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ctrListDetainedLicensesFilterBy";
            this.Size = new System.Drawing.Size(507, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDetainedFilterBy;
        private System.Windows.Forms.ComboBox cmbDetainedFilterBy;
        private System.Windows.Forms.ComboBox cmbIsReleased;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
