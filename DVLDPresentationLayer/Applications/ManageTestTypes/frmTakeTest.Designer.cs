namespace DVLDPresentationLayer.Applications
{
    partial class frmTakeTest
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
            this.labResult = new System.Windows.Forms.Label();
            this.ctrTakeTest1 = new DVLDPresentationLayer.Applications.Controls.ctrTakeTest();
            this.rabPass = new System.Windows.Forms.RadioButton();
            this.rabFail = new System.Windows.Forms.RadioButton();
            this.labNotes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Location = new System.Drawing.Point(29, 511);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(61, 18);
            this.labResult.TabIndex = 1;
            this.labResult.Text = "Result:";
            // 
            // ctrTakeTest1
            // 
            this.ctrTakeTest1.Date = "???";
            this.ctrTakeTest1.DrivingClass = "???";
            this.ctrTakeTest1.DrivingLicenseAppID = "???";
            this.ctrTakeTest1.Fees = "???";
            this.ctrTakeTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrTakeTest1.FullName = "???";
            this.ctrTakeTest1.Location = new System.Drawing.Point(15, 15);
            this.ctrTakeTest1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ctrTakeTest1.Name = "ctrTakeTest1";
            this.ctrTakeTest1.Size = new System.Drawing.Size(593, 470);
            this.ctrTakeTest1.TabIndex = 0;
            this.ctrTakeTest1.TestID = "???";
            this.ctrTakeTest1.TitleGroupBox = "Title Header";
            this.ctrTakeTest1.Trial = "???";
            // 
            // rabPass
            // 
            this.rabPass.AutoSize = true;
            this.rabPass.Location = new System.Drawing.Point(153, 507);
            this.rabPass.Name = "rabPass";
            this.rabPass.Size = new System.Drawing.Size(64, 22);
            this.rabPass.TabIndex = 2;
            this.rabPass.TabStop = true;
            this.rabPass.Text = "Pass";
            this.rabPass.UseVisualStyleBackColor = true;
            // 
            // rabFail
            // 
            this.rabFail.AutoSize = true;
            this.rabFail.Location = new System.Drawing.Point(245, 507);
            this.rabFail.Name = "rabFail";
            this.rabFail.Size = new System.Drawing.Size(53, 22);
            this.rabFail.TabIndex = 3;
            this.rabFail.TabStop = true;
            this.rabFail.Text = "Fail";
            this.rabFail.UseVisualStyleBackColor = true;
            // 
            // labNotes
            // 
            this.labNotes.AutoSize = true;
            this.labNotes.Location = new System.Drawing.Point(29, 581);
            this.labNotes.Name = "labNotes";
            this.labNotes.Size = new System.Drawing.Size(58, 18);
            this.labNotes.TabIndex = 4;
            this.labNotes.Text = "Notes:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 551);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 70);
            this.textBox1.TabIndex = 5;
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(444, 637);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(83, 32);
            this.ctrButtonClose1.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(535, 637);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 30);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 680);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labNotes);
            this.Controls.Add(this.rabFail);
            this.Controls.Add(this.rabPass);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.ctrTakeTest1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmTakeTest";
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrTakeTest ctrTakeTest1;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.RadioButton rabPass;
        private System.Windows.Forms.RadioButton rabFail;
        private System.Windows.Forms.Label labNotes;
        private System.Windows.Forms.TextBox textBox1;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
        private System.Windows.Forms.Button btnSave;
    }
}