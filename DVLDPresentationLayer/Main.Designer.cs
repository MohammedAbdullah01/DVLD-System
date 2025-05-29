namespace DVLDPresentationLayer
{
    partial class Main
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
            this.ctrFilterByUser1 = new DVLDPresentationLayer.User.Controls.ctrFilterByUser();
            this.SuspendLayout();
            // 
            // ctrFilterByUser1
            // 
            this.ctrFilterByUser1.AutoSize = true;
            this.ctrFilterByUser1.Location = new System.Drawing.Point(237, 107);
            this.ctrFilterByUser1.Name = "ctrFilterByUser1";
            this.ctrFilterByUser1.Size = new System.Drawing.Size(561, 46);
            this.ctrFilterByUser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 500);
            this.Controls.Add(this.ctrFilterByUser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User.Controls.ctrFilterByUser ctrFilterByUser1;
    }
}

