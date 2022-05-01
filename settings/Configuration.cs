using OnboardingHelper_NetCore.wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using static OnboardingHelper_NetCore.CEventArgs;
using static OnboardingHelper_NetCore.EnumHelper;

namespace OnboardingHelper_NetCore.settings
{

    /// <summary>
    /// This class represents an entire Configuration for a new computer. It is responsible for adding and removing configuration options and
    /// loading/saving a configuration file. Using the <see cref="Instance"/> property ensures that an up-to-date configuration
    /// is returned as this single instance is read and set throughout the application.
    /// </summary>
    [XmlType("configuration")]
    public sealed class Configuration
    {
        /// <summary>
        /// Occurs when a configuration file is loaded successfully.
        /// </summary>
        public static EventHandler? ConfigLoaded;
        /// <summary>
        /// Occurs when a configuration file is saved successfully.
        /// </summary>
        public static EventHandler? ConfigSaved;
        /// <summary>
        /// Occurs when the active configuration is reset to defaults.
        /// </summary>
        public static EventHandler? ConfigReset;
        /// <summary>
        /// Occurs when an error occurs while saving the configuration.
        /// </summary>
        public static EventHandler? ConfigSaveError;
        /// <summary>
        /// Occurs when an error occurs while loading the configuration.
        /// </summary>
        public static EventHandler? ConfigLoadError;

        private static Configuration? instance = null;
        private static object instanceLock = new object();

        [XmlIgnore()]
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
        [XmlElement("computer-name")]
        public string ComputerName { get; set; } = string.Empty;

        [XmlElement("domain")]
        public string Domain { get; set; } = string.Empty;

        [XmlIgnore()]
        public TimeZoneInfo TimeZone { get; set; } = TimeZoneInfo.Local;

        [XmlElement("timezone")]
        public string TimeZoneString { get; set; } = string.Empty;

        [XmlElement("primary-ntp-server")]
        public string PrimaryNTPServer { get; set; } = string.Empty;

        [XmlElement("should-perform-time-sync", typeof(bool))]
        public bool PerformTimeSync { get; set; } = true;

        [XmlElement("domain-username")]
        public string DomainUsername { get; set; } = string.Empty;

        [XmlElement("domain-password")]
        public string Base64DomainPassword { get; set; } = string.Empty;

        [XmlIgnore()]
        public SecureString DomainPassword { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;
        #endregion

        #region Accounts
        [XmlElement("accounts")]
        public List<Account> Accounts { get { return accounts; } set { accounts = value; } }
        private List<Account> accounts = new List<Account>();
        #endregion

        #region Connections
        [XmlElement("wifi-profiles")]
        public List<WiFi> WiFiProfiles { get { return wifiProfiles; } set { wifiProfiles = value; } }
        private List<WiFi> wifiProfiles = new List<WiFi>();

        [XmlElement("vpn-profiles")]
        public List<VPN> VPNProfiles { get { return vpnProfiles; } set { vpnProfiles = value; } }
        private List<VPN> vpnProfiles = new List<VPN>();
        #endregion

        #region Programs
        [XmlElement("applications")]
        public List<wrappers.Application> Applications { get { return applications; } set { applications = value; } }
        private List<wrappers.Application> applications = new List<wrappers.Application>();
        #endregion

        #region Remote Desktop
        [XmlElement("rdp-files")]
        public List<RDPFile> RDPFiles { get { return rdpFiles; } set { rdpFiles = value; } }
        private List<RDPFile> rdpFiles = new List<RDPFile>();
        #endregion

        #region Mapped Drive
        [XmlElement("mapped-drives")]
        public List<MappedDrive> MappedDrives { get { return mappedDrives; } set { mappedDrives = value; } }
        private List<MappedDrive> mappedDrives = new List<MappedDrive>();
        #endregion

        /// <summary>
        /// Create a new blank configuration.
        /// </summary>
        public Configuration() {  }

        /// <summary>
        /// Reset the current configuration to defaults (blank config).
        /// </summary>
        /// <param name="fireEvent">Whether to fire the <see cref="ConfigReset"/> event.</param>
        public void ResetConfig(bool fireEvent = false)
        {
            instance = new Configuration();
            ConfigReset?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Load a config <c>XML</c> file from the specified <paramref name="path"/> into the current
        /// configuration <see cref="Instance"/>.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>A <see cref="Configuration"/> object containing the configuration present in the XML file.</returns>
        public static Configuration LoadConfig(string path)
        {
            try
            {
                XmlSerializer serializer = new(typeof(Configuration));
                StreamReader reader = new StreamReader(path);
                instance = (Configuration)serializer.Deserialize(reader);
                reader.Close();
                ConfigLoaded?.Invoke(Instance, new EventArgs());
            } catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application",
                    $"An error occured loading a configuration file: {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                ConfigLoadError?.Invoke(Instance, new EventArgs());
            }
            return Instance;
        }

        /// <summary>
        /// Save the current configuration to an <c>XML</c> file.
        /// </summary>
        /// <param name="path"></param>
        /// <returns><c>True</c> if the file was saved successfully; <c>False</c> otherwise.</returns>
        public bool SaveConfig(string path)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(Configuration));
                using (var stream = new StringWriter())
                {
                    serializer.Serialize(stream, this);
                    File.WriteAllText(path, stream.ToString());
                }
                ConfigSaved?.Invoke(Instance, new ConfigSavedEventArgs(path));
            } catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application",
                    $"An error occured loading a configuration file: {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                ConfigSaveError?.Invoke(Instance, new EventArgs());
                return false;
            }
            
            return true;
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

        #region Mapped Drives
        public ErrorCodes AddMappedDrive(MappedDrive d)
        {
            if (mappedDrives.Any(f => f.DriveLetter == d.DriveLetter))
                return ErrorCodes.MAPPED_DRIVE_ALREADY_EXISTS;
            mappedDrives.Add(d);

            return ErrorCodes.NO_ERROR;
        }

        public ErrorCodes RemoveMappedDrive(MappedDrive d)
        {
            if (mappedDrives.Contains(d))
                mappedDrives.Remove(d);
            else
                return ErrorCodes.MAPPED_DRIVE_DOES_NOT_EXIST;

            return ErrorCodes.NO_ERROR;
        }

        public MappedDrive GetMappedDrive(DriveLetter letter)
        {
            return mappedDrives.FirstOrDefault(d => d.DriveLetter == letter);
        }
        #endregion
    }
}
