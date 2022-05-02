namespace Zest_Script.forms
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExpandTreeView = new System.Windows.Forms.Button();
            this.btnCollapseTreeView = new System.Windows.Forms.Button();
            this.tlpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvOptions
            // 
            this.tvOptions.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.tvOptions.Size = new System.Drawing.Size(181, 415);
            this.tvOptions.TabIndex = 0;
            this.tvOptions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvOptions_AfterSelect);
            // 
            // propGrid
            // 
            this.propGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGrid.Location = new System.Drawing.Point(0, 0);
            this.propGrid.Name = "propGrid";
            this.propGrid.Size = new System.Drawing.Size(615, 415);
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
            this.tlpButtons.Location = new System.Drawing.Point(0, 415);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Size = new System.Drawing.Size(615, 35);
            this.tlpButtons.TabIndex = 2;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAccept.Location = new System.Drawing.Point(472, 6);
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
            this.btnCancel.Location = new System.Drawing.Point(336, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Make Changes";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvOptions);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1MinSize = 180;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.propGrid);
            this.splitContainer1.Panel2.Controls.Add(this.tlpButtons);
            this.splitContainer1.Panel2MinSize = 610;
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnExpandTreeView);
            this.flowLayoutPanel1.Controls.Add(this.btnCollapseTreeView);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 415);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(181, 35);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnExpandTreeView
            // 
            this.btnExpandTreeView.Location = new System.Drawing.Point(107, 3);
            this.btnExpandTreeView.Name = "btnExpandTreeView";
            this.btnExpandTreeView.Size = new System.Drawing.Size(71, 23);
            this.btnExpandTreeView.TabIndex = 2;
            this.btnExpandTreeView.Text = "Expand All";
            this.btnExpandTreeView.UseVisualStyleBackColor = true;
            this.btnExpandTreeView.Click += new System.EventHandler(this.btnExpandTreeView_Click);
            // 
            // btnCollapseTreeView
            // 
            this.btnCollapseTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCollapseTreeView.Location = new System.Drawing.Point(21, 3);
            this.btnCollapseTreeView.Name = "btnCollapseTreeView";
            this.btnCollapseTreeView.Size = new System.Drawing.Size(80, 23);
            this.btnCollapseTreeView.TabIndex = 3;
            this.btnCollapseTreeView.Text = "Collapse All";
            this.btnCollapseTreeView.UseVisualStyleBackColor = true;
            this.btnCollapseTreeView.Click += new System.EventHandler(this.btnCollapseTreeView_Click);
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Summary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration Summary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Summary_FormClosing);
            this.Load += new System.EventHandler(this.Summary_Load);
            this.tlpButtons.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView tvOptions;
        private PropertyGrid propGrid;
        private TableLayoutPanel tlpButtons;
        private Button btnAccept;
        private Button btnCancel;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnExpandTreeView;
        private Button btnCollapseTreeView;
    }
}