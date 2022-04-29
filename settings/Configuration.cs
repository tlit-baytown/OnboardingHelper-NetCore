using OnboardingHelper_NetCore.wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static OnboardingHelper_NetCore.EnumHelper;

namespace OnboardingHelper_NetCore.settings
{
    /// <summary>
    /// This class represents an entire Configuration for a new computer. It is responsible for adding and removing configuration options and
    /// loading/saving a configuration file. This class cannot be instantiated. It must be accessed through its <see cref="Instance"/> property.
    /// </summary>
    public sealed class Configuration
    {
        private static Configuration? instance = null;
        private static object instanceLock = new object();

        public static Configuration Instance
        {
            get
            {
                lock(instanceLock)
                {
                    if (instance == null)
                        instance = new Configuration();
                    return instance;
                }
            }
        }

        #region Basic Options
        public string ComputerName { get; set; } = string.Empty;
        public string Domain { get; set; } = string.Empty;
        public TimeZoneInfo TimeZone { get; set; } = TimeZoneInfo.Local;
        public string PrimaryNTPServer { get; set; } = string.Empty;
        public bool PerformTimeSync { get; set; } = true;
        public string DomainUsername { get; set; } = string.Empty;
        public string DomainPasswordString { private get; set; } = string.Empty;
        public SecureString DomainPassword { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;
        #endregion

        #region Accounts

        /// <summary>
        /// Get the collection of accounts to create. This collection is Read-Only and can only be modified using the
        /// methods in <see cref="Configuration"/>.
        /// </summary>
        public IReadOnlyCollection<Account> Accounts { get { return accounts; } }
        private List<Account> accounts = new List<Account>();
        #endregion

        #region Connections
        /// <summary>
        /// Get the collection of WiFi profiles to create. This collection is Read-Only and can only be modified using the
        /// methods in <see cref="Configuration"/>.
        /// </summary>
        public IReadOnlyCollection<WiFi> WiFiProfiles { get { return wifiProfiles; } }
        private List<WiFi> wifiProfiles = new List<WiFi>();

        public IReadOnlyCollection<VPN> VPNProfiles { get { return vpnProfiles; } }
        private List<VPN> vpnProfiles = new List<VPN>();
        #endregion

        #region Programs
        /// <summary>
        /// Get the collection of applications to install. This collection is Read-Only and can only be modified using the
        /// methods in <see cref="Configuration"/>.
        /// </summary>
        public IReadOnlyCollection<wrappers.Application> Applications { get { return applications; } }
        private List<wrappers.Application> applications = new List<wrappers.Application>();
        #endregion

        #region Remote Desktop
        public IReadOnlyCollection<RDPFile> RDPFiles { get { return rdpFiles; } }
        private List<RDPFile> rdpFiles = new List<RDPFile>();
        #endregion

        /// <summary>
        /// Create a new blank configuration.
        /// </summary>
        public Configuration()
        {

        }

        /// <summary>
        /// Load a configuration <c>XML</c> file from the specified <paramref name="path"/>.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>A <see cref="Configuration"/> object containing the configuration present in the XML file.</returns>
        public static Configuration LoadConfig(string path)
        {
            return new Configuration();
        }

        /// <summary>
        /// Save the current configuration to a <c>XML</c> file.
        /// </summary>
        /// <param name="path"></param>
        /// <returns><c>True</c> if the file was saved successfully; <c>False</c> otherwise.</returns>
        public bool SaveConfig(string path)
        {
            XmlTextWriter textWriter = new(path, Encoding.UTF8);
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("root");
            WriteBasicInfo(textWriter);
            WriteAccountInfo(textWriter);

            textWriter.WriteStartElement("Connections");
            WriteWiFiInfo(textWriter);
            WriteVPNInfo(textWriter);
            textWriter.WriteEndElement();

            WriteApplicationsInfo(textWriter);
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();

            return true;
        }

        private void WriteBasicInfo(XmlTextWriter w)
        {
            w.WriteComment("Basic Information");
            w.WriteStartElement("Properties");

            w.WriteStartElement("Computer-Name");
            w.WriteString(ComputerName);
            w.WriteEndElement();

            w.WriteStartElement("Domain-Info");

            w.WriteStartElement("Domain");
            w.WriteString(Domain);
            w.WriteEndElement();
            NetworkCredential domainCredentials = new(DomainUsername, DomainPasswordString);
            w.WriteStartElement("Domain-Username");
            w.WriteString(domainCredentials.UserName);
            w.WriteEndElement();

            w.WriteStartElement("Domain-Password");
            byte[] pwBytes = Encoding.ASCII.GetBytes(domainCredentials.Password);
            w.WriteBase64(pwBytes, 0, pwBytes.Length);
            w.WriteEndElement();

            w.WriteEndElement();

            w.WriteStartElement("Time-Zone");
            w.WriteString(TimeZone.ToSerializedString());
            w.WriteEndElement();

            w.WriteStartElement("Primary-NTP-Server");
            w.WriteString(PrimaryNTPServer);
            w.WriteEndElement();

            w.WriteStartElement("Perform-Time-Sync");
            w.WriteValue(PerformTimeSync);
            w.WriteEndElement();

            w.WriteEndElement();
        }

        private void WriteAccountInfo(XmlTextWriter w)
        {
            w.WriteComment("User accounts");
            w.WriteStartElement("AccountList");
            foreach (Account a in Accounts)
            {
                w.WriteStartElement("Account");
                w.WriteAttributeString("Username", a.Username);
                w.WriteStartElement("Password");
                byte[] pwBytes = Encoding.ASCII.GetBytes(a.ConvertPasswordToUnsecureString());
                w.WriteBase64(pwBytes, 0, pwBytes.Length);
                w.WriteEndElement();
                w.WriteStartElement("Comment");
                w.WriteString(a.Comment);
                w.WriteEndElement();
                w.WriteStartElement("Account-Type");
                w.WriteString(a.AccountType.ToString());
                w.WriteEndElement();
                w.WriteStartElement("Password-Expires");
                w.WriteValue(a.DoesPasswordExpire);
                w.WriteEndElement();
                w.WriteStartElement("Require-Password-Change");
                w.WriteValue(a.RequirePasswordChange);
                w.WriteEndElement();
                w.WriteEndElement();
            }
            w.WriteEndElement();
        }

        private void WriteWiFiInfo(XmlTextWriter w)
        {
            w.WriteComment("Wifi profiles");
            w.WriteStartElement("WifiList");
            foreach (WiFi wifi in WiFiProfiles)
            {
                w.WriteStartElement("Wifi");
                w.WriteAttributeString("SSID", wifi.SSID);
                w.WriteStartElement("WiFi-Type");
                w.WriteString(wifi.WiFiType.ToString());
                w.WriteEndElement();

                //check if profile is using enterprise security and write the attribute if it does.
                switch (wifi.WiFiType)
                {
                    case WiFiType.WPA2_ENTERPRISE:
                    case WiFiType.WPA3_ENTERPRISE:
                        w.WriteStartElement("Username");
                        w.WriteString(wifi.Username);
                        w.WriteEndElement();

                        w.WriteStartElement("Password");
                        byte[] pwBytes = Encoding.ASCII.GetBytes(wifi.ConvertKeyToUnsecureString(wifi.UserPassword));
                        w.WriteBase64(pwBytes, 0, pwBytes.Length);
                        w.WriteEndElement();
                        break;
                    default:
                        w.WriteStartElement("PSK");
                        byte[] pskBytes = Encoding.ASCII.GetBytes(wifi.ConvertKeyToUnsecureString(wifi.PreSharedKey));
                        w.WriteBase64(pskBytes, 0, pskBytes.Length);
                        w.WriteEndElement();
                        break;
                }
                w.WriteStartElement("Is-Hidden");
                w.WriteValue(wifi.IsHiddenNetwork);
                w.WriteEndElement();

                w.WriteStartElement("Connection-Type");
                w.WriteString(wifi.ConnectionType.ToString());
                w.WriteEndElement();

                w.WriteStartElement("Encryption");
                w.WriteString(wifi.EncryptionSetting.ToString());
                w.WriteEndElement();

                w.WriteEndElement();
            }
            w.WriteEndElement();
        }

        private void WriteVPNInfo(XmlTextWriter w)
        {
            w.WriteComment("VPN profiles");
            w.WriteStartElement("VPNList");
            foreach (VPN v in VPNProfiles)
            {
                w.WriteStartElement("VPN");
                w.WriteAttributeString("Name", v.ConnectionName);
                w.WriteStartElement("Server");
                w.WriteString(v.ServerAddress);
                w.WriteEndElement();
                w.WriteStartElement("Tunnel-Type");
                w.WriteString(v.TunnelType.ToString());
                w.WriteEndElement();
                switch (v.TunnelType)
                {
                    case TunnelType.SSTP:
                    case TunnelType.PPTP:
                        w.WriteStartElement("Username");
                        w.WriteString(v.Username);
                        w.WriteEndElement();
                        w.WriteStartElement("Password");
                        byte[] pwBytes = Encoding.ASCII.GetBytes(v.ConvertKeyToUnsecureString(v.Password));
                        w.WriteBase64(pwBytes, 0, pwBytes.Length);
                        w.WriteEndElement();
                        break;
                    default:
                        w.WriteStartElement("PSK");
                        byte[] pskBytes = Encoding.ASCII.GetBytes(v.ConvertKeyToUnsecureString(v.PreSharedKey));
                        w.WriteBase64(pskBytes, 0, pskBytes.Length);
                        w.WriteEndElement();
                        break;
                }

                w.WriteStartElement("Encryption");
                w.WriteString(v.EncryptionLevel.ToString());
                w.WriteEndElement();

                w.WriteStartElement("Authentication");
                w.WriteString(v.AuthenticationMethod.ToString());
                w.WriteEndElement();
                if (v.IdleDisconnectSeconds != 0)
                {
                    w.WriteStartElement("Idle-Disconnec");
                    w.WriteValue(v.IdleDisconnectSeconds);
                    w.WriteEndElement();
                }
                w.WriteStartElement("Remember-Credentials");
                w.WriteValue(v.RememberCredentials);
                w.WriteEndElement();
                w.WriteStartElement("Split-Tunneling-Enabled");
                w.WriteValue(v.EnableSplitTunneling);
                w.WriteEndElement();
                w.WriteStartElement("Auto-Reconnect");
                w.WriteValue(v.AutoReconnect);
                w.WriteEndElement();

                w.WriteEndElement();
            }
            w.WriteEndElement();
        }

        private void WriteApplicationsInfo(XmlTextWriter w)
        {
            w.WriteComment("Applications to install");
            w.WriteStartElement("Applications");
            foreach (wrappers.Application app in Applications)
            {
                w.WriteStartElement("App");
                w.WriteAttributeString("Name", app.Name);
                w.WriteAttributeString("Description", app.Description);
                w.WriteStartElement("Path");
                w.WriteString(app.Path);
                w.WriteEndElement();
                w.WriteStartElement("Install-Command");
                w.WriteString(app.InstallArguments);
                w.WriteEndElement();
                w.WriteStartElement("IsWindowsInstaller");
                w.WriteValue(app.IsWindowsInstaller);
                w.WriteEndElement();
                w.WriteStartElement("IsISOImage");
                w.WriteValue(app.IsISOImage);
                w.WriteEndElement();
                w.WriteEndElement();
            }
            w.WriteEndElement();
        }

        #region Accounts
        public ErrorCodes AddAccount(Account a)
        {
            if (accounts.Any(acct => acct.Username.Equals(a.Username)))
                return ErrorCodes.ACCOUNT_ALREADY_EXISTS;
            accounts.Add(a);
            return ErrorCodes.NO_ERROR;
        }

        public ErrorCodes RemoveAccount(Account a)
        {
            if (accounts.Contains(a))
                accounts.Remove(a);
            else
                return ErrorCodes.ACCOUNT_DOES_NOT_EXIST;

            return ErrorCodes.NO_ERROR;
        }

        public Account? GetAccount(string username)
        {
            return accounts.FirstOrDefault(a => a.Username.Equals(username));
        }
        #endregion

        #region Connections
        public ErrorCodes AddWiFi(WiFi w)
        {
            if (wifiProfiles.Any(wifi => wifi.SSID.Equals(w.SSID)))
                return ErrorCodes.WIFI_ALREADY_EXISTS;
            wifiProfiles.Add(w);

            return ErrorCodes.NO_ERROR;
        }

        public ErrorCodes RemoveWiFi(WiFi w)
        {
            if (wifiProfiles.Contains(w))
                wifiProfiles.Remove(w);
            else
                return ErrorCodes.WIFI_DOES_NOT_EXIST;

            return ErrorCodes.NO_ERROR;
        }

        public WiFi? GetWiFi(string ssid)
        {
            return wifiProfiles.FirstOrDefault(wifi => wifi.SSID.Equals(ssid));
        }

        public ErrorCodes AddVPN(VPN v)
        {
            if (vpnProfiles.Any(vpn => vpn.ConnectionName.Equals(v.ConnectionName)))
                return ErrorCodes.VPN_ALREADY_EXISTS;
            vpnProfiles.Add(v);

            return ErrorCodes.NO_ERROR;
        }

        public ErrorCodes RemoveVPN(VPN v)
        {
            if (vpnProfiles.Contains(v))
                vpnProfiles.Remove(v);
            else
                return ErrorCodes.VPN_DOES_NOT_EXIST;

            return ErrorCodes.NO_ERROR;
        }

        public VPN? GetVPN(string connectionName)
        {
            return vpnProfiles.FirstOrDefault(vpn => vpn.ConnectionName.Equals(connectionName));
        }
        #endregion

        #region Programs
        public ErrorCodes AddApplication(wrappers.Application a)
        {
            if (applications.Any(app => app.Name.Equals(a.Name)))
                return ErrorCodes.APPLICATION_ALREADY_EXISTS;

            applications.Add(a);
            return ErrorCodes.NO_ERROR;
        }

        public ErrorCodes RemoveApplication(wrappers.Application a)
        {
            if (applications.Contains(a))
                applications.Remove(a);
            else
                return ErrorCodes.APPLICATION_DOES_NOT_EXIST;

            return ErrorCodes.NO_ERROR;
        }

        public wrappers.Application GetApplication(string name)
        {
            return applications.FirstOrDefault(a => a.Name.Equals(name));
        }
        #endregion

        #region RDP Files
        public ErrorCodes AddRDPFile(RDPFile file)
        {
            if (rdpFiles.Any(f => f.ComputerName.Equals(file.ComputerName)))
                return ErrorCodes.RDP_ALREADY_EXISTS;
            rdpFiles.Add(file);

            return ErrorCodes.NO_ERROR;
        }

        public ErrorCodes RemoveRDPFile(RDPFile file)
        {
            if (rdpFiles.Contains(file))
                rdpFiles.Remove(file);
            else
                return ErrorCodes.RDP_DOES_NOT_EXIST;

            return ErrorCodes.NO_ERROR;
        }

        public RDPFile GetRDPFile(string computerName)
        {
            return rdpFiles.FirstOrDefault(a => a.ComputerName.Equals(computerName));
        }
        #endregion
    }
}
