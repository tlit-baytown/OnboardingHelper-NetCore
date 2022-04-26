using OnboardingHelper_NetCore.wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return false;
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

        public Account GetAccount(string username)
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

        public WiFi GetWiFi(string ssid)
        {
            return wifiProfiles.FirstOrDefault(wifi => wifi.SSID.Equals(ssid));
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
    }
}
