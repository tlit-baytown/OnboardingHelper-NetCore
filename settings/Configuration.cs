using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Zest_Script.wrappers;
using static Zest_Script.CEventArgs;
using static Zest_Script.EnumHelper;

namespace Zest_Script.settings
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

        /// <summary>
        /// Get a value indicating whether the current configuration has already been on-boarded this session.
        /// </summary>
        [XmlIgnore()]
        public bool HasBeenOnboarded { get; set; } = false;

        /// <summary>
        /// Get the current (up-to-date) version of the configuration.
        /// </summary>
        [XmlIgnore()]
        public static Configuration Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                        instance = new Configuration();
                    return instance;
                }
            }
        }

        #region Basic Options
        /// <summary>
        /// Basic computer information
        /// </summary>
        [XmlElement("basic-information")]
        public BasicInfo BasicInfo = new BasicInfo();
        #endregion

        #region Accounts
        /// <summary>
        /// Get a list of accounts to create.
        /// </summary>
        [XmlElement("accounts")]
        public List<Account> Accounts { get { return accounts; } set { accounts = value; } }
        private List<Account> accounts = new List<Account>();
        #endregion

        #region Connections
        /// <summary>
        /// Get a list of wifi profiles to create.
        /// </summary>
        [XmlElement("wifi-profiles")]
        public List<WiFi> WiFiProfiles { get { return wifiProfiles; } set { wifiProfiles = value; } }
        private List<WiFi> wifiProfiles = new List<WiFi>();

        /// <summary>
        /// Get a list of vpn profiles to create.
        /// </summary>
        [XmlElement("vpn-profiles")]
        public List<VPN> VPNProfiles { get { return vpnProfiles; } set { vpnProfiles = value; } }
        private List<VPN> vpnProfiles = new List<VPN>();
        #endregion

        #region Programs
        /// <summary>
        /// Get a list of applications to install.
        /// </summary>
        [XmlElement("applications")]
        public List<wrappers.Application> Applications { get { return applications; } set { applications = value; } }
        private List<wrappers.Application> applications = new List<wrappers.Application>();
        #endregion

        #region Remote Desktop
        /// <summary>
        /// Get a list of RDP files to create.
        /// </summary>
        [XmlElement("rdp-files")]
        public List<RDPFile> RDPFiles { get { return rdpFiles; } set { rdpFiles = value; } }
        private List<RDPFile> rdpFiles = new List<RDPFile>();
        #endregion

        #region Mapped Drive
        /// <summary>
        /// Get a list of mapped drives to create.
        /// </summary>
        [XmlElement("mapped-drives")]
        public List<MappedDrive> MappedDrives { get { return mappedDrives; } set { mappedDrives = value; } }
        private List<MappedDrive> mappedDrives = new List<MappedDrive>();
        #endregion

        #region Mapped Printer
        /// <summary>
        /// Get a list of printers to install.
        /// </summary>
        [XmlElement("printers")]
        public List<Printer> Printers { get { return printers; } set { printers = value; } }
        private List<Printer> printers = new List<Printer>();
        #endregion

        /// <summary>
        /// Create a new blank configuration.
        /// </summary>
        public Configuration() { }

        /// <summary>
        /// Check that the current configuration is valid and ready for on-boarding.
        /// <para>A valid configuration has at the very least all basic settings (computer name, time zone, ntp server, and whether to perform time sync) as well as at least one account.</para>
        /// </summary>
        /// <returns></returns>
        public bool CheckConfiguration()
        {
            if (BasicInfo.ComputerName.Equals(string.Empty) | BasicInfo.TimeZone == null
                | BasicInfo.PrimaryNTPServer.Equals(string.Empty) | accounts.Count <= 0)
                return false;

            return true;
        }

        /// <summary>
        /// Reset the current configuration to defaults (blank config).
        /// </summary>
        /// <param name="fireEvent">Whether to fire the <see cref="ConfigReset"/> event.</param>
        public void ResetConfig(bool fireEvent = false)
        {
            instance = new Configuration();
            if (fireEvent)
                ConfigReset?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Load a config <c>XML</c> file from the specified <paramref name="path"/> into the current
        /// configuration <see cref="Instance"/> by default.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="loadIntoCurrentConfiguration">Whether to load the configuration file into the configuration <see cref="Instance"/> or simply return a new configuration variable.</param>
        /// <returns>A <see cref="Configuration"/> object containing the configuration present in the XML file or the current configuration if loading failed.</returns>
        public static Configuration LoadConfig(string path, bool loadIntoCurrentConfiguration = true)
        {
            XmlSerializer serializer = new(typeof(Configuration));
            StreamReader reader = new StreamReader(path);
            try
            {
                object? deserialized = serializer.Deserialize(reader);
                if (deserialized != null)
                {
                    if (!loadIntoCurrentConfiguration)
                    {
                        ConfigLoaded?.Invoke(Instance, new EventArgs());
                        return (Configuration)deserialized;
                    }
                    else
                    {
                        instance = (Configuration)deserialized;
                        ConfigLoaded?.Invoke(Instance, new EventArgs());
                    }
                }
                else
                    ConfigLoadError?.Invoke(Instance, new EventArgs());
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application",
                    $"An error occured loading a configuration file: {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                ConfigLoadError?.Invoke(Instance, new EventArgs());
            }
            finally
            {
                reader.Close();
            }

            return Instance;
        }

        /// <summary>
        /// Save the current configuration to an <c>XML</c> file encoded in <see cref="Encoding.UTF8"/>.
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
                    File.WriteAllText(path, stream.ToString(), Encoding.UTF8);
                }
                ConfigSaved?.Invoke(Instance, new ConfigSavedEventArgs(path));
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application",
                    $"An error occured loading a configuration file: {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                ConfigSaveError?.Invoke(Instance, new EventArgs());
                return false;
            }

            return true;
        }

        #region Accounts
        /// <summary>
        /// Add an account (if not present) to the <see cref="Accounts"/> list.
        /// </summary>
        /// <param name="a"></param>
        /// <returns>A code representing the state after invoking.</returns>
        public ReturnCodes AddAccount(Account a)
        {
            if (accounts.Any(acct => acct.Username.Equals(a.Username)))
                return ReturnCodes.ACCOUNT_ALREADY_EXISTS;
            accounts.Add(a);
            return ReturnCodes.NO_ERROR;
        }

        /// <summary>
        /// Remove an account (if present) from the <see cref="Accounts"/> list.
        /// </summary>
        /// <param name="a"></param>
        /// <returns>A code representing the state after invoking.</returns>
        public ReturnCodes RemoveAccount(Account a)
        {
            if (accounts.Contains(a))
                accounts.Remove(a);
            else
                return ReturnCodes.ACCOUNT_DOES_NOT_EXIST;

            return ReturnCodes.NO_ERROR;
        }

        /// <summary>
        /// Get an account based on the <paramref name="username"/>.
        /// </summary>
        /// <param name="username"></param>
        /// <returns>The account or <c>null</c> if not found.</returns>
        public Account? GetAccount(string username)
        {
            return accounts.FirstOrDefault(a => a.Username.Equals(username));
        }
        #endregion

        #region Connections
        /// <summary>
        /// Add a wifi profile (if not present) to the <see cref="WiFiProfiles"/> list.
        /// </summary>
        /// <param name="w"></param>
        /// <returns>A code representing the state after invoking.</returns>
        public ReturnCodes AddWiFi(WiFi w)
        {
            if (wifiProfiles.Any(wifi => wifi.SSID.Equals(w.SSID)))
                return ReturnCodes.WIFI_ALREADY_EXISTS;
            wifiProfiles.Add(w);

            return ReturnCodes.NO_ERROR;
        }

        /// <summary>
        /// Remove a wifi profile (if present) from the <see cref="WiFiProfiles"/> list.
        /// </summary>
        /// <param name="w"></param>
        /// <returns>A code representing the state after invoking.</returns>
        public ReturnCodes RemoveWiFi(WiFi w)
        {
            if (wifiProfiles.Contains(w))
                wifiProfiles.Remove(w);
            else
                return ReturnCodes.WIFI_DOES_NOT_EXIST;

            return ReturnCodes.NO_ERROR;
        }

        /// <summary>
        /// Get a wifi profile based on the <paramref name="ssid"/>.
        /// </summary>
        /// <param name="ssid"></param>
        /// <returns>The wifi profile or <c>null</c> if not found.</returns>
        public WiFi? GetWiFi(string ssid)
        {
            return wifiProfiles.FirstOrDefault(wifi => wifi.SSID.Equals(ssid));
        }

        /// <summary>
        /// Add a vpn profile (if not present) to the <see cref="VPNProfiles"/> list.
        /// </summary>
        /// <param name="v"></param>
        /// <returns>A code representing the state after invoking.</returns>
        public ReturnCodes AddVPN(VPN v)
        {
            if (vpnProfiles.Any(vpn => vpn.ConnectionName.Equals(v.ConnectionName)))
                return ReturnCodes.VPN_ALREADY_EXISTS;
            vpnProfiles.Add(v);

            return ReturnCodes.NO_ERROR;
        }

        /// <summary>
        /// Remove a vpn profile (if present) from the <see cref="VPNProfiles"/> list.
        /// </summary>
        /// <param name="v"></param>
        /// <returns>A code representing the state after invoking.</returns>
        public ReturnCodes RemoveVPN(VPN v)
        {
            if (vpnProfiles.Contains(v))
                vpnProfiles.Remove(v);
            else
                return ReturnCodes.VPN_DOES_NOT_EXIST;

            return ReturnCodes.NO_ERROR;
        }

        /// <summary>
        /// Get a vpn profile based on the <paramref name="connectionName"/>.
        /// </summary>
        /// <param name="connectionName"></param>
        /// <returns>The vpn profile or <c>null</c> if not found.</returns>
        public VPN? GetVPN(string connectionName)
        {
            return vpnProfiles.FirstOrDefault(vpn => vpn.ConnectionName.Equals(connectionName));
        }
        #endregion

        #region Programs
        /// <summary>
        /// Add an application (if not present) to the <see cref="Applications"/> list.
        /// </summary>
        /// <param name="a"></param>
        /// <returns>A code representing the state after invoking.</returns>
        public ReturnCodes AddApplication(wrappers.Application a)
        {
            if (applications.Any(app => app.Name.Equals(a.Name)))
                return ReturnCodes.APPLICATION_ALREADY_EXISTS;

            applications.Add(a);
            return ReturnCodes.NO_ERROR;
        }

        /// <summary>
        /// Remove an application (if present) from the <see cref="Applications"/> list.
        /// </summary>
        /// <param name="a"></param>
        /// <returns>A code representing the state after invoking.</returns>
        public ReturnCodes RemoveApplication(wrappers.Application a)
        {
            if (applications.Contains(a))
                applications.Remove(a);
            else
                return ReturnCodes.APPLICATION_DOES_NOT_EXIST;

            return ReturnCodes.NO_ERROR;
        }

        /// <summary>
        /// Get an application based on the <paramref name="name"/>.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>The vpn profile or <c>null</c> if not found.</returns>
        public wrappers.Application? GetApplication(string name)
        {
            return applications.FirstOrDefault(a => a.Name.Equals(name));
        }
        #endregion

        #region RDP Files
        /// <summary>
        /// Add an RDP file (if not present) to the <see cref="RDPFiles"/> list.
        /// </summary>
        /// <param name="file"></param>
        /// <returns>A code representing the state after invoking.</returns>
        public ReturnCodes AddRDPFile(RDPFile file)
        {
            if (rdpFiles.Any(f => f.ComputerName.Equals(file.ComputerName)))
                return ReturnCodes.RDP_ALREADY_EXISTS;
            rdpFiles.Add(file);

            return ReturnCodes.NO_ERROR;
        }

        /// <summary>
        /// Remove an RDP file (if present) from the <see cref="RDPFiles"/> list.
        /// </summary>
        /// <param name="file"></param>
        /// <returns>A code representing the state after invoking.</returns>
        public ReturnCodes RemoveRDPFile(RDPFile file)
        {
            if (rdpFiles.Contains(file))
                rdpFiles.Remove(file);
            else
                return ReturnCodes.RDP_DOES_NOT_EXIST;

            return ReturnCodes.NO_ERROR;
        }

        /// <summary>
        /// Get an RDP file based on the <paramref name="computerName"/>.
        /// </summary>
        /// <param name="computerName"></param>
        /// <returns>The RDP file or <c>null</c> if not found.</returns>
        public RDPFile? GetRDPFile(string computerName)
        {
            return rdpFiles.FirstOrDefault(a => a.ComputerName.Equals(computerName));
        }
        #endregion

        #region Mapped Drives
        /// <summary>
        /// Add a mapped drive (if not present) to the <see cref="MappedDrives"/> list.
        /// </summary>
        /// <param name="d"></param>
        /// <returns>A code representing the state after invoking.</returns>
        public ReturnCodes AddMappedDrive(MappedDrive d)
        {
            if (mappedDrives.Any(f => f.DriveLetter == d.DriveLetter))
                return ReturnCodes.MAPPED_DRIVE_ALREADY_EXISTS;
            mappedDrives.Add(d);

            return ReturnCodes.NO_ERROR;
        }

        /// <summary>
        /// Remove a mapped drive (if present) from the <see cref="MappedDrives"/> list.
        /// </summary>
        /// <param name="d"></param>
        /// <returns>A code representing the state after invoking.</returns>
        public ReturnCodes RemoveMappedDrive(MappedDrive d)
        {
            if (mappedDrives.Contains(d))
                mappedDrives.Remove(d);
            else
                return ReturnCodes.MAPPED_DRIVE_DOES_NOT_EXIST;

            return ReturnCodes.NO_ERROR;
        }

        /// <summary>
        /// Get a mapped drive based on the <paramref name="path"/> and optionally the <paramref name="letter"/>.
        /// </summary>
        /// 
        /// <param name="path">The UNC path of the mapped drive.</param>
        /// <param name="letter">The drive letter to search for. <c>Nullable</c></param>
        /// <returns>The mapped drive or <c>null</c> if not found.</returns>
        public MappedDrive? GetMappedDrive(string path, DriveLetter? letter)
        {
            if (letter != null)
                return mappedDrives.FirstOrDefault(d => d.DriveLetter == letter && d.Path.Equals(path));
            else
                return mappedDrives.FirstOrDefault(d => d.Path.Equals(path));
        }
        #endregion

        #region Printers
        /// <summary>
        /// Add a printer (if not present) to the <see cref="Printers"/> list.
        /// </summary>
        /// <param name="p"></param>
        /// <returns>A code representing the state after invoking.</returns>
        public ReturnCodes AddPrinter(Printer p)
        {
            if (printers.Any(f => f.Name == p.Name))
                return ReturnCodes.PRINTER_ALREADY_EXISTS;
            printers.Add(p);

            return ReturnCodes.NO_ERROR;
        }

        /// <summary>
        /// Remove a printer (if present) from the <see cref="Printers"/> list.
        /// </summary>
        /// <param name="p"></param>
        /// <returns>A code representing the state after invoking.</returns>
        public ReturnCodes RemovePrinter(Printer p)
        {
            if (printers.Contains(p))
                printers.Remove(p);
            else
                return ReturnCodes.PRINTER_DOES_NOT_EXIST;
            return ReturnCodes.NO_ERROR;
        }

        /// <summary>
        /// Get a printer based on the <paramref name="name"/>.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>The printer or <c>null</c> if not found.</returns>
        public Printer? GetPrinter(string name)
        {
            return printers.FirstOrDefault(p => p.Name.Equals(name));
        }
        #endregion
    }
}
