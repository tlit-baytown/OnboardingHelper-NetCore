namespace OnboardingHelper_NetCore.userControls
{
    partial class BasicInfoUserCtl
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
            this.grpDomainCredentials = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDomainPassword = new System.Windows.Forms.TextBox();
            this.btnShowDomainPassword = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDomainUsername = new System.Windows.Forms.TextBox();
            this.chkPerformTZSync = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComputerName = new System.Windows.Forms.TextBox();
            this.cmbTimeZones = new System.Windows.Forms.ComboBox();
            this.cmbNTPServers = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.grpDomainCredentials.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDomainCredentials
            // 
            this.grpDomainCredentials.Controls.Add(this.tableLayoutPanel2);
            this.grpDomainCredentials.Location = new System.Drawing.Point(3, 3);
            this.grpDomainCredentials.Name = "grpDomainCredentials";
            this.grpDomainCredentials.Size = new System.Drawing.Size(385, 100);
            this.grpDomainCredentials.TabIndex = 12;
            this.grpDomainCredentials.TabStop = false;
            this.grpDomainCredentials.Text = "Domain Credentials";
            this.grpDomainCredentials.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.27027F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.72973F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDomainUsername, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.56097F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.43903F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(370, 73);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.txtDomainPassword);
            this.flowLayoutPanel1.Controls.Add(this.btnShowDomainPassword);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(77, 37);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 33);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // txtDomainPassword
            // 
            this.txtDomainPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDomainPassword.Location = new System.Drawing.Point(3, 3);
            this.txtDomainPassword.Name = "txtDomainPassword";
            this.txtDomainPassword.PlaceholderText = "Password for domain administrator";
            this.txtDomainPassword.Size = new System.Drawing.Size(253, 23);
            this.txtDomainPassword.TabIndex = 3;
            this.txtDomainPassword.UseSystemPasswordChar = true;
            this.txtDomainPassword.TextChanged += new System.EventHandler(this.txtDomainPassword_TextChanged);
            this.txtDomainPassword.Leave += new System.EventHandler(this.txtDomainPassword_Leave);
            // 
            // btnShowDomainPassword
            // 
            this.btnShowDomainPassword.BackgroundImage = global::OnboardingHelper_NetCore.Properties.Resources.show_24x24;
            this.btnShowDomainPassword.FlatAppearance.BorderSize = 0;
            this.btnShowDomainPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDomainPassword.Location = new System.Drawing.Point(262, 3);
            this.btnShowDomainPassword.Name = "btnShowDomainPassword";
            this.btnShowDomainPassword.Size = new System.Drawing.Size(24, 24);
            this.btnShowDomainPassword.TabIndex = 4;
            this.btnShowDomainPassword.UseVisualStyleBackColor = true;
            this.btnShowDomainPassword.MouseEnter += new System.EventHandler(this.btnShowDomainPassword_MouseEnter);
            this.btnShowDomainPassword.MouseLeave += new System.EventHandler(this.btnShowDomainPassword_MouseLeave);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password: ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username: ";
            // 
            // txtDomainUsername
            // 
            this.txtDomainUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDomainUsername.Location = new System.Drawing.Point(77, 5);
            this.txtDomainUsername.Name = "txtDomainUsername";
            this.txtDomainUsername.PlaceholderText = "Username of domain administrator";
            this.txtDomainUsername.Size = new System.Drawing.Size(290, 23);
            this.txtDomainUsername.TabIndex = 1;
            this.txtDomainUsername.TextChanged += new System.EventHandler(this.txtDomainUsername_TextChanged);
            // 
            // chkPerformTZSync
            // 
            this.chkPerformTZSync.AutoSize = true;
            this.chkPerformTZSync.Location = new System.Drawing.Point(3, 109);
            this.chkPerformTZSync.Name = "chkPerformTZSync";
            this.chkPerformTZSync.Size = new System.Drawing.Size(166, 19);
            this.chkPerformTZSync.TabIndex = 11;
            this.chkPerformTZSync.Text = "Perform Time Server Sync?";
            this.chkPerformTZSync.UseVisualStyleBackColor = true;
            this.chkPerformTZSync.CheckedChanged += new System.EventHandler(this.chkPerformTZSync_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.65204F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.34796F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDomain, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtComputerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbTimeZones, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbNTPServers, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(877, 140);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Primary NTP Server: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time Zone: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Domain: ";
            // 
            // txtDomain
            // 
            this.txtDomain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDomain.Location = new System.Drawing.Point(166, 41);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(708, 23);
            this.txtDomain.TabIndex = 3;
            this.txtDomain.TextChanged += new System.EventHandler(this.txtDomain_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer Name: ";
            // 
            // txtComputerName
            // 
            this.txtComputerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComputerName.Location = new System.Drawing.Point(166, 6);
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.Size = new System.Drawing.Size(708, 23);
            this.txtComputerName.TabIndex = 1;
            this.txtComputerName.TextChanged += new System.EventHandler(this.txtComputerName_TextChanged);
            // 
            // cmbTimeZones
            // 
            this.cmbTimeZones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTimeZones.DisplayMember = "DisplayName";
            this.cmbTimeZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeZones.FormattingEnabled = true;
            this.cmbTimeZones.Location = new System.Drawing.Point(166, 76);
            this.cmbTimeZones.Name = "cmbTimeZones";
            this.cmbTimeZones.Size = new System.Drawing.Size(708, 23);
            this.cmbTimeZones.TabIndex = 5;
            this.cmbTimeZones.SelectedIndexChanged += new System.EventHandler(this.cmbTimeZones_SelectedIndexChanged);
            // 
            // cmbNTPServers
            // 
            this.cmbNTPServers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNTPServers.FormattingEnabled = true;
            this.cmbNTPServers.Location = new System.Drawing.Point(166, 111);
            this.cmbNTPServers.Name = "cmbNTPServers";
            this.cmbNTPServers.Size = new System.Drawing.Size(708, 23);
            this.cmbNTPServers.TabIndex = 7;
            this.cmbNTPServers.SelectedIndexChanged += new System.EventHandler(this.cmbNTPServers_SelectedIndexChanged);
            this.cmbNTPServers.TextChanged += new System.EventHandler(this.cmbNTPServers_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 471);
            this.panel1.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.grpDomainCredentials);
            this.flowLayoutPanel2.Controls.Add(this.chkPerformTZSync);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 140);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(395, 331);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // BasicInfoUserCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "BasicInfoUserCtl";
            this.Size = new System.Drawing.Size(877, 471);
            this.Load += new System.EventHandler(this.BasicInfoUserCtl_Load);
            this.grpDomainCredentials.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpDomainCredentials;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtDomainPassword;
        private Button btnShowDomainPassword;
        private Label label6;
        private Label label5;
        private TextBox txtDomainUsername;
        private CheckBox chkPerformTZSync;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDomain;
        private Label label1;
        private TextBox txtComputerName;
        private ComboBox cmbTimeZones;
        private ComboBox cmbNTPServers;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
