using System;

namespace DVLDPresentationLayer.Applications.Controls
{
    partial class ctrScheduleTest
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
            this.grbScheduleTest = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.labValueFees = new System.Windows.Forms.Label();
            this.labFees = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.labDate = new System.Windows.Forms.Label();
            this.labValueTrial = new System.Windows.Forms.Label();
            this.labTrial = new System.Windows.Forms.Label();
            this.labValueName = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labValueDClass = new System.Windows.Forms.Label();
            this.labDClass = new System.Windows.Forms.Label();
            this.labValueDLAppID = new System.Windows.Forms.Label();
            this.labDLAppID = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.ctrHeaderTitleControl1 = new DVLDPresentationLayer.Controls.ctrHeaderTitleControl();
            this.ctrRetakeTestInfo1 = new DVLDPresentationLayer.Applications.Controls.ctrRetakeTestInfo();
            this.grbScheduleTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbScheduleTest
            // 
            this.grbScheduleTest.Controls.Add(this.btnSave);
            this.grbScheduleTest.Controls.Add(this.labValueFees);
            this.grbScheduleTest.Controls.Add(this.ctrRetakeTestInfo1);
            this.grbScheduleTest.Controls.Add(this.labFees);
            this.grbScheduleTest.Controls.Add(this.dtpDate);
            this.grbScheduleTest.Controls.Add(this.labDate);
            this.grbScheduleTest.Controls.Add(this.labValueTrial);
            this.grbScheduleTest.Controls.Add(this.labTrial);
            this.grbScheduleTest.Controls.Add(this.labValueName);
            this.grbScheduleTest.Controls.Add(this.labName);
            this.grbScheduleTest.Controls.Add(this.labValueDClass);
            this.grbScheduleTest.Controls.Add(this.labDClass);
            this.grbScheduleTest.Controls.Add(this.labValueDLAppID);
            this.grbScheduleTest.Controls.Add(this.labDLAppID);
            this.grbScheduleTest.Location = new System.Drawing.Point(20, 83);
            this.grbScheduleTest.Name = "grbScheduleTest";
            this.grbScheduleTest.Size = new System.Drawing.Size(513, 476);
            this.grbScheduleTest.TabIndex = 1;
            this.grbScheduleTest.TabStop = false;
            this.grbScheduleTest.Text = "Header Title";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(424, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 32);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labValueFees
            // 
            this.labValueFees.AutoSize = true;
            this.labValueFees.Location = new System.Drawing.Point(136, 263);
            this.labValueFees.Name = "labValueFees";
            this.labValueFees.Size = new System.Drawing.Size(35, 18);
            this.labValueFees.TabIndex = 11;
            this.labValueFees.Text = "???";
            // 
            // labFees
            // 
            this.labFees.AutoSize = true;
            this.labFees.Location = new System.Drawing.Point(23, 261);
            this.labFees.Name = "labFees";
            this.labFees.Size = new System.Drawing.Size(50, 18);
            this.labFees.TabIndex = 10;
            this.labFees.Text = "Fees:";
            // 
            // dtpDate
            // 
            this.dtpDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(139, 213);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(142, 24);
            this.dtpDate.TabIndex = 9;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Location = new System.Drawing.Point(23, 216);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(48, 18);
            this.labDate.TabIndex = 8;
            this.labDate.Text = "Date:";
            // 
            // labValueTrial
            // 
            this.labValueTrial.AutoSize = true;
            this.labValueTrial.Location = new System.Drawing.Point(136, 169);
            this.labValueTrial.Name = "labValueTrial";
            this.labValueTrial.Size = new System.Drawing.Size(35, 18);
            this.labValueTrial.TabIndex = 7;
            this.labValueTrial.Text = "???";
            // 
            // labTrial
            // 
            this.labTrial.AutoSize = true;
            this.labTrial.Location = new System.Drawing.Point(23, 171);
            this.labTrial.Name = "labTrial";
            this.labTrial.Size = new System.Drawing.Size(46, 18);
            this.labTrial.TabIndex = 6;
            this.labTrial.Text = "Trial:";
            // 
            // labValueName
            // 
            this.labValueName.AutoSize = true;
            this.labValueName.Location = new System.Drawing.Point(136, 125);
            this.labValueName.Name = "labValueName";
            this.labValueName.Size = new System.Drawing.Size(35, 18);
            this.labValueName.TabIndex = 5;
            this.labValueName.Text = "???";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(23, 126);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(57, 18);
            this.labName.TabIndex = 4;
            this.labName.Text = "Name:";
            // 
            // labValueDClass
            // 
            this.labValueDClass.AutoSize = true;
            this.labValueDClass.Location = new System.Drawing.Point(136, 81);
            this.labValueDClass.Name = "labValueDClass";
            this.labValueDClass.Size = new System.Drawing.Size(35, 18);
            this.labValueDClass.TabIndex = 3;
            this.labValueDClass.Text = "???";
            // 
            // labDClass
            // 
            this.labDClass.AutoSize = true;
            this.labDClass.Location = new System.Drawing.Point(23, 81);
            this.labDClass.Name = "labDClass";
            this.labDClass.Size = new System.Drawing.Size(73, 18);
            this.labDClass.TabIndex = 2;
            this.labDClass.Text = "D.Class:";
            // 
            // labValueDLAppID
            // 
            this.labValueDLAppID.AutoSize = true;
            this.labValueDLAppID.Location = new System.Drawing.Point(136, 37);
            this.labValueDLAppID.Name = "labValueDLAppID";
            this.labValueDLAppID.Size = new System.Drawing.Size(35, 18);
            this.labValueDLAppID.TabIndex = 1;
            this.labValueDLAppID.Text = "???";
            // 
            // labDLAppID
            // 
            this.labDLAppID.AutoSize = true;
            this.labDLAppID.Location = new System.Drawing.Point(23, 36);
            this.labDLAppID.Name = "labDLAppID";
            this.labDLAppID.Size = new System.Drawing.Size(93, 18);
            this.labDLAppID.TabIndex = 0;
            this.labDLAppID.Text = "D.L.App.ID:";
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(240, 565);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(82, 30);
            this.ctrButtonClose1.TabIndex = 3;
            // 
            // ctrHeaderTitleControl1
            // 
            this.ctrHeaderTitleControl1.Location = new System.Drawing.Point(134, 3);
            this.ctrHeaderTitleControl1.Name = "ctrHeaderTitleControl1";
            this.ctrHeaderTitleControl1.Size = new System.Drawing.Size(291, 65);
            this.ctrHeaderTitleControl1.TabIndex = 2;
            this.ctrHeaderTitleControl1.Title = "Schedule Test";
            // 
            // ctrRetakeTestInfo1
            // 
            this.ctrRetakeTestInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrRetakeTestInfo1.Location = new System.Drawing.Point(11, 304);
            this.ctrRetakeTestInfo1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrRetakeTestInfo1.Name = "ctrRetakeTestInfo1";
            this.ctrRetakeTestInfo1.RetakeAppFees = "???";
            this.ctrRetakeTestInfo1.RetakeAppID = "???";
            this.ctrRetakeTestInfo1.Size = new System.Drawing.Size(494, 116);
            this.ctrRetakeTestInfo1.TabIndex = 0;
            this.ctrRetakeTestInfo1.TotalFees = "???";
            // 
            // ctrScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.ctrHeaderTitleControl1);
            this.Controls.Add(this.grbScheduleTest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ctrScheduleTest";
            this.Size = new System.Drawing.Size(560, 606);
            this.Load += new System.EventHandler(this.ctrScheduleTest_Load);
            this.grbScheduleTest.ResumeLayout(false);
            this.grbScheduleTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrRetakeTestInfo ctrRetakeTestInfo1;
        private System.Windows.Forms.GroupBox grbScheduleTest;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labValueTrial;
        private System.Windows.Forms.Label labTrial;
        private System.Windows.Forms.Label labValueName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labValueDClass;
        private System.Windows.Forms.Label labDClass;
        private System.Windows.Forms.Label labValueDLAppID;
        private System.Windows.Forms.Label labDLAppID;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label labValueFees;
        private System.Windows.Forms.Label labFees;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Button btnSave;
        private DVLDPresentationLayer.Controls.ctrHeaderTitleControl ctrHeaderTitleControl1;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
    }
}
