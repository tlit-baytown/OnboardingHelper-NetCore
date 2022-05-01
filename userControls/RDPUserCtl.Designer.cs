namespace OnboardingHelper_NetCore.userControls
{
    partial class RDPUserCtl
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Default", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.lvRDPPaths = new System.Windows.Forms.ListView();
            this.rdpComputer = new System.Windows.Forms.ColumnHeader();
            this.rdpFilePath = new System.Windows.Forms.ColumnHeader();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRDPFile = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvRDPPaths
            // 
            this.lvRDPPaths.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rdpComputer,
            this.rdpFilePath});
            this.lvRDPPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "Default";
            listViewGroup1.Name = "default";
            this.lvRDPPaths.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lvRDPPaths.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvRDPPaths.Location = new System.Drawing.Point(0, 0);
            this.lvRDPPaths.Name = "lvRDPPaths";
            this.lvRDPPaths.Size = new System.Drawing.Size(765, 316);
            this.lvRDPPaths.TabIndex = 3;
            this.lvRDPPaths.UseCompatibleStateImageBehavior = false;
            this.lvRDPPaths.View = System.Windows.Forms.View.Details;
            // 
            // rdpComputer
            // 
            this.rdpComputer.Text = "Computer";
            this.rdpComputer.Width = 200;
            // 
            // rdpFilePath
            // 
            this.rdpFilePath.Text = "File Path";
            this.rdpFilePath.Width = 520;
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Filter = "RDP Files (*.rdp)|*.rdp";
            this.dlgOpenFile.Multiselect = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddAccount, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Location = new System.Drawing.Point(3, 37);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(94, 25);
            this.btnAddAccount.TabIndex = 6;
            this.btnAddAccount.Text = "Add Account...";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAccount.Location = new System.Drawing.Point(103, 37);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(94, 25);
            this.btnDeleteAccount.TabIndex = 7;
            this.btnDeleteAccount.Text = "Delete Selected";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddRDPFile, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteSelected, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 316);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(765, 40);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // btnAddRDPFile
            // 
            this.btnAddRDPFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddRDPFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddRDPFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRDPFile.Location = new System.Drawing.Point(3, 8);
            this.btnAddRDPFile.Name = "btnAddRDPFile";
            this.btnAddRDPFile.Size = new System.Drawing.Size(142, 23);
            this.btnAddRDPFile.TabIndex = 6;
            this.btnAddRDPFile.Text = "Add RDP...";
            this.btnAddRDPFile.UseVisualStyleBackColor = false;
            this.btnAddRDPFile.Click += new System.EventHandler(this.btnAddRDPFile_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelected.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteSelected.Location = new System.Drawing.Point(620, 8);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(142, 23);
            this.btnDeleteSelected.TabIndex = 7;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = false;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // RDPUserCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvRDPPaths);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "RDPUserCtl";
            this.Size = new System.Drawing.Size(765, 356);
            this.Load += new System.EventHandler(this.RDPUserCtl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ListView lvRDPPaths;
        private ColumnHeader rdpComputer;
        private ColumnHeader rdpFilePath;
        private OpenFileDialog dlgOpenFile;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAddAccount;
        private Button btnDeleteAccount;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAddRDPFile;
        private Button btnDeleteSelected;
    }
}
