namespace DVLDPresentationLayer.Controls
{
    partial class ctrHeaderTitleControl
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
            this.labHeaderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeaderTitle.ForeColor = System.Drawing.Color.Purple;
            this.labHeaderTitle.Location = new System.Drawing.Point(10, 9);
            this.labHeaderTitle.Name = "labHeaderTitle";
            this.labHeaderTitle.Size = new System.Drawing.Size(333, 42);
            this.labHeaderTitle.TabIndex = 0;
            this.labHeaderTitle.Text = "HEADWER TITLE";
            // 
            // ctrHeaderTitleControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.labHeaderTitle);
            this.Name = "ctrHeaderTitleControl";
            this.Size = new System.Drawing.Size(388, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labHeaderTitle;
    }
}
