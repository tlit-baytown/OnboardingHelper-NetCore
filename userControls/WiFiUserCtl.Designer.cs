namespace OnboardingHelper_NetCore.userControls
{
    partial class WiFiUserCtl
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
            this.dgWifis = new System.Windows.Forms.DataGridView();
            this.btnAddWiFi = new System.Windows.Forms.Button();
            this.btnDeleteWiFi = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.columnSSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPSK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAuthType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnConnectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEncryption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIsHidden = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgWifis)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgWifis
            // 
            this.dgWifis.AllowUserToAddRows = false;
            this.dgWifis.AllowUserToDeleteRows = false;
            this.dgWifis.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgWifis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWifis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnSSID,
            this.columnPSK,
            this.columnAuthType,
            this.columnConnectType,
            this.columnEncryption,
            this.columnIsHidden});
            this.dgWifis.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgWifis.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgWifis.Location = new System.Drawing.Point(0, 0);
            this.dgWifis.Name = "dgWifis";
            this.dgWifis.ReadOnly = true;
            this.dgWifis.RowTemplate.Height = 25;
            this.dgWifis.Size = new System.Drawing.Size(765, 319);
            this.dgWifis.TabIndex = 9;
            // 
            // btnAddWiFi
            // 
            this.btnAddWiFi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddWiFi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddWiFi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWiFi.Location = new System.Drawing.Point(3, 8);
            this.btnAddWiFi.Name = "btnAddWiFi";
            this.btnAddWiFi.Size = new System.Drawing.Size(142, 23);
            this.btnAddWiFi.TabIndex = 6;
            this.btnAddWiFi.Text = "Add Wi-Fi...";
            this.btnAddWiFi.UseVisualStyleBackColor = false;
            this.btnAddWiFi.Click += new System.EventHandler(this.btnAddWiFi_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.btnAddWiFi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteWiFi, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 316);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 40);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // columnSSID
            // 
            this.columnSSID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnSSID.HeaderText = "SSID";
            this.columnSSID.Name = "columnSSID";
            this.columnSSID.ReadOnly = true;
            // 
            // columnPSK
            // 
            this.columnPSK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPSK.HeaderText = "Pre-Shared Key";
            this.columnPSK.Name = "columnPSK";
            this.columnPSK.ReadOnly = true;
            // 
            // columnAuthType
            // 
            this.columnAuthType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnAuthType.HeaderText = "Auth. Type";
            this.columnAuthType.Name = "columnAuthType";
            this.columnAuthType.ReadOnly = true;
            this.columnAuthType.Width = 86;
            // 
            // columnConnectType
            // 
            this.columnConnectType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnConnectType.HeaderText = "Connection Type";
            this.columnConnectType.Name = "columnConnectType";
            this.columnConnectType.ReadOnly = true;
            this.columnConnectType.Width = 109;
            // 
            // columnEncryption
            // 
            this.columnEncryption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnEncryption.HeaderText = "Encryption Type";
            this.columnEncryption.Name = "columnEncryption";
            this.columnEncryption.ReadOnly = true;
            this.columnEncryption.Width = 104;
            // 
            // columnIsHidden
            // 
            this.columnIsHidden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnIsHidden.HeaderText = "Is Hidden Network?";
            this.columnIsHidden.Name = "columnIsHidden";
            this.columnIsHidden.ReadOnly = true;
            this.columnIsHidden.Width = 103;
            // 
            // WiFiUserCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgWifis);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WiFiUserCtl";
            this.Size = new System.Drawing.Size(765, 356);
            ((System.ComponentModel.ISupportInitialize)(this.dgWifis)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgWifis;
        private Button btnAddWiFi;
        private Button btnDeleteWiFi;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn columnSSID;
        private DataGridViewTextBoxColumn columnPSK;
        private DataGridViewTextBoxColumn columnAuthType;
        private DataGridViewTextBoxColumn columnConnectType;
        private DataGridViewTextBoxColumn columnEncryption;
        private DataGridViewCheckBoxColumn columnIsHidden;
    }
}
