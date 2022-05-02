using System.ComponentModel;
using System.Net;
using System.Security;
using System.Text;
using System.Xml.Serialization;

namespace Zest_Script.wrappers
{
    /// <summary>
    /// Represents a Wi-Fi connection profile.
    /// </summary>
    [XmlType("wifi")]
    public class WiFi
    {
        /// <summary>
        /// The SSID (network name) for the WiFi network.
        /// </summary>
        [XmlAttribute("ssid")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The SSID (name) of the Wi-Fi network to connect to.")]
        [DisplayName("SSID")]
        [Category("Wi-Fi Information")]
        public string SSID { get; set; } = string.Empty;

        /// <summary>
        /// The password used to connect to the WiFi network. Only valid if <see cref="WiFiType"/> is set 
        /// to <see cref="WiFiType.WEP"/>, <see cref="WiFiType.WPA"/>, <see cref="WiFiType.WPA2PSK"/>, or <see cref="WiFiType.WPA3PSK"/>.
        /// </summary>
        [XmlIgnore()]
        [Browsable(false)]
        public SecureString PreSharedKey { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;

        /// <summary>
        /// The base64 representation of the <see cref="PreSharedKey"/> for displaying and saving, if applicable.
        /// </summary>
        [XmlElement("psk")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("If applicable, the pre-shared key (in base64) to use to connect to this Wi-Fi.")]
        [DisplayName("Pre-Shared Key")]
        [Category("Wi-Fi Information")]
        public string Base64PSK { get; set; } = string.Empty;

        /// <summary>
        /// The user's username to log on to this WiFi network. Only valid if <see cref="WiFiType"/> is set 
        /// to <see cref="WiFiType.WPA2_ENTERPRISE"/> or <see cref="WiFiType.WPA3_ENTERPRISE"/>.
        /// </summary>
        [XmlElement("username")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("If applicable (using Enterprise), the username to use to connect to this Wi-Fi.")]
        [DisplayName("Username")]
        [Category("Wi-Fi Information")]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// The user's password to log on to this WiFi network. Only valid if <see cref="WiFiType"/> is set 
        /// to <see cref="WiFiType.WPA2_ENTERPRISE"/> or <see cref="WiFiType.WPA3_ENTERPRISE"/>.
        /// </summary>
        [XmlIgnore()]
        [Browsable(false)]
        public SecureString UserPassword { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;

        /// <summary>
        /// The base64 representation of the <see cref="UserPassword"/> for display and saving, if applicable.
        /// </summary>
        [XmlElement("password")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("If applicable (using Enterprise), the password (in base64) to use to connect to this Wi-Fi.")]
        [DisplayName("Password")]
        [Category("Wi-Fi Information")]
        public string Base64UserPassword { get; set; } = string.Empty;

        /// <summary>
        /// Indicates whether this network's SSID is hidden. Default: <c>false</c>
        /// </summary>
        [XmlElement("is-hidden-network")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates whether this Wi-Fi network is a hidden SSID.")]
        [DisplayName("Hidden Network?")]
        [Category("Wi-Fi Information")]
        public bool IsHiddenNetwork { get; set; } = false;

        /// <summary>
        /// The protocol the WiFi network uses to authenticate users. Default: <see cref="WiFiType.WPA2PSK"/>
        /// </summary>
        [XmlElement("wifi-type")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates the protocol used by this Wi-Fi network to authenticate connections. Default is WPA2PSK.")]
        [DisplayName("Wi-Fi Type")]
        [Category("Wi-Fi Information")]
        public WiFiType WiFiType { get; set; } = WiFiType.WPA2PSK;

        /// <summary>
        /// The type of connection that this WiFi network accepts. Default: <see cref="ConnectionType.ESS"/>
        /// </summary>
        [XmlElement("connection-type")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates the type of connection that this Wi-Fi network accepts. Default is ESS.")]
        [DisplayName("Connection Type")]
        [Category("Wi-Fi Information")]
        public ConnectionType ConnectionType { get; set; } = ConnectionType.ESS;

        /// <summary>
        /// The encryption type used for this WiFi network. Default: <see cref="EncryptionSetting.AES"/>
        /// </summary>
        [XmlElement("encryption-setting")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates the encryption setting used by this Wi-Fi network. Default is AES.")]
        [DisplayName("Encryption Setting")]
        [Category("Wi-Fi Information")]
        public EncryptionSetting EncryptionSetting { get; set; } = EncryptionSetting.AES;

        /// <summary>
        /// Create a new empty Wi-Fi profile.
        /// </summary>
        public WiFi() { }

        /// <summary>
        /// Set the values for <see cref="Base64PSK"/> and <see cref="Base64UserPassword"/> to the correct
        /// values depending on thier <see cref="SecureString"/> equivalents.
        /// </summary>
        public void SetBase64Passwords()
        {
            if (PreSharedKey.Length != 0)
                Base64PSK = Convert.ToBase64String(Encoding.UTF8.GetBytes(Utility.ConvertToUnsecureString(PreSharedKey)));
            if (UserPassword.Length != 0)
                Base64UserPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(Utility.ConvertToUnsecureString(UserPassword)));
        }

        /// <summary>
        /// Set the values for <see cref="PreSharedKey"/> and <see cref="UserPassword"/> to the correct values
        /// depending on their base64 equivalents.
        /// </summary>
        public void SetPasswordFromBase64()
        {
            if (!Base64PSK.Equals(string.Empty))
                PreSharedKey = new NetworkCredential("",
                    Encoding.UTF8.GetString(Convert.FromBase64String(Base64PSK))).SecurePassword;

            if (!Base64UserPassword.Equals(string.Empty))
                UserPassword = new NetworkCredential("",
                    Encoding.UTF8.GetString(Convert.FromBase64String(Base64UserPassword))).SecurePassword;
        }

        /// <summary>
        /// Create a new Wi-Fi profile with the specified arguments.
        /// </summary>
        /// <param name="ssid"></param>
        /// <param name="psk"></param>
        /// <param name="isHidden"></param>
        /// <param name="type"></param>
        /// <param name="connectionType"></param>
        /// <param name="encryption"></param>
        public WiFi(string ssid, string psk, bool isHidden, WiFiType type, ConnectionType connectionType, EncryptionSetting encryption)
            : this(ssid, new NetworkCredential("", psk).SecurePassword, isHidden, type, connectionType, encryption) { }

        /// <summary>
        /// Create a new Wi-Fi profile with the specified arguments.
        /// </summary>
        /// <param name="ssid"></param>
        /// <param name="username"></param>
        /// <param name="userpassword"></param>
        /// <param name="isHidden"></param>
        /// <param name="type"></param>
        /// <param name="connectionType"></param>
        /// <param name="encryption"></param>
        public WiFi(string ssid, string username, string userpassword, bool isHidden, WiFiType type, ConnectionType connectionType, EncryptionSetting encryption)
        {
            SSID = ssid;
            Username = username;
            UserPassword = new NetworkCredential("", userpassword).SecurePassword;
            Base64UserPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(userpassword));
            IsHiddenNetwork = isHidden;
            WiFiType = type;
            ConnectionType = connectionType;
            EncryptionSetting = encryption;

            PreSharedKey = new NetworkCredential("", string.Empty).SecurePassword;
        }

        /// <summary>
        /// Create a new Wi-Fi profile with the specified arguments.
        /// </summary>
        /// <param name="ssid"></param>
        /// <param name="psk"></param>
        /// <param name="isHidden"></param>
        /// <param name="type"></param>
        /// <param name="connectionType"></param>
        /// <param name="encryption"></param>
        public WiFi(string ssid, SecureString psk, bool isHidden, WiFiType type, ConnectionType connectionType, EncryptionSetting encryption)
        {
            SSID = ssid;
            PreSharedKey = psk;
            Base64PSK = Convert.ToBase64String(Encoding.UTF8.GetBytes(Utility.ConvertToUnsecureString(psk)));
            IsHiddenNetwork = isHidden;
            WiFiType = type;
            ConnectionType = connectionType;
            EncryptionSetting = encryption;
        }
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Represents the valid protocol types for Wi-Fi networks.
    /// </summary>
    public enum WiFiType
    {
        [Description("Open Network - No Security")]
        OPEN = 0,
        [Description("Wired Equivalent Privacy")]
        WEP = 2,
        [Description("Wi-Fi Protected Access")]
        WPA = 4,
        [Description("Wi-Fi Protected Access 2 (Default) - PreShared Key")]
        WPA2PSK = 8,
        [Description("Wi-Fi Protected Access 2 - Enterprise")]
        WPA2_ENTERPRISE = 16,
        [Description("Wi-Fi Protected Access 3 - PreShared Key")]
        WPA3PSK = 32,
        [Description("Wi-Fi Protected Access 3 - Enterprise")]
        WPA3_ENTERPRISE = 64
    }

    /// <summary>
    /// Indicates the valid connection types for Wi-Fi networks.
    /// </summary>
    public enum ConnectionType
    {
        [Description("Infrastructure Network (Default)")]
        ESS = 0,
        [Description("Ad-Hoc Network")]
        IBSS = 2
    }

    /// <summary>
    /// Represents the valid encryption settings for Wi-Fi networks.
    /// </summary>
    public enum EncryptionSetting
    {
        [Description("No Encryption")]
        NONE = 0,
        [Description("Wired Equivalent Privacy")]
        WEP = 2,
        [Description("Temporal Key Integrity Protocol")]
        TKIP = 4,
        [Description("Advanced Encryption Standard (Default)")]
        AES = 8
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
