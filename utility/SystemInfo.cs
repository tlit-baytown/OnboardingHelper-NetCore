using Microsoft.Win32;
using System.Management;

namespace Zest_Script
{
    public sealed class SystemInfo
    {
        private static object _lock = new object();
        private static SystemInfo? instance = null;

        public string? OSName { get; private set; }
        public string? OSArch { get; private set; }
        public string? CSDVersion { get; private set; }
        public string? ProcessorName { get; private set; }

        public string? RAMAmount { get; private set; }

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
            getOperatingSystemInfo();
            getProcessorInfo();
            getRamInfo();
        }

        private void getOperatingSystemInfo()
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

        private void getProcessorInfo()
        {
            RegistryKey? processor_name = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);   //This registry entry contains entry for processor info.

            if (processor_name != null)
            {
                if (processor_name.GetValue("ProcessorNameString") != null)
                    ProcessorName = processor_name.GetValue("ProcessorNameString").ToString();
            }
        }

        private void getRamInfo()
        {
            RAMAmount = "Total RAM: " + Utility.FormatSize(GC.GetGCMemoryInfo().TotalAvailableMemoryBytes);
        }
    }
}
