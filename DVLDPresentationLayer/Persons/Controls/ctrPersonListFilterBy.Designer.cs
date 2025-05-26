namespace DVLDPresentationLayer.Persons.Controls
{
    partial class ctrPersonListFilterBy
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
            this.txbPersonFilterBy = new System.Windows.Forms.TextBox();
            this.cmbPersonFilterBy = new System.Windows.Forms.ComboBox();
            this.labFilterBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbPersonFilterBy
            // 
            this.txbPersonFilterBy.Enabled = false;
            this.txbPersonFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPersonFilterBy.Location = new System.Drawing.Point(314, 15);
            this.txbPersonFilterBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txbPersonFilterBy.Name = "txbPersonFilterBy";
            this.txbPersonFilterBy.Size = new System.Drawing.Size(200, 24);
            this.txbPersonFilterBy.TabIndex = 2;
            this.txbPersonFilterBy.TextChanged += new System.EventHandler(this.txbPersonFilterBy_TextChanged);
            // 
            // cmbPersonFilterBy
            // 
            this.cmbPersonFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersonFilterBy.FormattingEnabled = true;
            this.cmbPersonFilterBy.Location = new System.Drawing.Point(89, 16);
            this.cmbPersonFilterBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbPersonFilterBy.Name = "cmbPersonFilterBy";
            this.cmbPersonFilterBy.Size = new System.Drawing.Size(200, 24);
            this.cmbPersonFilterBy.TabIndex = 1;
            this.cmbPersonFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // labFilterBy
            // 
            this.labFilterBy.AutoSize = true;
            this.labFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFilterBy.Location = new System.Drawing.Point(7, 16);
            this.labFilterBy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labFilterBy.Name = "labFilterBy";
            this.labFilterBy.Size = new System.Drawing.Size(75, 18);
            this.labFilterBy.TabIndex = 6;
            this.labFilterBy.Text = "Filter By:";
            // 
            // ctrPersonListFilterBy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txbPersonFilterBy);
            this.Controls.Add(this.cmbPersonFilterBy);
            this.Controls.Add(this.labFilterBy);
            this.Name = "ctrPersonListFilterBy";
            this.Size = new System.Drawing.Size(528, 50);
            this.Load += new System.EventHandler(this.ctrPersonListFilterBy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPersonFilterBy;
        private System.Windows.Forms.ComboBox cmbPersonFilterBy;
        private System.Windows.Forms.Label labFilterBy;
    }
}
