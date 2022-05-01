using OnboardingHelper_NetCore.forms;
using OnboardingHelper_NetCore.settings;
using OnboardingHelper_NetCore.userControls;
using OnboardingHelper_NetCore.utility;
using static OnboardingHelper_NetCore.CEventArgs;

namespace OnboardingHelper_NetCore
{
    public partial class MainForm : Form
    {
        private TabControlHelper tabHelper;

        public MainForm()
        {
            InitializeComponent();

            tabHelper = new TabControlHelper(mainTabs);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utility.SetMainForm(this);

            lblOsVersion.Text = SystemInfo.Instance.OSName + "\t" + SystemInfo.Instance.CSDVersion;
            lblProcessorInfo.Text = SystemInfo.Instance.ProcessorName;
            lblRamAmount.Text = SystemInfo.Instance.RAMAmount;

            Configuration.ConfigLoadError += HandleConfigLoadError;
            Configuration.ConfigSaveError += HandleConfigSaveError;
            Configuration.ConfigLoaded += HandleConfigLoaded;
            Configuration.ConfigSaved += HandleConfigSaved;
            Configuration.ConfigReset += HandleConfigReset;
        }

        private void HandleConfigLoadError(object sender, EventArgs e)
        {
            MessageBox.Show(this, "An error occured reading the XML configuration. " +
                "Ensure it is a valid configuration file and try again.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            lblStatusText.Text = "Error loading configuration!";
        }

        private void HandleConfigSaveError(object sender, EventArgs e)
        {
            MessageBox.Show(this, "An error occured saving the XML configuration. " +
                "Ensure the file path is accessible and writable to the application.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            lblStatusText.Text = "Error saving configuration!";
        }

        private void HandleConfigLoaded(object sender, EventArgs e)
        {
            //Update values on each user control that implements IUpdatable
            int errorCount = 0;

            foreach (TabPage t in mainTabs.TabPages)
                errorCount += UpdateRecursive(t.Controls);

            if (errorCount > 0)
            {
                MessageBox.Show(this, "There was an error while loading the configuration." +
                    "Inspect the configuration file for any issues and try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatusText.Text = "Config loading failed!";
            }
            else
            {
                MessageBox.Show(this, "Successfully loaded the configuration!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblStatusText.Text = "Config loaded successfully.";
            }
        }

        private int UpdateRecursive(Control.ControlCollection collection)
        {
            int errorCount = 0;
            foreach (Control c in collection)
            {
                if (c is IUpdatable i)
                {
                    if (!i.UpdateValues())
                    {
                        errorCount++;
                    }
                }
                else
                    UpdateRecursive(c.Controls);
            }

            return errorCount;
        }

        private void HandleConfigSaved(object sender, EventArgs e)
        {
            if (e is ConfigSavedEventArgs args)
            {
                lblStatusText.Text = $"Config saved: {args.ConfigPath}";
            }
        }

        private void HandleConfigReset(object sender, EventArgs e)
        {
            foreach (TabPage t in mainTabs.TabPages)
                UpdateRecursive(t.Controls);

            lblStatusText.Text = "Configuration Cleared!";
        }

        #region File Menu
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure you want to reset all configuration values?",
                "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.No || result == DialogResult.Cancel)
                return;

            Configuration.Instance.ResetConfig(true);
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var info = new System.Diagnostics.ProcessStartInfo(System.Windows.Forms.Application.ExecutablePath);
            System.Diagnostics.Process.Start(info);
        }

        private void openConfigurationFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgOpenConfig.ShowDialog() == DialogResult.OK)
            {
                if (Configuration.LoadConfig(dlgOpenConfig.FileName) == null)
                    MessageBox.Show(this, "The configuration file could not be read. It may be corrupted. Please try again.",
                        "Error Reading Config", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveCurrentConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgSaveConfig.ShowDialog() == DialogResult.OK)
            {
                if (!Configuration.Instance.SaveConfig(dlgSaveConfig.FileName))
                    MessageBox.Show(this, "The configuration file could not be saved due to an unknown error. Please try again.",
                        "Error Saving Config", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure you want to exit?\nThe configuration is NOT automatically saved.", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.No || result == DialogResult.Cancel)
                return;

            System.Windows.Forms.Application.Exit();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region View Menu
        private void HideTab(string tabKey)
        {
            tabHelper.HidePage(tabHelper.GetPage(tabKey));
        }

        private void ShowTab(string tabKey)
        {
            tabHelper.ShowPage(tabHelper.GetPage(tabKey));
        }

        private void chkShowConnectionsTab_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowConnectionsTab.Checked)
                ShowTab("connectionsTab");
            else
                HideTab("connectionsTab");
        }

        private void chkProgramsTab_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProgramsTab.Checked)
                ShowTab("programsTab");
            else
                HideTab("programsTab");
        }

        private void chkRemoteDesktops_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRemoteDesktops.Checked)
                ShowTab("remoteDesktopTab");
            else
                HideTab("remoteDesktopTab");
        }

        private void chkDriveMappings_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDriveMappings.Checked)
                ShowTab("tabDriveMaps");
            else
                HideTab("tabDriveMaps");
        }

        private void chkPrinterMappings_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrinterMappings.Checked)
                ShowTab("tabPrinters");
            else
                HideTab("tabPrinters");
        }

        private void btnHideAllTabs_Click(object sender, EventArgs e)
        {
            tabHelper.HideAllPages();
        }

        private void btnShowAllTabs_Click(object sender, EventArgs e)
        {
            tabHelper.ShowAllPages();
        }

        private void chkStatusBarShow_CheckedChanged(object sender, EventArgs e)
        {
            mainStatusBar.Visible = chkStatusBarShow.Checked;
        }
        #endregion

        #region Help Menu
        private void btnViewHelp_Click(object sender, EventArgs e)
        {
            new HelpBox().ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
        #endregion
    }
}