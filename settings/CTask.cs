using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingHelper_NetCore.settings
{
    public sealed class CTask
    {
        public string ShortMessage { get; set; } = string.Empty;
        public string DescriptionMessage { get; set; } = string.Empty;

        public CTask() { }

        public CTask(string shortMessage, string descriptionMessage)
        {
            ShortMessage = shortMessage;
            DescriptionMessage = descriptionMessage;
        }
    }
}
