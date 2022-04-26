namespace OnboardingHelper_NetCore.forms
{
    partial class AddWiFiPopUp
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEncryptionType = new System.Windows.Forms.ComboBox();
            this.txtPSK = new System.Windows.Forms.TextBox();
            this.cmbConnectionType = new System.Windows.Forms.ComboBox();
            this.lblPSK = new System.Windows.Forms.Label();
            this.cmbAuthenticationType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSSID = new System.Windows.Forms.TextBox();
            this.tlpEnterpriseCreds = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnterpriseUsername = new System.Windows.Forms.TextBox();
            this.txtEnterprisePassword = new System.Windows.Forms.TextBox();
            this.grpEnterpriseCreds = new System.Windows.Forms.GroupBox();
            this.chkIsHiddenNetwork = new System.Windows.Forms.CheckBox();
            this.btnAddAndClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpEnterpriseCreds.SuspendLayout();
            this.grpEnterpriseCreds.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.10084F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.89916F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbEncryptionType, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPSK, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbConnectionType, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPSK, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbAuthenticationType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSSID, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.73684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.26316F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 185);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Encryption Type: ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Connection Type: ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Authentication Type: ";
            // 
            // cmbEncryptionType
            // 
            this.cmbEncryptionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEncryptionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncryptionType.FormattingEnabled = true;
            this.cmbEncryptionType.Items.AddRange(new object[] {
            "None",
            "WEP",
            "TKIP",
            "AES"});
            this.cmbEncryptionType.Location = new System.Drawing.Point(132, 152);
            this.cmbEncryptionType.Name = "cmbEncryptionType";
            this.cmbEncryptionType.Size = new System.Drawing.Size(341, 24);
            this.cmbEncryptionType.TabIndex = 14;
            this.cmbEncryptionType.SelectedIndexChanged += new System.EventHandler(this.cmbEncryptionType_SelectedIndexChanged);
            // 
            // txtPSK
            // 
            this.txtPSK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPSK.Location = new System.Drawing.Point(132, 37);
            this.txtPSK.Name = "txtPSK";
            this.txtPSK.Size = new System.Drawing.Size(341, 23);
            this.txtPSK.TabIndex = 3;
            this.txtPSK.TextChanged += new System.EventHandler(this.txtPSK_TextChanged);
            // 
            // cmbConnectionType
            // 
            this.cmbConnectionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConnectionType.FormattingEnabled = true;
            this.cmbConnectionType.Items.AddRange(new object[] {
            "ESS",
            "IBSS"});
            this.cmbConnectionType.Location = new System.Drawing.Point(132, 112);
            this.cmbConnectionType.Name = "cmbConnectionType";
            this.cmbConnectionType.Size = new System.Drawing.Size(341, 24);
            this.cmbConnectionType.TabIndex = 13;
            this.cmbConnectionType.SelectedIndexChanged += new System.EventHandler(this.cmbConnectionType_SelectedIndexChanged);
            // 
            // lblPSK
            // 
            this.lblPSK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPSK.AutoSize = true;
            this.lblPSK.Location = new System.Drawing.Point(3, 40);
            this.lblPSK.Name = "lblPSK";
            this.lblPSK.Size = new System.Drawing.Size(123, 16);
            this.lblPSK.TabIndex = 2;
            this.lblPSK.Text = "Pre-Shared Key: ";
            // 
            // cmbAuthenticationType
            // 
            this.cmbAuthenticationType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAuthenticationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthenticationType.FormattingEnabled = true;
            this.cmbAuthenticationType.Items.AddRange(new object[] {
            "Open",
            "WEP",
            "WPA",
            "WPA2: Pre-Shared Key",
            "WPA2: Enterprise",
            "WPA3: Pre-Shared Key",
            "WPA3: Enterprise"});
            this.cmbAuthenticationType.Location = new System.Drawing.Point(132, 74);
            this.cmbAuthenticationType.Name = "cmbAuthenticationType";
            this.cmbAuthenticationType.Size = new System.Drawing.Size(341, 24);
            this.cmbAuthenticationType.TabIndex = 12;
            this.cmbAuthenticationType.SelectedIndexChanged += new System.EventHandler(this.cmbAuthenticationType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SSID: ";
            // 
            // txtSSID
            // 
            this.txtSSID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSSID.Location = new System.Drawing.Point(132, 3);
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Size = new System.Drawing.Size(341, 23);
            this.txtSSID.TabIndex = 1;
            this.txtSSID.TextChanged += new System.EventHandler(this.txtSSID_TextChanged);
            // 
            // tlpEnterpriseCreds
            // 
            this.tlpEnterpriseCreds.ColumnCount = 2;
            this.tlpEnterpriseCreds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.45509F));
            this.tlpEnterpriseCreds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.54491F));
            this.tlpEnterpriseCreds.Controls.Add(this.label3, 0, 1);
            this.tlpEnterpriseCreds.Controls.Add(this.label4, 0, 0);
            this.tlpEnterpriseCreds.Controls.Add(this.txtEnterpriseUsername, 1, 0);
            this.tlpEnterpriseCreds.Controls.Add(this.txtEnterprisePassword, 1, 1);
            this.tlpEnterpriseCreds.Location = new System.Drawing.Point(6, 27);
            this.tlpEnterpriseCreds.Name = "tlpEnterpriseCreds";
            this.tlpEnterpriseCreds.RowCount = 2;
            this.tlpEnterpriseCreds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.18033F));
            this.tlpEnterpriseCreds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.tlpEnterpriseCreds.Size = new System.Drawing.Size(322, 65);
            this.tlpEnterpriseCreds.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password: ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username: ";
            // 
            // txtEnterpriseUsername
            // 
            this.txtEnterpriseUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnterpriseUsername.Location = new System.Drawing.Point(75, 4);
            this.txtEnterpriseUsername.Name = "txtEnterpriseUsername";
            this.txtEnterpriseUsername.Size = new System.Drawing.Size(244, 23);
            this.txtEnterpriseUsername.TabIndex = 1;
            this.txtEnterpriseUsername.TextChanged += new System.EventHandler(this.txtEnterpriseUsername_TextChanged);
            // 
            // txtEnterprisePassword
            // 
            this.txtEnterprisePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnterprisePassword.Location = new System.Drawing.Point(75, 36);
            this.txtEnterprisePassword.Name = "txtEnterprisePassword";
            this.txtEnterprisePassword.Size = new System.Drawing.Size(244, 23);
            this.txtEnterprisePassword.TabIndex = 3;
            this.txtEnterprisePassword.UseSystemPasswordChar = true;
            this.txtEnterprisePassword.TextChanged += new System.EventHandler(this.txtEnterprisePassword_TextChanged);
            // 
            // grpEnterpriseCreds
            // 
            this.grpEnterpriseCreds.Controls.Add(this.tlpEnterpriseCreds);
            this.grpEnterpriseCreds.Location = new System.Drawing.Point(10, 204);
            this.grpEnterpriseCreds.Name = "grpEnterpriseCreds";
            this.grpEnterpriseCreds.Size = new System.Drawing.Size(334, 100);
            this.grpEnterpriseCreds.TabIndex = 7;
            this.grpEnterpriseCreds.TabStop = false;
            this.grpEnterpriseCreds.Text = "Enterprise Credentials";
            this.grpEnterpriseCreds.Visible = false;
            // 
            // chkIsHiddenNetwork
            // 
            this.chkIsHiddenNetwork.AutoSize = true;
            this.chkIsHiddenNetwork.Location = new System.Drawing.Point(357, 213);
            this.chkIsHiddenNetwork.Name = "chkIsHiddenNetwork";
            this.chkIsHiddenNetwork.Size = new System.Drawing.Size(134, 20);
            this.chkIsHiddenNetwork.TabIndex = 8;
            this.chkIsHiddenNetwork.Text = "Is Hidden Network?";
            this.chkIsHiddenNetwork.UseVisualStyleBackColor = true;
            this.chkIsHiddenNetwork.CheckedChanged += new System.EventHandler(this.chkIsHiddenNetwork_CheckedChanged);
            // 
            // btnAddAndClear
            // 
            this.btnAddAndClear.Location = new System.Drawing.Point(379, 311);
            this.btnAddAndClear.Name = "btnAddAndClear";
            this.btnAddAndClear.Size = new System.Drawing.Size(107, 25);
            this.btnAddAndClear.TabIndex = 11;
            this.btnAddAndClear.Text = "Add && Clear";
            this.btnAddAndClear.UseVisualStyleBackColor = true;
            this.btnAddAndClear.Click += new System.EventHandler(this.btnAddAndClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(153, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 25);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 25);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddWiFiPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 343);
            this.Controls.Add(this.btnAddAndClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkIsHiddenNetwork);
            this.Controls.Add(this.grpEnterpriseCreds);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWiFiPopUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Wi-Fi Profile";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddWiFiPopUp_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpEnterpriseCreds.ResumeLayout(false);
            this.tlpEnterpriseCreds.PerformLayout();
            this.grpEnterpriseCreds.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblPSK;
        private Label label1;
        private TextBox txtSSID;
        private TableLayoutPanel tlpEnterpriseCreds;
        private Label label3;
        private Label label4;
        private TextBox txtEnterpriseUsername;
        private TextBox txtEnterprisePassword;
        private GroupBox grpEnterpriseCreds;
        private TextBox txtPSK;
        private CheckBox chkIsHiddenNetwork;
        private Button btnAddAndClear;
        private Button btnCancel;
        private Button btnAdd;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cmbEncryptionType;
        private ComboBox cmbConnectionType;
        private ComboBox cmbAuthenticationType;
    }
}