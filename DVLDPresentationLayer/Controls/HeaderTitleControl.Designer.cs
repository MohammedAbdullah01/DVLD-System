namespace DVLDPresentationLayer.Controls
{
    partial class HeaderTitleControl
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
            this.labHeaderTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labHeaderTitle
            // 
            this.labHeaderTitle.AutoSize = true;
            this.labHeaderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labHeaderTitle.Location = new System.Drawing.Point(85, 28);
            this.labHeaderTitle.Name = "labHeaderTitle";
            this.labHeaderTitle.Size = new System.Drawing.Size(202, 37);
            this.labHeaderTitle.TabIndex = 0;
            this.labHeaderTitle.Text = "Header Title";
            // 
            // HeaderTitleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labHeaderTitle);
            this.Name = "HeaderTitleControl";
            this.Size = new System.Drawing.Size(375, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labHeaderTitle;
    }
}
