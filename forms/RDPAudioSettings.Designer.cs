namespace OnboardingHelper_NetCore.forms
{
    partial class RDPAudioSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RDPAudioSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPlayOnRemoteComputer = new System.Windows.Forms.RadioButton();
            this.radDoNotPlay = new System.Windows.Forms.RadioButton();
            this.radPlayOnThisComputer = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radDoNotRecord = new System.Windows.Forms.RadioButton();
            this.radRecordFromComputer = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 66);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(77, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(77, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remote Desktop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnboardingHelper_NetCore.Properties.Resources.mstsc_48x48;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 52);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPlayOnRemoteComputer);
            this.groupBox1.Controls.Add(this.radDoNotPlay);
            this.groupBox1.Controls.Add(this.radPlayOnThisComputer);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remote Audio Playback";
            // 
            // radPlayOnRemoteComputer
            // 
            this.radPlayOnRemoteComputer.AutoSize = true;
            this.radPlayOnRemoteComputer.Location = new System.Drawing.Point(76, 72);
            this.radPlayOnRemoteComputer.Name = "radPlayOnRemoteComputer";
            this.radPlayOnRemoteComputer.Size = new System.Drawing.Size(169, 20);
            this.radPlayOnRemoteComputer.TabIndex = 3;
            this.radPlayOnRemoteComputer.Text = "Play on remote computer";
            this.radPlayOnRemoteComputer.UseVisualStyleBackColor = true;
            this.radPlayOnRemoteComputer.CheckedChanged += new System.EventHandler(this.radPlayOnRemoteComputer_CheckedChanged);
            // 
            // radDoNotPlay
            // 
            this.radDoNotPlay.AutoSize = true;
            this.radDoNotPlay.Location = new System.Drawing.Point(76, 46);
            this.radDoNotPlay.Name = "radDoNotPlay";
            this.radDoNotPlay.Size = new System.Drawing.Size(88, 20);
            this.radDoNotPlay.TabIndex = 2;
            this.radDoNotPlay.Text = "Do not play";
            this.radDoNotPlay.UseVisualStyleBackColor = true;
            this.radDoNotPlay.CheckedChanged += new System.EventHandler(this.radDoNotPlay_CheckedChanged);
            // 
            // radPlayOnThisComputer
            // 
            this.radPlayOnThisComputer.AutoSize = true;
            this.radPlayOnThisComputer.Checked = true;
            this.radPlayOnThisComputer.Location = new System.Drawing.Point(76, 22);
            this.radPlayOnThisComputer.Name = "radPlayOnThisComputer";
            this.radPlayOnThisComputer.Size = new System.Drawing.Size(148, 20);
            this.radPlayOnThisComputer.TabIndex = 1;
            this.radPlayOnThisComputer.TabStop = true;
            this.radPlayOnThisComputer.Text = "Play on this computer";
            this.radPlayOnThisComputer.UseVisualStyleBackColor = true;
            this.radPlayOnThisComputer.CheckedChanged += new System.EventHandler(this.radPlayOnThisComputer_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OnboardingHelper_NetCore.Properties.Resources._13004;
            this.pictureBox2.Location = new System.Drawing.Point(16, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radDoNotRecord);
            this.groupBox2.Controls.Add(this.radRecordFromComputer);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 74);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remote Audio Recording";
            // 
            // radDoNotRecord
            // 
            this.radDoNotRecord.AutoSize = true;
            this.radDoNotRecord.Checked = true;
            this.radDoNotRecord.Location = new System.Drawing.Point(76, 46);
            this.radDoNotRecord.Name = "radDoNotRecord";
            this.radDoNotRecord.Size = new System.Drawing.Size(105, 20);
            this.radDoNotRecord.TabIndex = 2;
            this.radDoNotRecord.TabStop = true;
            this.radDoNotRecord.Text = "Do not record";
            this.radDoNotRecord.UseVisualStyleBackColor = true;
            this.radDoNotRecord.CheckedChanged += new System.EventHandler(this.radDoNotRecord_CheckedChanged);
            // 
            // radRecordFromComputer
            // 
            this.radRecordFromComputer.AutoSize = true;
            this.radRecordFromComputer.Location = new System.Drawing.Point(76, 22);
            this.radRecordFromComputer.Name = "radRecordFromComputer";
            this.radRecordFromComputer.Size = new System.Drawing.Size(182, 20);
            this.radRecordFromComputer.TabIndex = 1;
            this.radRecordFromComputer.Text = "Record from this computer";
            this.radRecordFromComputer.UseVisualStyleBackColor = true;
            this.radRecordFromComputer.CheckedChanged += new System.EventHandler(this.radRecordFromComputer_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OnboardingHelper_NetCore.Properties.Resources._13013;
            this.pictureBox3.Location = new System.Drawing.Point(16, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(216, 256);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // RDPAudioSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RDPAudioSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remote Desktop Connection";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RadioButton radPlayOnRemoteComputer;
        private RadioButton radDoNotPlay;
        private RadioButton radPlayOnThisComputer;
        private PictureBox pictureBox2;
        private GroupBox groupBox2;
        private RadioButton radDoNotRecord;
        private RadioButton radRecordFromComputer;
        private PictureBox pictureBox3;
        private Button btnCancel;
        private Button btnOK;
    }
}