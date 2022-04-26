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
    public partial class RDPAudioSettings : Form
    {
        public EventHandler? RDPAudioChanged;

        private RDPAudioPlayback playback = RDPAudioPlayback.PLAY_ON_THIS_COMPUTER;
        private RDPAudioRecording recording = RDPAudioRecording.DO_NOT_RECORD;

        public RDPAudioSettings()
        {
            InitializeComponent();
        }

        public void SetOptions(RDPAudioPlayback playback, RDPAudioRecording recording)
        {
            this.playback = playback;
            this.recording = recording;

            switch (playback)
            {
                case RDPAudioPlayback.PLAY_ON_THIS_COMPUTER:
                    radPlayOnThisComputer.Checked = true;
                    break;
                case RDPAudioPlayback.DO_NOT_PLAY:
                    radDoNotPlay.Checked = true;
                    break;
                case RDPAudioPlayback.PLAY_ON_REMOTE_COMPUTER:
                    radPlayOnRemoteComputer.Checked = true;
                    radRecordFromComputer.Enabled = false;
                    radDoNotRecord.Enabled = false;
                    break;
            }

            switch (recording)
            {
                case RDPAudioRecording.RECORD_FROM_THIS_COMPUTER:
                    radRecordFromComputer.Checked = true;
                    break;
                case RDPAudioRecording.DO_NOT_RECORD:
                    radDoNotRecord.Checked = true;
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            RDPAudioChanged?.Invoke(this, new CEventArgs.RDPAudioEventArgs(playback, recording));
            Close();
        }

        private void radPlayOnThisComputer_CheckedChanged(object sender, EventArgs e)
        {
            playback = RDPAudioPlayback.PLAY_ON_THIS_COMPUTER;
            radRecordFromComputer.Enabled = true;
            radDoNotRecord.Enabled = true;
        }

        private void radDoNotPlay_CheckedChanged(object sender, EventArgs e)
        {
            playback = RDPAudioPlayback.DO_NOT_PLAY;
            radRecordFromComputer.Enabled = true;
            radDoNotRecord.Enabled = true;
        }

        private void radPlayOnRemoteComputer_CheckedChanged(object sender, EventArgs e)
        {
            playback = RDPAudioPlayback.PLAY_ON_REMOTE_COMPUTER;
            radRecordFromComputer.Enabled = false;
            radDoNotRecord.Enabled = false;
        }

        private void radRecordFromComputer_CheckedChanged(object sender, EventArgs e)
        {
            recording = RDPAudioRecording.RECORD_FROM_THIS_COMPUTER;
        }

        private void radDoNotRecord_CheckedChanged(object sender, EventArgs e)
        {
            recording = RDPAudioRecording.DO_NOT_RECORD;
        }
    }
}
