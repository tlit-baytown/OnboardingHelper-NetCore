using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingHelper_NetCore.wrappers
{
    public class VPN
    {
        /// <summary>
        /// The name of this VPN profile in Windows.
        /// </summary>
        public string ConnectionName { get; set; } = string.Empty;

        /// <summary>
        /// The server address for this VPN, including any port information.
        /// </summary>
        public string ServerAddress { get; set; } = string.Empty;

        /// <summary>
        /// If <see cref="TunnelType"/> is <see cref="TunnelType.SSTP"/> or <see cref="TunnelType.PPTP"/>,
        /// this is the Username for logging into the VPN. Otherwise, this value is empty.
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// If <see cref="TunnelType"/> is <see cref="TunnelType.SSTP"/> or <see cref="TunnelType.PPTP"/>,
        /// this is the Password for logging into the VPN. Otherwise, this value is empty.
        /// </summary>
        public SecureString Password { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;

        /// <summary>
        /// The type of VPN tunnel that should be created by this profile. Default: <see cref="TunnelType.SSTP"/>
        /// </summary>
        public TunnelType TunnelType { get; set; } = TunnelType.SSTP;

        /// <summary>
        /// Specifies the encryption level for the VPN connection. Default: <see cref="EncryptionLevel.REQUIRED"/>
        /// </summary>
        public EncryptionLevel EncryptionLevel { get; set; } = EncryptionLevel.REQUIRED;

        /// <summary>
        /// Specifies the authentical method to use for the VPN connection. Default: <see cref="AuthenticationMethod.MSCHAPv2"/>
        /// </summary>
        public AuthenticationMethod AuthenticationMethod { get; set; } = AuthenticationMethod.MSCHAPv2;

        /// <summary>
        /// If <see cref="TunnelType"/> is <see cref="TunnelType.IKEv2"/> or <see cref="TunnelType.L2TP_IPSEC_WITH_PSK"/>,
        /// this is the pre-shared key for connecting to the VPN. Otherwise, this value is empty.
        /// </summary>
        public SecureString PreSharedKey { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;

        /// <summary>
        /// Specifies the time, in seconds, before an idle connection is closed. If this value is <c>0</c>,
        /// this property is not used to build the VPN profile. Default: <c>0</c>
        /// </summary>
        public int IdleDisconnectSeconds { get; set; } = 0;

        /// <summary>
        /// Indicates whether this VPN connection should remember user's credentials. Default: <c>true</c>
        /// </summary>
        public bool RememberCredentials { get; set; } = true;

        /// <summary>
        /// Indicates whether split tunneling should be enabled for this VPN connection. Default: <c>false</c>
        /// </summary>
        public bool EnableSplitTunneling { get; set; } = false;

        /// <summary>
        /// Indicates whether this VPN connection will auto-connect on user log in and stay connected
        /// until the user disconnects manually. Default: <c>false</c>
        /// </summary>
        public bool AutoReconnect { get; set; } = false;

        public VPN() { }

        public VPN(string connectionName, string serverAddress, string username, SecureString password, TunnelType tunnelType, SecureString preSharedKey, int idleDisconnectSeconds, bool rememberCredentials, bool enableSplitTunneling, bool autoReconnect)
        {
            ConnectionName = connectionName;
            ServerAddress = serverAddress;
            Username = username;
            Password = password;
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
            TunnelType = tunnelType;
            PreSharedKey = preSharedKey;
        }

        public VPN(string connectionName, string serverAddress, TunnelType tunnelType, SecureString preSharedKey) : this(connectionName, serverAddress)
        {
            TunnelType = tunnelType;
            PreSharedKey = preSharedKey;
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
            TunnelType = tunnelType;
            EncryptionLevel = encryptionLevel;
            AuthenticationMethod = authenticationMethod;
            PreSharedKey = preSharedKey;
            IdleDisconnectSeconds = idleDisconnectSeconds;
            RememberCredentials = rememberCredentials;
            EnableSplitTunneling = enableSplitTunneling;
            AutoReconnect = autoReconnect;
        }

        public VPN(string serverAddress, string username, SecureString password, TunnelType tunnelType, EncryptionLevel encryptionLevel, AuthenticationMethod authenticationMethod) : this(serverAddress, username)
        {
            Password = password;
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
