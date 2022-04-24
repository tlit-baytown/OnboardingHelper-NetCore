using OnboardingHelper_NetCore.wrappers;
using WUApiLib;

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
        }

        #region Windows Update Functionality
        private void btnCheckForUpdates_Click(object sender, EventArgs e)
        {
            if (!checkForUpdatesBackground.IsBusy)
            {
                updatesProgressBar.Value = 0;
                updatesProgressBar.Visible = true;
                checkForUpdatesBackground.RunWorkerAsync();
            }
            //List<UpdateWrapper> list = PowershellHelper.GetUpdates();
            //foreach (UpdateWrapper update in list)
            //    dgWindowsUpdate.Rows.Add(update.KB, update.Size, update.Title);
        }

        public ToolStripProgressBar GetUpdatesProgressBar()
        {
            return updatesProgressBar;
        }

        public void UpdateWindowsUpdateChecker(int progress)
        {
            checkForUpdatesBackground.ReportProgress(progress);
        }

        public void UpdateWindowsUpdateLabel(string label)
        {
            lblUpdateStatus.Text = label;
        }

        private void checkForUpdatesBackground_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            updates = updateTool.GetUpdates();
        }

        private void checkForUpdatesBackground_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            updatesProgressBar.Value = e.ProgressPercentage;
        }

        private void checkForUpdatesBackground_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            dgWindowsUpdate.DataSource = updates;
            dgWindowsUpdate.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            updatesProgressBar.Value = 100;
            updatesProgressBar.Visible = false;
        }

        public void UpdateInstallUpdatesProgress(int progress)
        {
            installUpdatesBackground.ReportProgress(progress);
        }

        private void installUpdatesBackground_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            updateTool.InstallAllUpdates();
            
        }

        private void installUpdatesBackground_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            updatesProgressBar.Value = e.ProgressPercentage;
            lblUpdateStatus.Text = "Installing Updates...";
        }

        private void installUpdatesBackground_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            lblUpdateStatus.Text = "Updates installed successfully. Reboot your computer as soon as possible.";
            updatesProgressBar.Value = 100;
            updatesProgressBar.Visible = false;
        }

        private void btnSelectAllUpdates_Click(object sender, EventArgs e)
        {
            if (dgWindowsUpdate.Rows.Count == 0)
                return;

            dgWindowsUpdate.SelectAll();
        }

        private void btnInstallAllUpdates_Click(object sender, EventArgs e)
        {
            if (!installUpdatesBackground.IsBusy)
            {
                updatesProgressBar.Visible = true;
                updatesProgressBar.Value = 0;
                installUpdatesBackground.RunWorkerAsync();
            }
        }
        #endregion
    }
}