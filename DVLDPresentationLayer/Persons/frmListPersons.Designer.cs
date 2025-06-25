namespace DVLDPresentationLayer.Persons
{
    partial class frmListPersons
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
            this.dGVListPersons = new System.Windows.Forms.DataGridView();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.labTotalRecords = new System.Windows.Forms.Label();
            this.labTotalRecordsValue = new System.Windows.Forms.Label();
            this.ctrHeaderTitleControl1 = new DVLDPresentationLayer.Controls.ctrHeaderTitleControl();
            this.ctrButtonClose1 = new DVLDPresentationLayer.Controls.ctrButtonClose();
            this.ctrPersonFilterBy1 = new DVLDPresentationLayer.Persons.Controls.ctrPersonFilterBy();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Governorate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVListPersons
            // 
            this.dGVListPersons.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGVListPersons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVListPersons.ColumnHeadersHeight = 25;
            this.dGVListPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonID,
            this.NationalID,
            this.FirstName,
            this.SecondName,
            this.ThirdName,
            this.LastName,
            this.Gender,
            this.DateOfBirth,
            this.Phone,
            this.Email,
            this.Nationality,
            this.Governorate,
            this.City});
            this.dGVListPersons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dGVListPersons.Location = new System.Drawing.Point(15, 130);
            this.dGVListPersons.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dGVListPersons.Name = "dGVListPersons";
            this.dGVListPersons.Size = new System.Drawing.Size(1268, 397);
            this.dGVListPersons.TabIndex = 1;
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPerson.Location = new System.Drawing.Point(1131, 92);
            this.btnAddNewPerson.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(154, 30);
            this.btnAddNewPerson.TabIndex = 3;
            this.btnAddNewPerson.Text = "Add New Person";
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // labTotalRecords
            // 
            this.labTotalRecords.AutoSize = true;
            this.labTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalRecords.Location = new System.Drawing.Point(12, 531);
            this.labTotalRecords.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labTotalRecords.Name = "labTotalRecords";
            this.labTotalRecords.Size = new System.Drawing.Size(91, 18);
            this.labTotalRecords.TabIndex = 5;
            this.labTotalRecords.Text = "# Records:";
            // 
            // labTotalRecordsValue
            // 
            this.labTotalRecordsValue.AutoSize = true;
            this.labTotalRecordsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalRecordsValue.Location = new System.Drawing.Point(107, 533);
            this.labTotalRecordsValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labTotalRecordsValue.Name = "labTotalRecordsValue";
            this.labTotalRecordsValue.Size = new System.Drawing.Size(31, 16);
            this.labTotalRecordsValue.TabIndex = 6;
            this.labTotalRecordsValue.Text = "???";
            // 
            // ctrHeaderTitleControl1
            // 
            this.ctrHeaderTitleControl1.Location = new System.Drawing.Point(484, 12);
            this.ctrHeaderTitleControl1.Name = "ctrHeaderTitleControl1";
            this.ctrHeaderTitleControl1.Size = new System.Drawing.Size(330, 65);
            this.ctrHeaderTitleControl1.TabIndex = 13;
            this.ctrHeaderTitleControl1.Title = "Manage Persons";
            // 
            // ctrButtonClose1
            // 
            this.ctrButtonClose1.ButtonText = "CLose";
            this.ctrButtonClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrButtonClose1.Location = new System.Drawing.Point(1208, 534);
            this.ctrButtonClose1.Name = "ctrButtonClose1";
            this.ctrButtonClose1.Size = new System.Drawing.Size(78, 29);
            this.ctrButtonClose1.TabIndex = 12;
            // 
            // ctrPersonFilterBy1
            // 
            this.ctrPersonFilterBy1.Location = new System.Drawing.Point(15, 83);
            this.ctrPersonFilterBy1.Name = "ctrPersonFilterBy1";
            this.ctrPersonFilterBy1.Size = new System.Drawing.Size(602, 39);
            this.ctrPersonFilterBy1.TabIndex = 11;
            // 
            // PersonID
            // 
            this.PersonID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PersonID.HeaderText = "ID";
            this.PersonID.Name = "PersonID";
            this.PersonID.Width = 49;
            // 
            // NationalID
            // 
            this.NationalID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NationalID.HeaderText = "National NO";
            this.NationalID.Name = "NationalID";
            this.NationalID.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FirstName.HeaderText = "F.Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 92;
            // 
            // SecondName
            // 
            this.SecondName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SecondName.HeaderText = "S.Name";
            this.SecondName.Name = "SecondName";
            this.SecondName.Width = 93;
            // 
            // ThirdName
            // 
            this.ThirdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ThirdName.HeaderText = "T.Name";
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.Width = 92;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LastName.HeaderText = "L.Name";
            this.LastName.Name = "LastName";
            this.LastName.Width = 91;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.Width = 88;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Width = 131;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.Width = 81;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Nationality
            // 
            this.Nationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nationality.HeaderText = "Country";
            this.Nationality.Name = "Nationality";
            this.Nationality.Width = 92;
            // 
            // Governorate
            // 
            this.Governorate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Governorate.HeaderText = "Governorate";
            this.Governorate.Name = "Governorate";
            this.Governorate.Width = 127;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.Width = 62;
            // 
            // frmListPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 575);
            this.Controls.Add(this.ctrHeaderTitleControl1);
            this.Controls.Add(this.ctrButtonClose1);
            this.Controls.Add(this.ctrPersonFilterBy1);
            this.Controls.Add(this.labTotalRecordsValue);
            this.Controls.Add(this.labTotalRecords);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.dGVListPersons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmListPersons";
            this.Text = "Manage Persons";
            this.Load += new System.EventHandler(this.frmListPersons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVListPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVListPersons;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Label labTotalRecords;
        private System.Windows.Forms.Label labTotalRecordsValue;
        private Controls.ctrPersonFilterBy ctrPersonFilterBy1;
        private DVLDPresentationLayer.Controls.ctrButtonClose ctrButtonClose1;
        private DVLDPresentationLayer.Controls.ctrHeaderTitleControl ctrHeaderTitleControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThirdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Governorate;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
    }
}