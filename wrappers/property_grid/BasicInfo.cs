using OnboardingHelper_NetCore.settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingHelper_NetCore.wrappers.property_grid
{
    public sealed class BasicInfo
    {
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The computer's name that will be set.")]
        [DisplayName("Computer Name")]
        public string ComputerName { get; } = Configuration.Instance.ComputerName;

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("If running a supported version of Windows, the domain to join.")]
        [DisplayName("Domain")]
        public string Domain { get; } = Configuration.Instance.Domain;


        [Browsable(true)]
        [ReadOnly(true)]
        [Description("If running a supported version of Windows, the username of an account with permission to join the domain.")]
        [DisplayName("Domain Username")]
        public string DomainUsername { get; } = Configuration.Instance.DomainUsername;

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("If running a supported version of Windows, the password of an account with permission to join the domain.")]
        [DisplayName("Domain Password")]
        public string DomainPassword { get; } = !Configuration.Instance.Base64DomainPassword.Equals(string.Empty)
            ? Utility.ConvertToUnsecureString(Configuration.Instance.DomainPassword) : string.Empty;

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The time zone that should be set for this computer.")]
        [DisplayName("Time Zone")]
        public string TimeZone { get; } = Configuration.Instance.TimeZone.DisplayName;

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The primary NTP server that should be set for this computer.")]
        [DisplayName("Primary NTP Server")]
        public string PrimaryNTPServer { get; } = Configuration.Instance.PrimaryNTPServer;

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates whether or not an initial time server sync is performed from the Primary NTP Server.")]
        [DisplayName("Perform initial time sync?")]
        public bool PerformTimeSync { get; } = Configuration.Instance.PerformTimeSync;
    }
}
