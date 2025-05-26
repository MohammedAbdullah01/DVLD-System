namespace DVLDPresentationLayer.User.Controls
{
    partial class ctrLoginInformation
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
            this.grbLoginInformation = new System.Windows.Forms.GroupBox();
            this.labValueUserName = new System.Windows.Forms.Label();
            this.labValueUserID = new System.Windows.Forms.Label();
            this.labIsActive = new System.Windows.Forms.Label();
            this.labUserId = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labValueIsActive = new System.Windows.Forms.Label();
            this.grbLoginInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLoginInformation
            // 
            this.grbLoginInformation.Controls.Add(this.labValueIsActive);
            this.grbLoginInformation.Controls.Add(this.labValueUserName);
            this.grbLoginInformation.Controls.Add(this.labValueUserID);
            this.grbLoginInformation.Controls.Add(this.labIsActive);
            this.grbLoginInformation.Controls.Add(this.labUserId);
            this.grbLoginInformation.Controls.Add(this.labUserName);
            this.grbLoginInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLoginInformation.Location = new System.Drawing.Point(3, 3);
            this.grbLoginInformation.Name = "grbLoginInformation";
            this.grbLoginInformation.Size = new System.Drawing.Size(810, 79);
            this.grbLoginInformation.TabIndex = 0;
            this.grbLoginInformation.TabStop = false;
            this.grbLoginInformation.Text = "Login Information";
            // 
            // labValueUserName
            // 
            this.labValueUserName.AutoSize = true;
            this.labValueUserName.Location = new System.Drawing.Point(437, 41);
            this.labValueUserName.Name = "labValueUserName";
            this.labValueUserName.Size = new System.Drawing.Size(35, 18);
            this.labValueUserName.TabIndex = 4;
            this.labValueUserName.Text = "???";
            // 
            // labValueUserID
            // 
            this.labValueUserID.AutoSize = true;
            this.labValueUserID.Location = new System.Drawing.Point(217, 41);
            this.labValueUserID.Name = "labValueUserID";
            this.labValueUserID.Size = new System.Drawing.Size(35, 18);
            this.labValueUserID.TabIndex = 3;
            this.labValueUserID.Text = "???";
            // 
            // labIsActive
            // 
            this.labIsActive.AutoSize = true;
            this.labIsActive.Location = new System.Drawing.Point(552, 41);
            this.labIsActive.Name = "labIsActive";
            this.labIsActive.Size = new System.Drawing.Size(76, 18);
            this.labIsActive.TabIndex = 2;
            this.labIsActive.Text = "Is Active:";
            // 
            // labUserId
            // 
            this.labUserId.AutoSize = true;
            this.labUserId.Location = new System.Drawing.Point(141, 41);
            this.labUserId.Name = "labUserId";
            this.labUserId.Size = new System.Drawing.Size(70, 18);
            this.labUserId.TabIndex = 1;
            this.labUserId.Text = "User ID:";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Location = new System.Drawing.Point(338, 41);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(93, 18);
            this.labUserName.TabIndex = 0;
            this.labUserName.Text = "UserName:";
            // 
            // labValueIsActive
            // 
            this.labValueIsActive.AutoSize = true;
            this.labValueIsActive.Location = new System.Drawing.Point(634, 41);
            this.labValueIsActive.Name = "labValueIsActive";
            this.labValueIsActive.Size = new System.Drawing.Size(35, 18);
            this.labValueIsActive.TabIndex = 5;
            this.labValueIsActive.Text = "???";
            // 
            // ctrLoginInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbLoginInformation);
            this.Name = "ctrLoginInformation";
            this.Size = new System.Drawing.Size(820, 90);
            this.grbLoginInformation.ResumeLayout(false);
            this.grbLoginInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLoginInformation;
        private System.Windows.Forms.Label labUserName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labValueUserName;
        private System.Windows.Forms.Label labValueUserID;
        private System.Windows.Forms.Label labIsActive;
        private System.Windows.Forms.Label labUserId;
        private System.Windows.Forms.Label labValueIsActive;
    }
}
