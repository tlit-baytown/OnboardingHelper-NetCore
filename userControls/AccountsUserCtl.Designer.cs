namespace OnboardingHelper_NetCore.userControls
{
    partial class AccountsUserCtl
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
            this.dgAccounts = new System.Windows.Forms.DataGridView();
            this.columnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPasswordExpires = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnRequirePasswordChange = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAccounts
            // 
            this.dgAccounts.AllowUserToAddRows = false;
            this.dgAccounts.AllowUserToDeleteRows = false;
            this.dgAccounts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnUsername,
            this.columnPassword,
            this.columnComment,
            this.columnAccountType,
            this.columnPasswordExpires,
            this.columnRequirePasswordChange});
            this.dgAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgAccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgAccounts.Location = new System.Drawing.Point(0, 0);
            this.dgAccounts.Name = "dgAccounts";
            this.dgAccounts.ReadOnly = true;
            this.dgAccounts.RowTemplate.Height = 25;
            this.dgAccounts.Size = new System.Drawing.Size(765, 340);
            this.dgAccounts.TabIndex = 0;
            // 
            // columnUsername
            // 
            this.columnUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnUsername.HeaderText = "Username";
            this.columnUsername.Name = "columnUsername";
            this.columnUsername.ReadOnly = true;
            this.columnUsername.Width = 89;
            // 
            // columnPassword
            // 
            this.columnPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnPassword.HeaderText = "Password";
            this.columnPassword.Name = "columnPassword";
            this.columnPassword.ReadOnly = true;
            this.columnPassword.Width = 85;
            // 
            // columnComment
            // 
            this.columnComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnComment.HeaderText = "Comment";
            this.columnComment.Name = "columnComment";
            this.columnComment.ReadOnly = true;
            this.columnComment.Width = 89;
            // 
            // columnAccountType
            // 
            this.columnAccountType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnAccountType.HeaderText = "Account Type";
            this.columnAccountType.Name = "columnAccountType";
            this.columnAccountType.ReadOnly = true;
            // 
            // columnPasswordExpires
            // 
            this.columnPasswordExpires.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPasswordExpires.HeaderText = "Password Expires?";
            this.columnPasswordExpires.Name = "columnPasswordExpires";
            this.columnPasswordExpires.ReadOnly = true;
            // 
            // columnRequirePasswordChange
            // 
            this.columnRequirePasswordChange.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnRequirePasswordChange.HeaderText = "Require Password Change?";
            this.columnRequirePasswordChange.Name = "columnRequirePasswordChange";
            this.columnRequirePasswordChange.ReadOnly = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAccount.Location = new System.Drawing.Point(620, 9);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(142, 25);
            this.btnDeleteAccount.TabIndex = 7;
            this.btnDeleteAccount.Text = "Delete Selected";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Location = new System.Drawing.Point(3, 9);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(142, 25);
            this.btnAddAccount.TabIndex = 6;
            this.btnAddAccount.Text = "Add Account...";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddAccount, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteAccount, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 337);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 43);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // AccountsUserCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgAccounts);
            this.Name = "AccountsUserCtl";
            this.Size = new System.Drawing.Size(765, 380);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgAccounts;
        private DataGridViewTextBoxColumn columnUsername;
        private DataGridViewTextBoxColumn columnPassword;
        private DataGridViewTextBoxColumn columnComment;
        private DataGridViewTextBoxColumn columnAccountType;
        private DataGridViewCheckBoxColumn columnPasswordExpires;
        private DataGridViewCheckBoxColumn columnRequirePasswordChange;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
