using System.ComponentModel;
using System.Diagnostics;
using Zest_Script.Powershell;
using Zest_Script.settings;
using Zest_Script.wrappers;

namespace Zest_Script.forms
{
    public partial class OnboardForm : Form
    {
        /// <summary>
        /// Occurs when on-boarding has completed.
        /// </summary>
        public EventHandler? OnboardingDone;

        /// <summary>
        /// Occurs when an error occurs while on-boarding.
        /// </summary>
        public EventHandler? OnboardingError;

        private List<CTask> tasks = new List<CTask>();
        private CTask currentTask = new CTask();

        private bool inDevEnv = false;

        public OnboardForm()
        {
            InitializeComponent();

            if (Debugger.IsAttached)
                inDevEnv = true;
        }

        private void OnboardForm_Load(object sender, EventArgs e)
        {
            if (!PSHelper.SetEnvironment())
            {
                MessageBox.Show(this, "The PowerShell environment could not be created! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!bgOnboardWorker.IsBusy)
                bgOnboardWorker.RunWorkerAsync();
        }

        private void bgOnboardWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            currentTask.ShortMessage = "Creating script...";
            currentTask.DescriptionMessage = $"Script writing to: {PSHelper.FullScriptPath}\nPlease wait...";
            tasks.Add(currentTask);
            bgOnboardWorker.ReportProgress(50);
            Thread.Sleep(500);

            PSHelper.CreateScript();

            currentTask.ShortMessage = "Script Created!";
            currentTask.DescriptionMessage = "PowerShell script has been created and can now be executed to on-board the computer.";
            tasks.Add(currentTask);

            bgOnboardWorker.ReportProgress(100);
        }

        private void bgOnboardWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgOnboardProgress.Value = e.ProgressPercentage;
            lblCurrentTask.Text = currentTask.ShortMessage;
            SetDetails();
        }

        private void bgOnboardWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            OnboardingDone?.Invoke(this, new CEventArgs.OnboardDoneEventArgs("Successful", true));
            pgOnboardProgress.Style = ProgressBarStyle.Continuous;
            pgOnboardProgress.Value = 100;

            btnCancel.Text = "Close";
        }

        private void SetDetails()
        {
            rtbDetails.AppendText(currentTask.DescriptionMessage);
            rtbDetails.AppendText("\n");
            rtbDetails.ScrollToCaret();
        }

        private void btnSeeLog_Click(object sender, EventArgs e)
        {
            if (panelDetails.Visible)
            {
                panelDetails.Visible = false;
                btnSeeLog.Text = "Show Details";
                Size = new Size(649, 100);
            }
            else
            {
                panelDetails.Visible = true;
                btnSeeLog.Text = "Hide Details";
                Size = new Size(649, 303);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
