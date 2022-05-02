namespace OnboardingHelper_NetCore.forms
{
    partial class Summary
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Basic Information");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Accounts");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("WiFi");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("VPN");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Connections", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Programs");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Remote Desktop(s)");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Drive Mapping(s)");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Printer Mapping(s)");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Summary));
            this.tvOptions = new System.Windows.Forms.TreeView();
            this.propGrid = new System.Windows.Forms.PropertyGrid();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvOptions
            // 
            this.tvOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tvOptions.Location = new System.Drawing.Point(0, 0);
            this.tvOptions.Name = "tvOptions";
            treeNode1.Name = "nodeBasic";
            treeNode1.Text = "Basic Information";
            treeNode2.Name = "nodeAccounts";
            treeNode2.Text = "Accounts";
            treeNode3.Name = "nodeWifi";
            treeNode3.Text = "WiFi";
            treeNode4.Name = "nodeVPN";
            treeNode4.Text = "VPN";
            treeNode5.Name = "nodeConnections";
            treeNode5.Text = "Connections";
            treeNode6.Name = "nodePrograms";
            treeNode6.Text = "Programs";
            treeNode7.Name = "nodeRemoteDesktop";
            treeNode7.Text = "Remote Desktop(s)";
            treeNode8.Name = "nodeDriveMappings";
            treeNode8.Text = "Drive Mapping(s)";
            treeNode9.Name = "nodePrinterMappings";
            treeNode9.Text = "Printer Mapping(s)";
            this.tvOptions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.tvOptions.Size = new System.Drawing.Size(196, 450);
            this.tvOptions.TabIndex = 0;
            this.tvOptions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvOptions_AfterSelect);
            // 
            // propGrid
            // 
            this.propGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGrid.Location = new System.Drawing.Point(196, 0);
            this.propGrid.Name = "propGrid";
            this.propGrid.Size = new System.Drawing.Size(604, 415);
            this.propGrid.TabIndex = 1;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.82781F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.17219F));
            this.tlpButtons.Controls.Add(this.btnAccept, 1, 0);
            this.tlpButtons.Controls.Add(this.btnCancel, 0, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpButtons.Location = new System.Drawing.Point(196, 415);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Size = new System.Drawing.Size(604, 35);
            this.tlpButtons.TabIndex = 2;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAccept.Location = new System.Drawing.Point(461, 6);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(140, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Confirm Configuration";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Location = new System.Drawing.Point(328, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Make Changes";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.propGrid);
            this.Controls.Add(this.tlpButtons);
            this.Controls.Add(this.tvOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Summary";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration Summary";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Summary_Load);
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView tvOptions;
        private PropertyGrid propGrid;
        private TableLayoutPanel tlpButtons;
        private Button btnAccept;
        private Button btnCancel;
    }
}