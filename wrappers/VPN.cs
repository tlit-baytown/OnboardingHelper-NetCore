using System.ComponentModel;
using System.Net;
using System.Security;
using System.Text;
using System.Xml.Serialization;

namespace Zest_Script.wrappers
{
    /// <summary>
    /// Represents a VPN connection profile.
    /// </summary>
    [XmlType("vpn")]
    public class VPN
    {
        /// <summary>
        /// The name of this VPN profile in Windows.
        /// </summary>
        [XmlAttribute("connection-name")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The name of this connection as it appears in the VPN list in settings.")]
        [DisplayName("Connection Name")]
        [Category("VPN Information")]
        public string ConnectionName { get; set; } = string.Empty;

        /// <summary>
        /// The server address for this VPN, including any port information.
        /// </summary>
        [XmlElement("server-address")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The FQDN or IP address of the VPN server to connect to.")]
        [DisplayName("Server Address")]
        [Category("VPN Information")]
        public string ServerAddress { get; set; } = string.Empty;

        /// <summary>
        /// If <see cref="TunnelType"/> is <see cref="TunnelType.SSTP"/> or <see cref="TunnelType.PPTP"/>,
        /// this is the Username for logging into the VPN. Otherwise, this value is empty.
        /// </summary>
        [XmlElement("username")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("If applicable, the username to use to connect to this VPN.")]
        [DisplayName("Username")]
        [Category("VPN Information")]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// If <see cref="TunnelType"/> is <see cref="TunnelType.SSTP"/> or <see cref="TunnelType.PPTP"/>,
        /// this is the Password for logging into the VPN. Otherwise, this value is empty.
        /// </summary>
        [XmlIgnore()]
        [Browsable(false)]
        public SecureString Password { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;

        /// <summary>
        /// The base64 representation of the <see cref="Password"/> for display and saving, if applicable.
        /// </summary>
        [XmlElement("password")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("If applicable, the password (in base64) to use to connect to this VPN.")]
        [DisplayName("Password")]
        [Category("VPN Information")]
        public string Base64Password { get; set; } = string.Empty;

        /// <summary>
        /// The type of VPN tunnel that should be created by this profile. Default: <see cref="TunnelType.SSTP"/>
        /// </summary>
        [XmlElement("tunnel-type")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The type of VPN tunnel to use for this connection. Defaults to SSTP.")]
        [DisplayName("Tunnel Type")]
        [Category("VPN Information")]
        public TunnelType TunnelType { get; set; } = TunnelType.SSTP;

        /// <summary>
        /// Specifies the encryption level for the VPN connection. Default: <see cref="EncryptionLevel.REQUIRED"/>
        /// </summary>
        [XmlElement("encryption-level")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The encryption level used for this VPN connection. Defaults to REQUIRED.")]
        [DisplayName("Encryption Level")]
        [Category("VPN Information")]
        public EncryptionLevel EncryptionLevel { get; set; } = EncryptionLevel.REQUIRED;

        /// <summary>
        /// Specifies the authentication method to use for the VPN connection. Default: <see cref="AuthenticationMethod.MSCHAPv2"/>
        /// </summary>
        [XmlElement("auth-method")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The authentication method used to authenticate connectons to this VPN. Defaults to MSCHAPv2.")]
        [DisplayName("Authentication Method")]
        [Category("VPN Information")]
        public AuthenticationMethod AuthenticationMethod { get; set; } = AuthenticationMethod.MSCHAPv2;

        /// <summary>
        /// If <see cref="TunnelType"/> is <see cref="TunnelType.IKEv2"/> or <see cref="TunnelType.L2TP_IPSEC_WITH_PSK"/>,
        /// this is the pre-shared key for connecting to the VPN. Otherwise, this value is empty.
        /// </summary>
        [XmlIgnore()]
        [Browsable(false)]
        public SecureString PreSharedKey { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;

        /// <summary>
        /// The base64 representation of the <see cref="PreSharedKey"/> for display and saving, if applicable.
        /// </summary>
        [XmlElement("psk")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("If applicable, the pre-shared key (in base64) to use to connect to this VPN.")]
        [DisplayName("Pre-Shared Key")]
        [Category("VPN Information")]
        public string Base64PSK { get; set; } = string.Empty;

        /// <summary>
        /// Specifies the time, in seconds, before an idle connection is closed. If this value is <c>0</c>,
        /// this property is not used to build the VPN profile. Default: <c>0</c>
        /// </summary>
        [XmlElement("idle-disconnect-seconds")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates the time, in seconds, before an idle connection is closed. Default is 0 (not applicable).")]
        [DisplayName("Idle Disconnect")]
        [Category("VPN Information")]
        public int IdleDisconnectSeconds { get; set; } = 0;

        /// <summary>
        /// Indicates whether this VPN connection should remember user's credentials. Default: <c>true</c>
        /// </summary>
        [XmlElement("should-remember-credentials")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates whether user's credentials are remembered for this VPN connection. Default is True.")]
        [DisplayName("Remember Credentials?")]
        [Category("VPN Information")]
        public bool RememberCredentials { get; set; } = true;

        /// <summary>
        /// Indicates whether split tunneling should be enabled for this VPN connection. Default: <c>false</c>
        /// </summary>
        [XmlElement("enable-split-tunneling")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates whether split-tunneling should be enabled for this VPN connection. Default is False.")]
        [DisplayName("Enable Split-Tunneling?")]
        [Category("VPN Information")]
        public bool EnableSplitTunneling { get; set; } = false;

        /// <summary>
        /// Indicates whether this VPN connection will auto-connect on user log in and stay connected
        /// until the user disconnects manually. Default: <c>false</c>
        /// </summary>
        [XmlElement("auto-reconnect")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates whether this VPN connection should auto-connect on user log-in " +
            "and stay connected until the user disconnects manually. Default is False.")]
        [DisplayName("Auto-Reconnect?")]
        [Category("VPN Information")]
        public bool AutoReconnect { get; set; } = false;

        /// <summary>
        /// Create an empty VPN profile.
        /// </summary>
        public VPN() { }

        /// <summary>
        /// Set the values for <see cref="Base64PSK"/> and <see cref="Base64Password"/> to the correct
        /// values depending on their <see cref="SecureString"/> equivalents.
        /// </summary>
        public void SetBase64Passwords()
        {
            if (PreSharedKey.Length != 0)
                Base64PSK = Convert.ToBase64String(Encoding.UTF8.GetBytes(Utility.ConvertToUnsecureString(PreSharedKey)));
            if (Password.Length != 0)
                Base64Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(Utility.ConvertToUnsecureString(Password)));
        }

        /// <summary>
        /// Set the values for <see cref="PreSharedKey"/> and <see cref="Password"/> to the correct values
        /// depending on their base64 equivalents.
        /// </summary>
        public void SetPasswords()
        {
            if (!Base64PSK.Equals(string.Empty))
                PreSharedKey = new NetworkCredential("",
                    Encoding.UTF8.GetString(Convert.FromBase64String(Base64PSK))).SecurePassword;

            if (!Base64Password.Equals(string.Empty))
                Password = new NetworkCredential("",
                    Encoding.UTF8.GetString(Convert.FromBase64String(Base64Password))).SecurePassword;
        }

        /// <summary>
        /// Create a new VPN profile with the specified arguments.
        /// </summary>
        /// <param name="connectionName"></param>
        /// <param name="serverAddress"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="tunnelType"></param>
        /// <param name="preSharedKey"></param>
        /// <param name="idleDisconnectSeconds"></param>
        /// <param name="rememberCredentials"></param>
        /// <param name="enableSplitTunneling"></param>
        /// <param name="autoReconnect"></param>
        public VPN(string connectionName, string serverAddress, string username, SecureString password, TunnelType tunnelType, SecureString preSharedKey, int idleDisconnectSeconds, bool rememberCredentials, bool enableSplitTunneling, bool autoReconnect)
        {
            ConnectionName = connectionName;
            ServerAddress = serverAddress;
            Username = username;
            Password = password;
            Base64Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(Utility.ConvertToUnsecureString(password)));
            TunnelType = tunnelType;
            PreSharedKey = preSharedKey;
            IdleDisconnectSeconds = idleDisconnectSeconds;
            RememberCredentials = rememberCredentials;
            EnableSplitTunneling = enableSplitTunneling;
            AutoReconnect = autoReconnect;
        }

        /// <summary>
        /// Create a new VPN profile with the specified arguments.
        /// </summary>
        /// <param name="connectionName"></param>
        /// <param name="serverAddress"></param>
        public VPN(string connectionName, string serverAddress)
        {
            ConnectionName = connectionName;
            ServerAddress = serverAddress;
        }

        /// <summary>
        /// Create a new VPN profile with the specified arguments.
        /// </summary>
        /// <param name="connectionName"></param>
        /// <param name="serverAddress"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="tunnelType"></param>
        /// <param name="preSharedKey"></param>
        public VPN(string connectionName, string serverAddress, string username, SecureString password, TunnelType tunnelType, SecureString preSharedKey) : this(connectionName, serverAddress)
        {
            Username = username;
            Password = password;
            Base64Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(Utility.ConvertToUnsecureString(password)));
            TunnelType = tunnelType;
            PreSharedKey = preSharedKey;
            Base64PSK = Convert.ToBase64String(Encoding.UTF8.GetBytes(Utility.ConvertToUnsecureString(preSharedKey)));
        }

        /// <summary>
        /// Create a new VPN profile with the specified arguments.
        /// </summary>
        /// <param name="connectionName"></param>
        /// <param name="serverAddress"></param>
        /// <param name="tunnelType"></param>
        /// <param name="preSharedKey"></param>
        public VPN(string connectionName, string serverAddress, TunnelType tunnelType, SecureString preSharedKey) : this(connectionName, serverAddress)
        {
            TunnelType = tunnelType;
            PreSharedKey = preSharedKey;
            Base64PSK = Convert.ToBase64String(Encoding.UTF8.GetBytes(Utility.ConvertToUnsecureString(preSharedKey)));
        }

        /// <summary>
        /// Create a new VPN profile with the specified arguments.
        /// </summary>
        /// <param name="connectionName"></param>
        /// <param name="serverAddress"></param>
        /// <param name="tunnelType"></param>
        /// <param name="preSharedKey"></param>
        /// <param name="idleDisconnectSeconds"></param>
        /// <param name="rememberCredentials"></param>
        /// <param name="enableSplitTunneling"></param>
        /// <param name="autoReconnect"></param>
        public VPN(string connectionName, string serverAddress, TunnelType tunnelType, SecureString preSharedKey, int idleDisconnectSeconds, bool rememberCredentials, bool enableSplitTunneling, bool autoReconnect) : this(connectionName, serverAddress, tunnelType, preSharedKey)
        {
            IdleDisconnectSeconds = idleDisconnectSeconds;
            RememberCredentials = rememberCredentials;
            EnableSplitTunneling = enableSplitTunneling;
            AutoReconnect = autoReconnect;
        }

        /// <summary>
        /// Create a new VPN profile with the specified arguments.
        /// </summary>
        /// <param name="connectionName"></param>
        /// <param name="serverAddress"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="tunnelType"></param>
        /// <param name="encryptionLevel"></param>
        /// <param name="authenticationMethod"></param>
        /// <param name="preSharedKey"></param>
        /// <param name="idleDisconnectSeconds"></param>
        /// <param name="rememberCredentials"></param>
        /// <param name="enableSplitTunneling"></param>
        /// <param name="autoReconnect"></param>
        public VPN(string connectionName, string serverAddress, string username, SecureString password, TunnelType tunnelType, EncryptionLevel encryptionLevel, AuthenticationMethod authenticationMethod, SecureString preSharedKey, int idleDisconnectSeconds, bool rememberCredentials, bool enableSplitTunneling, bool autoReconnect) : this(connectionName, serverAddress)
        {
            Username = username;
            Password = password;
            Base64Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(Utility.ConvertToUnsecureString(password)));
            TunnelType = tunnelType;
            EncryptionLevel = encryptionLevel;
            AuthenticationMethod = authenticationMethod;
            PreSharedKey = preSharedKey;
            Base64PSK = Convert.ToBase64String(Encoding.UTF8.GetBytes(Utility.ConvertToUnsecureString(preSharedKey)));
            IdleDisconnectSeconds = idleDisconnectSeconds;
            RememberCredentials = rememberCredentials;
            EnableSplitTunneling = enableSplitTunneling;
            AutoReconnect = autoReconnect;
        }

        /// <summary>
        /// Create a new VPN profile with the specified arguments.
        /// </summary>
        /// <param name="serverAddress"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="tunnelType"></param>
        /// <param name="encryptionLevel"></param>
        /// <param name="authenticationMethod"></param>
        public VPN(string serverAddress, string username, SecureString password, TunnelType tunnelType, EncryptionLevel encryptionLevel, AuthenticationMethod authenticationMethod) : this(serverAddress, username)
        {
            Password = password;
            Base64Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(Utility.ConvertToUnsecureString(password)));
            TunnelType = tunnelType;
            EncryptionLevel = encryptionLevel;
            AuthenticationMethod = authenticationMethod;
        }
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Represents the valid tunnel types for a VPN connection.
    /// </summary>
    public enum TunnelType
    {
        IKEv2 = 0,
        [Description("Secure Socket Tunneling Protocol (Default)")]
        SSTP = 2,
        [Description("L2TP/IPsec with certificate")]
        L2TP_IPSEC_WITH_CERTIFICATE = 4,
        [Description("L2TP/IPsec with pre-shared key")]
        L2TP_IPSEC_WITH_PSK = 8,
        [Description("Point to Point Tunneling Protocol")]
        PPTP = 16
    }

    /// <summary>
    /// Represents the valid encryption levels for a VPN connection.
    /// </summary>
    public enum EncryptionLevel
    {
        NO_ENCRYPTION = 0,
        OPTIONAL = 2,
        REQUIRED = 4,
        MAXIMUM = 8,
        CUSTOM = 16
    }

    /// <summary>
    /// Represents the valid authentication methods for a VPN connection.
    /// </summary>
    public enum AuthenticationMethod
    {

        PAP = 0,
        CHAP = 2,
        MSCHAPv2 = 4,
        EAP = 8,
        MACHINE_CERTIFICATE = 16
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
