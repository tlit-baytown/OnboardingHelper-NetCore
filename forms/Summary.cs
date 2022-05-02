using Zest_Script.settings;
using Zest_Script.wrappers;

namespace Zest_Script.forms
{
    /// <summary>
    /// Shows a summary of the current configuration or of a configuration loaded by file.
    /// </summary>
    public partial class Summary : Form
    {
        /// <summary>
        /// Occurs when the user accepts the current configuration for on-boarding.
        /// </summary>
        public EventHandler? ConfigAccepted;

        /// <summary>
        /// Occurs when the user rejects the current configuration for on-boarding.
        /// </summary>
        public EventHandler? ConfigRejected;

        private readonly Configuration tempConfig = Configuration.Instance;

        /// <summary>
        /// Create a new default summary dialog.
        /// </summary>
        public Summary()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Display a configuration file seperate from the current configuration loaded into Zest Script.
        /// </summary>
        /// <param name="file"></param>
        public Summary(string file) : this(false)
        {
            tempConfig = Configuration.LoadConfig(file, false);
        }

        /// <summary>
        /// Create a new summary dialog with the specified argument.
        /// </summary>
        /// <param name="showConfirmationButtons">Indicate whether or not to show confirmation buttons.</param>
        public Summary(bool showConfirmationButtons) : this()
        {
            if (!showConfirmationButtons)
                tlpButtons.Visible = false;
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            SetupTree();
            tvOptions.SelectedNode = tvOptions.Nodes[0]; //Select the first node in the tree view.
        }

        private void SetupTree()
        {
            AddBasicInfo();
            AddAccounts();
            AddConnections();
            AddPrograms();
            AddRemoteDesktops();
            AddDriveMappings();
            AddPrinterMappings();
        }

        private void AddBasicInfo()
        {
            TreeNode? basicRoot = tvOptions.Nodes["nodeBasic"];
            if (basicRoot == null)
                return;
            basicRoot.Tag = tempConfig.BasicInfo;
        }

        private void AddAccounts()
        {
            TreeNode? accountRoot = tvOptions.Nodes["nodeAccounts"];
            if (accountRoot == null)
                return;

            foreach (Account a in tempConfig.Accounts)
            {
                TreeNode newNode = new TreeNode(a.Username);
                newNode.Tag = a;
                accountRoot.Nodes.Add(newNode);
            }
        }

        private void AddConnections()
        {
            TreeNode? wifiRoot = tvOptions.Nodes.Find("nodeWiFi", true).FirstOrDefault();
            TreeNode? vpnRoot = tvOptions.Nodes.Find("nodeVPN", true).FirstOrDefault();
            if (wifiRoot == null || vpnRoot == null)
                return;

            foreach (WiFi w in tempConfig.WiFiProfiles)
            {
                TreeNode newNode = new TreeNode(w.SSID);
                newNode.Tag = w;
                wifiRoot.Nodes.Add(newNode);
            }

            foreach (VPN v in tempConfig.VPNProfiles)
            {
                TreeNode newNode = new TreeNode(v.ConnectionName);
                newNode.Tag = v;
                vpnRoot.Nodes.Add(newNode);
            }
        }

        private void AddPrograms()
        {
            TreeNode? programsRoot = tvOptions.Nodes["nodePrograms"];
            if (programsRoot == null)
                return;

            foreach (wrappers.Application a in tempConfig.Applications)
            {
                TreeNode newNode = new TreeNode(a.Name);
                newNode.Tag = a;
                programsRoot.Nodes.Add(newNode);
            }
        }

        private void AddRemoteDesktops()
        {
            TreeNode? remoteDesktopRoot = tvOptions.Nodes["nodeRemoteDesktop"];
            if (remoteDesktopRoot == null)
                return;

            foreach (RDPFile f in tempConfig.RDPFiles)
            {
                TreeNode newNode = new TreeNode(f.ComputerName);
                newNode.Tag = f;
                remoteDesktopRoot.Nodes.Add(newNode);
            }
        }

        private void AddDriveMappings()
        {
            TreeNode? driveMappingsRoot = tvOptions.Nodes["nodeDriveMappings"];
            if (driveMappingsRoot == null)
                return;

            foreach (MappedDrive m in tempConfig.MappedDrives)
            {
                TreeNode newNode = new TreeNode(m.DriveLetter.ToString());
                newNode.Tag = m;
                driveMappingsRoot.Nodes.Add(newNode);
            }
        }

        private void AddPrinterMappings()
        {
            TreeNode? printerMappingsRoot = tvOptions.Nodes["nodePrinterMappings"];
            if (printerMappingsRoot == null)
                return;

            foreach (Printer p in tempConfig.Printers)
            {
                TreeNode newNode = new TreeNode(p.Name);
                newNode.Tag = p;
                printerMappingsRoot.Nodes.Add(newNode);
            }
        }

        private void tvOptions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
                if (e.Node.Tag != null)
                    propGrid.SelectedObject = e.Node.Tag;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ConfigAccepted?.Invoke(this, new EventArgs());
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ConfigRejected?.Invoke(this, new EventArgs());
            Close();
        }

        private void btnExpandTreeView_Click(object sender, EventArgs e)
        {
            tvOptions.ExpandAll();
        }

        private void btnCollapseTreeView_Click(object sender, EventArgs e)
        {
            tvOptions.CollapseAll();
        }

        private void Summary_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
