namespace OnboardingHelper_NetCore
{
    partial class HelpBox
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(548, 30);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Fill out the information on each tab and when ready, click the \"On-Board\" button " +
    "to begin the process.\r\nThis program will perform the necessary on-boarding proce" +
    "dures for a new computer.";
            // 
            // HelpBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 211);
            this.Controls.Add(this.lblDescription);
            this.Name = "HelpBox";
            this.Text = "HelpBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDescription;
    }
}