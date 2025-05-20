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
            this.txbInputFilterByPerson = new System.Windows.Forms.TextBox();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.labFilterBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbInputFilterByPerson
            // 
            this.txbInputFilterByPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInputFilterByPerson.Location = new System.Drawing.Point(314, 15);
            this.txbInputFilterByPerson.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txbInputFilterByPerson.Name = "txbInputFilterByPerson";
            this.txbInputFilterByPerson.Size = new System.Drawing.Size(200, 24);
            this.txbInputFilterByPerson.TabIndex = 7;
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Location = new System.Drawing.Point(89, 16);
            this.cmbFilterBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(200, 24);
            this.cmbFilterBy.TabIndex = 5;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // labFilterBy
            // 
            this.labFilterBy.AutoSize = true;
            this.labFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFilterBy.Location = new System.Drawing.Point(11, 16);
            this.labFilterBy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labFilterBy.Name = "labFilterBy";
            this.labFilterBy.Size = new System.Drawing.Size(75, 18);
            this.labFilterBy.TabIndex = 6;
            this.labFilterBy.Text = "Filter By:";
            // 
            // ctrPersonListFilterBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbInputFilterByPerson);
            this.Controls.Add(this.cmbFilterBy);
            this.Controls.Add(this.labFilterBy);
            this.Name = "ctrPersonListFilterBy";
            this.Size = new System.Drawing.Size(546, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbInputFilterByPerson;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.Label labFilterBy;
    }
}
