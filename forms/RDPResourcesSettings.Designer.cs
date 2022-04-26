namespace OnboardingHelper_NetCore.forms
{
    partial class RDPResourcesSettings
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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Smart cards or Windows Hello for Business");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Ports");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Location");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Windows (C:)");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Drives that I plug in later");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Drives", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Devices that I plug in later");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Video capture devices", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Devices that I plug in later");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Other supported Plug and Play (PnP) devices", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RDPResourcesSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpLocalDevices = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpLocalDevices.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 66);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(77, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(77, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remote Desktop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnboardingHelper_NetCore.Properties.Resources.mstsc_48x48;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 52);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpLocalDevices
            // 
            this.grpLocalDevices.Controls.Add(this.treeView1);
            this.grpLocalDevices.Controls.Add(this.label3);
            this.grpLocalDevices.Location = new System.Drawing.Point(8, 72);
            this.grpLocalDevices.Name = "grpLocalDevices";
            this.grpLocalDevices.Size = new System.Drawing.Size(364, 233);
            this.grpLocalDevices.TabIndex = 2;
            this.grpLocalDevices.TabStop = false;
            this.grpLocalDevices.Text = "Local Devices and Resources";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(216, 311);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose the devices and resources on this computer that you\r\nwant to use in your r" +
    "emote session.";
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(6, 85);
            this.treeView1.Name = "treeView1";
            treeNode11.Name = "nodeSmartCards";
            treeNode11.Text = "Smart cards or Windows Hello for Business";
            treeNode12.Name = "nodePorts";
            treeNode12.Text = "Ports";
            treeNode13.Name = "nodeLocation";
            treeNode13.Text = "Location";
            treeNode14.Name = "nodeWindows";
            treeNode14.Text = "Windows (C:)";
            treeNode15.Name = "nodeDrivesLater";
            treeNode15.Text = "Drives that I plug in later";
            treeNode16.Name = "nodeDrives";
            treeNode16.Text = "Drives";
            treeNode17.Name = "nodeVideoCaptureDevicesLater";
            treeNode17.Text = "Devices that I plug in later";
            treeNode18.Name = "nodeVideoCaptureDevices";
            treeNode18.Text = "Video capture devices";
            treeNode19.Name = "nodePnPDevicesLater";
            treeNode19.Text = "Devices that I plug in later";
            treeNode20.Name = "nodePnPDevices";
            treeNode20.Text = "Other supported Plug and Play (PnP) devices";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode16,
            treeNode18,
            treeNode20});
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(352, 142);
            this.treeView1.TabIndex = 1;
            // 
            // RDPResourcesSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpLocalDevices);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RDPResourcesSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remote Desktop Connection";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpLocalDevices.ResumeLayout(false);
            this.grpLocalDevices.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox grpLocalDevices;
        private TreeView treeView1;
        private Label label3;
        private Button btnCancel;
        private Button btnOK;
    }
}