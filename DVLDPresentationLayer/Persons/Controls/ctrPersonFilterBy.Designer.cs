using System.Windows.Forms;

namespace DVLDPresentationLayer.Persons.Controls
{
    partial class ctrPersonFilterBy
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
            this.txbPersonFilterBy = new System.Windows.Forms.TextBox();
            this.cmbPersonFilterBy = new System.Windows.Forms.ComboBox();
            this.labFilterBy = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbPersonFilterBy
            // 
            this.txbPersonFilterBy.Enabled = false;
            this.txbPersonFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPersonFilterBy.Location = new System.Drawing.Point(303, 6);
            this.txbPersonFilterBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txbPersonFilterBy.MaximumSize = new System.Drawing.Size(200, 24);
            this.txbPersonFilterBy.Name = "txbPersonFilterBy";
            this.txbPersonFilterBy.Size = new System.Drawing.Size(200, 24);
            this.txbPersonFilterBy.TabIndex = 8;
            this.txbPersonFilterBy.TextChanged += new System.EventHandler(this.txbPersonFilterBy_TextChanged);
            // 
            // cmbPersonFilterBy
            // 
            this.cmbPersonFilterBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPersonFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersonFilterBy.FormattingEnabled = true;
            this.cmbPersonFilterBy.Location = new System.Drawing.Point(96, 7);
            this.cmbPersonFilterBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbPersonFilterBy.MaximumSize = new System.Drawing.Size(200, 0);
            this.cmbPersonFilterBy.Name = "cmbPersonFilterBy";
            this.cmbPersonFilterBy.Size = new System.Drawing.Size(200, 24);
            this.cmbPersonFilterBy.TabIndex = 7;
            this.cmbPersonFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbPersonFilterBy_SelectedIndexChanged);
            // 
            // labFilterBy
            // 
            this.labFilterBy.AutoSize = true;
            this.labFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFilterBy.Location = new System.Drawing.Point(14, 7);
            this.labFilterBy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labFilterBy.MaximumSize = new System.Drawing.Size(75, 18);
            this.labFilterBy.Name = "labFilterBy";
            this.labFilterBy.Size = new System.Drawing.Size(75, 18);
            this.labFilterBy.TabIndex = 9;
            this.labFilterBy.Text = "Filter By:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(510, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 25);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ctrPersonFilterBy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbPersonFilterBy);
            this.Controls.Add(this.cmbPersonFilterBy);
            this.Controls.Add(this.labFilterBy);
            this.Name = "ctrPersonFilterBy";
            this.Size = new System.Drawing.Size(602, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPersonFilterBy;
        private System.Windows.Forms.ComboBox cmbPersonFilterBy;
        private System.Windows.Forms.Label labFilterBy;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnSearch;
    }
}
