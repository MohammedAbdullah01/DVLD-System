namespace DVLDPresentationLayer.User.Controls
{
    partial class frmListUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labHeaderTitleUser = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.labTotalRecordsValue = new System.Windows.Forms.Label();
            this.labTotalRecords = new System.Windows.Forms.Label();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.dGVListUsers = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdName = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ctrUserFilterBy = new DVLDPresentationLayer.Persons.Controls.ctrPersonFilterBy();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // labHeaderTitleUser
            // 
            this.labHeaderTitleUser.AutoSize = true;
            this.labHeaderTitleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeaderTitleUser.ForeColor = System.Drawing.Color.IndianRed;
            this.labHeaderTitleUser.Location = new System.Drawing.Point(309, 16);
            this.labHeaderTitleUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labHeaderTitleUser.Name = "labHeaderTitleUser";
            this.labHeaderTitleUser.Size = new System.Drawing.Size(200, 33);
            this.labHeaderTitleUser.TabIndex = 17;
            this.labHeaderTitleUser.Text = "Manage User";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.Location = new System.Drawing.Point(675, 519);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(125, 30);
            this.btnCloseForm.TabIndex = 16;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            // 
            // labTotalRecordsValue
            // 
            this.labTotalRecordsValue.AutoSize = true;
            this.labTotalRecordsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalRecordsValue.Location = new System.Drawing.Point(115, 517);
            this.labTotalRecordsValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labTotalRecordsValue.Name = "labTotalRecordsValue";
            this.labTotalRecordsValue.Size = new System.Drawing.Size(31, 16);
            this.labTotalRecordsValue.TabIndex = 15;
            this.labTotalRecordsValue.Text = "???";
            // 
            // labTotalRecords
            // 
            this.labTotalRecords.AutoSize = true;
            this.labTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalRecords.Location = new System.Drawing.Point(12, 515);
            this.labTotalRecords.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labTotalRecords.Name = "labTotalRecords";
            this.labTotalRecords.Size = new System.Drawing.Size(91, 18);
            this.labTotalRecords.TabIndex = 14;
            this.labTotalRecords.Text = "# Records:";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.Location = new System.Drawing.Point(675, 144);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(125, 30);
            this.btnAddNewUser.TabIndex = 12;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            // 
            // dGVListUsers
            // 
            this.dGVListUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGVListUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVListUsers.ColumnHeadersHeight = 25;
            this.dGVListUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.PersonID,
            this.FullName,
            this.UserName,
            this.ThirdName});
            this.dGVListUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVListUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVListUsers.Location = new System.Drawing.Point(15, 182);
            this.dGVListUsers.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dGVListUsers.Name = "dGVListUsers";
            this.dGVListUsers.Size = new System.Drawing.Size(785, 329);
            this.dGVListUsers.TabIndex = 10;
            // 
            // UserID
            // 
            this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UserID.HeaderText = "User ID";
            this.UserID.Name = "UserID";
            this.UserID.Width = 68;
            // 
            // PersonID
            // 
            this.PersonID.HeaderText = "Person ID";
            this.PersonID.Name = "PersonID";
            this.PersonID.Width = 150;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.Width = 150;
            // 
            // ThirdName
            // 
            this.ThirdName.HeaderText = "Is Active";
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ThirdName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ThirdName.Width = 80;
            // 
            // ctrUserFilterBy
            // 
            this.ctrUserFilterBy.AutoSize = true;
            this.ctrUserFilterBy.FilterByValue = "";
            this.ctrUserFilterBy.Location = new System.Drawing.Point(12, 74);
            this.ctrUserFilterBy.Name = "ctrUserFilterBy";
            this.ctrUserFilterBy.Size = new System.Drawing.Size(601, 101);
            this.ctrUserFilterBy.TabIndex = 18;
            // 
            // frmListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 564);
            this.Controls.Add(this.ctrUserFilterBy);
            this.Controls.Add(this.labHeaderTitleUser);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.labTotalRecordsValue);
            this.Controls.Add(this.labTotalRecords);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.dGVListUsers);
            this.Name = "frmListUser";
            this.Text = "frmListUser";
            ((System.ComponentModel.ISupportInitialize)(this.dGVListUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labHeaderTitleUser;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label labTotalRecordsValue;
        private System.Windows.Forms.Label labTotalRecords;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.DataGridView dGVListUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ThirdName;
        private Persons.Controls.ctrPersonFilterBy ctrUserFilterBy;
    }
}