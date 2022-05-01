namespace OnboardingHelper_NetCore.userControls
{
    partial class VPNUserCtl
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
            this.dgVpns = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTunnelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEncryptionLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAuthMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRememberCredential = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnSplitTunneling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddVPN = new System.Windows.Forms.Button();
            this.btnDeleteWiFi = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgVpns)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVpns
            // 
            this.dgVpns.AllowUserToAddRows = false;
            this.dgVpns.AllowUserToDeleteRows = false;
            this.dgVpns.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgVpns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVpns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnAddress,
            this.columnTunnelType,
            this.columnEncryptionLevel,
            this.columnAuthMethod,
            this.columnRememberCredential,
            this.columnSplitTunneling});
            this.dgVpns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVpns.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgVpns.Location = new System.Drawing.Point(0, 0);
            this.dgVpns.Name = "dgVpns";
            this.dgVpns.ReadOnly = true;
            this.dgVpns.RowTemplate.Height = 25;
            this.dgVpns.Size = new System.Drawing.Size(765, 316);
            this.dgVpns.TabIndex = 11;
            // 
            // columnName
            // 
            this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnName.HeaderText = "Connection Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnAddress
            // 
            this.columnAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnAddress.HeaderText = "Server Address";
            this.columnAddress.Name = "columnAddress";
            this.columnAddress.ReadOnly = true;
            // 
            // columnTunnelType
            // 
            this.columnTunnelType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnTunnelType.HeaderText = "Tunnel Type";
            this.columnTunnelType.Name = "columnTunnelType";
            this.columnTunnelType.ReadOnly = true;
            this.columnTunnelType.Width = 86;
            // 
            // columnEncryptionLevel
            // 
            this.columnEncryptionLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnEncryptionLevel.HeaderText = "Encryption Level";
            this.columnEncryptionLevel.Name = "columnEncryptionLevel";
            this.columnEncryptionLevel.ReadOnly = true;
            this.columnEncryptionLevel.Width = 107;
            // 
            // columnAuthMethod
            // 
            this.columnAuthMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnAuthMethod.HeaderText = "Auth. Method";
            this.columnAuthMethod.Name = "columnAuthMethod";
            this.columnAuthMethod.ReadOnly = true;
            this.columnAuthMethod.Width = 95;
            // 
            // columnRememberCredential
            // 
            this.columnRememberCredential.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnRememberCredential.HeaderText = "Remember Credentials?";
            this.columnRememberCredential.Name = "columnRememberCredential";
            this.columnRememberCredential.ReadOnly = true;
            this.columnRememberCredential.Width = 122;
            // 
            // columnSplitTunneling
            // 
            this.columnSplitTunneling.HeaderText = "Split Tunneling?";
            this.columnSplitTunneling.Name = "columnSplitTunneling";
            this.columnSplitTunneling.ReadOnly = true;
            // 
            // btnAddVPN
            // 
            this.btnAddVPN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddVPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddVPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVPN.Location = new System.Drawing.Point(3, 8);
            this.btnAddVPN.Name = "btnAddVPN";
            this.btnAddVPN.Size = new System.Drawing.Size(142, 23);
            this.btnAddVPN.TabIndex = 6;
            this.btnAddVPN.Text = "Add VPN...";
            this.btnAddVPN.UseVisualStyleBackColor = false;
            this.btnAddVPN.Click += new System.EventHandler(this.btnAddVPN_Click);
            // 
            // btnDeleteWiFi
            // 
            this.btnDeleteWiFi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteWiFi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteWiFi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteWiFi.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteWiFi.Location = new System.Drawing.Point(620, 8);
            this.btnDeleteWiFi.Name = "btnDeleteWiFi";
            this.btnDeleteWiFi.Size = new System.Drawing.Size(142, 23);
            this.btnDeleteWiFi.TabIndex = 7;
            this.btnDeleteWiFi.Text = "Delete Selected";
            this.btnDeleteWiFi.UseVisualStyleBackColor = false;
            this.btnDeleteWiFi.Click += new System.EventHandler(this.btnDeleteWiFi_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddVPN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteWiFi, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 316);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 40);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // VPNUserCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgVpns);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VPNUserCtl";
            this.Size = new System.Drawing.Size(765, 356);
            ((System.ComponentModel.ISupportInitialize)(this.dgVpns)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgVpns;
        private Button btnAddVPN;
        private Button btnDeleteWiFi;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnAddress;
        private DataGridViewTextBoxColumn columnTunnelType;
        private DataGridViewTextBoxColumn columnEncryptionLevel;
        private DataGridViewTextBoxColumn columnAuthMethod;
        private DataGridViewCheckBoxColumn columnRememberCredential;
        private DataGridViewTextBoxColumn columnSplitTunneling;
    }
}
