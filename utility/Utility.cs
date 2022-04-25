﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingHelper_NetCore
{
    public sealed class Utility
    {
        public static MainForm MainForm { get; private set; }

        public static void SetMainForm(MainForm form)
        {
            MainForm = form;
        }

        public static ReadOnlyCollection<TimeZoneInfo> GetTimezones()
        {
            return TimeZoneInfo.GetSystemTimeZones();
        }

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
        /// <para>This is a quick alternative to using the <see cref="DGV.FileSizeFormatProvider"/> class.</para>
        /// </summary>
        /// <param name="bytes">The bytes to format</param>
        /// <returns>The number formatted with its suffix.</returns>
        public static string FormatSize(long bytes)
        {
            string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };
            int counter = 0;
            decimal number = bytes;

            while (Math.Round(number / 1024) >= 1)
            {
                number /= 1024;
                counter++;
            }
            return string.Format("{0:n" + 2 + "} {1}", number, suffixes[counter]);
        }
    }
}