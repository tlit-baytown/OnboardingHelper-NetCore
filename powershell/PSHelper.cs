using Microsoft.Management.Infrastructure;
using Microsoft.PowerShell;
using System.Collections.ObjectModel;
using System.Management.Automation;

namespace Zest_Script.Powershell
{
    /// <summary>
    /// Classes to handle interacting with Powershell from the Zest Script program.
    /// </summary>
    public sealed class PSHelper
    {
        private PSHelper() { }

        private static ExecutionPolicy Policy = GetExecutionPolicy();
        private static bool _isIntialized = false;

        /// <summary>
        /// Initialized the Powershell environment on the user's computer so that scripts can run.
        /// <para>Essentially, sets the execution policy to 'Unrestricted'. The policy is set back to what it was after the application is closed.</para>
        /// </summary>
        public static void InitializePSEnvironment()
        {
            using (PowerShell instance = PowerShell.Create())
            {
                instance.AddScript("Set-ExecutionPolicy -ExecutionPolicy Unrestricted -Scope LocalMachine -Force");
                instance.Invoke();
                if (!instance.HadErrors)
                    _isIntialized = true;
            }
        }

        /// <summary>
        /// Resets the ExecutionPolicy on the computer back to what it was before the on-boarding script ran.
        /// </summary>
        public static void DestroyPSEnvironment()
        {
            if (!_isIntialized)
                return;

            using (PowerShell instance = PowerShell.Create())
            {
                instance.AddScript($"Set-ExecutionPolicy -ExecutionPolicy {Policy} -Scope LocalMachine -Force");
                instance.Invoke();
                if (!instance.HadErrors)
                    _isIntialized = false;
            }
        }

        private static ExecutionPolicy GetExecutionPolicy()
        {
            using (PowerShell instance = PowerShell.Create())
            {
                instance.AddScript("Get-ExecutionPolicy");
                Collection<PSObject> result = instance.Invoke();
                if (result.Count > 0)
                {
                    ExecutionPolicy i = (ExecutionPolicy)result[0].BaseObject;
                    return i;
                }
                return ExecutionPolicy.Default;
            }
        }

        #region Internal Classes

        #region Basic Info
        public sealed class Basic
        {
            private Basic() { }

            internal static string SetComputerName(string name, bool restartAfterSet = false)
            {
                if (!_isIntialized)
                    return "Environment is not initialized!";

                using (PowerShell instance = PowerShell.Create())
                {
                    string cmd = $"Rename-Computer -NewName \"{name}\"";
                    if (restartAfterSet)
                        cmd = $"{cmd} -Restart";
                    instance.AddScript(cmd);

                    Collection<PSObject> result = instance.Invoke();
                    if (instance.HadErrors)
                    {
                        if (instance.InvocationStateInfo != null)
                            if (instance.InvocationStateInfo.Reason != null)
                                System.Diagnostics.EventLog.WriteEntry("Application",
                                    instance.InvocationStateInfo.Reason.Message, System.Diagnostics.EventLogEntryType.Error);
                        return "Could not set the computer name! Perhaps you should run Zest Script as an administrator. See the system Event Log for errors.";
                    }
                    return $"Computer name successfully set to: {name}";
                }
            }
        }
        #endregion
        /// <summary>
        /// Contains scripts for configuring printers.
        /// </summary>
        public sealed class Printer
        {
            private Printer() { }

            /// <summary>
            /// Get the list of current printer drivers installed on the current system.
            /// </summary>
            /// <returns>A list of strings containing the exact driver <c>Name</c>s.</returns>
            internal static List<string> GetPrinterDriversInstalled()
            {
                if (!_isIntialized)
                    return new List<string>() { "Environment is not initialized!" };

                List<string> drivers = new List<string>();

                using (PowerShell instance = PowerShell.Create())
                {
                    string path = Path.Combine("scripts", "printers", "GetPrinterDrivers.ps1");
                    if (!string.IsNullOrEmpty(path))
                    {
                        try
                        {
                            instance.AddScript(File.ReadAllText(path));
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine(ex.Message);
                            return drivers;
                        }
                    }

                    Collection<PSObject> result = instance.Invoke();

                    if (instance.HadErrors)
                    {
                        if (instance.InvocationStateInfo != null)
                            System.Diagnostics.Debug.WriteLine(instance.InvocationStateInfo.Reason.Message);
                        return new List<string>();
                    }

                    if (result.Count > 0)
                    {
                        foreach (PSObject obj in result)
                        {
                            CimInstance i = (CimInstance)obj.BaseObject; //convert base object to CimInstance
                            object val = i.CimInstanceProperties["Name"].Value; //Get the 'Name' property of the printer driver
                            if (val != null)
                            {
                                //Convert the object to a string and add it to the list of drivers if it is not null
                                string? name = Convert.ToString(val);
                                drivers.Add(name ?? "");
                            }
                        }
                    }
                }
                return drivers;
            }
        }
        #endregion
    }
}