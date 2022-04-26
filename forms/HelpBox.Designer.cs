namespace OnboardingHelper_NetCore
{
    partial class HelpBox
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Basic"}, "settings (Custom).png", System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Accounts"}, "user (Custom).png", System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Connections"}, "internet (Custom).png", System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Programs"}, "web-programming (Custom).png", System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Remote Desktop(s)"}, "remote-control (Custom).png", System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Exporting/Importing Configurations"}, "document (Custom).png", System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpBox));
            this.lvPages = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // lvPages
            // 
            this.lvPages.AutoArrange = false;
            this.lvPages.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvPages.FullRowSelect = true;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.StateImageIndex = 0;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.StateImageIndex = 0;
            this.lvPages.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.lvPages.Location = new System.Drawing.Point(0, 0);
            this.lvPages.Name = "lvPages";
            this.lvPages.Size = new System.Drawing.Size(257, 460);
            this.lvPages.SmallImageList = this.iconList;
            this.lvPages.TabIndex = 5;
            this.lvPages.TileSize = new System.Drawing.Size(228, 36);
            this.lvPages.UseCompatibleStateImageBehavior = false;
            this.lvPages.View = System.Windows.Forms.View.List;
            this.lvPages.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // iconList
            // 
            this.iconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "document (Custom).png");
            this.iconList.Images.SetKeyName(1, "export (Custom).png");
            this.iconList.Images.SetKeyName(2, "import (Custom).png");
            this.iconList.Images.SetKeyName(3, "internet (Custom).png");
            this.iconList.Images.SetKeyName(4, "remote-control (Custom).png");
            this.iconList.Images.SetKeyName(5, "settings (Custom).png");
            this.iconList.Images.SetKeyName(6, "user (Custom).png");
            this.iconList.Images.SetKeyName(7, "web-programming (Custom).png");
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.webView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(257, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 460);
            this.panel1.TabIndex = 7;
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView.Location = new System.Drawing.Point(0, 0);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(632, 460);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // HelpBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvPages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Help";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.HelpBox_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvPages;
        private ImageList iconList;
        private Panel panel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}