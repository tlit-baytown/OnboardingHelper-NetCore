using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;

namespace OnboardingHelper_NetCore.wrappers
{
    public class WiFi
    {
        /// <summary>
        /// The SSID (network name) for the WiFi network.
        /// </summary>
        public string SSID { get; set; } = string.Empty;

        /// <summary>
        /// The password used to connect to the WiFi network. Only valid if <see cref="WiFiType"/> is set 
        /// to <see cref="WiFiType.WEP"/>, <see cref="WiFiType.WPA"/>, <see cref="WiFiType.WPA2PSK"/>, or <see cref="WiFiType.WPA3PSK"/>.
        /// </summary>
        public SecureString PreSharedKey { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;

        /// <summary>
        /// The user's username to log on to this WiFi network. Only valid if <see cref="WiFiType"/> is set 
        /// to <see cref="WiFiType.WPA2_ENTERPRISE"/> or <see cref="WiFiType.WPA3_ENTERPRISE"/>.
        /// </summary>
        public string Username { get; set; } = string.Empty;
        /// <summary>
        /// The user's password to log on to this WiFi network. Only valid if <see cref="WiFiType"/> is set 
        /// to <see cref="WiFiType.WPA2_ENTERPRISE"/> or <see cref="WiFiType.WPA3_ENTERPRISE"/>.
        /// </summary>
        public SecureString UserPassword { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;

        /// <summary>
        /// Indicates whether this network's SSID is hidden. Default: <c>false</c>
        /// </summary>
        public bool IsHiddenNetwork { get; set; } = false;

        /// <summary>
        /// The protocol the WiFi network uses to authenticate users. Default: <see cref="WiFiType.WPA2PSK"/>
        /// </summary>
        public WiFiType WiFiType { get; set; } = WiFiType.WPA2PSK;

        /// <summary>
        /// The type of connection that this WiFi network accepts. Default: <see cref="ConnectionType.ESS"/>
        /// </summary>
        public ConnectionType ConnectionType { get; set; } = ConnectionType.ESS;

        /// <summary>
        /// The encryption type used for this WiFi network. Default: <see cref="EncryptionSetting.AES"/>
        /// </summary>
        public EncryptionSetting EncryptionSetting { get; set; } = EncryptionSetting.AES;

        public WiFi() { }

        /// <summary>
        /// Create a new WiFi network with the specified options.
        /// </summary>
        /// <param name="ssid"></param>
        /// <param name="psk"></param>
        /// <param name="isHidden"></param>
        /// <param name="type"></param>
        /// <param name="connectionType"></param>
        /// <param name="encryption"></param>
        public WiFi(string ssid, string psk, bool isHidden, WiFiType type, ConnectionType connectionType, EncryptionSetting encryption)
            : this(ssid, new NetworkCredential("", psk).SecurePassword, isHidden, type, connectionType, encryption) { }

        public WiFi(string ssid, string username, string userpassword, bool isHidden, WiFiType type, ConnectionType connectionType, EncryptionSetting encryption)
        {
            SSID = ssid;
            Username = username;
            UserPassword = new NetworkCredential("", userpassword).SecurePassword;
            IsHiddenNetwork = isHidden;
            WiFiType = type;
            ConnectionType = connectionType;
            EncryptionSetting = encryption;

            PreSharedKey = new NetworkCredential("", string.Empty).SecurePassword;
        }

        public WiFi(string ssid, SecureString psk, bool isHidden, WiFiType type, ConnectionType connectionType, EncryptionSetting encryption)
        {
            SSID = ssid;
            PreSharedKey = psk;
            IsHiddenNetwork = isHidden;
            WiFiType = type;
            ConnectionType = connectionType;
            EncryptionSetting = encryption;
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

    public enum ConnectionType
    {
        [Description("Infrastructure Network (Default)")]
        ESS = 0,
        [Description("Ad-Hoc Network")]
        IBSS = 2
    }

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
}
