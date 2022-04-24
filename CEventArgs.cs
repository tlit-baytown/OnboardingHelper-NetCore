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
    }
}
