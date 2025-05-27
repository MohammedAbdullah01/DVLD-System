namespace DVLDPresentationLayer.Applications
{
    partial class frmUpdateApplicationType
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
            this.labValueId = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.labFees = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.labId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrHeaderTitleControl1 = new DVLDPresentationLayer.Controls.ctrHeaderTitleControl();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.SuspendLayout();
            // 
            // labValueId
            // 
            this.labValueId.AutoSize = true;
            this.labValueId.Location = new System.Drawing.Point(88, 88);
            this.labValueId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labValueId.Name = "labValueId";
            this.labValueId.Size = new System.Drawing.Size(35, 18);
            this.labValueId.TabIndex = 30;
            this.labValueId.Text = "???";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 172);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(343, 24);
            this.textBox2.TabIndex = 27;
            // 
            // txbTitle
            // 
            this.txbTitle.Location = new System.Drawing.Point(93, 127);
            this.txbTitle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(343, 24);
            this.txbTitle.TabIndex = 25;
            // 
            // labFees
            // 
            this.labFees.AutoSize = true;
            this.labFees.Location = new System.Drawing.Point(40, 178);
            this.labFees.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labFees.Name = "labFees";
            this.labFees.Size = new System.Drawing.Size(50, 18);
            this.labFees.TabIndex = 24;
            this.labFees.Text = "Fees:";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Location = new System.Drawing.Point(40, 126);
            this.labTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(45, 18);
            this.labTitle.TabIndex = 22;
            this.labTitle.Text = "Title:";
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(40, 88);
            this.labId.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(29, 18);
            this.labId.TabIndex = 21;
            this.labId.Text = "ID:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(363, 213);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 30);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // ctrHeaderTitleControl1
            // 
            this.ctrHeaderTitleControl1.Location = new System.Drawing.Point(12, 12);
            this.ctrHeaderTitleControl1.Name = "ctrHeaderTitleControl1";
            this.ctrHeaderTitleControl1.Size = new System.Drawing.Size(452, 65);
            this.ctrHeaderTitleControl1.TabIndex = 32;
            this.ctrHeaderTitleControl1.Title = "Update Application Type";
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(272, 213);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(83, 32);
            this.ctrButtonClose1.TabIndex = 33;
            // 
            // frmUpdateApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 256);
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.ctrHeaderTitleControl1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labValueId);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txbTitle);
            this.Controls.Add(this.labFees);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmUpdateApplicationType";
            this.Text = "Update Application Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labValueId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.Label labFees;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Button btnSave;
        private DVLDPresentationLayer.Controls.ctrHeaderTitleControl ctrHeaderTitleControl1;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
    }
}