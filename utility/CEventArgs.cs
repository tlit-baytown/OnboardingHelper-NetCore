using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
