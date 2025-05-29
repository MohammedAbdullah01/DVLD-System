namespace DVLDPresentationLayer.User.Controls
{
    partial class ctrFilterByUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboActive = new System.Windows.Forms.ComboBox();
            this.txbUserFilterBy = new System.Windows.Forms.TextBox();
            this.cmbUserFilterBy = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filter By:";
            // 
            // comboActive
            // 
            this.comboActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboActive.FormattingEnabled = true;
            this.comboActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.comboActive.Location = new System.Drawing.Point(300, 18);
            this.comboActive.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.comboActive.Name = "comboActive";
            this.comboActive.Size = new System.Drawing.Size(200, 24);
            this.comboActive.TabIndex = 14;
            this.comboActive.Visible = false;
            this.comboActive.SelectedIndexChanged += new System.EventHandler(this.comboActive_SelectedIndexChanged);
            // 
            // txbUserFilterBy
            // 
            this.txbUserFilterBy.Enabled = false;
            this.txbUserFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserFilterBy.Location = new System.Drawing.Point(300, 17);
            this.txbUserFilterBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txbUserFilterBy.MaximumSize = new System.Drawing.Size(200, 24);
            this.txbUserFilterBy.Name = "txbUserFilterBy";
            this.txbUserFilterBy.Size = new System.Drawing.Size(200, 24);
            this.txbUserFilterBy.TabIndex = 16;
            this.txbUserFilterBy.Visible = false;
            this.txbUserFilterBy.TextChanged += new System.EventHandler(this.txbUserFilterBy_TextChanged);
            // 
            // cmbUserFilterBy
            // 
            this.cmbUserFilterBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUserFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserFilterBy.FormattingEnabled = true;
            this.cmbUserFilterBy.Location = new System.Drawing.Point(90, 18);
            this.cmbUserFilterBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbUserFilterBy.MaximumSize = new System.Drawing.Size(200, 0);
            this.cmbUserFilterBy.Name = "cmbUserFilterBy";
            this.cmbUserFilterBy.Size = new System.Drawing.Size(200, 24);
            this.cmbUserFilterBy.TabIndex = 15;
            this.cmbUserFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbUserFilterBy_SelectedIndexChanged);
            // 
            // ctrFilterByUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.txbUserFilterBy);
            this.Controls.Add(this.cmbUserFilterBy);
            this.Controls.Add(this.comboActive);
            this.Controls.Add(this.label1);
            this.Name = "ctrFilterByUser";
            this.Size = new System.Drawing.Size(642, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboActive;
        private System.Windows.Forms.TextBox txbUserFilterBy;
        private System.Windows.Forms.ComboBox cmbUserFilterBy;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
