namespace Zest_Script.forms
{
    partial class OnboardForm
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
            this.bgOnboardWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.rtbDetails = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSeeLog = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pgOnboardProgress = new System.Windows.Forms.ProgressBar();
            this.lblCurrentTask = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgOnboardWorker
            // 
            this.bgOnboardWorker.WorkerReportsProgress = true;
            this.bgOnboardWorker.WorkerSupportsCancellation = true;
            this.bgOnboardWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgOnboardWorker_DoWork);
            this.bgOnboardWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgOnboardWorker_ProgressChanged);
            this.bgOnboardWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgOnboardWorker_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelDetails);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 100);
            this.panel1.TabIndex = 0;
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.rtbDetails);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(0, 61);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(649, 0);
            this.panelDetails.TabIndex = 5;
            this.panelDetails.Visible = false;
            // 
            // rtbDetails
            // 
            this.rtbDetails.HideSelection = false;
            this.rtbDetails.Location = new System.Drawing.Point(12, 3);
            this.rtbDetails.Name = "rtbDetails";
            this.rtbDetails.ReadOnly = true;
            this.rtbDetails.Size = new System.Drawing.Size(625, 194);
            this.rtbDetails.TabIndex = 0;
            this.rtbDetails.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.51002F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.48998F));
            this.tableLayoutPanel1.Controls.Add(this.btnSeeLog, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 39);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnSeeLog
            // 
            this.btnSeeLog.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSeeLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSeeLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeLog.Location = new System.Drawing.Point(418, 8);
            this.btnSeeLog.Name = "btnSeeLog";
            this.btnSeeLog.Size = new System.Drawing.Size(108, 23);
            this.btnSeeLog.TabIndex = 3;
            this.btnSeeLog.Text = "Show Details";
            this.btnSeeLog.UseVisualStyleBackColor = false;
            this.btnSeeLog.Click += new System.EventHandler(this.btnSeeLog_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(532, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pgOnboardProgress);
            this.panel2.Controls.Add(this.lblCurrentTask);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 61);
            this.panel2.TabIndex = 4;
            // 
            // pgOnboardProgress
            // 
            this.pgOnboardProgress.Location = new System.Drawing.Point(12, 12);
            this.pgOnboardProgress.Name = "pgOnboardProgress";
            this.pgOnboardProgress.Size = new System.Drawing.Size(625, 23);
            this.pgOnboardProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgOnboardProgress.TabIndex = 0;
            // 
            // lblCurrentTask
            // 
            this.lblCurrentTask.AutoSize = true;
            this.lblCurrentTask.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCurrentTask.Location = new System.Drawing.Point(12, 38);
            this.lblCurrentTask.Name = "lblCurrentTask";
            this.lblCurrentTask.Size = new System.Drawing.Size(96, 17);
            this.lblCurrentTask.TabIndex = 1;
            this.lblCurrentTask.Text = "Current task...";
            // 
            // OnboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(649, 100);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OnboardForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Onboarding";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OnboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgOnboardWorker;
        private Panel panel1;
        private Panel panelDetails;
        private RichTextBox rtbDetails;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSeeLog;
        private Button btnCancel;
        private Panel panel2;
        private ProgressBar pgOnboardProgress;
        private Label lblCurrentTask;
    }
}