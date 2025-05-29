namespace DVLDPresentationLayer.Applications.Controls
{
    partial class ctrRetakeTestInfo
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
            this.grbRetakeTestInfo = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labRetakeAppFees = new System.Windows.Forms.Label();
            this.labTotalFees = new System.Windows.Forms.Label();
            this.labRTestAppID = new System.Windows.Forms.Label();
            this.labValueRetakeAppFees = new System.Windows.Forms.Label();
            this.labValueTotalFees = new System.Windows.Forms.Label();
            this.labValueRTestAppID = new System.Windows.Forms.Label();
            this.grbRetakeTestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRetakeTestInfo
            // 
            this.grbRetakeTestInfo.Controls.Add(this.labValueRTestAppID);
            this.grbRetakeTestInfo.Controls.Add(this.labValueTotalFees);
            this.grbRetakeTestInfo.Controls.Add(this.labValueRetakeAppFees);
            this.grbRetakeTestInfo.Controls.Add(this.labRTestAppID);
            this.grbRetakeTestInfo.Controls.Add(this.labTotalFees);
            this.grbRetakeTestInfo.Controls.Add(this.labRetakeAppFees);
            this.grbRetakeTestInfo.Location = new System.Drawing.Point(0, 0);
            this.grbRetakeTestInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbRetakeTestInfo.Name = "grbRetakeTestInfo";
            this.grbRetakeTestInfo.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbRetakeTestInfo.Size = new System.Drawing.Size(493, 116);
            this.grbRetakeTestInfo.TabIndex = 0;
            this.grbRetakeTestInfo.TabStop = false;
            this.grbRetakeTestInfo.Text = "Retake Test Info";
            // 
            // labRetakeAppFees
            // 
            this.labRetakeAppFees.AutoSize = true;
            this.labRetakeAppFees.Location = new System.Drawing.Point(28, 38);
            this.labRetakeAppFees.Name = "labRetakeAppFees";
            this.labRetakeAppFees.Size = new System.Drawing.Size(100, 18);
            this.labRetakeAppFees.TabIndex = 0;
            this.labRetakeAppFees.Text = "R.App.Fees:";
            // 
            // labTotalFees
            // 
            this.labTotalFees.AutoSize = true;
            this.labTotalFees.Location = new System.Drawing.Point(296, 60);
            this.labTotalFees.Name = "labTotalFees";
            this.labTotalFees.Size = new System.Drawing.Size(93, 18);
            this.labTotalFees.TabIndex = 1;
            this.labTotalFees.Text = "Total Fees:";
            // 
            // labRTestAppID
            // 
            this.labRTestAppID.AutoSize = true;
            this.labRTestAppID.Location = new System.Drawing.Point(28, 82);
            this.labRTestAppID.Name = "labRTestAppID";
            this.labRTestAppID.Size = new System.Drawing.Size(117, 18);
            this.labRTestAppID.TabIndex = 2;
            this.labRTestAppID.Text = "R.Test.App.ID:";
            // 
            // labValueRetakeAppFees
            // 
            this.labValueRetakeAppFees.AutoSize = true;
            this.labValueRetakeAppFees.Location = new System.Drawing.Point(164, 38);
            this.labValueRetakeAppFees.Name = "labValueRetakeAppFees";
            this.labValueRetakeAppFees.Size = new System.Drawing.Size(35, 18);
            this.labValueRetakeAppFees.TabIndex = 3;
            this.labValueRetakeAppFees.Text = "???";
            // 
            // labValueTotalFees
            // 
            this.labValueTotalFees.AutoSize = true;
            this.labValueTotalFees.Location = new System.Drawing.Point(405, 60);
            this.labValueTotalFees.Name = "labValueTotalFees";
            this.labValueTotalFees.Size = new System.Drawing.Size(35, 18);
            this.labValueTotalFees.TabIndex = 4;
            this.labValueTotalFees.Text = "???";
            // 
            // labValueRTestAppID
            // 
            this.labValueRTestAppID.AutoSize = true;
            this.labValueRTestAppID.Location = new System.Drawing.Point(164, 82);
            this.labValueRTestAppID.Name = "labValueRTestAppID";
            this.labValueRTestAppID.Size = new System.Drawing.Size(35, 18);
            this.labValueRTestAppID.TabIndex = 5;
            this.labValueRTestAppID.Text = "???";
            // 
            // ctrRetakeTestInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbRetakeTestInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ctrRetakeTestInfo";
            this.Size = new System.Drawing.Size(493, 116);
            this.grbRetakeTestInfo.ResumeLayout(false);
            this.grbRetakeTestInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRetakeTestInfo;
        private System.Windows.Forms.Label labRTestAppID;
        private System.Windows.Forms.Label labTotalFees;
        private System.Windows.Forms.Label labRetakeAppFees;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labValueRetakeAppFees;
        private System.Windows.Forms.Label labValueTotalFees;
        private System.Windows.Forms.Label labValueRTestAppID;
    }
}
