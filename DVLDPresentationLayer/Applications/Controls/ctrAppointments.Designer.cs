namespace DVLDPresentationLayer.Applications.Controls
{
    partial class ctrAppointments
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
            this.grbAppointments = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridAppointments = new System.Windows.Forms.DataGridView();
            this.AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.labRecords = new System.Windows.Forms.Label();
            this.labValueCountRecords = new System.Windows.Forms.Label();
            this.grbAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAppointments
            // 
            this.grbAppointments.Controls.Add(this.labValueCountRecords);
            this.grbAppointments.Controls.Add(this.labRecords);
            this.grbAppointments.Controls.Add(this.ctrButtonClose1);
            this.grbAppointments.Controls.Add(this.btnAddAppointment);
            this.grbAppointments.Controls.Add(this.dataGridAppointments);
            this.grbAppointments.Location = new System.Drawing.Point(7, 8);
            this.grbAppointments.Name = "grbAppointments";
            this.grbAppointments.Size = new System.Drawing.Size(719, 338);
            this.grbAppointments.TabIndex = 0;
            this.grbAppointments.TabStop = false;
            this.grbAppointments.Text = "Appointments";
            // 
            // dataGridAppointments
            // 
            this.dataGridAppointments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridAppointments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppointmentID,
            this.AppointmentDate,
            this.PaidFees,
            this.IsLocked});
            this.dataGridAppointments.Location = new System.Drawing.Point(6, 48);
            this.dataGridAppointments.Name = "dataGridAppointments";
            this.dataGridAppointments.Size = new System.Drawing.Size(707, 242);
            this.dataGridAppointments.TabIndex = 0;
            // 
            // AppointmentID
            // 
            this.AppointmentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppointmentID.HeaderText = "Appointment ID";
            this.AppointmentID.Name = "AppointmentID";
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppointmentDate.HeaderText = "Appointment Date";
            this.AppointmentDate.Name = "AppointmentDate";
            // 
            // PaidFees
            // 
            this.PaidFees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaidFees.HeaderText = "Paid Fees";
            this.PaidFees.Name = "PaidFees";
            // 
            // IsLocked
            // 
            this.IsLocked.HeaderText = "Is Locked";
            this.IsLocked.Name = "IsLocked";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAppointment.Location = new System.Drawing.Point(570, 14);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(143, 28);
            this.btnAddAppointment.TabIndex = 1;
            this.btnAddAppointment.Text = "Add Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(630, 300);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(83, 32);
            this.ctrButtonClose1.TabIndex = 2;
            // 
            // labRecords
            // 
            this.labRecords.AutoSize = true;
            this.labRecords.Location = new System.Drawing.Point(3, 303);
            this.labRecords.Name = "labRecords";
            this.labRecords.Size = new System.Drawing.Size(91, 18);
            this.labRecords.TabIndex = 3;
            this.labRecords.Text = "# Records:";
            // 
            // labValueCountRecords
            // 
            this.labValueCountRecords.AutoSize = true;
            this.labValueCountRecords.Location = new System.Drawing.Point(100, 303);
            this.labValueCountRecords.Name = "labValueCountRecords";
            this.labValueCountRecords.Size = new System.Drawing.Size(35, 18);
            this.labValueCountRecords.TabIndex = 4;
            this.labValueCountRecords.Text = "???";
            // 
            // ctrAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbAppointments);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ctrAppointments";
            this.Size = new System.Drawing.Size(733, 349);
            this.grbAppointments.ResumeLayout(false);
            this.grbAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAppointments;
        private System.Windows.Forms.DataGridView dataGridAppointments;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidFees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsLocked;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Label labValueCountRecords;
        private System.Windows.Forms.Label labRecords;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
    }
}
