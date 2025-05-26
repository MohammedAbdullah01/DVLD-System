namespace DVLDPresentationLayer.User
{
    partial class frmUserDetails
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.ctrlPersonCard1 = new DVLDPresentationLayer.UserControls.ctrlPersonCard();
            this.ctrLoginInformation1 = new DVLDPresentationLayer.User.Controls.ctrLoginInformation();
            this.SuspendLayout();
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(751, 487);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(83, 32);
            this.ctrButtonClose1.TabIndex = 0;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(11, 12);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(820, 369);
            this.ctrlPersonCard1.TabIndex = 1;
            // 
            // ctrLoginInformation1
            // 
            this.ctrLoginInformation1.Location = new System.Drawing.Point(11, 396);
            this.ctrLoginInformation1.Name = "ctrLoginInformation1";
            this.ctrLoginInformation1.Size = new System.Drawing.Size(820, 85);
            this.ctrLoginInformation1.TabIndex = 2;
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 526);
            this.Controls.Add(this.ctrLoginInformation1);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.ctrButtonClose1);
            this.Name = "frmUserDetails";
            this.Text = "User Details";
            this.ResumeLayout(false);

        }

        #endregion

        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
        private UserControls.ctrlPersonCard ctrlPersonCard1;
        private Controls.ctrLoginInformation ctrLoginInformation1;
    }
}