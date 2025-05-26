namespace DVLDPresentationLayer.User.Controls
{
    partial class ctrChangePassword
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
            this.labCurrentPassword = new System.Windows.Forms.Label();
            this.labNewPassword = new System.Windows.Forms.Label();
            this.labConfirmPassword = new System.Windows.Forms.Label();
            this.txbCurrentPassword = new System.Windows.Forms.TextBox();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.txbConfirmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labCurrentPassword
            // 
            this.labCurrentPassword.AutoSize = true;
            this.labCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCurrentPassword.Location = new System.Drawing.Point(10, 29);
            this.labCurrentPassword.Name = "labCurrentPassword";
            this.labCurrentPassword.Size = new System.Drawing.Size(149, 18);
            this.labCurrentPassword.TabIndex = 0;
            this.labCurrentPassword.Text = "Current Password:";
            // 
            // labNewPassword
            // 
            this.labNewPassword.AutoSize = true;
            this.labNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNewPassword.Location = new System.Drawing.Point(10, 92);
            this.labNewPassword.Name = "labNewPassword";
            this.labNewPassword.Size = new System.Drawing.Size(126, 18);
            this.labNewPassword.TabIndex = 1;
            this.labNewPassword.Text = "New Password:";
            // 
            // labConfirmPassword
            // 
            this.labConfirmPassword.AutoSize = true;
            this.labConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConfirmPassword.Location = new System.Drawing.Point(10, 155);
            this.labConfirmPassword.Name = "labConfirmPassword";
            this.labConfirmPassword.Size = new System.Drawing.Size(153, 18);
            this.labConfirmPassword.TabIndex = 2;
            this.labConfirmPassword.Text = "Confirm Password:";
            // 
            // txbCurrentPassword
            // 
            this.txbCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCurrentPassword.Location = new System.Drawing.Point(181, 22);
            this.txbCurrentPassword.Name = "txbCurrentPassword";
            this.txbCurrentPassword.Size = new System.Drawing.Size(240, 29);
            this.txbCurrentPassword.TabIndex = 3;
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewPassword.Location = new System.Drawing.Point(181, 85);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Size = new System.Drawing.Size(240, 29);
            this.txbNewPassword.TabIndex = 4;
            // 
            // txbConfirmPassword
            // 
            this.txbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfirmPassword.Location = new System.Drawing.Point(181, 148);
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            this.txbConfirmPassword.Size = new System.Drawing.Size(240, 29);
            this.txbConfirmPassword.TabIndex = 5;
            // 
            // ctrChangePassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txbConfirmPassword);
            this.Controls.Add(this.txbNewPassword);
            this.Controls.Add(this.txbCurrentPassword);
            this.Controls.Add(this.labConfirmPassword);
            this.Controls.Add(this.labNewPassword);
            this.Controls.Add(this.labCurrentPassword);
            this.Name = "ctrChangePassword";
            this.Size = new System.Drawing.Size(431, 199);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCurrentPassword;
        private System.Windows.Forms.Label labNewPassword;
        private System.Windows.Forms.Label labConfirmPassword;
        private System.Windows.Forms.TextBox txbCurrentPassword;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.TextBox txbConfirmPassword;
    }
}
