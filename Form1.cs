using OnboardingHelper_NetCore.wrappers;

namespace OnboardingHelper_NetCore
{
    public partial class MainForm : Form
    {
        private List<UpdateWrapper> updates = new List<UpdateWrapper>();
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

        private void btnCheckForUpdates_Click(object sender, EventArgs e)
        {
            if (!checkForUpdatesBackground.IsBusy)
                checkForUpdatesBackground.RunWorkerAsync();
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
            dgWindowsUpdate.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void installUpdatesBackground_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void installUpdatesBackground_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }

        private void installUpdatesBackground_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

        }

        private void btnSelectAllUpdates_Click(object sender, EventArgs e)
        {
            if (dgWindowsUpdate.Rows.Count == 0)
                return;

            dgWindowsUpdate.SelectAll();
        }
    }
}