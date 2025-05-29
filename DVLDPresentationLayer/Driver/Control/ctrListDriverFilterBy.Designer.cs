namespace DVLDPresentationLayer.Driver.Control
{
    partial class ctrListDriverFilterBy
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
            this.txbDriverFilterBy = new System.Windows.Forms.TextBox();
            this.cmbDriverFilterBy = new System.Windows.Forms.ComboBox();
            this.labFilterBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbDriverFilterBy
            // 
            this.txbDriverFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDriverFilterBy.Location = new System.Drawing.Point(310, 5);
            this.txbDriverFilterBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txbDriverFilterBy.Name = "txbDriverFilterBy";
            this.txbDriverFilterBy.Size = new System.Drawing.Size(200, 24);
            this.txbDriverFilterBy.TabIndex = 8;
            this.txbDriverFilterBy.Visible = false;
            this.txbDriverFilterBy.TextChanged += new System.EventHandler(this.txbDriverFilterBy_TextChanged);
            // 
            // cmbDriverFilterBy
            // 
            this.cmbDriverFilterBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDriverFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriverFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDriverFilterBy.FormattingEnabled = true;
            this.cmbDriverFilterBy.Location = new System.Drawing.Point(94, 6);
            this.cmbDriverFilterBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbDriverFilterBy.Name = "cmbDriverFilterBy";
            this.cmbDriverFilterBy.Size = new System.Drawing.Size(200, 24);
            this.cmbDriverFilterBy.TabIndex = 7;
            this.cmbDriverFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbDriverFilterBy_SelectedIndexChanged);
            // 
            // labFilterBy
            // 
            this.labFilterBy.AutoSize = true;
            this.labFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFilterBy.Location = new System.Drawing.Point(3, 6);
            this.labFilterBy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labFilterBy.Name = "labFilterBy";
            this.labFilterBy.Size = new System.Drawing.Size(75, 18);
            this.labFilterBy.TabIndex = 9;
            this.labFilterBy.Text = "Filter By:";
            // 
            // ctrListDriverFilterBy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txbDriverFilterBy);
            this.Controls.Add(this.cmbDriverFilterBy);
            this.Controls.Add(this.labFilterBy);
            this.Name = "ctrListDriverFilterBy";
            this.Size = new System.Drawing.Size(513, 35);
            this.Load += new System.EventHandler(this.ctrListDriverFilterBy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDriverFilterBy;
        private System.Windows.Forms.ComboBox cmbDriverFilterBy;
        private System.Windows.Forms.Label labFilterBy;
    }
}
