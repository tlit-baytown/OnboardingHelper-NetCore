using System.ComponentModel;
using System.Net;
using System.Security;
using System.Text;
using System.Xml.Serialization;

namespace Zest_Script.wrappers.property_grid
{
    /// <summary>
    /// Represents the collection of basic information needed for a computer's configuration. This class cannot be inherited.
    /// </summary>
    [XmlType("basic-info")]
    public sealed class BasicInfo
    {
        /// <summary>
        /// The computer's name that will be set.
        /// </summary>
        [XmlElement("computer-name")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The computer's name that will be set.")]
        [DisplayName("Computer Name")]
        [Category("Basic Information")]
        public string ComputerName { get; set; } = string.Empty;

        /// <summary>
        /// If applicable, the domain to join this computer with.
        /// </summary>
        [XmlElement("domain")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("If running a supported version of Windows, the domain to join.")]
        [DisplayName("Domain")]
        [Category("Basic Information")]
        public string Domain { get; set; } = string.Empty;

        /// <summary>
        /// If applicable, the username of an authorized domain account with permission to join the domain.
        /// </summary>
        [XmlElement("domain-username")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("If running a supported version of Windows, the username of an account with permission to join the domain.")]
        [DisplayName("Domain Username")]
        [Category("Basic Information")]
        public string DomainUsername { get; set; } = string.Empty;

        /// <summary>
        /// If applicable, the password of an authorized domain account with permission to join the domain.
        /// </summary>
        [XmlIgnore()]
        [Browsable(false)]
        public SecureString DomainPassword { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;

        /// <summary>
        /// The base64 representation of the <see cref="DomainPassword"/> for displaying and saving.
        /// </summary>
        [XmlElement("domain-password")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("If running a supported version of Windows, the password of an account with permission to join the domain.")]
        [DisplayName("Domain Password")]
        [Category("Basic Information")]
        public string Base64DomainPassword { get; set; } = string.Empty;

        /// <summary>
        /// The time zone that will be set for this computer.
        /// </summary>
        [XmlIgnore()]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The time zone that should be set for this computer.")]
        [DisplayName("Time Zone")]
        [Category("Basic Information")]
        public TimeZoneInfo TimeZone { get; set; } = TimeZoneInfo.Local;

        /// <summary>
        /// The <see cref="TimeZone"/>'s serialized string; used for saving to config file.
        /// </summary>
        [XmlElement("time-zone")]
        [Browsable(false)]
        public string TimeZoneString { get; set; } = string.Empty;

        /// <summary>
        /// The primary NTP server used to sync this computer's time.
        /// </summary>
        [XmlElement("primary-ntp-server")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The primary NTP server that should be set for this computer.")]
        [DisplayName("Primary NTP Server")]
        [Category("Basic Information")]
        public string PrimaryNTPServer { get; set; } = string.Empty;

        /// <summary>
        /// Should an initial time server sync be done?
        /// </summary>
        [XmlElement("should-perform-time-sync")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates whether or not an initial time server sync is performed from the Primary NTP Server.")]
        [DisplayName("Perform initial time sync?")]
        [Category("Basic Information")]
        public bool PerformTimeSync { get; set; } = true;

        /// <summary>
        /// Create a new empty basic info object.
        /// </summary>
        public BasicInfo() { }

        /// <summary>
        /// Set the value for <see cref="DomainPassword"/> to the correct value depending on the base64 equivalent (<see cref="Base64DomainPassword"/>).
        /// </summary>
        public void SetPasswordFromBase64()
        {
            if (!Base64DomainPassword.Equals(string.Empty))
                DomainPassword = new NetworkCredential(DomainUsername,
                    Encoding.UTF8.GetString(Convert.FromBase64String(Base64DomainPassword))).SecurePassword;
        }

        /// <summary>
        /// Set the value for <see cref="Base64DomainPassword"/> to the correct value depending on the <see cref="DomainPassword"/> equivalent.
        /// </summary>
        public void SetBase64FromPassword()
        {
            if (DomainPassword.Length != 0)
                Base64DomainPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(
                    Utility.ConvertToUnsecureString(DomainPassword)));
        }
    }
}
