using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Security;

namespace Zest_Script
{
    /// <summary>
    /// Utility class that contains some static utility methods and members. This class cannot be inherited.
    /// </summary>
    public sealed class Utility
    {
        /// <summary>
        /// A reference to the main form of the application.
        /// </summary>
        public static MainForm? MainForm { get; private set; }

        /// <summary>
        /// Set the main form of the application.
        /// </summary>
        /// <param name="form"></param>
        public static void SetMainForm(MainForm form)
        {
            MainForm = form;
        }

        /// <summary>
        /// Get a list of Time Zones available.
        /// </summary>
        /// <returns>A <see cref="ReadOnlyCollection{T}"/> of <see cref="TimeZoneInfo"/>s available on the current system or <c>null</c> if an exception occured.</returns>
        public static ReadOnlyCollection<TimeZoneInfo>? GetTimezones()
        {
            try
            {
                return TimeZoneInfo.GetSystemTimeZones();
            }
            catch (Exception ex) when (ex is OutOfMemoryException || ex is SecurityException)
            {
                System.Diagnostics.EventLog.WriteEntry("Application",
                    $"Exception occured in Zest Script while getting time zone info from current system: {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                return null;
            }
        }

        /// <summary>
        /// Get a list of some NTP servers that the user can choose from.
        /// </summary>
        /// <returns>A <see cref="ReadOnlyCollection{T}"/> of <see cref="string"/>s containing some common NTP servers.</returns>
        public static ReadOnlyCollection<string> GetPossibleNTPServers()
        {
            return new ReadOnlyCollection<string>(new List<string> {
                "time.google.com",
                "time1.google.com",
                "time2.google.com",
                "time3.google.com",
                "time4.google.com",
                "time.cloudflare.com",
                "time.facebook.com",
                "time1.facebook.com",
                "time2.facebook.com",
                "time3.facebook.com",
                "time4.facebook.com",
                "time5.facebook.com",
                "time.windows.com",
                "time.apple.com",
                "time1.apple.com",
                "time2.apple.com",
                "time3.apple.com",
                "time4.apple.com",
                "time5.apple.com",
                "time6.apple.com",
                "time7.apple.com",
                "time.euro.apple.com",
                "time-a-g.nist.gov",
                "time-b-g-nist.gov",
                "time-c-g-nist.gov",
                "time-d-g-nist.gov",
                "time-a-wwv.nist.gov",
                "time-b-wwv.nist.gov",
                "time-c-wwv.nist.gov",
                "time-d-wwv.nist.gov",
                "time-a-b.nist.gov",
                "time-b-b.nist.gov",
                "time-c-b.nist.gov",
                "time-d-b.nist.gov",
                "time.nist.gov",
                "utcnist.colorado.edu",
                "utcnist2.colorado.edu",
                "pool.ntp.org",
                "0.pool.ntp.org",
                "1.pool.ntp.org",
                "2.pool.ntp.org",
                "3.pool.ntp.org",
            });
        }

        /// <summary>
        /// Formats a number in bytes to the next closest size representation and appends its suffix to the end.
        /// </summary>
        /// <param name="bytes">The number in bytes to format</param>
        /// <returns>The number formatted with its suffix or an empty <see cref="string"/> if an error ocurred.</returns>
        public static string FormatSize(long bytes)
        {
            string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };
            int counter = 0;
            decimal number = bytes;

            try
            {
                while (Math.Round(number / 1024) >= 1)
                {
                    number /= 1024;
                    counter++;
                }
                return string.Format("{0:n" + 2 + "} {1}", number, suffixes[counter]);
            }
            catch (Exception ex) when (ex is OverflowException || ex is ArgumentNullException || ex is FormatException)
            {
                System.Diagnostics.EventLog.WriteEntry("Application",
                    $"Exception occured in Zest Script while formatting size string: {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                return string.Empty;
            }
        }

        /// <summary>
        /// Get an unsecure version of the <see cref="SecureString"/> for converting to base64 or displaying.
        /// </summary>
        /// <param name="ss"></param>
        /// <returns>A decrypted <see cref="string"/> version of the <see cref="SecureString"/> or <see cref="string.Empty"/> if an error occured.</returns>
        public static string ConvertToUnsecureString(SecureString ss)
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(ss);
                string? unsecure = Marshal.PtrToStringUni(unmanagedString);

                return unsecure == null ? string.Empty : unsecure;
            }
            catch (Exception ex) when (ex is ArgumentNullException || ex is OutOfMemoryException)
            {
                System.Diagnostics.EventLog.WriteEntry("Application",
                    $"Exception occured in Zest Script while converting secure string: {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                return string.Empty;
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

        /// <summary>
        /// Show a tool tip on the specified <paramref name="parent"/> control.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="parent"></param>
        /// <param name="toolTip"></param>
        /// <param name="duration"></param>
        public static void ShowToolTip(string text, Control parent, ToolTip toolTip, int duration = 4000)
        {
            if (parent == null || toolTip == null || text == null)
                return;

            toolTip.IsBalloon = true;
            toolTip.Show(text, parent, 0, 0 - parent.Size.Height - 20, duration);
        }
    }
}
