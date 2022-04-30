using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OnboardingHelper_NetCore.wrappers
{
    [XmlType("vpn")]
    public class VPN
    {
        [XmlAttribute("connection-name")]
        /// <summary>
        /// The name of this VPN profile in Windows.
        /// </summary>
        public string ConnectionName { get; set; } = string.Empty;

        [XmlElement("server-address")]
        /// <summary>
        /// The server address for this VPN, including any port information.
        /// </summary>
        public string ServerAddress { get; set; } = string.Empty;

        [XmlElement("username")]
        /// <summary>
        /// If <see cref="TunnelType"/> is <see cref="TunnelType.SSTP"/> or <see cref="TunnelType.PPTP"/>,
        /// this is the Username for logging into the VPN. Otherwise, this value is empty.
        /// </summary>
        public string Username { get; set; } = string.Empty;

        [XmlIgnore()]
        /// <summary>
        /// If <see cref="TunnelType"/> is <see cref="TunnelType.SSTP"/> or <see cref="TunnelType.PPTP"/>,
        /// this is the Password for logging into the VPN. Otherwise, this value is empty.
        /// </summary>
        public SecureString Password { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;

        [XmlElement("password")]
        public string Base64Password { get; set; } = string.Empty;

        [XmlElement("tunnel-type")]
        /// <summary>
        /// The type of VPN tunnel that should be created by this profile. Default: <see cref="TunnelType.SSTP"/>
        /// </summary>
        public TunnelType TunnelType { get; set; } = TunnelType.SSTP;

        [XmlElement("encryption-level")]
        /// <summary>
        /// Specifies the encryption level for the VPN connection. Default: <see cref="EncryptionLevel.REQUIRED"/>
        /// </summary>
        public EncryptionLevel EncryptionLevel { get; set; } = EncryptionLevel.REQUIRED;

        [XmlElement("auth-method")]
        /// <summary>
        /// Specifies the authentical method to use for the VPN connection. Default: <see cref="AuthenticationMethod.MSCHAPv2"/>
        /// </summary>
        public AuthenticationMethod AuthenticationMethod { get; set; } = AuthenticationMethod.MSCHAPv2;

        [XmlIgnore()]
        /// <summary>
        /// If <see cref="TunnelType"/> is <see cref="TunnelType.IKEv2"/> or <see cref="TunnelType.L2TP_IPSEC_WITH_PSK"/>,
        /// this is the pre-shared key for connecting to the VPN. Otherwise, this value is empty.
        /// </summary>
        public SecureString PreSharedKey { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;

        [XmlElement("psk")]
        public string Base64PSK { get; set; } = string.Empty;

        [XmlElement("idle-disconnect-seconds")]
        /// <summary>
        /// Specifies the time, in seconds, before an idle connection is closed. If this value is <c>0</c>,
        /// this property is not used to build the VPN profile. Default: <c>0</c>
        /// </summary>
        public int IdleDisconnectSeconds { get; set; } = 0;

        [XmlElement("should-remember-credentials")]
        /// <summary>
        /// Indicates whether this VPN connection should remember user's credentials. Default: <c>true</c>
        /// </summary>
        public bool RememberCredentials { get; set; } = true;

        [XmlElement("enable-split-tunneling")]
        /// <summary>
        /// Indicates whether split tunneling should be enabled for this VPN connection. Default: <c>false</c>
        /// </summary>
        public bool EnableSplitTunneling { get; set; } = false;

        [XmlElement("auto-reconnect")]
        /// <summary>
        /// Indicates whether this VPN connection will auto-connect on user log in and stay connected
        /// until the user disconnects manually. Default: <c>false</c>
        /// </summary>
        public bool AutoReconnect { get; set; } = false;

        public VPN() { }

        /// <summary>
        /// Set the values for <see cref="Base64PSK"/> and <see cref="Base64Password"/> to the correct
        /// values depending on thier <see cref="SecureString"/> equivalents.
        /// </summary>
        public void SetBase64Passwords()
        {
            if (!PreSharedKey.Equals(string.Empty))
                Base64PSK = Convert.ToBase64String(Encoding.UTF8.GetBytes(ConvertKeyToUnsecureString(PreSharedKey)));
            if (!Password.Equals(string.Empty))
                Base64Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(ConvertKeyToUnsecureString(Password)));
        }

        public VPN(string connectionName, string serverAddress, string username, SecureString password, TunnelType tunnelType, SecureString preSharedKey, int idleDisconnectSeconds, bool rememberCredentials, bool enableSplitTunneling, bool autoReconnect)
        {
            ConnectionName = connectionName;
            ServerAddress = serverAddress;
            Username = username;
            Password = password;
            Base64Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(ConvertKeyToUnsecureString(password)));
            TunnelType = tunnelType;
            PreSharedKey = preSharedKey;
            IdleDisconnectSeconds = idleDisconnectSeconds;
            RememberCredentials = rememberCredentials;
            EnableSplitTunneling = enableSplitTunneling;
            AutoReconnect = autoReconnect;
        }

        public VPN(string connectionName, string serverAddress)
        {
            ConnectionName = connectionName;
            ServerAddress = serverAddress;
        }

        public VPN(string connectionName, string serverAddress, string username, SecureString password, TunnelType tunnelType, SecureString preSharedKey) : this(connectionName, serverAddress)
        {
            Username = username;
            Password = password;
            Base64Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(ConvertKeyToUnsecureString(password)));
            TunnelType = tunnelType;
            PreSharedKey = preSharedKey;
            Base64PSK = Convert.ToBase64String(Encoding.UTF8.GetBytes(ConvertKeyToUnsecureString(preSharedKey)));
        }

        public VPN(string connectionName, string serverAddress, TunnelType tunnelType, SecureString preSharedKey) : this(connectionName, serverAddress)
        {
            TunnelType = tunnelType;
            PreSharedKey = preSharedKey;
            Base64PSK = Convert.ToBase64String(Encoding.UTF8.GetBytes(ConvertKeyToUnsecureString(preSharedKey)));
        }

        public VPN(string connectionName, string serverAddress, TunnelType tunnelType, SecureString preSharedKey, int idleDisconnectSeconds, bool rememberCredentials, bool enableSplitTunneling, bool autoReconnect) : this(connectionName, serverAddress, tunnelType, preSharedKey)
        {
            IdleDisconnectSeconds = idleDisconnectSeconds;
            RememberCredentials = rememberCredentials;
            EnableSplitTunneling = enableSplitTunneling;
            AutoReconnect = autoReconnect;
        }

        public VPN(string connectionName, string serverAddress, string username, SecureString password, TunnelType tunnelType, EncryptionLevel encryptionLevel, AuthenticationMethod authenticationMethod, SecureString preSharedKey, int idleDisconnectSeconds, bool rememberCredentials, bool enableSplitTunneling, bool autoReconnect) : this(connectionName, serverAddress)
        {
            Username = username;
            Password = password;
            Base64Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(ConvertKeyToUnsecureString(password)));
            TunnelType = tunnelType;
            EncryptionLevel = encryptionLevel;
            AuthenticationMethod = authenticationMethod;
            PreSharedKey = preSharedKey;
            Base64PSK = Convert.ToBase64String(Encoding.UTF8.GetBytes(ConvertKeyToUnsecureString(preSharedKey)));
            IdleDisconnectSeconds = idleDisconnectSeconds;
            RememberCredentials = rememberCredentials;
            EnableSplitTunneling = enableSplitTunneling;
            AutoReconnect = autoReconnect;
        }

        public VPN(string serverAddress, string username, SecureString password, TunnelType tunnelType, EncryptionLevel encryptionLevel, AuthenticationMethod authenticationMethod) : this(serverAddress, username)
        {
            Password = password;
            Base64Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(ConvertKeyToUnsecureString(password)));
            TunnelType = tunnelType;
            EncryptionLevel = encryptionLevel;
            AuthenticationMethod = authenticationMethod;
        }

        /// <summary>
        /// Gets an unsecure version of the encrypted key string.
        /// </summary>
        /// <param name="psk"></param>
        /// <returns>A decrypted <see cref="string"/> version of the encrypted <see cref="SecureString"/> key.</returns>
        public string ConvertKeyToUnsecureString(SecureString psk)
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(psk);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }


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

    public enum EncryptionLevel
    {
        NO_ENCRYPTION = 0,
        OPTIONAL = 2,
        REQUIRED = 4,
        MAXIMUM = 8,
        CUSTOM = 16
    }

    public enum AuthenticationMethod
    {
        PAP = 0,
        CHAP = 2,
        MSCHAPv2 = 4,
        EAP = 8,
        MACHINE_CERTIFICATE = 16
    }
}
