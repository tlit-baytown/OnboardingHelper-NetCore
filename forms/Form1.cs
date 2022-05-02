using OnboardingHelper_NetCore.forms;
using OnboardingHelper_NetCore.settings;
using OnboardingHelper_NetCore.userControls;
using OnboardingHelper_NetCore.utility;
using System.Text;
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

        private void btnOnboard_Click(object sender, EventArgs e)
        {
            if (Configuration.Instance.HasBeenOnboarded)
            {
                DialogResult result = MessageBox.Show(this, "The current configuration has already been set on this computer.\nContinue Anyway?", "Confirm",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.No || result == DialogResult.Cancel)
                    return;
            }

            if (Configuration.Instance.CheckConfiguration())
                ShowSummaryBeforeOnboard();
            else
                ShowMissingInformation();
        }

        private void ShowSummaryBeforeOnboard()
        {
            Summary summaryDialog = new Summary();
            summaryDialog.ConfigAccepted += HandleConfigAccepted;
            summaryDialog.ConfigRejected += HandleConfigRejected;

            summaryDialog.ShowDialog();
        }

        private void HandleConfigAccepted(object sender, EventArgs e)
        {
            lblStatusText.Text = "Configuration Accepted! Beginning On-Boarding Process...";

            OnboardForm onboardingForm = new OnboardForm();
            onboardingForm.OnboardingDone += HandleOnboardDone;

            onboardingForm.ShowDialog();
        }

        private void HandleConfigRejected(object sender, EventArgs e)
        {
            lblStatusText.Text = "Configuration rejected by user. Make changes and attempt On-Boarding again.";
        }

        private void ShowMissingInformation()
        {
            StringBuilder bldr = new StringBuilder();

            if (Configuration.Instance.ComputerName.Equals(string.Empty))
                bldr.Append("-> Missing computer name.\n");
            if (Configuration.Instance.TimeZone == null)
                bldr.Append("-> Missing time zone information.\n");
            if (Configuration.Instance.PrimaryNTPServer.Equals(string.Empty))
                bldr.Append("-> Missing primary NTP server.\n");
            if (Configuration.Instance.Accounts.Count <= 0)
                bldr.Append("-> Missing at least 1 account.\n");

            MessageBox.Show(this, $"The current configuration is missing required information. See below:\n{bldr}", "Incomplete Configuration",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HandleOnboardDone(object sender, EventArgs e)
        {
            if (e is OnboardDoneEventArgs args)
            {
                if (args.IsSuccessful)
                {
                    lblStatusText.Text = "Onboarding Process Completed!";
                    Configuration.Instance.HasBeenOnboarded = true;
                }
                else
                {
                    lblStatusText.Text = "Onboarding Process Failed! See message in popup.";
                    Configuration.Instance.HasBeenOnboarded = false;
                }

                if (!args.IsSuccessful)
                    MessageBox.Show(this, args.Message, "Onboarding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnShowConfigSummary_Click(object sender, EventArgs e)
        {
            new Summary(false).ShowDialog();
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