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
            this.grbPersonFilterBy = new System.Windows.Forms.GroupBox();
            this.txbInputFilterByPerson = new System.Windows.Forms.TextBox();
            this.combFilterBy = new System.Windows.Forms.ComboBox();
            this.labFilterBy = new System.Windows.Forms.Label();
            this.labPersoneFilterBy = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbPersonFilterBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPersonFilterBy
            // 
            this.grbPersonFilterBy.AutoSize = true;
            this.grbPersonFilterBy.Controls.Add(this.btnSearch);
            this.grbPersonFilterBy.Controls.Add(this.labPersoneFilterBy);
            this.grbPersonFilterBy.Controls.Add(this.txbInputFilterByPerson);
            this.grbPersonFilterBy.Controls.Add(this.combFilterBy);
            this.grbPersonFilterBy.Controls.Add(this.labFilterBy);
            this.grbPersonFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPersonFilterBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grbPersonFilterBy.Location = new System.Drawing.Point(3, 3);
            this.grbPersonFilterBy.Name = "grbPersonFilterBy";
            this.grbPersonFilterBy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbPersonFilterBy.Size = new System.Drawing.Size(557, 95);
            this.grbPersonFilterBy.TabIndex = 0;
            this.grbPersonFilterBy.TabStop = false;
            this.grbPersonFilterBy.Text = "Filter";
            // 
            // txbInputFilterByPerson
            // 
            this.txbInputFilterByPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInputFilterByPerson.Location = new System.Drawing.Point(273, 46);
            this.txbInputFilterByPerson.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txbInputFilterByPerson.Name = "txbInputFilterByPerson";
            this.txbInputFilterByPerson.Size = new System.Drawing.Size(195, 24);
            this.txbInputFilterByPerson.TabIndex = 7;
            // 
            // combFilterBy
            // 
            this.combFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combFilterBy.FormattingEnabled = true;
            this.combFilterBy.Location = new System.Drawing.Point(90, 46);
            this.combFilterBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.combFilterBy.Name = "combFilterBy";
            this.combFilterBy.Size = new System.Drawing.Size(171, 24);
            this.combFilterBy.TabIndex = 5;
            // 
            // labFilterBy
            // 
            this.labFilterBy.AutoSize = true;
            this.labFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFilterBy.Location = new System.Drawing.Point(-233, 39);
            this.labFilterBy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labFilterBy.Name = "labFilterBy";
            this.labFilterBy.Size = new System.Drawing.Size(75, 18);
            this.labFilterBy.TabIndex = 6;
            this.labFilterBy.Text = "Filter By:";
            // 
            // labPersoneFilterBy
            // 
            this.labPersoneFilterBy.AutoSize = true;
            this.labPersoneFilterBy.Location = new System.Drawing.Point(6, 46);
            this.labPersoneFilterBy.Name = "labPersoneFilterBy";
            this.labPersoneFilterBy.Size = new System.Drawing.Size(75, 18);
            this.labPersoneFilterBy.TabIndex = 8;
            this.labPersoneFilterBy.Text = "Filter By:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(477, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 30);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // ctrPersonFilterBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.grbPersonFilterBy);
            this.Name = "ctrPersonFilterBy";
            this.Size = new System.Drawing.Size(569, 112);
            this.grbPersonFilterBy.ResumeLayout(false);
            this.grbPersonFilterBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPersonFilterBy;
        private System.Windows.Forms.Label labPersoneFilterBy;
        private System.Windows.Forms.TextBox txbInputFilterByPerson;
        private System.Windows.Forms.ComboBox combFilterBy;
        private System.Windows.Forms.Label labFilterBy;
        private System.Windows.Forms.Button btnSearch;
    }
}
