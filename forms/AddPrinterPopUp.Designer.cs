namespace OnboardingHelper_NetCore.forms
{
    partial class AddPrinterPopUp
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddAndClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrinterName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDriverNames = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkCreateNewDriver = new System.Windows.Forms.CheckBox();
            this.lblInfPath = new System.Windows.Forms.Label();
            this.flpINFPath = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpenINF = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.chkIsNetworkSharedPrinter = new System.Windows.Forms.CheckBox();
            this.flpIsNetworkSharedPrinter = new System.Windows.Forms.FlowLayoutPanel();
            this.txtConnectionName = new System.Windows.Forms.TextBox();
            this.chkShouldShare = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtShareName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flpINFPath.SuspendLayout();
            this.flpIsNetworkSharedPrinter.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddAndClear, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 308);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(510, 36);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // btnAddAndClear
            // 
            this.btnAddAndClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddAndClear.Location = new System.Drawing.Point(421, 6);
            this.btnAddAndClear.Name = "btnAddAndClear";
            this.btnAddAndClear.Size = new System.Drawing.Size(86, 23);
            this.btnAddAndClear.TabIndex = 10;
            this.btnAddAndClear.Text = "Add && Clear";
            this.btnAddAndClear.UseVisualStyleBackColor = true;
            this.btnAddAndClear.Click += new System.EventHandler(this.btnAddAndClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.Location = new System.Drawing.Point(308, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Location = new System.Drawing.Point(194, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.2549F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.74509F));
            this.tableLayoutPanel1.Controls.Add(this.lblInfPath, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtComment, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPrinterName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flpINFPath, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flpIsNetworkSharedPrinter, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.62069F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.37931F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 308);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrinterName.Location = new System.Drawing.Point(91, 8);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.Size = new System.Drawing.Size(416, 23);
            this.txtPrinterName.TabIndex = 1;
            this.txtPrinterName.TextChanged += new System.EventHandler(this.txtPrinterName_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comment: ";
            // 
            // txtComment
            // 
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.Location = new System.Drawing.Point(91, 42);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(416, 71);
            this.txtComment.TabIndex = 3;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Driver Name: ";
            // 
            // cmbDriverNames
            // 
            this.cmbDriverNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDriverNames.FormattingEnabled = true;
            this.cmbDriverNames.Location = new System.Drawing.Point(3, 3);
            this.cmbDriverNames.Name = "cmbDriverNames";
            this.cmbDriverNames.Size = new System.Drawing.Size(261, 23);
            this.cmbDriverNames.TabIndex = 5;
            this.cmbDriverNames.SelectedIndexChanged += new System.EventHandler(this.cmbDriverNames_SelectedIndexChanged);
            this.cmbDriverNames.TextChanged += new System.EventHandler(this.cmbDriverNames_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cmbDriverNames);
            this.flowLayoutPanel1.Controls.Add(this.chkCreateNewDriver);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(91, 119);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(416, 31);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // chkCreateNewDriver
            // 
            this.chkCreateNewDriver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCreateNewDriver.AutoSize = true;
            this.chkCreateNewDriver.Location = new System.Drawing.Point(270, 5);
            this.chkCreateNewDriver.Name = "chkCreateNewDriver";
            this.chkCreateNewDriver.Size = new System.Drawing.Size(121, 19);
            this.chkCreateNewDriver.TabIndex = 6;
            this.chkCreateNewDriver.Text = "Create New Driver";
            this.chkCreateNewDriver.UseVisualStyleBackColor = true;
            this.chkCreateNewDriver.CheckedChanged += new System.EventHandler(this.chkCreateNewDriver_CheckedChanged);
            // 
            // lblInfPath
            // 
            this.lblInfPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfPath.AutoSize = true;
            this.lblInfPath.Location = new System.Drawing.Point(3, 184);
            this.lblInfPath.Name = "lblInfPath";
            this.lblInfPath.Size = new System.Drawing.Size(82, 15);
            this.lblInfPath.TabIndex = 7;
            this.lblInfPath.Text = "INF Path: ";
            // 
            // flpINFPath
            // 
            this.flpINFPath.Controls.Add(this.btnOpenINF);
            this.flpINFPath.Controls.Add(this.lblPath);
            this.flpINFPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpINFPath.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpINFPath.Location = new System.Drawing.Point(91, 156);
            this.flpINFPath.Name = "flpINFPath";
            this.flpINFPath.Size = new System.Drawing.Size(416, 71);
            this.flpINFPath.TabIndex = 8;
            // 
            // btnOpenINF
            // 
            this.btnOpenINF.Location = new System.Drawing.Point(3, 3);
            this.btnOpenINF.Name = "btnOpenINF";
            this.btnOpenINF.Size = new System.Drawing.Size(76, 23);
            this.btnOpenINF.TabIndex = 0;
            this.btnOpenINF.Text = "Open...";
            this.btnOpenINF.UseVisualStyleBackColor = true;
            this.btnOpenINF.Click += new System.EventHandler(this.btnOpenINF_Click);
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(3, 29);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(76, 15);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "<path>";
            // 
            // chkIsNetworkSharedPrinter
            // 
            this.chkIsNetworkSharedPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIsNetworkSharedPrinter.AutoSize = true;
            this.chkIsNetworkSharedPrinter.Location = new System.Drawing.Point(3, 5);
            this.chkIsNetworkSharedPrinter.Name = "chkIsNetworkSharedPrinter";
            this.chkIsNetworkSharedPrinter.Size = new System.Drawing.Size(164, 19);
            this.chkIsNetworkSharedPrinter.TabIndex = 9;
            this.chkIsNetworkSharedPrinter.Text = "Is Network Shared Printer?";
            this.chkIsNetworkSharedPrinter.UseVisualStyleBackColor = true;
            this.chkIsNetworkSharedPrinter.CheckedChanged += new System.EventHandler(this.chkIsNetworkSharedPrinter_CheckedChanged);
            // 
            // flpIsNetworkSharedPrinter
            // 
            this.flpIsNetworkSharedPrinter.Controls.Add(this.chkIsNetworkSharedPrinter);
            this.flpIsNetworkSharedPrinter.Controls.Add(this.txtConnectionName);
            this.flpIsNetworkSharedPrinter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpIsNetworkSharedPrinter.Location = new System.Drawing.Point(91, 233);
            this.flpIsNetworkSharedPrinter.Name = "flpIsNetworkSharedPrinter";
            this.flpIsNetworkSharedPrinter.Size = new System.Drawing.Size(416, 31);
            this.flpIsNetworkSharedPrinter.TabIndex = 10;
            // 
            // txtConnectionName
            // 
            this.txtConnectionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnectionName.Location = new System.Drawing.Point(173, 3);
            this.txtConnectionName.Name = "txtConnectionName";
            this.txtConnectionName.PlaceholderText = "\\\\server\\printer";
            this.txtConnectionName.Size = new System.Drawing.Size(234, 23);
            this.txtConnectionName.TabIndex = 10;
            this.txtConnectionName.TextChanged += new System.EventHandler(this.txtConnectionName_TextChanged);
            // 
            // chkShouldShare
            // 
            this.chkShouldShare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShouldShare.AutoSize = true;
            this.chkShouldShare.Location = new System.Drawing.Point(3, 5);
            this.chkShouldShare.Name = "chkShouldShare";
            this.chkShouldShare.Size = new System.Drawing.Size(135, 19);
            this.chkShouldShare.TabIndex = 11;
            this.chkShouldShare.Text = "Create Printer Share?";
            this.chkShouldShare.UseVisualStyleBackColor = true;
            this.chkShouldShare.CheckedChanged += new System.EventHandler(this.chkShouldShare_CheckedChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.chkShouldShare);
            this.flowLayoutPanel2.Controls.Add(this.txtShareName);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(91, 270);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(416, 35);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // txtShareName
            // 
            this.txtShareName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShareName.Location = new System.Drawing.Point(144, 3);
            this.txtShareName.Name = "txtShareName";
            this.txtShareName.PlaceholderText = "Name to share printer with";
            this.txtShareName.Size = new System.Drawing.Size(263, 23);
            this.txtShareName.TabIndex = 10;
            this.txtShareName.TextChanged += new System.EventHandler(this.txtShareName_TextChanged);
            // 
            // AddPrinterPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 344);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPrinterPopUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Printer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddPrinterPopUp_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flpINFPath.ResumeLayout(false);
            this.flpINFPath.PerformLayout();
            this.flpIsNetworkSharedPrinter.ResumeLayout(false);
            this.flpIsNetworkSharedPrinter.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAddAndClear;
        private Button btnAdd;
        private Button btnCancel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox txtComment;
        private Label label1;
        private TextBox txtPrinterName;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox cmbDriverNames;
        private CheckBox chkCreateNewDriver;
        private Label lblInfPath;
        private FlowLayoutPanel flpINFPath;
        private Button btnOpenINF;
        private Label lblPath;
        private FlowLayoutPanel flpIsNetworkSharedPrinter;
        private CheckBox chkIsNetworkSharedPrinter;
        private TextBox txtConnectionName;
        private FlowLayoutPanel flowLayoutPanel2;
        private CheckBox chkShouldShare;
        private TextBox txtShareName;
    }
}