using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnboardingHelper_NetCore.EnumHelper;

namespace OnboardingHelper_NetCore
{
    public class CEventArgs
    {
        public class ApplicationAddedEventArgs : EventArgs
        {
            public wrappers.Application AddedApplication { get; private set; }

            public ApplicationAddedEventArgs(wrappers.Application addedApplication)
            {
                AddedApplication = addedApplication;
            }
        }

        public class AccountAddedEventArgs : EventArgs
        {
            public wrappers.Account AddedAccount { get; private set; }

            public AccountAddedEventArgs(wrappers.Account addedAccount)
            {
                AddedAccount = addedAccount;
            }
        }

        public class WiFiAddedEventArgs : EventArgs
        {
            public wrappers.WiFi WiFi { get; private set; }

            public WiFiAddedEventArgs(wrappers.WiFi addedWifi)
            {
                WiFi = addedWifi;
            }
        }

        public class VPNAddedEventArgs : EventArgs
        {
            public wrappers.VPN VPN { get; private set; }

            public VPNAddedEventArgs(wrappers.VPN addedVPN)
            {
                VPN = addedVPN;
            }
        }

        public class RDPAudioEventArgs : EventArgs
        {
            public RDPAudioPlayback playbackOption { get; private set; }
            public RDPAudioRecording recordingOption { get; private set; }

            public RDPAudioEventArgs(RDPAudioPlayback playback, RDPAudioRecording recording)
            {
                playbackOption = playback;
                recordingOption = recording;
            }
        }

        public class ConfigSavedEventArgs : EventArgs
        {
            public string ConfigPath { get; private set; }

            public ConfigSavedEventArgs(string path)
            {
                ConfigPath = path;
            }
        }
    }
}
