using OnboardingHelper_NetCore.settings;
using OnboardingHelper_NetCore.wrappers;
using OnboardingHelper_NetCore.wrappers.property_grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnboardingHelper_NetCore.forms
{
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

        private BasicInfo basicInfo = new BasicInfo();

        public Summary()
        {
            InitializeComponent();
        }

        public Summary(bool showButtons = true)
        {
            InitializeComponent();

            if (!showButtons)
                tlpButtons.Visible = false;
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            TreeNode? basicRoot = tvOptions.Nodes["nodeBasic"];
            if (basicRoot != null)
            {
                basicRoot.Tag = basicInfo;
                propGrid.SelectedObject = basicRoot.Tag;
                SetupTree();
            }
        }

        private void SetupTree()
        {
            //Set up accounts
            AddAccounts();
            AddConnections();
            AddPrograms();
            AddRemoteDesktops();
            AddDriveMappings();
            AddPrinterMappings();
        }

        private void AddAccounts()
        {
            TreeNode? accountRoot = tvOptions.Nodes["nodeAccounts"];
            if (accountRoot == null)
                return;

            foreach (Account a in Configuration.Instance.Accounts)
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

            foreach (WiFi w in Configuration.Instance.WiFiProfiles)
            {
                TreeNode newNode = new TreeNode(w.SSID);
                newNode.Tag = w;
                wifiRoot.Nodes.Add(newNode);
            }

            foreach (VPN v in Configuration.Instance.VPNProfiles)
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

            foreach (wrappers.Application a in Configuration.Instance.Applications)
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

            foreach (RDPFile f in Configuration.Instance.RDPFiles)
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

            foreach (MappedDrive m in Configuration.Instance.MappedDrives)
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

            foreach (Printer p in Configuration.Instance.Printers)
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
    }
}
