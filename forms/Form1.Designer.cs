﻿namespace OnboardingHelper_NetCore
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblOsVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProcessorInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRamAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComputerName = new System.Windows.Forms.TextBox();
            this.cmbTimeZones = new System.Windows.Forms.ComboBox();
            this.cmbNTPServers = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.basicTab = new System.Windows.Forms.TabPage();
            this.btnInstallAllUpdates = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.lblUpdateStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.updatesProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.btnSelectAllUpdates = new System.Windows.Forms.Button();
            this.btnInstallUpdates = new System.Windows.Forms.Button();
            this.btnCheckForUpdates = new System.Windows.Forms.Button();
            this.dgWindowsUpdate = new System.Windows.Forms.DataGridView();
            this.chkPerformTZSync = new System.Windows.Forms.CheckBox();
            this.accountsTab = new System.Windows.Forms.TabPage();
            this.accountsUserCtl1 = new OnboardingHelper_NetCore.userControls.AccountsUserCtl();
            this.connectionsTab = new System.Windows.Forms.TabPage();
            this.programsTab = new System.Windows.Forms.TabPage();
            this.programsUserCtl1 = new OnboardingHelper_NetCore.userControls.ProgramsUserCtl();
            this.remoteDesktopTab = new System.Windows.Forms.TabPage();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigurationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesBackground = new System.ComponentModel.BackgroundWorker();
            this.installUpdatesBackground = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.basicTab.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWindowsUpdate)).BeginInit();
            this.accountsTab.SuspendLayout();
            this.programsTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblOsVersion,
            this.toolStripStatusLabel1,
            this.lblProcessorInfo,
            this.toolStripStatusLabel2,
            this.lblRamAmount});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(746, 21);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            // 
            // lblOsVersion
            // 
            this.lblOsVersion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblOsVersion.Name = "lblOsVersion";
            this.lblOsVersion.Size = new System.Drawing.Size(80, 16);
            this.lblOsVersion.Spring = true;
            this.lblOsVersion.Text = "<OS Version>";
            this.lblOsVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 16);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // lblProcessorInfo
            // 
            this.lblProcessorInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblProcessorInfo.Name = "lblProcessorInfo";
            this.lblProcessorInfo.Size = new System.Drawing.Size(114, 16);
            this.lblProcessorInfo.Spring = true;
            this.lblProcessorInfo.Text = "<Processor Name>";
            this.lblProcessorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 16);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // lblRamAmount
            // 
            this.lblRamAmount.Name = "lblRamAmount";
            this.lblRamAmount.Size = new System.Drawing.Size(95, 16);
            this.lblRamAmount.Text = "<RAM Amount>";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.65204F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.34796F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDomain, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtComputerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbTimeZones, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbNTPServers, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Primary NTP Server: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time Zone: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Domain: ";
            // 
            // txtDomain
            // 
            this.txtDomain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDomain.Location = new System.Drawing.Point(137, 41);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(582, 23);
            this.txtDomain.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer Name: ";
            // 
            // txtComputerName
            // 
            this.txtComputerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComputerName.Location = new System.Drawing.Point(137, 6);
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.Size = new System.Drawing.Size(582, 23);
            this.txtComputerName.TabIndex = 1;
            // 
            // cmbTimeZones
            // 
            this.cmbTimeZones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTimeZones.DisplayMember = "DisplayName";
            this.cmbTimeZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeZones.FormattingEnabled = true;
            this.cmbTimeZones.Location = new System.Drawing.Point(137, 75);
            this.cmbTimeZones.Name = "cmbTimeZones";
            this.cmbTimeZones.Size = new System.Drawing.Size(582, 24);
            this.cmbTimeZones.TabIndex = 5;
            // 
            // cmbNTPServers
            // 
            this.cmbNTPServers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNTPServers.FormattingEnabled = true;
            this.cmbNTPServers.Location = new System.Drawing.Point(137, 110);
            this.cmbNTPServers.Name = "cmbNTPServers";
            this.cmbNTPServers.Size = new System.Drawing.Size(582, 24);
            this.cmbNTPServers.TabIndex = 7;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.basicTab);
            this.tabControl.Controls.Add(this.accountsTab);
            this.tabControl.Controls.Add(this.connectionsTab);
            this.tabControl.Controls.Add(this.programsTab);
            this.tabControl.Controls.Add(this.remoteDesktopTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.iconList;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(746, 616);
            this.tabControl.TabIndex = 3;
            // 
            // basicTab
            // 
            this.basicTab.Controls.Add(this.btnInstallAllUpdates);
            this.basicTab.Controls.Add(this.statusStrip2);
            this.basicTab.Controls.Add(this.btnSelectAllUpdates);
            this.basicTab.Controls.Add(this.btnInstallUpdates);
            this.basicTab.Controls.Add(this.btnCheckForUpdates);
            this.basicTab.Controls.Add(this.dgWindowsUpdate);
            this.basicTab.Controls.Add(this.chkPerformTZSync);
            this.basicTab.Controls.Add(this.tableLayoutPanel1);
            this.basicTab.ImageKey = "settings (Custom).png";
            this.basicTab.Location = new System.Drawing.Point(4, 39);
            this.basicTab.Name = "basicTab";
            this.basicTab.Padding = new System.Windows.Forms.Padding(3);
            this.basicTab.Size = new System.Drawing.Size(738, 573);
            this.basicTab.TabIndex = 0;
            this.basicTab.Text = "Basic";
            this.basicTab.UseVisualStyleBackColor = true;
            // 
            // btnInstallAllUpdates
            // 
            this.btnInstallAllUpdates.Location = new System.Drawing.Point(305, 179);
            this.btnInstallAllUpdates.Name = "btnInstallAllUpdates";
            this.btnInstallAllUpdates.Size = new System.Drawing.Size(145, 23);
            this.btnInstallAllUpdates.TabIndex = 9;
            this.btnInstallAllUpdates.Text = "Install All Updates";
            this.btnInstallAllUpdates.UseVisualStyleBackColor = true;
            this.btnInstallAllUpdates.Click += new System.EventHandler(this.btnInstallAllUpdates_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUpdateStatus,
            this.updatesProgressBar});
            this.statusStrip2.Location = new System.Drawing.Point(3, 206);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(732, 22);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 8;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(415, 17);
            this.lblUpdateStatus.Spring = true;
            this.lblUpdateStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updatesProgressBar
            // 
            this.updatesProgressBar.Name = "updatesProgressBar";
            this.updatesProgressBar.Size = new System.Drawing.Size(300, 16);
            // 
            // btnSelectAllUpdates
            // 
            this.btnSelectAllUpdates.Location = new System.Drawing.Point(641, 177);
            this.btnSelectAllUpdates.Name = "btnSelectAllUpdates";
            this.btnSelectAllUpdates.Size = new System.Drawing.Size(94, 23);
            this.btnSelectAllUpdates.TabIndex = 7;
            this.btnSelectAllUpdates.Text = "Select All";
            this.btnSelectAllUpdates.UseVisualStyleBackColor = true;
            this.btnSelectAllUpdates.Click += new System.EventHandler(this.btnSelectAllUpdates_Click);
            // 
            // btnInstallUpdates
            // 
            this.btnInstallUpdates.Location = new System.Drawing.Point(154, 177);
            this.btnInstallUpdates.Name = "btnInstallUpdates";
            this.btnInstallUpdates.Size = new System.Drawing.Size(145, 23);
            this.btnInstallUpdates.TabIndex = 6;
            this.btnInstallUpdates.Text = "Install Selected Updates";
            this.btnInstallUpdates.UseVisualStyleBackColor = true;
            // 
            // btnCheckForUpdates
            // 
            this.btnCheckForUpdates.Location = new System.Drawing.Point(3, 177);
            this.btnCheckForUpdates.Name = "btnCheckForUpdates";
            this.btnCheckForUpdates.Size = new System.Drawing.Size(145, 23);
            this.btnCheckForUpdates.TabIndex = 5;
            this.btnCheckForUpdates.Text = "Check For Updates";
            this.btnCheckForUpdates.UseVisualStyleBackColor = true;
            this.btnCheckForUpdates.Click += new System.EventHandler(this.btnCheckForUpdates_Click);
            // 
            // dgWindowsUpdate
            // 
            this.dgWindowsUpdate.AllowUserToAddRows = false;
            this.dgWindowsUpdate.AllowUserToDeleteRows = false;
            this.dgWindowsUpdate.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgWindowsUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWindowsUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgWindowsUpdate.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgWindowsUpdate.Location = new System.Drawing.Point(3, 228);
            this.dgWindowsUpdate.Name = "dgWindowsUpdate";
            this.dgWindowsUpdate.ReadOnly = true;
            this.dgWindowsUpdate.RowTemplate.Height = 25;
            this.dgWindowsUpdate.ShowEditingIcon = false;
            this.dgWindowsUpdate.Size = new System.Drawing.Size(732, 342);
            this.dgWindowsUpdate.TabIndex = 3;
            // 
            // chkPerformTZSync
            // 
            this.chkPerformTZSync.AutoSize = true;
            this.chkPerformTZSync.Location = new System.Drawing.Point(8, 152);
            this.chkPerformTZSync.Name = "chkPerformTZSync";
            this.chkPerformTZSync.Size = new System.Drawing.Size(175, 20);
            this.chkPerformTZSync.TabIndex = 1;
            this.chkPerformTZSync.Text = "Perform Time Server Sync?";
            this.chkPerformTZSync.UseVisualStyleBackColor = true;
            // 
            // accountsTab
            // 
            this.accountsTab.Controls.Add(this.accountsUserCtl1);
            this.accountsTab.ImageKey = "user (Custom).png";
            this.accountsTab.Location = new System.Drawing.Point(4, 39);
            this.accountsTab.Name = "accountsTab";
            this.accountsTab.Padding = new System.Windows.Forms.Padding(3);
            this.accountsTab.Size = new System.Drawing.Size(738, 573);
            this.accountsTab.TabIndex = 1;
            this.accountsTab.Text = "Accounts";
            this.accountsTab.UseVisualStyleBackColor = true;
            // 
            // accountsUserCtl1
            // 
            this.accountsUserCtl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountsUserCtl1.Location = new System.Drawing.Point(3, 3);
            this.accountsUserCtl1.Name = "accountsUserCtl1";
            this.accountsUserCtl1.Size = new System.Drawing.Size(732, 537);
            this.accountsUserCtl1.TabIndex = 0;
            // 
            // connectionsTab
            // 
            this.connectionsTab.ImageKey = "internet (Custom).png";
            this.connectionsTab.Location = new System.Drawing.Point(4, 39);
            this.connectionsTab.Name = "connectionsTab";
            this.connectionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.connectionsTab.Size = new System.Drawing.Size(738, 573);
            this.connectionsTab.TabIndex = 2;
            this.connectionsTab.Text = "Connections";
            this.connectionsTab.UseVisualStyleBackColor = true;
            // 
            // programsTab
            // 
            this.programsTab.Controls.Add(this.programsUserCtl1);
            this.programsTab.ImageKey = "web-programming (Custom).png";
            this.programsTab.Location = new System.Drawing.Point(4, 39);
            this.programsTab.Name = "programsTab";
            this.programsTab.Padding = new System.Windows.Forms.Padding(3);
            this.programsTab.Size = new System.Drawing.Size(738, 573);
            this.programsTab.TabIndex = 3;
            this.programsTab.Text = "Programs";
            this.programsTab.UseVisualStyleBackColor = true;
            // 
            // programsUserCtl1
            // 
            this.programsUserCtl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.programsUserCtl1.Location = new System.Drawing.Point(3, 3);
            this.programsUserCtl1.Name = "programsUserCtl1";
            this.programsUserCtl1.Size = new System.Drawing.Size(732, 537);
            this.programsUserCtl1.TabIndex = 0;
            // 
            // remoteDesktopTab
            // 
            this.remoteDesktopTab.ImageKey = "remote-control (Custom).png";
            this.remoteDesktopTab.Location = new System.Drawing.Point(4, 39);
            this.remoteDesktopTab.Name = "remoteDesktopTab";
            this.remoteDesktopTab.Padding = new System.Windows.Forms.Padding(3);
            this.remoteDesktopTab.Size = new System.Drawing.Size(738, 573);
            this.remoteDesktopTab.TabIndex = 4;
            this.remoteDesktopTab.Text = "Remote Desktop(s)";
            this.remoteDesktopTab.UseVisualStyleBackColor = true;
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 595);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 45);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(746, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "On-Board";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openConfigurationFileToolStripMenuItem,
            this.saveCurrentConfigurationToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openConfigurationFileToolStripMenuItem
            // 
            this.openConfigurationFileToolStripMenuItem.Name = "openConfigurationFileToolStripMenuItem";
            this.openConfigurationFileToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.openConfigurationFileToolStripMenuItem.Text = "Open Configuration File...";
            // 
            // saveCurrentConfigurationToolStripMenuItem
            // 
            this.saveCurrentConfigurationToolStripMenuItem.Name = "saveCurrentConfigurationToolStripMenuItem";
            this.saveCurrentConfigurationToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.saveCurrentConfigurationToolStripMenuItem.Text = "Save Current Configuration...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(236, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // checkForUpdatesBackground
            // 
            this.checkForUpdatesBackground.WorkerReportsProgress = true;
            this.checkForUpdatesBackground.WorkerSupportsCancellation = true;
            this.checkForUpdatesBackground.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkForUpdatesBackground_DoWork);
            this.checkForUpdatesBackground.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.checkForUpdatesBackground_ProgressChanged);
            this.checkForUpdatesBackground.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.checkForUpdatesBackground_RunWorkerCompleted);
            // 
            // installUpdatesBackground
            // 
            this.installUpdatesBackground.WorkerReportsProgress = true;
            this.installUpdatesBackground.WorkerSupportsCancellation = true;
            this.installUpdatesBackground.DoWork += new System.ComponentModel.DoWorkEventHandler(this.installUpdatesBackground_DoWork);
            this.installUpdatesBackground.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.installUpdatesBackground_ProgressChanged);
            this.installUpdatesBackground.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.installUpdatesBackground_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "On-Boarding Helper v1.0";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.basicTab.ResumeLayout(false);
            this.basicTab.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWindowsUpdate)).EndInit();
            this.accountsTab.ResumeLayout(false);
            this.programsTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblOsVersion;
        private ToolStripStatusLabel lblProcessorInfo;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label2;
        private TextBox txtDomain;
        private Label label1;
        private TextBox txtComputerName;
        private ComboBox cmbTimeZones;
        private TabControl tabControl;
        private TabPage basicTab;
        private TabPage accountsTab;
        private Panel panel1;
        private Button button1;
        private Label label4;
        private ComboBox cmbNTPServers;
        private CheckBox chkPerformTZSync;
        private TabPage connectionsTab;
        private TabPage programsTab;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openConfigurationFileToolStripMenuItem;
        private ToolStripMenuItem saveCurrentConfigurationToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private DataGridView dgWindowsUpdate;
        private Button btnSelectAllUpdates;
        private Button btnInstallUpdates;
        private Button btnCheckForUpdates;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel lblUpdateStatus;
        private ToolStripProgressBar updatesProgressBar;
        private System.ComponentModel.BackgroundWorker checkForUpdatesBackground;
        private System.ComponentModel.BackgroundWorker installUpdatesBackground;
        private Button btnInstallAllUpdates;
        private TabPage remoteDesktopTab;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblRamAmount;
        private userControls.AccountsUserCtl accountsUserCtl1;
        private userControls.ProgramsUserCtl programsUserCtl1;
        private ImageList iconList;
    }
}