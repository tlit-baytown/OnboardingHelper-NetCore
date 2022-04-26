using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OnboardingHelper_NetCore.EnumHelper;

namespace OnboardingHelper_NetCore.forms
{
    public partial class AddRemoteDesktopPopUp : Form
    {
        private readonly string[] DISPLAY_SIZES = new string[]
        {
            "640 by 480 pixels",
            "800 by 600 pixels",
            "1024 by 768 pixels",
            "1280 by 720 pixels",
            "1280 by 768 pixels",
            "1280 by 800 pixels",
            "1280 by 1024 pixels",
            "1366 by 768 pixels",
            "1440 by 900 pixels",
            "1400 by 1050 pixels",
            "1680 by 1050 pixels",
            "1920 by 1080 pixels",
            "Full Screen",
        };

        private RDPAudioPlayback remotePlayback = RDPAudioPlayback.PLAY_ON_THIS_COMPUTER;
        private RDPAudioRecording remoteRecording = RDPAudioRecording.DO_NOT_RECORD;

        public AddRemoteDesktopPopUp()
        {
            InitializeComponent();
        }

        int lastVal = 0;
        private void tbDisplaySize_Scroll(object sender, EventArgs e)
        {
            lblDisplaySize.Text = DISPLAY_SIZES[tbDisplaySize.Value];
            lastVal = tbDisplaySize.Value;
        }

        private void chkUseAllMonitors_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseAllMonitors.Checked)
            {
                tbDisplaySize.Value = tbDisplaySize.Maximum;
                lblDisplaySize.Text = DISPLAY_SIZES[tbDisplaySize.Value];
                tbDisplaySize.Enabled = false;
            }
            else
            {
                tbDisplaySize.Value = lastVal;
                lblDisplaySize.Text = DISPLAY_SIZES[lastVal];
                tbDisplaySize.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddRemoteDesktopPopUp_Load(object sender, EventArgs e)
        {
            cmbColorMode.SelectedIndex = cmbColorMode.Items.Count - 1;
            cmbKeyboardCombos.SelectedIndex = cmbKeyboardCombos.Items.Count - 1;
        }

        private void btnAudioSettings_Click(object sender, EventArgs e)
        {
            RDPAudioSettings rdpAudioForm = new RDPAudioSettings();
            rdpAudioForm.SetOptions(remotePlayback, remoteRecording);

            rdpAudioForm.RDPAudioChanged += UpdateAudioSetting;

            rdpAudioForm.ShowDialog();
        }

        private void UpdateAudioSetting(object o, EventArgs e)
        {
            if (e is CEventArgs.RDPAudioEventArgs args)
            {
                remotePlayback = args.playbackOption;
                remoteRecording = args.recordingOption;
            }
        }
    }
}
