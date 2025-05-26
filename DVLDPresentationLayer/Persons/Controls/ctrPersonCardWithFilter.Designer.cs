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
            this.ctrPersonFilterBy1 = new DVLDPresentationLayer.Persons.Controls.ctrPersonFilterBy();
            this.ctrlPersonCard1 = new DVLDPresentationLayer.UserControls.ctrlPersonCard();
            this.SuspendLayout();
            // 
            // ctrPersonFilterBy1
            // 
            this.ctrPersonFilterBy1.Location = new System.Drawing.Point(6, 3);
            this.ctrPersonFilterBy1.Name = "ctrPersonFilterBy1";
            this.ctrPersonFilterBy1.Size = new System.Drawing.Size(602, 39);
            this.ctrPersonFilterBy1.TabIndex = 5;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(6, 48);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(820, 369);
            this.ctrlPersonCard1.TabIndex = 6;
            // 
            // ctrPersonCardWithFilter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.ctrPersonFilterBy1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ctrPersonCardWithFilter";
            this.Size = new System.Drawing.Size(832, 420);
            this.ResumeLayout(false);

        }

        #endregion
        private Persons.Controls.ctrPersonFilterBy ctrPersonFilterBy1;
        private ctrlPersonCard ctrlPersonCard1;
    }
}
