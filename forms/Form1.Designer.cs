namespace OnboardingHelper_NetCore
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
            this.mainStatusBar = new System.Windows.Forms.StatusStrip();
            this.lblOsVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProcessorInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRamAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.basicTab = new System.Windows.Forms.TabPage();
            this.basicInfoUserCtl1 = new OnboardingHelper_NetCore.userControls.BasicInfoUserCtl();
            this.accountsTab = new System.Windows.Forms.TabPage();
            this.accountsUserCtl2 = new OnboardingHelper_NetCore.userControls.AccountsUserCtl();
            this.connectionsTab = new System.Windows.Forms.TabPage();
            this.connectionsTabs = new System.Windows.Forms.TabControl();
            this.tabWiFi = new System.Windows.Forms.TabPage();
            this.wiFiUserCtl1 = new OnboardingHelper_NetCore.userControls.WiFiUserCtl();
            this.tabVPN = new System.Windows.Forms.TabPage();
            this.vpnUserCtl1 = new OnboardingHelper_NetCore.userControls.VPNUserCtl();
            this.programsTab = new System.Windows.Forms.TabPage();
            this.programsUserCtl1 = new OnboardingHelper_NetCore.userControls.ProgramsUserCtl();
            this.remoteDesktopTab = new System.Windows.Forms.TabPage();
            this.rdpUserCtl1 = new OnboardingHelper_NetCore.userControls.RDPUserCtl();
            this.tabDriveMaps = new System.Windows.Forms.TabPage();
            this.driveUserCtl1 = new OnboardingHelper_NetCore.userControls.DriveUserCtl();
            this.tabPrinters = new System.Windows.Forms.TabPage();
            this.printerUserCtl1 = new OnboardingHelper_NetCore.userControls.PrinterUserCtl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOnboard = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigurationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkShowConnectionsTab = new System.Windows.Forms.ToolStripMenuItem();
            this.chkProgramsTab = new System.Windows.Forms.ToolStripMenuItem();
            this.chkRemoteDesktops = new System.Windows.Forms.ToolStripMenuItem();
            this.chkDriveMappings = new System.Windows.Forms.ToolStripMenuItem();
            this.chkPrinterMappings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHideAllTabs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowAllTabs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.chkStatusBarShow = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgSaveConfig = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpenConfig = new System.Windows.Forms.OpenFileDialog();
            this.btnShowConfigSummary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mainStatusBar.SuspendLayout();
            this.mainTabs.SuspendLayout();
            this.basicTab.SuspendLayout();
            this.accountsTab.SuspendLayout();
            this.connectionsTab.SuspendLayout();
            this.connectionsTabs.SuspendLayout();
            this.tabWiFi.SuspendLayout();
            this.tabVPN.SuspendLayout();
            this.programsTab.SuspendLayout();
            this.remoteDesktopTab.SuspendLayout();
            this.tabDriveMaps.SuspendLayout();
            this.tabPrinters.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatusBar
            // 
            this.mainStatusBar.BackColor = System.Drawing.SystemColors.Control;
            this.mainStatusBar.GripMargin = new System.Windows.Forms.Padding(0);
            this.mainStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblOsVersion,
            this.toolStripStatusLabel1,
            this.lblProcessorInfo,
            this.toolStripStatusLabel2,
            this.lblRamAmount,
            this.toolStripStatusLabel3,
            this.lblStatusText});
            this.mainStatusBar.Location = new System.Drawing.Point(0, 523);
            this.mainStatusBar.Name = "mainStatusBar";
            this.mainStatusBar.Size = new System.Drawing.Size(885, 22);
            this.mainStatusBar.SizingGrip = false;
            this.mainStatusBar.TabIndex = 0;
            // 
            // lblOsVersion
            // 
            this.lblOsVersion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblOsVersion.Name = "lblOsVersion";
            this.lblOsVersion.Size = new System.Drawing.Size(79, 17);
            this.lblOsVersion.Text = "<OS Version>";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProcessorInfo
            // 
            this.lblProcessorInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblProcessorInfo.Name = "lblProcessorInfo";
            this.lblProcessorInfo.Size = new System.Drawing.Size(109, 17);
            this.lblProcessorInfo.Text = "<Processor Name>";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // lblRamAmount
            // 
            this.lblRamAmount.Name = "lblRamAmount";
            this.lblRamAmount.Size = new System.Drawing.Size(96, 17);
            this.lblRamAmount.Text = "<RAM Amount>";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // lblStatusText
            // 
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(556, 17);
            this.lblStatusText.Spring = true;
            this.lblStatusText.Text = "Ready";
            this.lblStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.basicTab);
            this.mainTabs.Controls.Add(this.accountsTab);
            this.mainTabs.Controls.Add(this.connectionsTab);
            this.mainTabs.Controls.Add(this.programsTab);
            this.mainTabs.Controls.Add(this.remoteDesktopTab);
            this.mainTabs.Controls.Add(this.tabDriveMaps);
            this.mainTabs.Controls.Add(this.tabPrinters);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.ImageList = this.imageList1;
            this.mainTabs.Location = new System.Drawing.Point(0, 24);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(885, 454);
            this.mainTabs.TabIndex = 3;
            // 
            // basicTab
            // 
            this.basicTab.Controls.Add(this.basicInfoUserCtl1);
            this.basicTab.ImageKey = "settings_24x24.png";
            this.basicTab.Location = new System.Drawing.Point(4, 24);
            this.basicTab.Name = "basicTab";
            this.basicTab.Padding = new System.Windows.Forms.Padding(3);
            this.basicTab.Size = new System.Drawing.Size(877, 426);
            this.basicTab.TabIndex = 0;
            this.basicTab.Text = "Basic";
            this.basicTab.UseVisualStyleBackColor = true;
            // 
            // basicInfoUserCtl1
            // 
            this.basicInfoUserCtl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicInfoUserCtl1.Location = new System.Drawing.Point(3, 3);
            this.basicInfoUserCtl1.Name = "basicInfoUserCtl1";
            this.basicInfoUserCtl1.Size = new System.Drawing.Size(871, 420);
            this.basicInfoUserCtl1.TabIndex = 0;
            // 
            // accountsTab
            // 
            this.accountsTab.Controls.Add(this.accountsUserCtl2);
            this.accountsTab.ImageKey = "user_24x24.png";
            this.accountsTab.Location = new System.Drawing.Point(4, 24);
            this.accountsTab.Name = "accountsTab";
            this.accountsTab.Padding = new System.Windows.Forms.Padding(3);
            this.accountsTab.Size = new System.Drawing.Size(192, 72);
            this.accountsTab.TabIndex = 1;
            this.accountsTab.Text = "Accounts";
            this.accountsTab.UseVisualStyleBackColor = true;
            // 
            // accountsUserCtl2
            // 
            this.accountsUserCtl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountsUserCtl2.Location = new System.Drawing.Point(3, 3);
            this.accountsUserCtl2.Name = "accountsUserCtl2";
            this.accountsUserCtl2.Size = new System.Drawing.Size(186, 66);
            this.accountsUserCtl2.TabIndex = 0;
            // 
            // connectionsTab
            // 
            this.connectionsTab.Controls.Add(this.connectionsTabs);
            this.connectionsTab.ImageKey = "internet_24x24.png";
            this.connectionsTab.Location = new System.Drawing.Point(4, 24);
            this.connectionsTab.Name = "connectionsTab";
            this.connectionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.connectionsTab.Size = new System.Drawing.Size(192, 72);
            this.connectionsTab.TabIndex = 2;
            this.connectionsTab.Text = "Connections";
            this.connectionsTab.UseVisualStyleBackColor = true;
            // 
            // connectionsTabs
            // 
            this.connectionsTabs.Controls.Add(this.tabWiFi);
            this.connectionsTabs.Controls.Add(this.tabVPN);
            this.connectionsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionsTabs.Location = new System.Drawing.Point(3, 3);
            this.connectionsTabs.Name = "connectionsTabs";
            this.connectionsTabs.SelectedIndex = 0;
            this.connectionsTabs.Size = new System.Drawing.Size(186, 66);
            this.connectionsTabs.TabIndex = 1;
            // 
            // tabWiFi
            // 
            this.tabWiFi.Controls.Add(this.wiFiUserCtl1);
            this.tabWiFi.Location = new System.Drawing.Point(4, 24);
            this.tabWiFi.Name = "tabWiFi";
            this.tabWiFi.Padding = new System.Windows.Forms.Padding(3);
            this.tabWiFi.Size = new System.Drawing.Size(178, 38);
            this.tabWiFi.TabIndex = 0;
            this.tabWiFi.Text = "Wi-Fi Networks";
            this.tabWiFi.UseVisualStyleBackColor = true;
            // 
            // wiFiUserCtl1
            // 
            this.wiFiUserCtl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wiFiUserCtl1.Location = new System.Drawing.Point(3, 3);
            this.wiFiUserCtl1.Name = "wiFiUserCtl1";
            this.wiFiUserCtl1.Size = new System.Drawing.Size(172, 32);
            this.wiFiUserCtl1.TabIndex = 0;
            // 
            // tabVPN
            // 
            this.tabVPN.Controls.Add(this.vpnUserCtl1);
            this.tabVPN.Location = new System.Drawing.Point(4, 24);
            this.tabVPN.Name = "tabVPN";
            this.tabVPN.Padding = new System.Windows.Forms.Padding(3);
            this.tabVPN.Size = new System.Drawing.Size(178, 38);
            this.tabVPN.TabIndex = 1;
            this.tabVPN.Text = "VPN Connections";
            this.tabVPN.UseVisualStyleBackColor = true;
            // 
            // vpnUserCtl1
            // 
            this.vpnUserCtl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vpnUserCtl1.Location = new System.Drawing.Point(3, 3);
            this.vpnUserCtl1.Name = "vpnUserCtl1";
            this.vpnUserCtl1.Size = new System.Drawing.Size(172, 32);
            this.vpnUserCtl1.TabIndex = 0;
            // 
            // programsTab
            // 
            this.programsTab.Controls.Add(this.programsUserCtl1);
            this.programsTab.ImageKey = "web-programming_24x24.png";
            this.programsTab.Location = new System.Drawing.Point(4, 24);
            this.programsTab.Name = "programsTab";
            this.programsTab.Padding = new System.Windows.Forms.Padding(3);
            this.programsTab.Size = new System.Drawing.Size(192, 72);
            this.programsTab.TabIndex = 3;
            this.programsTab.Text = "Programs";
            this.programsTab.UseVisualStyleBackColor = true;
            // 
            // programsUserCtl1
            // 
            this.programsUserCtl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programsUserCtl1.Location = new System.Drawing.Point(3, 3);
            this.programsUserCtl1.Name = "programsUserCtl1";
            this.programsUserCtl1.Size = new System.Drawing.Size(186, 66);
            this.programsUserCtl1.TabIndex = 0;
            // 
            // remoteDesktopTab
            // 
            this.remoteDesktopTab.Controls.Add(this.rdpUserCtl1);
            this.remoteDesktopTab.ImageKey = "remote-control_24x24.png";
            this.remoteDesktopTab.Location = new System.Drawing.Point(4, 24);
            this.remoteDesktopTab.Name = "remoteDesktopTab";
            this.remoteDesktopTab.Padding = new System.Windows.Forms.Padding(3);
            this.remoteDesktopTab.Size = new System.Drawing.Size(192, 72);
            this.remoteDesktopTab.TabIndex = 4;
            this.remoteDesktopTab.Text = "Remote Desktop(s)";
            this.remoteDesktopTab.UseVisualStyleBackColor = true;
            // 
            // rdpUserCtl1
            // 
            this.rdpUserCtl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdpUserCtl1.Location = new System.Drawing.Point(3, 3);
            this.rdpUserCtl1.Name = "rdpUserCtl1";
            this.rdpUserCtl1.Size = new System.Drawing.Size(186, 66);
            this.rdpUserCtl1.TabIndex = 0;
            // 
            // tabDriveMaps
            // 
            this.tabDriveMaps.Controls.Add(this.driveUserCtl1);
            this.tabDriveMaps.ImageKey = "folder-network_24x24.png";
            this.tabDriveMaps.Location = new System.Drawing.Point(4, 24);
            this.tabDriveMaps.Name = "tabDriveMaps";
            this.tabDriveMaps.Padding = new System.Windows.Forms.Padding(3);
            this.tabDriveMaps.Size = new System.Drawing.Size(192, 72);
            this.tabDriveMaps.TabIndex = 5;
            this.tabDriveMaps.Text = "Drive Mapping(s)";
            this.tabDriveMaps.UseVisualStyleBackColor = true;
            // 
            // driveUserCtl1
            // 
            this.driveUserCtl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driveUserCtl1.Location = new System.Drawing.Point(3, 3);
            this.driveUserCtl1.Name = "driveUserCtl1";
            this.driveUserCtl1.Size = new System.Drawing.Size(186, 66);
            this.driveUserCtl1.TabIndex = 0;
            // 
            // tabPrinters
            // 
            this.tabPrinters.Controls.Add(this.printerUserCtl1);
            this.tabPrinters.ImageKey = "printer_24x24.png";
            this.tabPrinters.Location = new System.Drawing.Point(4, 24);
            this.tabPrinters.Name = "tabPrinters";
            this.tabPrinters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrinters.Size = new System.Drawing.Size(192, 72);
            this.tabPrinters.TabIndex = 6;
            this.tabPrinters.Text = "Printer Mapping(s)";
            this.tabPrinters.UseVisualStyleBackColor = true;
            // 
            // printerUserCtl1
            // 
            this.printerUserCtl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printerUserCtl1.Location = new System.Drawing.Point(3, 3);
            this.printerUserCtl1.Name = "printerUserCtl1";
            this.printerUserCtl1.Size = new System.Drawing.Size(186, 66);
            this.printerUserCtl1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "document_24x24.png");
            this.imageList1.Images.SetKeyName(1, "folder-network_24x24.png");
            this.imageList1.Images.SetKeyName(2, "internet_24x24.png");
            this.imageList1.Images.SetKeyName(3, "printer_24x24.png");
            this.imageList1.Images.SetKeyName(4, "remote-control_24x24.png");
            this.imageList1.Images.SetKeyName(5, "settings_24x24.png");
            this.imageList1.Images.SetKeyName(6, "user_24x24.png");
            this.imageList1.Images.SetKeyName(7, "web-programming_24x24.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOnboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 45);
            this.panel1.TabIndex = 2;
            // 
            // btnOnboard
            // 
            this.btnOnboard.BackColor = System.Drawing.Color.DarkGreen;
            this.btnOnboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOnboard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOnboard.ForeColor = System.Drawing.Color.White;
            this.btnOnboard.Location = new System.Drawing.Point(0, 0);
            this.btnOnboard.Name = "btnOnboard";
            this.btnOnboard.Size = new System.Drawing.Size(885, 45);
            this.btnOnboard.TabIndex = 3;
            this.btnOnboard.Text = "On-Board";
            this.btnOnboard.UseVisualStyleBackColor = false;
            this.btnOnboard.Click += new System.EventHandler(this.btnOnboard_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(885, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newWindowToolStripMenuItem,
            this.openConfigurationFileToolStripMenuItem,
            this.saveCurrentConfigurationToolStripMenuItem,
            this.toolStripSeparator3,
            this.printToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::OnboardingHelper_NetCore.Properties.Resources.document_24x24;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.newWindowToolStripMenuItem.Text = "New Window...";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // openConfigurationFileToolStripMenuItem
            // 
            this.openConfigurationFileToolStripMenuItem.Image = global::OnboardingHelper_NetCore.Properties.Resources.import_24x24;
            this.openConfigurationFileToolStripMenuItem.Name = "openConfigurationFileToolStripMenuItem";
            this.openConfigurationFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openConfigurationFileToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openConfigurationFileToolStripMenuItem.Text = "Open...";
            this.openConfigurationFileToolStripMenuItem.Click += new System.EventHandler(this.openConfigurationFileToolStripMenuItem_Click);
            // 
            // saveCurrentConfigurationToolStripMenuItem
            // 
            this.saveCurrentConfigurationToolStripMenuItem.Image = global::OnboardingHelper_NetCore.Properties.Resources.export_24x24;
            this.saveCurrentConfigurationToolStripMenuItem.Name = "saveCurrentConfigurationToolStripMenuItem";
            this.saveCurrentConfigurationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveCurrentConfigurationToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.saveCurrentConfigurationToolStripMenuItem.Text = "Save";
            this.saveCurrentConfigurationToolStripMenuItem.Click += new System.EventHandler(this.saveCurrentConfigurationToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(226, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::OnboardingHelper_NetCore.Properties.Resources.exit_24x24;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowConfigSummary,
            this.toolStripSeparator6,
            this.chkShowConnectionsTab,
            this.chkProgramsTab,
            this.chkRemoteDesktops,
            this.chkDriveMappings,
            this.chkPrinterMappings,
            this.toolStripSeparator2,
            this.btnHideAllTabs,
            this.btnShowAllTabs,
            this.toolStripSeparator4,
            this.chkStatusBarShow});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // chkShowConnectionsTab
            // 
            this.chkShowConnectionsTab.Checked = true;
            this.chkShowConnectionsTab.CheckOnClick = true;
            this.chkShowConnectionsTab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowConnectionsTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.chkShowConnectionsTab.Name = "chkShowConnectionsTab";
            this.chkShowConnectionsTab.Size = new System.Drawing.Size(247, 22);
            this.chkShowConnectionsTab.Text = "Connections";
            this.chkShowConnectionsTab.CheckedChanged += new System.EventHandler(this.chkShowConnectionsTab_CheckedChanged);
            // 
            // chkProgramsTab
            // 
            this.chkProgramsTab.Checked = true;
            this.chkProgramsTab.CheckOnClick = true;
            this.chkProgramsTab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProgramsTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.chkProgramsTab.Name = "chkProgramsTab";
            this.chkProgramsTab.Size = new System.Drawing.Size(247, 22);
            this.chkProgramsTab.Text = "Programs";
            this.chkProgramsTab.CheckedChanged += new System.EventHandler(this.chkProgramsTab_CheckedChanged);
            // 
            // chkRemoteDesktops
            // 
            this.chkRemoteDesktops.Checked = true;
            this.chkRemoteDesktops.CheckOnClick = true;
            this.chkRemoteDesktops.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemoteDesktops.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.chkRemoteDesktops.Name = "chkRemoteDesktops";
            this.chkRemoteDesktops.Size = new System.Drawing.Size(247, 22);
            this.chkRemoteDesktops.Text = "Remote Desktop(s)";
            this.chkRemoteDesktops.CheckedChanged += new System.EventHandler(this.chkRemoteDesktops_CheckedChanged);
            // 
            // chkDriveMappings
            // 
            this.chkDriveMappings.Checked = true;
            this.chkDriveMappings.CheckOnClick = true;
            this.chkDriveMappings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDriveMappings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.chkDriveMappings.Name = "chkDriveMappings";
            this.chkDriveMappings.Size = new System.Drawing.Size(247, 22);
            this.chkDriveMappings.Text = "Drive Mapping(s)";
            this.chkDriveMappings.CheckedChanged += new System.EventHandler(this.chkDriveMappings_CheckedChanged);
            // 
            // chkPrinterMappings
            // 
            this.chkPrinterMappings.Checked = true;
            this.chkPrinterMappings.CheckOnClick = true;
            this.chkPrinterMappings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrinterMappings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.chkPrinterMappings.Name = "chkPrinterMappings";
            this.chkPrinterMappings.Size = new System.Drawing.Size(247, 22);
            this.chkPrinterMappings.Text = "Printer Mapping(s)";
            this.chkPrinterMappings.CheckedChanged += new System.EventHandler(this.chkPrinterMappings_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(244, 6);
            // 
            // btnHideAllTabs
            // 
            this.btnHideAllTabs.Name = "btnHideAllTabs";
            this.btnHideAllTabs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.btnHideAllTabs.Size = new System.Drawing.Size(247, 22);
            this.btnHideAllTabs.Text = "Hide All";
            this.btnHideAllTabs.Click += new System.EventHandler(this.btnHideAllTabs_Click);
            // 
            // btnShowAllTabs
            // 
            this.btnShowAllTabs.Name = "btnShowAllTabs";
            this.btnShowAllTabs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.btnShowAllTabs.Size = new System.Drawing.Size(247, 22);
            this.btnShowAllTabs.Text = "Show All";
            this.btnShowAllTabs.Click += new System.EventHandler(this.btnShowAllTabs_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(244, 6);
            // 
            // chkStatusBarShow
            // 
            this.chkStatusBarShow.Checked = true;
            this.chkStatusBarShow.CheckOnClick = true;
            this.chkStatusBarShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatusBarShow.Name = "chkStatusBarShow";
            this.chkStatusBarShow.Size = new System.Drawing.Size(247, 22);
            this.chkStatusBarShow.Text = "Status Bar";
            this.chkStatusBarShow.CheckedChanged += new System.EventHandler(this.chkStatusBarShow_CheckedChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewHelp,
            this.toolStripSeparator5,
            this.btnAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnViewHelp
            // 
            this.btnViewHelp.Name = "btnViewHelp";
            this.btnViewHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.btnViewHelp.Size = new System.Drawing.Size(217, 22);
            this.btnViewHelp.Text = "View Help";
            this.btnViewHelp.Click += new System.EventHandler(this.btnViewHelp_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(214, 6);
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(217, 22);
            this.btnAbout.Text = "About On-Boarding Helper";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // dlgSaveConfig
            // 
            this.dlgSaveConfig.FileName = "configuration";
            this.dlgSaveConfig.Filter = "XML Config (*.xml)|*.xml";
            // 
            // dlgOpenConfig
            // 
            this.dlgOpenConfig.FileName = "configuration";
            this.dlgOpenConfig.Filter = "XML Config (*.xml)|*.xml";
            // 
            // btnShowConfigSummary
            // 
            this.btnShowConfigSummary.Name = "btnShowConfigSummary";
            this.btnShowConfigSummary.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.btnShowConfigSummary.Size = new System.Drawing.Size(247, 22);
            this.btnShowConfigSummary.Text = "Configuration Summary";
            this.btnShowConfigSummary.Click += new System.EventHandler(this.btnShowConfigSummary_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(244, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 545);
            this.Controls.Add(this.mainTabs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainStatusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "On-Boarding Helper v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainStatusBar.ResumeLayout(false);
            this.mainStatusBar.PerformLayout();
            this.mainTabs.ResumeLayout(false);
            this.basicTab.ResumeLayout(false);
            this.accountsTab.ResumeLayout(false);
            this.connectionsTab.ResumeLayout(false);
            this.connectionsTabs.ResumeLayout(false);
            this.tabWiFi.ResumeLayout(false);
            this.tabVPN.ResumeLayout(false);
            this.programsTab.ResumeLayout(false);
            this.remoteDesktopTab.ResumeLayout(false);
            this.tabDriveMaps.ResumeLayout(false);
            this.tabPrinters.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip mainStatusBar;
        private ToolStripStatusLabel lblOsVersion;
        private ToolStripStatusLabel lblProcessorInfo;
        private TabControl mainTabs;
        private TabPage basicTab;
        private TabPage accountsTab;
        private Panel panel1;
        private Button btnOnboard;
        private TabPage connectionsTab;
        private TabPage programsTab;
        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openConfigurationFileToolStripMenuItem;
        private ToolStripMenuItem saveCurrentConfigurationToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TabPage remoteDesktopTab;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblRamAmount;
        private userControls.AccountsUserCtl accountsUserCtl1;
        private userControls.ProgramsUserCtl programsUserCtl1;
        private SaveFileDialog dlgSaveConfig;
        private OpenFileDialog dlgOpenConfig;
        private userControls.AccountsUserCtl accountsUserCtl2;
        private userControls.WiFiUserCtl wiFiUserCtl1;
        private TabControl connectionsTabs;
        private TabPage tabWiFi;
        private TabPage tabVPN;
        private userControls.VPNUserCtl vpnUserCtl1;
        private userControls.RDPUserCtl rdpUserCtl1;
        private TabPage tabDriveMaps;
        private TabPage tabPrinters;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lblStatusText;
        private ImageList imageList1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem chkShowConnectionsTab;
        private ToolStripMenuItem chkProgramsTab;
        private ToolStripMenuItem chkRemoteDesktops;
        private ToolStripMenuItem chkDriveMappings;
        private ToolStripMenuItem chkPrinterMappings;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem btnHideAllTabs;
        private ToolStripMenuItem btnShowAllTabs;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem newWindowToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem chkStatusBarShow;
        private ToolStripMenuItem btnViewHelp;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem btnAbout;
        private userControls.BasicInfoUserCtl basicInfoUserCtl1;
        private userControls.DriveUserCtl driveUserCtl1;
        private userControls.PrinterUserCtl printerUserCtl1;
        private ToolStripMenuItem btnShowConfigSummary;
        private ToolStripSeparator toolStripSeparator6;
    }
}