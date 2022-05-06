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
            if (!bgOnboardWorker.IsBusy)
                bgOnboardWorker.RunWorkerAsync();
        }

        private void ConfigureBasicInfo()
        {
            BasicInfo info = Configuration.Instance.BasicInfo;
            currentTask.ShortMessage = "Setting computer name...";
            currentTask.DescriptionMessage = inDevEnv ? "[WhatIf] only! Running in development..." : PSHelper.Basic.SetComputerName(info.ComputerName);
            tasks.Add(currentTask);
            bgOnboardWorker.ReportProgress(5);

            //Join domain if present
            if (!info.Domain.Equals(string.Empty))
            {
                currentTask.ShortMessage = $"Joining the {info.Domain} domain...";
                currentTask.DescriptionMessage = PSHelper.Basic.JoinDomain(info.Domain, info.DomainUsername, info.DomainPassword, true);
                tasks.Add(currentTask);
                bgOnboardWorker.ReportProgress(10);
            }

        }

        private void bgOnboardWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ConfigureBasicInfo();
            
            //int counter = 0;
            //while (counter < 100)
            //{
            //    counter++;
            //    currentTask.ShortMessage = $"Counter: {counter}";
            //    currentTask.DescriptionMessage = $"Currently setting the counter variable to: {counter}";

            //    tasks.Add(currentTask);

            //    bgOnboardWorker.ReportProgress(counter);
            //    Thread.Sleep(50);
            //}
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
