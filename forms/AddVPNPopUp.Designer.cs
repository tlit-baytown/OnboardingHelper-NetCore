namespace OnboardingHelper_NetCore.forms
{
    partial class AddVPNPopUp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnectionName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTunnelType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEncryptionLevel = new System.Windows.Forms.ComboBox();
            this.cmbAuthMethod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkRememberCredentials = new System.Windows.Forms.CheckBox();
            this.chkSplitTunneling = new System.Windows.Forms.CheckBox();
            this.chkAutoReconnect = new System.Windows.Forms.CheckBox();
            this.btnAddAndClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpCredentials = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudIdleDisconnect = new System.Windows.Forms.NumericUpDown();
            this.btnSetDisconnectToZero = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpCredentials.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdleDisconnect)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.39437F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.60564F));
            this.tableLayoutPanel1.Controls.Add(this.txtServerAddress, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtConnectionName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbTunnelType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbEncryptionLevel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbAuthMethod, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.89874F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.10126F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(497, 184);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerAddress.Location = new System.Drawing.Point(164, 48);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(330, 23);
            this.txtServerAddress.TabIndex = 2;
            this.txtServerAddress.TextChanged += new System.EventHandler(this.txtServerAddress_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Address: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection Name: ";
            // 
            // txtConnectionName
            // 
            this.txtConnectionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnectionName.Location = new System.Drawing.Point(164, 9);
            this.txtConnectionName.Name = "txtConnectionName";
            this.txtConnectionName.Size = new System.Drawing.Size(330, 23);
            this.txtConnectionName.TabIndex = 1;
            this.txtConnectionName.TextChanged += new System.EventHandler(this.txtConnectionName_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tunnel Type: ";
            // 
            // cmbTunnelType
            // 
            this.cmbTunnelType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTunnelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTunnelType.FormattingEnabled = true;
            this.cmbTunnelType.Items.AddRange(new object[] {
            "IKEv2",
            "SSTP (Secure Socket Tunneling Protocol)",
            "L2TP/IPsec with certificate",
            "L2TP/IPsec with pre-shared key",
            "PPTP (Point to Point Tunneling Protocol)"});
            this.cmbTunnelType.Location = new System.Drawing.Point(164, 85);
            this.cmbTunnelType.Name = "cmbTunnelType";
            this.cmbTunnelType.Size = new System.Drawing.Size(330, 23);
            this.cmbTunnelType.TabIndex = 3;
            this.cmbTunnelType.SelectedIndexChanged += new System.EventHandler(this.cmbTunnelType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Encryption Level: ";
            // 
            // cmbEncryptionLevel
            // 
            this.cmbEncryptionLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEncryptionLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncryptionLevel.FormattingEnabled = true;
            this.cmbEncryptionLevel.Items.AddRange(new object[] {
            "No Encryption",
            "Optional",
            "Required",
            "Maximum",
            "Custom"});
            this.cmbEncryptionLevel.Location = new System.Drawing.Point(164, 120);
            this.cmbEncryptionLevel.Name = "cmbEncryptionLevel";
            this.cmbEncryptionLevel.Size = new System.Drawing.Size(330, 23);
            this.cmbEncryptionLevel.TabIndex = 4;
            this.cmbEncryptionLevel.SelectedIndexChanged += new System.EventHandler(this.cmbEncryptionLevel_SelectedIndexChanged);
            // 
            // cmbAuthMethod
            // 
            this.cmbAuthMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAuthMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthMethod.FormattingEnabled = true;
            this.cmbAuthMethod.Items.AddRange(new object[] {
            "PAP",
            "Chap",
            "MSChapv2",
            "EAP",
            "Machine Certificate"});
            this.cmbAuthMethod.Location = new System.Drawing.Point(164, 155);
            this.cmbAuthMethod.Name = "cmbAuthMethod";
            this.cmbAuthMethod.Size = new System.Drawing.Size(330, 23);
            this.cmbAuthMethod.TabIndex = 5;
            this.cmbAuthMethod.SelectedIndexChanged += new System.EventHandler(this.cmbAuthMethod_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Authentication Method: ";
            // 
            // chkRememberCredentials
            // 
            this.chkRememberCredentials.AutoSize = true;
            this.chkRememberCredentials.Location = new System.Drawing.Point(12, 202);
            this.chkRememberCredentials.Name = "chkRememberCredentials";
            this.chkRememberCredentials.Size = new System.Drawing.Size(151, 19);
            this.chkRememberCredentials.TabIndex = 6;
            this.chkRememberCredentials.Text = "Remember Credentials?";
            this.chkRememberCredentials.UseVisualStyleBackColor = true;
            this.chkRememberCredentials.CheckedChanged += new System.EventHandler(this.chkRememberCredentials_CheckedChanged);
            // 
            // chkSplitTunneling
            // 
            this.chkSplitTunneling.AutoSize = true;
            this.chkSplitTunneling.Location = new System.Drawing.Point(180, 202);
            this.chkSplitTunneling.Name = "chkSplitTunneling";
            this.chkSplitTunneling.Size = new System.Drawing.Size(148, 19);
            this.chkSplitTunneling.TabIndex = 7;
            this.chkSplitTunneling.Text = "Enable Split Tunneling?";
            this.chkSplitTunneling.UseVisualStyleBackColor = true;
            this.chkSplitTunneling.CheckedChanged += new System.EventHandler(this.chkSplitTunneling_CheckedChanged);
            // 
            // chkAutoReconnect
            // 
            this.chkAutoReconnect.AutoSize = true;
            this.chkAutoReconnect.Location = new System.Drawing.Point(340, 202);
            this.chkAutoReconnect.Name = "chkAutoReconnect";
            this.chkAutoReconnect.Size = new System.Drawing.Size(116, 19);
            this.chkAutoReconnect.TabIndex = 8;
            this.chkAutoReconnect.Text = "Auto Reconnect?";
            this.chkAutoReconnect.UseVisualStyleBackColor = true;
            this.chkAutoReconnect.CheckedChanged += new System.EventHandler(this.chkAutoReconnect_CheckedChanged);
            // 
            // btnAddAndClear
            // 
            this.btnAddAndClear.Location = new System.Drawing.Point(407, 361);
            this.btnAddAndClear.Name = "btnAddAndClear";
            this.btnAddAndClear.Size = new System.Drawing.Size(107, 25);
            this.btnAddAndClear.TabIndex = 14;
            this.btnAddAndClear.Text = "Add && Clear";
            this.btnAddAndClear.UseVisualStyleBackColor = true;
            this.btnAddAndClear.Click += new System.EventHandler(this.btnAddAndClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 25);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(294, 361);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 25);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpCredentials
            // 
            this.grpCredentials.Controls.Add(this.tableLayoutPanel2);
            this.grpCredentials.Location = new System.Drawing.Point(12, 265);
            this.grpCredentials.Name = "grpCredentials";
            this.grpCredentials.Size = new System.Drawing.Size(497, 90);
            this.grpCredentials.TabIndex = 15;
            this.grpCredentials.TabStop = false;
            this.grpCredentials.Text = "Credentials";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.60083F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.39917F));
            this.tableLayoutPanel2.Controls.Add(this.lblPassword, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblUsername, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtUsername, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPassword, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(481, 62);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 39);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(145, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password (optional): ";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 8);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(145, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username (optional): ";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(154, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(324, 23);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(154, 35);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(324, 23);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Idle Disconnect (seconds): ";
            // 
            // nudIdleDisconnect
            // 
            this.nudIdleDisconnect.Location = new System.Drawing.Point(176, 232);
            this.nudIdleDisconnect.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudIdleDisconnect.Name = "nudIdleDisconnect";
            this.nudIdleDisconnect.Size = new System.Drawing.Size(92, 23);
            this.nudIdleDisconnect.TabIndex = 9;
            this.nudIdleDisconnect.ValueChanged += new System.EventHandler(this.nudIdleDisconnect_ValueChanged);
            // 
            // btnSetDisconnectToZero
            // 
            this.btnSetDisconnectToZero.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSetDisconnectToZero.Location = new System.Drawing.Point(274, 231);
            this.btnSetDisconnectToZero.Name = "btnSetDisconnectToZero";
            this.btnSetDisconnectToZero.Size = new System.Drawing.Size(75, 24);
            this.btnSetDisconnectToZero.TabIndex = 10;
            this.btnSetDisconnectToZero.Text = "Set to \'0\'";
            this.btnSetDisconnectToZero.UseVisualStyleBackColor = true;
            this.btnSetDisconnectToZero.Click += new System.EventHandler(this.btnSetDisconnectToZero_Click);
            // 
            // AddVPNPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 397);
            this.Controls.Add(this.btnSetDisconnectToZero);
            this.Controls.Add(this.nudIdleDisconnect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpCredentials);
            this.Controls.Add(this.btnAddAndClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkAutoReconnect);
            this.Controls.Add(this.chkSplitTunneling);
            this.Controls.Add(this.chkRememberCredentials);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVPNPopUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add VPN Profile";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddVPNPopUp_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpCredentials.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdleDisconnect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private TextBox txtConnectionName;
        private TextBox txtServerAddress;
        private Label label3;
        private ComboBox cmbTunnelType;
        private Label label4;
        private ComboBox cmbEncryptionLevel;
        private ComboBox cmbAuthMethod;
        private Label label5;
        private CheckBox chkRememberCredentials;
        private CheckBox chkSplitTunneling;
        private CheckBox chkAutoReconnect;
        private Button btnAddAndClear;
        private Button btnCancel;
        private Button btnAdd;
        private GroupBox grpCredentials;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label6;
        private NumericUpDown nudIdleDisconnect;
        private Button btnSetDisconnectToZero;
    }
}