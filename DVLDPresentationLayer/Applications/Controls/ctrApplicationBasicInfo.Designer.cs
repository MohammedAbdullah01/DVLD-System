namespace DVLDPresentationLayer.Applications.Controls
{
    partial class ctrApplicationBasicInfo
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
            this.grbApplicationBasicInfo = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labID = new System.Windows.Forms.Label();
            this.labStatus = new System.Windows.Forms.Label();
            this.labType = new System.Windows.Forms.Label();
            this.labApplicant = new System.Windows.Forms.Label();
            this.labFees = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.labStatusDate = new System.Windows.Forms.Label();
            this.labCreatedBy = new System.Windows.Forms.Label();
            this.labLinkViewPersonInfo = new System.Windows.Forms.LinkLabel();
            this.labValueID = new System.Windows.Forms.Label();
            this.labValueStatus = new System.Windows.Forms.Label();
            this.labValueType = new System.Windows.Forms.Label();
            this.labValueApplicant = new System.Windows.Forms.Label();
            this.labVAlueFees = new System.Windows.Forms.Label();
            this.labValueDate = new System.Windows.Forms.Label();
            this.labValueStatusDate = new System.Windows.Forms.Label();
            this.labVAlueCreatedBy = new System.Windows.Forms.Label();
            this.grbApplicationBasicInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbApplicationBasicInfo
            // 
            this.grbApplicationBasicInfo.Controls.Add(this.labVAlueCreatedBy);
            this.grbApplicationBasicInfo.Controls.Add(this.labValueStatusDate);
            this.grbApplicationBasicInfo.Controls.Add(this.labValueDate);
            this.grbApplicationBasicInfo.Controls.Add(this.labVAlueFees);
            this.grbApplicationBasicInfo.Controls.Add(this.labValueApplicant);
            this.grbApplicationBasicInfo.Controls.Add(this.labValueType);
            this.grbApplicationBasicInfo.Controls.Add(this.labValueStatus);
            this.grbApplicationBasicInfo.Controls.Add(this.labValueID);
            this.grbApplicationBasicInfo.Controls.Add(this.labLinkViewPersonInfo);
            this.grbApplicationBasicInfo.Controls.Add(this.labCreatedBy);
            this.grbApplicationBasicInfo.Controls.Add(this.labStatusDate);
            this.grbApplicationBasicInfo.Controls.Add(this.labDate);
            this.grbApplicationBasicInfo.Controls.Add(this.labFees);
            this.grbApplicationBasicInfo.Controls.Add(this.labApplicant);
            this.grbApplicationBasicInfo.Controls.Add(this.labType);
            this.grbApplicationBasicInfo.Controls.Add(this.labStatus);
            this.grbApplicationBasicInfo.Controls.Add(this.labID);
            this.grbApplicationBasicInfo.Location = new System.Drawing.Point(5, 6);
            this.grbApplicationBasicInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbApplicationBasicInfo.Name = "grbApplicationBasicInfo";
            this.grbApplicationBasicInfo.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbApplicationBasicInfo.Size = new System.Drawing.Size(715, 254);
            this.grbApplicationBasicInfo.TabIndex = 0;
            this.grbApplicationBasicInfo.TabStop = false;
            this.grbApplicationBasicInfo.Text = "Application Basic Info";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(54, 55);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(29, 18);
            this.labID.TabIndex = 0;
            this.labID.Text = "ID:";
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(54, 112);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(61, 18);
            this.labStatus.TabIndex = 1;
            this.labStatus.Text = "Status:";
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Location = new System.Drawing.Point(54, 169);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(49, 18);
            this.labType.TabIndex = 2;
            this.labType.Text = "Type:";
            // 
            // labApplicant
            // 
            this.labApplicant.AutoSize = true;
            this.labApplicant.Location = new System.Drawing.Point(54, 226);
            this.labApplicant.Name = "labApplicant";
            this.labApplicant.Size = new System.Drawing.Size(81, 18);
            this.labApplicant.TabIndex = 3;
            this.labApplicant.Text = "Applicant:";
            // 
            // labFees
            // 
            this.labFees.AutoSize = true;
            this.labFees.Location = new System.Drawing.Point(476, 55);
            this.labFees.Name = "labFees";
            this.labFees.Size = new System.Drawing.Size(50, 18);
            this.labFees.TabIndex = 4;
            this.labFees.Text = "Fees:";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Location = new System.Drawing.Point(476, 112);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(48, 18);
            this.labDate.TabIndex = 5;
            this.labDate.Text = "Date:";
            // 
            // labStatusDate
            // 
            this.labStatusDate.AutoSize = true;
            this.labStatusDate.Location = new System.Drawing.Point(476, 169);
            this.labStatusDate.Name = "labStatusDate";
            this.labStatusDate.Size = new System.Drawing.Size(101, 18);
            this.labStatusDate.TabIndex = 6;
            this.labStatusDate.Text = "Status Date:";
            // 
            // labCreatedBy
            // 
            this.labCreatedBy.AutoSize = true;
            this.labCreatedBy.Location = new System.Drawing.Point(476, 226);
            this.labCreatedBy.Name = "labCreatedBy";
            this.labCreatedBy.Size = new System.Drawing.Size(96, 18);
            this.labCreatedBy.TabIndex = 7;
            this.labCreatedBy.Text = "Created By:";
            // 
            // labLinkViewPersonInfo
            // 
            this.labLinkViewPersonInfo.AutoSize = true;
            this.labLinkViewPersonInfo.Location = new System.Drawing.Point(572, 21);
            this.labLinkViewPersonInfo.Name = "labLinkViewPersonInfo";
            this.labLinkViewPersonInfo.Size = new System.Drawing.Size(135, 18);
            this.labLinkViewPersonInfo.TabIndex = 8;
            this.labLinkViewPersonInfo.TabStop = true;
            this.labLinkViewPersonInfo.Text = "View Person Info";
            // 
            // labValueID
            // 
            this.labValueID.AutoSize = true;
            this.labValueID.Location = new System.Drawing.Point(141, 55);
            this.labValueID.Name = "labValueID";
            this.labValueID.Size = new System.Drawing.Size(35, 18);
            this.labValueID.TabIndex = 9;
            this.labValueID.Text = "???";
            // 
            // labValueStatus
            // 
            this.labValueStatus.AutoSize = true;
            this.labValueStatus.Location = new System.Drawing.Point(141, 112);
            this.labValueStatus.Name = "labValueStatus";
            this.labValueStatus.Size = new System.Drawing.Size(35, 18);
            this.labValueStatus.TabIndex = 10;
            this.labValueStatus.Text = "???";
            // 
            // labValueType
            // 
            this.labValueType.AutoSize = true;
            this.labValueType.Location = new System.Drawing.Point(141, 169);
            this.labValueType.Name = "labValueType";
            this.labValueType.Size = new System.Drawing.Size(35, 18);
            this.labValueType.TabIndex = 11;
            this.labValueType.Text = "???";
            // 
            // labValueApplicant
            // 
            this.labValueApplicant.AutoSize = true;
            this.labValueApplicant.Location = new System.Drawing.Point(141, 226);
            this.labValueApplicant.Name = "labValueApplicant";
            this.labValueApplicant.Size = new System.Drawing.Size(35, 18);
            this.labValueApplicant.TabIndex = 12;
            this.labValueApplicant.Text = "???";
            // 
            // labVAlueFees
            // 
            this.labVAlueFees.AutoSize = true;
            this.labVAlueFees.Location = new System.Drawing.Point(585, 55);
            this.labVAlueFees.Name = "labVAlueFees";
            this.labVAlueFees.Size = new System.Drawing.Size(35, 18);
            this.labVAlueFees.TabIndex = 13;
            this.labVAlueFees.Text = "???";
            // 
            // labValueDate
            // 
            this.labValueDate.AutoSize = true;
            this.labValueDate.Location = new System.Drawing.Point(585, 112);
            this.labValueDate.Name = "labValueDate";
            this.labValueDate.Size = new System.Drawing.Size(35, 18);
            this.labValueDate.TabIndex = 14;
            this.labValueDate.Text = "???";
            // 
            // labValueStatusDate
            // 
            this.labValueStatusDate.AutoSize = true;
            this.labValueStatusDate.Location = new System.Drawing.Point(585, 169);
            this.labValueStatusDate.Name = "labValueStatusDate";
            this.labValueStatusDate.Size = new System.Drawing.Size(35, 18);
            this.labValueStatusDate.TabIndex = 15;
            this.labValueStatusDate.Text = "???";
            // 
            // labVAlueCreatedBy
            // 
            this.labVAlueCreatedBy.AutoSize = true;
            this.labVAlueCreatedBy.Location = new System.Drawing.Point(585, 226);
            this.labVAlueCreatedBy.Name = "labVAlueCreatedBy";
            this.labVAlueCreatedBy.Size = new System.Drawing.Size(35, 18);
            this.labVAlueCreatedBy.TabIndex = 16;
            this.labVAlueCreatedBy.Text = "???";
            // 
            // ctrApplicationBasicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbApplicationBasicInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ctrApplicationBasicInfo";
            this.Size = new System.Drawing.Size(725, 267);
            this.grbApplicationBasicInfo.ResumeLayout(false);
            this.grbApplicationBasicInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbApplicationBasicInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel labLinkViewPersonInfo;
        private System.Windows.Forms.Label labCreatedBy;
        private System.Windows.Forms.Label labStatusDate;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label labFees;
        private System.Windows.Forms.Label labApplicant;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labValueStatus;
        private System.Windows.Forms.Label labValueID;
        private System.Windows.Forms.Label labValueType;
        private System.Windows.Forms.Label labValueApplicant;
        private System.Windows.Forms.Label labVAlueFees;
        private System.Windows.Forms.Label labValueDate;
        private System.Windows.Forms.Label labVAlueCreatedBy;
        private System.Windows.Forms.Label labValueStatusDate;
    }
}
