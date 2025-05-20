namespace DVLDPresentationLayer.UserControls
{
    partial class ctrPersonCardWithFilter
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
            this.ctrlPersonCard1 = new DVLDPresentationLayer.UserControls.ctrlPersonCard();
            this.ctrPersonFilterBy1 = new DVLDPresentationLayer.Persons.Controls.ctrPersonFilterBy();
            this.SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 129);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(641, 336);
            this.ctrlPersonCard1.TabIndex = 4;
            // 
            // ctrPersonFilterBy1
            // 
            this.ctrPersonFilterBy1.AutoSize = true;
            this.ctrPersonFilterBy1.Location = new System.Drawing.Point(12, 22);
            this.ctrPersonFilterBy1.Name = "ctrPersonFilterBy1";
            this.ctrPersonFilterBy1.Size = new System.Drawing.Size(601, 101);
            this.ctrPersonFilterBy1.TabIndex = 5;
            // 
            // ctrPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrPersonFilterBy1);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrPersonCardWithFilter";
            this.Size = new System.Drawing.Size(650, 466);
            this.Load += new System.EventHandler(this.ctrPersonCardWithFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private Persons.Controls.ctrPersonFilterBy ctrPersonFilterBy1;
    }
}
