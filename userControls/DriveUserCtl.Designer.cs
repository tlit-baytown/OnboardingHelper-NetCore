namespace OnboardingHelper_NetCore.userControls
{
    partial class DriveUserCtl
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
            this.dgDrives = new System.Windows.Forms.DataGridView();
            this.columnDriveLetter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnReconnect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnUseDiffCreds = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAddDrive = new System.Windows.Forms.Button();
            this.btnDeleteDrive = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgDrives)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDrives
            // 
            this.dgDrives.AllowUserToAddRows = false;
            this.dgDrives.AllowUserToDeleteRows = false;
            this.dgDrives.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgDrives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDrives.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDriveLetter,
            this.columnPath,
            this.columnReconnect,
            this.columnUseDiffCreds});
            this.dgDrives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDrives.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgDrives.Location = new System.Drawing.Point(0, 0);
            this.dgDrives.Name = "dgDrives";
            this.dgDrives.ReadOnly = true;
            this.dgDrives.RowTemplate.Height = 25;
            this.dgDrives.Size = new System.Drawing.Size(765, 316);
            this.dgDrives.TabIndex = 9;
            // 
            // columnDriveLetter
            // 
            this.columnDriveLetter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnDriveLetter.HeaderText = "Drive Letter";
            this.columnDriveLetter.Name = "columnDriveLetter";
            this.columnDriveLetter.ReadOnly = true;
            this.columnDriveLetter.Width = 83;
            // 
            // columnPath
            // 
            this.columnPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnPath.HeaderText = "Folder";
            this.columnPath.Name = "columnPath";
            this.columnPath.ReadOnly = true;
            this.columnPath.Width = 63;
            // 
            // columnReconnect
            // 
            this.columnReconnect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnReconnect.HeaderText = "Reconnect At Sign-In?";
            this.columnReconnect.Name = "columnReconnect";
            this.columnReconnect.ReadOnly = true;
            // 
            // columnUseDiffCreds
            // 
            this.columnUseDiffCreds.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnUseDiffCreds.HeaderText = "Use Different Credentials?";
            this.columnUseDiffCreds.Name = "columnUseDiffCreds";
            this.columnUseDiffCreds.ReadOnly = true;
            // 
            // btnAddDrive
            // 
            this.btnAddDrive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddDrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDrive.Location = new System.Drawing.Point(3, 8);
            this.btnAddDrive.Name = "btnAddDrive";
            this.btnAddDrive.Size = new System.Drawing.Size(142, 23);
            this.btnAddDrive.TabIndex = 6;
            this.btnAddDrive.Text = "Add Mapped Drive...";
            this.btnAddDrive.UseVisualStyleBackColor = false;
            this.btnAddDrive.Click += new System.EventHandler(this.btnAddDrive_Click);
            // 
            // btnDeleteDrive
            // 
            this.btnDeleteDrive.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteDrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDrive.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteDrive.Location = new System.Drawing.Point(620, 8);
            this.btnDeleteDrive.Name = "btnDeleteDrive";
            this.btnDeleteDrive.Size = new System.Drawing.Size(142, 23);
            this.btnDeleteDrive.TabIndex = 7;
            this.btnDeleteDrive.Text = "Delete Selected";
            this.btnDeleteDrive.UseVisualStyleBackColor = false;
            this.btnDeleteDrive.Click += new System.EventHandler(this.btnDeleteDrive_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddDrive, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteDrive, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 316);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 40);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // DriveUserCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgDrives);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DriveUserCtl";
            this.Size = new System.Drawing.Size(765, 356);
            ((System.ComponentModel.ISupportInitialize)(this.dgDrives)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgDrives;
        private Button btnAddDrive;
        private Button btnDeleteDrive;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn columnDriveLetter;
        private DataGridViewTextBoxColumn columnPath;
        private DataGridViewCheckBoxColumn columnReconnect;
        private DataGridViewCheckBoxColumn columnUseDiffCreds;
    }
}
