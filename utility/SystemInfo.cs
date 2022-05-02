using Microsoft.Win32;
using System.Management;

namespace Zest_Script
{
    /// <summary>
    /// Class which holds information about the current system the program is running on. This class cannot be inherited. This class
    /// cannot be instantiated.
    /// </summary>
    public sealed class SystemInfo
    {
        private static object _lock = new object();
        private static SystemInfo? instance = null;

        /// <summary>
        /// The name of the currently running operating system.
        /// </summary>
        public string? OSName { get; private set; }

        /// <summary>
        /// The architecture of the currently running operating system.
        /// </summary>
        public string? OSArch { get; private set; }

        /// <summary>
        /// The name of the most recent service pack installed.
        /// </summary>
        public string? CSDVersion { get; private set; }

        /// <summary>
        /// The full name of the current CPU (processor).
        /// </summary>
        public string? ProcessorName { get; private set; }

        /// <summary>
        /// The amount of RAM currently installed on the system.
        /// </summary>
        public string? RAMAmount { get; private set; }

        /// <summary>
        /// Get the single instance of this class.
        /// </summary>
        public static SystemInfo Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                        instance = new SystemInfo();
                    return instance;
                }
            }
        }

        private SystemInfo()
        {
            GetOperatingSystemInfo();
            GetProcessorInfo();
            GetRAMInfo();
        }

        private void GetOperatingSystemInfo()
        {
            //Create an object of ManagementObjectSearcher class and pass query as parameter.
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            foreach (ManagementObject managementObject in mos.Get())
            {
                if (managementObject["Caption"] != null)
                    OSName = managementObject["Caption"].ToString();
                if (managementObject["OSArchitecture"] != null)
                    OSArch = managementObject["OSArchitecture"].ToString();
                if (managementObject["CSDVersion"] != null)
                    CSDVersion = managementObject["CSDVersion"].ToString();
            }
        }

        private void GetProcessorInfo()
        {
            RegistryKey? processor_name = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);   //This registry entry contains entry for processor info.

            if (processor_name != null)
            {
                object? processor = processor_name.GetValue("ProcessorNameString");
                if (processor != null)
                    ProcessorName = processor.ToString();
            }
        }

        private void GetRAMInfo()
        {
            RAMAmount = "Total RAM: " + Utility.FormatSize(GC.GetGCMemoryInfo().TotalAvailableMemoryBytes);
        }
    }
}
