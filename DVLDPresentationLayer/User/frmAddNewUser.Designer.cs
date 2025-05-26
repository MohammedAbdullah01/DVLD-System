namespace DVLDPresentationLayer.User
{
    partial class frmAddNewUser
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
            this.tabControlPersonInfo = new System.Windows.Forms.TabControl();
            this.tabPagePersonInfo = new System.Windows.Forms.TabPage();
            this.btnNextAddUser = new System.Windows.Forms.Button();
            this.tabPageLoginInfo = new System.Windows.Forms.TabPage();
            this.chbIsActive = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labUserIDValue = new System.Windows.Forms.Label();
            this.labConfirmPassword = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.labUserId = new System.Windows.Forms.Label();
            this.btnSaveAddUser = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.ctrHeaderTitleControl1 = new DVLDPresentationLayer.Controls.ctrHeaderTitleControl();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.ctrPersonCardWithFilter1 = new DVLDPresentationLayer.UserControls.ctrPersonCardWithFilter();
            this.tabControlPersonInfo.SuspendLayout();
            this.tabPagePersonInfo.SuspendLayout();
            this.tabPageLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPersonInfo
            // 
            this.tabControlPersonInfo.Controls.Add(this.tabPagePersonInfo);
            this.tabControlPersonInfo.Controls.Add(this.tabPageLoginInfo);
            this.tabControlPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPersonInfo.Location = new System.Drawing.Point(11, 51);
            this.tabControlPersonInfo.Name = "tabControlPersonInfo";
            this.tabControlPersonInfo.SelectedIndex = 0;
            this.tabControlPersonInfo.Size = new System.Drawing.Size(860, 503);
            this.tabControlPersonInfo.TabIndex = 0;
            // 
            // tabPagePersonInfo
            // 
            this.tabPagePersonInfo.Controls.Add(this.ctrPersonCardWithFilter1);
            this.tabPagePersonInfo.Controls.Add(this.btnNextAddUser);
            this.tabPagePersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPagePersonInfo.Name = "tabPagePersonInfo";
            this.tabPagePersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonInfo.Size = new System.Drawing.Size(852, 474);
            this.tabPagePersonInfo.TabIndex = 0;
            this.tabPagePersonInfo.Text = "Person Info";
            this.tabPagePersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNextAddUser
            // 
            this.btnNextAddUser.BackColor = System.Drawing.Color.Navy;
            this.btnNextAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextAddUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnNextAddUser.Location = new System.Drawing.Point(767, 434);
            this.btnNextAddUser.Name = "btnNextAddUser";
            this.btnNextAddUser.Size = new System.Drawing.Size(67, 32);
            this.btnNextAddUser.TabIndex = 2;
            this.btnNextAddUser.Text = "Next";
            this.btnNextAddUser.UseVisualStyleBackColor = false;
            this.btnNextAddUser.Click += new System.EventHandler(this.btnNextAddUser_Click);
            // 
            // tabPageLoginInfo
            // 
            this.tabPageLoginInfo.Controls.Add(this.btnBack);
            this.tabPageLoginInfo.Controls.Add(this.chbIsActive);
            this.tabPageLoginInfo.Controls.Add(this.textBox3);
            this.tabPageLoginInfo.Controls.Add(this.textBox2);
            this.tabPageLoginInfo.Controls.Add(this.textBox1);
            this.tabPageLoginInfo.Controls.Add(this.labUserIDValue);
            this.tabPageLoginInfo.Controls.Add(this.labConfirmPassword);
            this.tabPageLoginInfo.Controls.Add(this.labPassword);
            this.tabPageLoginInfo.Controls.Add(this.labUserName);
            this.tabPageLoginInfo.Controls.Add(this.labUserId);
            this.tabPageLoginInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPageLoginInfo.Name = "tabPageLoginInfo";
            this.tabPageLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoginInfo.Size = new System.Drawing.Size(852, 474);
            this.tabPageLoginInfo.TabIndex = 1;
            this.tabPageLoginInfo.Text = "Login Info";
            this.tabPageLoginInfo.UseVisualStyleBackColor = true;
            // 
            // chbIsActive
            // 
            this.chbIsActive.AutoSize = true;
            this.chbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIsActive.Location = new System.Drawing.Point(256, 215);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(90, 22);
            this.chbIsActive.TabIndex = 8;
            this.chbIsActive.Text = "Is Active";
            this.chbIsActive.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(256, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 24);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(256, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 24);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(256, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 24);
            this.textBox1.TabIndex = 5;
            // 
            // labUserIDValue
            // 
            this.labUserIDValue.AutoSize = true;
            this.labUserIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserIDValue.Location = new System.Drawing.Point(256, 45);
            this.labUserIDValue.Name = "labUserIDValue";
            this.labUserIDValue.Size = new System.Drawing.Size(35, 18);
            this.labUserIDValue.TabIndex = 4;
            this.labUserIDValue.Text = "???";
            // 
            // labConfirmPassword
            // 
            this.labConfirmPassword.AutoSize = true;
            this.labConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConfirmPassword.Location = new System.Drawing.Point(38, 175);
            this.labConfirmPassword.Name = "labConfirmPassword";
            this.labConfirmPassword.Size = new System.Drawing.Size(153, 18);
            this.labConfirmPassword.TabIndex = 3;
            this.labConfirmPassword.Text = "Confirm Password:";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.Location = new System.Drawing.Point(108, 131);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(88, 18);
            this.labPassword.TabIndex = 2;
            this.labPassword.Text = "Password:";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.Location = new System.Drawing.Point(98, 87);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(93, 18);
            this.labUserName.TabIndex = 1;
            this.labUserName.Text = "UserName:";
            // 
            // labUserId
            // 
            this.labUserId.AutoSize = true;
            this.labUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserId.Location = new System.Drawing.Point(126, 43);
            this.labUserId.Name = "labUserId";
            this.labUserId.Size = new System.Drawing.Size(65, 18);
            this.labUserId.TabIndex = 0;
            this.labUserId.Text = "UserID:";
            // 
            // btnSaveAddUser
            // 
            this.btnSaveAddUser.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSaveAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAddUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnSaveAddUser.Location = new System.Drawing.Point(800, 560);
            this.btnSaveAddUser.Name = "btnSaveAddUser";
            this.btnSaveAddUser.Size = new System.Drawing.Size(67, 30);
            this.btnSaveAddUser.TabIndex = 1;
            this.btnSaveAddUser.Text = "Save";
            this.btnSaveAddUser.UseVisualStyleBackColor = false;
            this.btnSaveAddUser.Click += new System.EventHandler(this.btnSaveAddUser_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Navy;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(779, 436);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 32);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ctrHeaderTitleControl1
            // 
            this.ctrHeaderTitleControl1.Location = new System.Drawing.Point(282, 12);
            this.ctrHeaderTitleControl1.Name = "ctrHeaderTitleControl1";
            this.ctrHeaderTitleControl1.Size = new System.Drawing.Size(361, 55);
            this.ctrHeaderTitleControl1.TabIndex = 2;
            this.ctrHeaderTitleControl1.Title = "Header Title ";
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(715, 560);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(79, 30);
            this.ctrButtonClose1.TabIndex = 0;
            // 
            // ctrPersonCardWithFilter1
            // 
            this.ctrPersonCardWithFilter1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrPersonCardWithFilter1.Location = new System.Drawing.Point(10, 8);
            this.ctrPersonCardWithFilter1.Name = "ctrPersonCardWithFilter1";
            this.ctrPersonCardWithFilter1.Size = new System.Drawing.Size(832, 420);
            this.ctrPersonCardWithFilter1.TabIndex = 3;
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 598);
            this.Controls.Add(this.ctrHeaderTitleControl1);
            this.Controls.Add(this.btnSaveAddUser);
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.tabControlPersonInfo);
            this.Name = "frmAddNewUser";
            this.Text = "Add New User";
            this.tabControlPersonInfo.ResumeLayout(false);
            this.tabPagePersonInfo.ResumeLayout(false);
            this.tabPageLoginInfo.ResumeLayout(false);
            this.tabPageLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPersonInfo;
        private System.Windows.Forms.TabPage tabPagePersonInfo;
        private System.Windows.Forms.TabPage tabPageLoginInfo;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
        private System.Windows.Forms.Button btnSaveAddUser;
        private System.Windows.Forms.Button btnNextAddUser;
        private System.Windows.Forms.Label labConfirmPassword;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labUserId;
        private System.Windows.Forms.Label labUserIDValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox chbIsActive;
        private DVLDPresentationLayer.Controls.ctrHeaderTitleControl ctrHeaderTitleControl1;
        private UserControls.ctrPersonCardWithFilter ctrPersonCardWithFilter1;
        private System.Windows.Forms.Button btnBack;
    }
}