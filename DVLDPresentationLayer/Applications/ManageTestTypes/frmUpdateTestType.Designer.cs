namespace DVLDPresentationLayer.Applications
{
    partial class frmUpdateTestType
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
            this.labId = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.labDescription = new System.Windows.Forms.Label();
            this.labFees = new System.Windows.Forms.Label();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.labValueId = new System.Windows.Forms.Label();
            this.ctrHeaderTitleControl1 = new DVLDPresentationLayer.Controls.ctrHeaderTitleControl();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.SuspendLayout();
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(23, 82);
            this.labId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(29, 18);
            this.labId.TabIndex = 1;
            this.labId.Text = "ID:";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Location = new System.Drawing.Point(23, 125);
            this.labTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(45, 18);
            this.labTitle.TabIndex = 2;
            this.labTitle.Text = "Title:";
            // 
            // labDescription
            // 
            this.labDescription.AutoSize = true;
            this.labDescription.Location = new System.Drawing.Point(23, 161);
            this.labDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(99, 18);
            this.labDescription.TabIndex = 3;
            this.labDescription.Text = "Description:";
            // 
            // labFees
            // 
            this.labFees.AutoSize = true;
            this.labFees.Location = new System.Drawing.Point(23, 263);
            this.labFees.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labFees.Name = "labFees";
            this.labFees.Size = new System.Drawing.Size(50, 18);
            this.labFees.TabIndex = 4;
            this.labFees.Text = "Fees:";
            // 
            // txbTitle
            // 
            this.txbTitle.Location = new System.Drawing.Point(136, 125);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(328, 24);
            this.txbTitle.TabIndex = 5;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(136, 161);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(328, 90);
            this.txbDescription.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 263);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(328, 24);
            this.textBox2.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(399, 309);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 30);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // labValueId
            // 
            this.labValueId.AutoSize = true;
            this.labValueId.Location = new System.Drawing.Point(133, 82);
            this.labValueId.Name = "labValueId";
            this.labValueId.Size = new System.Drawing.Size(35, 18);
            this.labValueId.TabIndex = 19;
            this.labValueId.Text = "???";
            // 
            // ctrHeaderTitleControl1
            // 
            this.ctrHeaderTitleControl1.Location = new System.Drawing.Point(74, 12);
            this.ctrHeaderTitleControl1.Name = "ctrHeaderTitleControl1";
            this.ctrHeaderTitleControl1.Size = new System.Drawing.Size(339, 65);
            this.ctrHeaderTitleControl1.TabIndex = 20;
            this.ctrHeaderTitleControl1.Title = "Update Test Type";
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(308, 309);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(83, 32);
            this.ctrButtonClose1.TabIndex = 21;
            // 
            // frmUpdateTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 352);
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.ctrHeaderTitleControl1);
            this.Controls.Add(this.labValueId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.txbTitle);
            this.Controls.Add(this.labFees);
            this.Controls.Add(this.labDescription);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmUpdateTestType";
            this.Text = "Update Test Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labDescription;
        private System.Windows.Forms.Label labFees;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labValueId;
        private DVLDPresentationLayer.Controls.ctrHeaderTitleControl ctrHeaderTitleControl1;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
    }
}