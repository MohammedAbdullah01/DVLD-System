namespace DVLDPresentationLayer.Applications
{
    partial class frmManageTestTypes
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
            this.dgvListServices = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctrHeaderTitleControl1 = new DVLDPresentationLayer.Controls.ctrHeaderTitleControl();
            this.label1 = new System.Windows.Forms.Label();
            this.labValueCountRecords = new System.Windows.Forms.Label();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListServices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListServices
            // 
            this.dgvListServices.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListServices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.Description,
            this.Fees});
            this.dgvListServices.Location = new System.Drawing.Point(14, 76);
            this.dgvListServices.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvListServices.Name = "dgvListServices";
            this.dgvListServices.Size = new System.Drawing.Size(711, 281);
            this.dgvListServices.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.Width = 150;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Fees
            // 
            this.Fees.HeaderText = "Fees";
            this.Fees.Name = "Fees";
            // 
            // ctrHeaderTitleControl1
            // 
            this.ctrHeaderTitleControl1.Location = new System.Drawing.Point(183, 12);
            this.ctrHeaderTitleControl1.Name = "ctrHeaderTitleControl1";
            this.ctrHeaderTitleControl1.Size = new System.Drawing.Size(372, 57);
            this.ctrHeaderTitleControl1.TabIndex = 7;
            this.ctrHeaderTitleControl1.Title = "Manage Test Types";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "# Records:";
            // 
            // labValueCountRecords
            // 
            this.labValueCountRecords.AutoSize = true;
            this.labValueCountRecords.Location = new System.Drawing.Point(109, 375);
            this.labValueCountRecords.Name = "labValueCountRecords";
            this.labValueCountRecords.Size = new System.Drawing.Size(35, 18);
            this.labValueCountRecords.TabIndex = 9;
            this.labValueCountRecords.Text = "???";
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(642, 364);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(83, 32);
            this.ctrButtonClose1.TabIndex = 10;
            // 
            // frmManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 402);
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.labValueCountRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrHeaderTitleControl1);
            this.Controls.Add(this.dgvListServices);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmManageTestTypes";
            this.Text = "List Test Types";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fees;
        private DVLDPresentationLayer.Controls.ctrHeaderTitleControl ctrHeaderTitleControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labValueCountRecords;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
    }
}