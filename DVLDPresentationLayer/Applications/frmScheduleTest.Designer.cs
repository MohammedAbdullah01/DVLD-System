namespace DVLDPresentationLayer.Applications
{
    partial class frmScheduleTest
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
            this.ctrScheduleTest1 = new DVLDPresentationLayer.Applications.Controls.ctrScheduleTest();
            this.SuspendLayout();
            // 
            // ctrScheduleTest1
            // 
            this.ctrScheduleTest1.Date = "5/28/2025";
            this.ctrScheduleTest1.DrivingClass = "???";
            this.ctrScheduleTest1.DrivingLicenseAppID = "???";
            this.ctrScheduleTest1.Fees = "???";
            this.ctrScheduleTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrScheduleTest1.FullName = "???";
            this.ctrScheduleTest1.Location = new System.Drawing.Point(14, 8);
            this.ctrScheduleTest1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrScheduleTest1.Name = "ctrScheduleTest1";
            this.ctrScheduleTest1.Size = new System.Drawing.Size(545, 610);
            this.ctrScheduleTest1.TabIndex = 0;
            this.ctrScheduleTest1.TitleGroupBox = "Header Title";
            this.ctrScheduleTest1.Trial = "???";
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 626);
            this.Controls.Add(this.ctrScheduleTest1);
            this.Name = "frmScheduleTest";
            this.Text = "Schedule Test";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrScheduleTest ctrScheduleTest1;
    }
}