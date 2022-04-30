using OnboardingHelper_NetCore.forms;
using OnboardingHelper_NetCore.settings;
using OnboardingHelper_NetCore.wrappers;
using WUApiLib;
using static OnboardingHelper_NetCore.CEventArgs;

namespace OnboardingHelper_NetCore
{
    public partial class MainForm : Form
    {
        private List<IUpdate> updates = new List<IUpdate>();
        private WindowsUpdate updateTool = new WindowsUpdate();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utility.SetMainForm(this);

            cmbTimeZones.DataSource = Utility.GetTimezones();
            cmbNTPServers.DataSource = Utility.GetPossibleNTPServers();

            lblOsVersion.Text = SystemInfo.Instance.OSName + "\t" + SystemInfo.Instance.CSDVersion;
            lblProcessorInfo.Text = SystemInfo.Instance.ProcessorName;
            lblRamAmount.Text = SystemInfo.Instance.RAMAmount;

            if (SystemInfo.Instance.OSName.Contains("Home"))
            {
                txtDomain.Enabled = false;
                txtDomain.PlaceholderText = "Domain not available in 'Home' versions of Windows!";
            }

            Configuration.ConfigError += HandleConfigError;
            Configuration.ConfigLoaded += HandleConfigLoaded;
            Configuration.ConfigSaved += HandleConfigSaved;
            Configuration.ConfigReset += HandleConfigReset;
        }

        private void HandleConfigError(object sender, EventArgs e)
        {
            MessageBox.Show(this, "An error occured reading the XML configuration. " +
                "Ensure it is a valid configuration file and try again.", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HandleConfigLoaded(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Successfully loaded the configuration!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //TODO: set GUI based on Configuration
        }

        private void HandleConfigSaved(object sender, EventArgs e)
        {
            if (e is ConfigSavedEventArgs args)
            {
                MessageBox.Show(this, $"Configuration file saved: {args.ConfigPath}", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void HandleConfigReset(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Configuration Cleared", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpBox().ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure you want to exit?\nThe configuration is NOT automatically saved.", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.No || result == DialogResult.Cancel)
                return;

            System.Windows.Forms.Application.Exit();
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

        private void btnShowDomainPassword_MouseEnter(object sender, EventArgs e)
        {
            txtDomainPassword.UseSystemPasswordChar = false;
        }

        private void btnShowDomainPassword_MouseLeave(object sender, EventArgs e)
        {
            txtDomainPassword.UseSystemPasswordChar = true;
        }

        private void txtDomain_TextChanged(object sender, EventArgs e)
        {
            if (txtDomain.Text.Length > 0)
                grpDomainCredentials.Visible = true;
            else
                grpDomainCredentials.Visible = false;

            Configuration.Instance.Domain = txtDomain.Text;
        }

        private void txtComputerName_TextChanged(object sender, EventArgs e)
        {
            Configuration.Instance.ComputerName = txtComputerName.Text;
        }

        private void cmbTimeZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configuration.Instance.TimeZone = (TimeZoneInfo)cmbTimeZones.SelectedItem;
            Configuration.Instance.TimeZoneString = Configuration.Instance.TimeZone.ToSerializedString();
        }

        private void cmbNTPServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configuration.Instance.PrimaryNTPServer = (string)cmbNTPServers.SelectedItem;
        }

        private void cmbNTPServers_TextChanged(object sender, EventArgs e)
        {
            Configuration.Instance.PrimaryNTPServer = cmbNTPServers.Text;
        }

        private void chkPerformTZSync_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.Instance.PerformTimeSync = chkPerformTZSync.Checked;
        }

        private void txtDomainUsername_TextChanged(object sender, EventArgs e)
        {
            Configuration.Instance.DomainUsername = txtDomainUsername.Text;
        }

        private void txtDomainPassword_TextChanged(object sender, EventArgs e)
        {
            Configuration.Instance.DomainPasswordString = txtDomainPassword.Text;
        }
    }
}