using OnboardingHelper_NetCore.settings;
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
    public partial class OnboardForm : Form
    {
        public EventHandler OnboardingDone;

        private CTask currentTask = new CTask();

        public OnboardForm()
        {
            InitializeComponent();
        }

        private void OnboardForm_Load(object sender, EventArgs e)
        {
            if (!bgOnboardWorker.IsBusy)
                bgOnboardWorker.RunWorkerAsync();
        }

        private void bgOnboardWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int counter = 0;
            while (counter < 100)
            {
                counter++;
                currentTask.ShortMessage = $"Counter: {counter}";
                currentTask.DescriptionMessage = $"Currently setting the counter variable to: {counter}";

                bgOnboardWorker.ReportProgress(counter);
                Thread.Sleep(50);
            }
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
