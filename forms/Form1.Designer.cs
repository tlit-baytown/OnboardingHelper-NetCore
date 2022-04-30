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
            this.grpDomainCredentials = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDomainPassword = new System.Windows.Forms.TextBox();
            this.btnShowDomainPassword = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDomainUsername = new System.Windows.Forms.TextBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.lblUpdateStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.updatesProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.chkPerformTZSync = new System.Windows.Forms.CheckBox();
            this.accountsTab = new System.Windows.Forms.TabPage();
            this.accountsUserCtl2 = new OnboardingHelper_NetCore.userControls.AccountsUserCtl();
            this.connectionsTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabWiFi = new System.Windows.Forms.TabPage();
            this.wiFiUserCtl1 = new OnboardingHelper_NetCore.userControls.WiFiUserCtl();
            this.tabVPN = new System.Windows.Forms.TabPage();
            this.vpnUserCtl1 = new OnboardingHelper_NetCore.userControls.VPNUserCtl();
            this.programsTab = new System.Windows.Forms.TabPage();
            this.programsUserCtl1 = new OnboardingHelper_NetCore.userControls.ProgramsUserCtl();
            this.remoteDesktopTab = new System.Windows.Forms.TabPage();
            this.rdpUserCtl1 = new OnboardingHelper_NetCore.userControls.RDPUserCtl();
            this.tabDriveMaps = new System.Windows.Forms.TabPage();
            this.tabPrinters = new System.Windows.Forms.TabPage();
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
            this.dlgSaveConfig = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpenConfig = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.basicTab.SuspendLayout();
            this.grpDomainCredentials.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.accountsTab.SuspendLayout();
            this.connectionsTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabWiFi.SuspendLayout();
            this.tabVPN.SuspendLayout();
            this.programsTab.SuspendLayout();
            this.remoteDesktopTab.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(885, 20);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            // 
            // lblOsVersion
            // 
            this.lblOsVersion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblOsVersion.Name = "lblOsVersion";
            this.lblOsVersion.Size = new System.Drawing.Size(79, 15);
            this.lblOsVersion.Spring = true;
            this.lblOsVersion.Text = "<OS Version>";
            this.lblOsVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 15);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // lblProcessorInfo
            // 
            this.lblProcessorInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblProcessorInfo.Name = "lblProcessorInfo";
            this.lblProcessorInfo.Size = new System.Drawing.Size(109, 15);
            this.lblProcessorInfo.Spring = true;
            this.lblProcessorInfo.Text = "<Processor Name>";
            this.lblProcessorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 15);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // lblRamAmount
            // 
            this.lblRamAmount.Name = "lblRamAmount";
            this.lblRamAmount.Size = new System.Drawing.Size(96, 15);
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
            this.label4.Location = new System.Drawing.Point(3, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Primary NTP Server: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time Zone: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
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
            this.txtDomain.TextChanged += new System.EventHandler(this.txtDomain_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
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
            this.txtComputerName.TextChanged += new System.EventHandler(this.txtComputerName_TextChanged);
            // 
            // cmbTimeZones
            // 
            this.cmbTimeZones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTimeZones.DisplayMember = "DisplayName";
            this.cmbTimeZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeZones.FormattingEnabled = true;
            this.cmbTimeZones.Location = new System.Drawing.Point(137, 76);
            this.cmbTimeZones.Name = "cmbTimeZones";
            this.cmbTimeZones.Size = new System.Drawing.Size(582, 23);
            this.cmbTimeZones.TabIndex = 5;
            this.cmbTimeZones.SelectedIndexChanged += new System.EventHandler(this.cmbTimeZones_SelectedIndexChanged);
            // 
            // cmbNTPServers
            // 
            this.cmbNTPServers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNTPServers.FormattingEnabled = true;
            this.cmbNTPServers.Location = new System.Drawing.Point(137, 111);
            this.cmbNTPServers.Name = "cmbNTPServers";
            this.cmbNTPServers.Size = new System.Drawing.Size(582, 23);
            this.cmbNTPServers.TabIndex = 7;
            this.cmbNTPServers.SelectedIndexChanged += new System.EventHandler(this.cmbNTPServers_SelectedIndexChanged);
            this.cmbNTPServers.TextChanged += new System.EventHandler(this.cmbNTPServers_TextChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.basicTab);
            this.tabControl.Controls.Add(this.accountsTab);
            this.tabControl.Controls.Add(this.connectionsTab);
            this.tabControl.Controls.Add(this.programsTab);
            this.tabControl.Controls.Add(this.remoteDesktopTab);
            this.tabControl.Controls.Add(this.tabDriveMaps);
            this.tabControl.Controls.Add(this.tabPrinters);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.iconList;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(885, 501);
            this.tabControl.TabIndex = 3;
            // 
            // basicTab
            // 
            this.basicTab.Controls.Add(this.grpDomainCredentials);
            this.basicTab.Controls.Add(this.statusStrip2);
            this.basicTab.Controls.Add(this.chkPerformTZSync);
            this.basicTab.Controls.Add(this.tableLayoutPanel1);
            this.basicTab.ImageKey = "settings (Custom).png";
            this.basicTab.Location = new System.Drawing.Point(4, 39);
            this.basicTab.Name = "basicTab";
            this.basicTab.Padding = new System.Windows.Forms.Padding(3);
            this.basicTab.Size = new System.Drawing.Size(877, 458);
            this.basicTab.TabIndex = 0;
            this.basicTab.Text = "Basic";
            this.basicTab.UseVisualStyleBackColor = true;
            // 
            // grpDomainCredentials
            // 
            this.grpDomainCredentials.Controls.Add(this.tableLayoutPanel2);
            this.grpDomainCredentials.Location = new System.Drawing.Point(8, 152);
            this.grpDomainCredentials.Name = "grpDomainCredentials";
            this.grpDomainCredentials.Size = new System.Drawing.Size(385, 100);
            this.grpDomainCredentials.TabIndex = 9;
            this.grpDomainCredentials.TabStop = false;
            this.grpDomainCredentials.Text = "Domain Credentials";
            this.grpDomainCredentials.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.27027F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.72973F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDomainUsername, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.56097F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.43903F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(370, 73);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.txtDomainPassword);
            this.flowLayoutPanel1.Controls.Add(this.btnShowDomainPassword);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(77, 37);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 33);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // txtDomainPassword
            // 
            this.txtDomainPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDomainPassword.Location = new System.Drawing.Point(3, 3);
            this.txtDomainPassword.Name = "txtDomainPassword";
            this.txtDomainPassword.PlaceholderText = "Password for domain administrator";
            this.txtDomainPassword.Size = new System.Drawing.Size(253, 23);
            this.txtDomainPassword.TabIndex = 3;
            this.txtDomainPassword.UseSystemPasswordChar = true;
            this.txtDomainPassword.TextChanged += new System.EventHandler(this.txtDomainPassword_TextChanged);
            // 
            // btnShowDomainPassword
            // 
            this.btnShowDomainPassword.BackgroundImage = global::OnboardingHelper_NetCore.Properties.Resources.show_24x24;
            this.btnShowDomainPassword.FlatAppearance.BorderSize = 0;
            this.btnShowDomainPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDomainPassword.Location = new System.Drawing.Point(262, 3);
            this.btnShowDomainPassword.Name = "btnShowDomainPassword";
            this.btnShowDomainPassword.Size = new System.Drawing.Size(24, 24);
            this.btnShowDomainPassword.TabIndex = 4;
            this.btnShowDomainPassword.UseVisualStyleBackColor = true;
            this.btnShowDomainPassword.MouseEnter += new System.EventHandler(this.btnShowDomainPassword_MouseEnter);
            this.btnShowDomainPassword.MouseLeave += new System.EventHandler(this.btnShowDomainPassword_MouseLeave);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password: ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username: ";
            // 
            // txtDomainUsername
            // 
            this.txtDomainUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDomainUsername.Location = new System.Drawing.Point(77, 5);
            this.txtDomainUsername.Name = "txtDomainUsername";
            this.txtDomainUsername.PlaceholderText = "Username of domain administrator";
            this.txtDomainUsername.Size = new System.Drawing.Size(290, 23);
            this.txtDomainUsername.TabIndex = 1;
            this.txtDomainUsername.TextChanged += new System.EventHandler(this.txtDomainUsername_TextChanged);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUpdateStatus,
            this.updatesProgressBar});
            this.statusStrip2.Location = new System.Drawing.Point(3, 433);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(871, 22);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 8;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(554, 17);
            this.lblUpdateStatus.Spring = true;
            this.lblUpdateStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updatesProgressBar
            // 
            this.updatesProgressBar.Name = "updatesProgressBar";
            this.updatesProgressBar.Size = new System.Drawing.Size(300, 16);
            // 
            // chkPerformTZSync
            // 
            this.chkPerformTZSync.AutoSize = true;
            this.chkPerformTZSync.Location = new System.Drawing.Point(564, 152);
            this.chkPerformTZSync.Name = "chkPerformTZSync";
            this.chkPerformTZSync.Size = new System.Drawing.Size(166, 19);
            this.chkPerformTZSync.TabIndex = 1;
            this.chkPerformTZSync.Text = "Perform Time Server Sync?";
            this.chkPerformTZSync.UseVisualStyleBackColor = true;
            this.chkPerformTZSync.CheckedChanged += new System.EventHandler(this.chkPerformTZSync_CheckedChanged);
            // 
            // accountsTab
            // 
            this.accountsTab.Controls.Add(this.accountsUserCtl2);
            this.accountsTab.ImageKey = "user (Custom).png";
            this.accountsTab.Location = new System.Drawing.Point(4, 39);
            this.accountsTab.Name = "accountsTab";
            this.accountsTab.Padding = new System.Windows.Forms.Padding(3);
            this.accountsTab.Size = new System.Drawing.Size(877, 458);
            this.accountsTab.TabIndex = 1;
            this.accountsTab.Text = "Accounts";
            this.accountsTab.UseVisualStyleBackColor = true;
            // 
            // accountsUserCtl2
            // 
            this.accountsUserCtl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountsUserCtl2.Location = new System.Drawing.Point(3, 3);
            this.accountsUserCtl2.Name = "accountsUserCtl2";
            this.accountsUserCtl2.Size = new System.Drawing.Size(871, 407);
            this.accountsUserCtl2.TabIndex = 0;
            // 
            // connectionsTab
            // 
            this.connectionsTab.Controls.Add(this.tabControl1);
            this.connectionsTab.ImageKey = "internet (Custom).png";
            this.connectionsTab.Location = new System.Drawing.Point(4, 39);
            this.connectionsTab.Name = "connectionsTab";
            this.connectionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.connectionsTab.Size = new System.Drawing.Size(877, 458);
            this.connectionsTab.TabIndex = 2;
            this.connectionsTab.Text = "Connections";
            this.connectionsTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabWiFi);
            this.tabControl1.Controls.Add(this.tabVPN);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(871, 452);
            this.tabControl1.TabIndex = 1;
            // 
            // tabWiFi
            // 
            this.tabWiFi.Controls.Add(this.wiFiUserCtl1);
            this.tabWiFi.Location = new System.Drawing.Point(4, 24);
            this.tabWiFi.Name = "tabWiFi";
            this.tabWiFi.Padding = new System.Windows.Forms.Padding(3);
            this.tabWiFi.Size = new System.Drawing.Size(863, 424);
            this.tabWiFi.TabIndex = 0;
            this.tabWiFi.Text = "Wi-Fi Networks";
            this.tabWiFi.UseVisualStyleBackColor = true;
            // 
            // wiFiUserCtl1
            // 
            this.wiFiUserCtl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.wiFiUserCtl1.Location = new System.Drawing.Point(3, 3);
            this.wiFiUserCtl1.Name = "wiFiUserCtl1";
            this.wiFiUserCtl1.Size = new System.Drawing.Size(857, 384);
            this.wiFiUserCtl1.TabIndex = 0;
            // 
            // tabVPN
            // 
            this.tabVPN.Controls.Add(this.vpnUserCtl1);
            this.tabVPN.Location = new System.Drawing.Point(4, 24);
            this.tabVPN.Name = "tabVPN";
            this.tabVPN.Padding = new System.Windows.Forms.Padding(3);
            this.tabVPN.Size = new System.Drawing.Size(863, 424);
            this.tabVPN.TabIndex = 1;
            this.tabVPN.Text = "VPN Connections";
            this.tabVPN.UseVisualStyleBackColor = true;
            // 
            // vpnUserCtl1
            // 
            this.vpnUserCtl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.vpnUserCtl1.Location = new System.Drawing.Point(3, 3);
            this.vpnUserCtl1.Name = "vpnUserCtl1";
            this.vpnUserCtl1.Size = new System.Drawing.Size(857, 379);
            this.vpnUserCtl1.TabIndex = 0;
            // 
            // programsTab
            // 
            this.programsTab.Controls.Add(this.programsUserCtl1);
            this.programsTab.ImageKey = "web-programming (Custom).png";
            this.programsTab.Location = new System.Drawing.Point(4, 39);
            this.programsTab.Name = "programsTab";
            this.programsTab.Padding = new System.Windows.Forms.Padding(3);
            this.programsTab.Size = new System.Drawing.Size(877, 458);
            this.programsTab.TabIndex = 3;
            this.programsTab.Text = "Programs";
            this.programsTab.UseVisualStyleBackColor = true;
            // 
            // programsUserCtl1
            // 
            this.programsUserCtl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.programsUserCtl1.Location = new System.Drawing.Point(3, 3);
            this.programsUserCtl1.Name = "programsUserCtl1";
            this.programsUserCtl1.Size = new System.Drawing.Size(871, 407);
            this.programsUserCtl1.TabIndex = 0;
            // 
            // remoteDesktopTab
            // 
            this.remoteDesktopTab.Controls.Add(this.rdpUserCtl1);
            this.remoteDesktopTab.ImageKey = "remote-control (Custom).png";
            this.remoteDesktopTab.Location = new System.Drawing.Point(4, 39);
            this.remoteDesktopTab.Name = "remoteDesktopTab";
            this.remoteDesktopTab.Padding = new System.Windows.Forms.Padding(3);
            this.remoteDesktopTab.Size = new System.Drawing.Size(877, 458);
            this.remoteDesktopTab.TabIndex = 4;
            this.remoteDesktopTab.Text = "Remote Desktop(s)";
            this.remoteDesktopTab.UseVisualStyleBackColor = true;
            // 
            // rdpUserCtl1
            // 
            this.rdpUserCtl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdpUserCtl1.Location = new System.Drawing.Point(3, 3);
            this.rdpUserCtl1.Name = "rdpUserCtl1";
            this.rdpUserCtl1.Size = new System.Drawing.Size(871, 408);
            this.rdpUserCtl1.TabIndex = 0;
            // 
            // tabDriveMaps
            // 
            this.tabDriveMaps.ImageKey = "folder-network (Custom).png";
            this.tabDriveMaps.Location = new System.Drawing.Point(4, 39);
            this.tabDriveMaps.Name = "tabDriveMaps";
            this.tabDriveMaps.Padding = new System.Windows.Forms.Padding(3);
            this.tabDriveMaps.Size = new System.Drawing.Size(877, 458);
            this.tabDriveMaps.TabIndex = 5;
            this.tabDriveMaps.Text = "Drive Mapping(s)";
            this.tabDriveMaps.UseVisualStyleBackColor = true;
            // 
            // tabPrinters
            // 
            this.tabPrinters.ImageKey = "printer (Custom).png";
            this.tabPrinters.Location = new System.Drawing.Point(4, 39);
            this.tabPrinters.Name = "tabPrinters";
            this.tabPrinters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrinters.Size = new System.Drawing.Size(877, 458);
            this.tabPrinters.TabIndex = 6;
            this.tabPrinters.Text = "Printer Mapping(s)";
            this.tabPrinters.UseVisualStyleBackColor = true;
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
            this.iconList.Images.SetKeyName(8, "folder-network (Custom).png");
            this.iconList.Images.SetKeyName(9, "printer (Custom).png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 45);
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
            this.button1.Size = new System.Drawing.Size(885, 45);
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
            this.menuStrip1.Size = new System.Drawing.Size(885, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openConfigurationFileToolStripMenuItem
            // 
            this.openConfigurationFileToolStripMenuItem.Name = "openConfigurationFileToolStripMenuItem";
            this.openConfigurationFileToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.openConfigurationFileToolStripMenuItem.Text = "Open Configuration File...";
            this.openConfigurationFileToolStripMenuItem.Click += new System.EventHandler(this.openConfigurationFileToolStripMenuItem_Click);
            // 
            // saveCurrentConfigurationToolStripMenuItem
            // 
            this.saveCurrentConfigurationToolStripMenuItem.Name = "saveCurrentConfigurationToolStripMenuItem";
            this.saveCurrentConfigurationToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.saveCurrentConfigurationToolStripMenuItem.Text = "Save Current Configuration...";
            this.saveCurrentConfigurationToolStripMenuItem.Click += new System.EventHandler(this.saveCurrentConfigurationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 545);
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
            this.grpDomainCredentials.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.accountsTab.ResumeLayout(false);
            this.connectionsTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabWiFi.ResumeLayout(false);
            this.tabVPN.ResumeLayout(false);
            this.programsTab.ResumeLayout(false);
            this.remoteDesktopTab.ResumeLayout(false);
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
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel lblUpdateStatus;
        private ToolStripProgressBar updatesProgressBar;
        private System.ComponentModel.BackgroundWorker checkForUpdatesBackground;
        private System.ComponentModel.BackgroundWorker installUpdatesBackground;
        private TabPage remoteDesktopTab;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblRamAmount;
        private userControls.AccountsUserCtl accountsUserCtl1;
        private userControls.ProgramsUserCtl programsUserCtl1;
        private ImageList iconList;
        private SaveFileDialog dlgSaveConfig;
        private OpenFileDialog dlgOpenConfig;
        private userControls.AccountsUserCtl accountsUserCtl2;
        private userControls.WiFiUserCtl wiFiUserCtl1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtDomainPassword;
        private Button btnShowDomainPassword;
        private GroupBox grpDomainCredentials;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label6;
        private Label label5;
        private TextBox txtDomainUsername;
        private TabControl tabControl1;
        private TabPage tabWiFi;
        private TabPage tabVPN;
        private userControls.VPNUserCtl vpnUserCtl1;
        private userControls.RDPUserCtl rdpUserCtl1;
        private TabPage tabDriveMaps;
        private TabPage tabPrinters;
    }
}