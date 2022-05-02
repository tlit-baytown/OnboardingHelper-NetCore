using Zest_Script.wrappers;

namespace Zest_Script
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Class to hold custom <see cref="EventArgs"/> for <see cref="EventHandler"/>s.
    /// </summary>
    public sealed class CEventArgs
    {
        public sealed class ApplicationAddedEventArgs : EventArgs
        {
            public wrappers.Application AddedApplication { get; private set; }

            public ApplicationAddedEventArgs(wrappers.Application addedApplication)
            {
                AddedApplication = addedApplication;
            }
        }

        public sealed class AccountAddedEventArgs : EventArgs
        {
            public Account AddedAccount { get; private set; }

            public AccountAddedEventArgs(wrappers.Account addedAccount)
            {
                AddedAccount = addedAccount;
            }
        }

        public sealed class WiFiAddedEventArgs : EventArgs
        {
            public WiFi WiFi { get; private set; }

            public WiFiAddedEventArgs(wrappers.WiFi addedWifi)
            {
                WiFi = addedWifi;
            }
        }

        public sealed class VPNAddedEventArgs : EventArgs
        {
            public VPN VPN { get; private set; }

            public VPNAddedEventArgs(wrappers.VPN addedVPN)
            {
                VPN = addedVPN;
            }
        }

        public sealed class ConfigSavedEventArgs : EventArgs
        {
            public string ConfigPath { get; private set; }

            public ConfigSavedEventArgs(string path)
            {
                ConfigPath = path;
            }
        }

        public sealed class MappedDriveAdddedEventArgs : EventArgs
        {
            public MappedDrive Drive { get; private set; }

            public MappedDriveAdddedEventArgs(MappedDrive d)
            {
                Drive = d;
            }
        }

        public sealed class PrinterAddedEventArgs : EventArgs
        {
            public Printer Printer { get; private set; }

            public PrinterAddedEventArgs(Printer printer)
            {
                Printer = printer;
            }
        }

        public sealed class OnboardDoneEventArgs : EventArgs
        {
            public string Message { get; private set; }
            public bool IsSuccessful { get; private set; }

            public OnboardDoneEventArgs(string message, bool success)
            {
                Message = message;
                IsSuccessful = success;
            }
        }
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member