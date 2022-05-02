using OnboardingHelper_NetCore.wrappers;

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
            public Account AddedAccount { get; private set; }

            public AccountAddedEventArgs(wrappers.Account addedAccount)
            {
                AddedAccount = addedAccount;
            }
        }

        public class WiFiAddedEventArgs : EventArgs
        {
            public WiFi WiFi { get; private set; }

            public WiFiAddedEventArgs(wrappers.WiFi addedWifi)
            {
                WiFi = addedWifi;
            }
        }

        public class VPNAddedEventArgs : EventArgs
        {
            public VPN VPN { get; private set; }

            public VPNAddedEventArgs(wrappers.VPN addedVPN)
            {
                VPN = addedVPN;
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

        public class MappedDriveAdddedEventArgs : EventArgs
        {
            public MappedDrive Drive { get; private set; }

            public MappedDriveAdddedEventArgs(MappedDrive d)
            {
                Drive = d;
            }
        }

        public class PrinterAddedEventArgs : EventArgs
        {
            public Printer Printer { get; private set; }

            public PrinterAddedEventArgs(Printer printer)
            {
                Printer = printer;
            }
        }

        public class OnboardDoneEventArgs : EventArgs
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
