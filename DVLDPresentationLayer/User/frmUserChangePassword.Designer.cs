namespace DVLDPresentationLayer.User
{
    partial class frmUserChangePassword
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
            this.ctrLoginInformation1 = new DVLDPresentationLayer.User.Controls.ctrLoginInformation();
            this.ctrChangePassword1 = new DVLDPresentationLayer.User.Controls.ctrChangePassword();
            this.ctrlPersonCard1 = new DVLDPresentationLayer.UserControls.ctrlPersonCard();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.btnSaveAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrLoginInformation1
            // 
            this.ctrLoginInformation1.Location = new System.Drawing.Point(12, 405);
            this.ctrLoginInformation1.Name = "ctrLoginInformation1";
            this.ctrLoginInformation1.Size = new System.Drawing.Size(820, 90);
            this.ctrLoginInformation1.TabIndex = 3;
            // 
            // ctrChangePassword1
            // 
            this.ctrChangePassword1.Location = new System.Drawing.Point(9, 501);
            this.ctrChangePassword1.Name = "ctrChangePassword1";
            this.ctrChangePassword1.Size = new System.Drawing.Size(820, 180);
            this.ctrChangePassword1.TabIndex = 2;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(9, 30);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(820, 369);
            this.ctrlPersonCard1.TabIndex = 1;
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(670, 687);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(83, 32);
            this.ctrButtonClose1.TabIndex = 4;
            // 
            // btnSaveAddUser
            // 
            this.btnSaveAddUser.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSaveAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAddUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnSaveAddUser.Location = new System.Drawing.Point(759, 689);
            this.btnSaveAddUser.Name = "btnSaveAddUser";
            this.btnSaveAddUser.Size = new System.Drawing.Size(67, 30);
            this.btnSaveAddUser.TabIndex = 5;
            this.btnSaveAddUser.Text = "Save";
            this.btnSaveAddUser.UseVisualStyleBackColor = false;
            // 
            // frmUserChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(838, 724);
            this.Controls.Add(this.btnSaveAddUser);
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.ctrLoginInformation1);
            this.Controls.Add(this.ctrChangePassword1);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmUserChangePassword";
            this.Text = "Change Password";
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.ctrlPersonCard ctrlPersonCard1;
        private Controls.ctrChangePassword ctrChangePassword1;
        private Controls.ctrLoginInformation ctrLoginInformation1;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
        private System.Windows.Forms.Button btnSaveAddUser;
    }
}