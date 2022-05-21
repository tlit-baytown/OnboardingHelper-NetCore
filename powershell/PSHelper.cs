using Microsoft.Management.Infrastructure;
using Microsoft.PowerShell;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Security;

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
        private static Runspace runspace = RunspaceFactory.CreateRunspace();

        /// <summary>
        /// Initialize the Powershell environment in the application's Runspace so that scripts can run. This method should be the first method
        /// called in <see cref="PSHelper"/> before any other methods.
        /// <para>Sets the execution policy to 'Unrestricted' and installs required modules. The policy is set back to what it was after the application is closed.</para>
        /// </summary>
        /// <returns>True if the environment was initialized successfully; False otherwise.</returns>
        public static bool InitializePSEnvironment()
        {
            runspace.Open();
            using (PowerShell instance = PowerShell.Create())
            {
                instance.Runspace = runspace;


                //Install modules and set up pre-req environment
                string path = Path.Combine("scripts", "Prereqs.ps1");
                if (!string.IsNullOrEmpty(path))
                {
                    try
                    {
                        instance.AddStatement().AddScript(File.ReadAllText(path));

                        instance.Invoke();
                        if (!instance.HadErrors)
                            _isIntialized = true;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);

                        if (instance.HadErrors)
                            System.Diagnostics.Debug.WriteLine(instance.Streams.Error.First().Exception.Message);

                        _isIntialized = false;
                    }
                }
                else
                    _isIntialized = false;
            }

            return _isIntialized;
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
                instance.Runspace = runspace;

                instance.AddScript($"Set-ExecutionPolicy -ExecutionPolicy {Policy} -Scope LocalMachine -Force");
                instance.Invoke();
                if (!instance.HadErrors)
                {
                    _isIntialized = false;
                    runspace.Close();
                }
            }
        }

        private static ExecutionPolicy GetExecutionPolicy()
        {
            using (PowerShell instance = PowerShell.Create())
            {
                instance.Runspace = runspace;

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

        private static string GetPsCommand(PowerShell ps)
        {
            string cmdText = string.Empty;
            for (int i = 0; i < ps.Commands.Commands.Count; i++)
            {
                var cmd = ps.Commands.Commands[i];
                cmdText += cmd.CommandText;
                foreach (var param in cmd.Parameters)
                {
                    if (!string.IsNullOrEmpty(param.Name))
                        cmdText += " -" + param.Name + ":";

                    cmdText += param.Value;
                }
                if (cmd.IsEndOfStatement || i + 1 == ps.Commands.Commands.Count)
                    cmdText += Environment.NewLine;
                else
                    cmdText += "|";
            }
            return cmdText;
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
                    instance.Runspace = runspace;

                    string cmd = $"Rename-Computer -NewName \"{name}\"";
                    if (restartAfterSet)
                        cmd = $"{cmd} -Restart";
                    instance.AddScript(cmd);

                    instance.Invoke();

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

            internal static string JoinDomain(string domain, string username, SecureString password, bool restartAfterJoin = false)
            {
                if (!_isIntialized)
                    return "Environment is not initialized!";

                using (PowerShell instance = PowerShell.Create())
                {
                    instance.Runspace = runspace;

                    PSCredential credential = new PSCredential(username, password);
                    instance.AddStatement()
                        .AddScript("Add-Computer")
                        .AddParameter("DomainName", domain)
                        .AddParameter("Credential", credential)
                        .AddParameter("Force", "$True");
                    if (restartAfterJoin)
                        instance.AddParameter("Restart", "$True");

                    System.Diagnostics.Debug.WriteLine(GetPsCommand(instance));

                    instance.Invoke();
                    if (instance.HadErrors)
                        return instance.Streams.Error.First().Exception.Message;

                    return GetPsCommand(instance);
                }
            }

            internal static string SetTimeZone(TimeZoneInfo timeZone, string ntpServer, bool performTimeSync)
            {
                if (!_isIntialized)
                    return "Environment is not initialized!";

                using (PowerShell instance = PowerShell.Create())
                {
                    instance.Runspace = runspace;

                    instance.AddStatement()
                        .AddScript("Set-TimeZone")
                        .AddParameter("Id", timeZone.Id);

                    instance.AddStatement()
                        .AddScript($"w32tm /config /syncfromflags:manual /manualpeerlist:\"{ntpServer}\"");

                    if (performTimeSync)
                        instance.AddStatement()
                            .AddScript("w32tm /resync /force");

                    System.Diagnostics.Debug.WriteLine(GetPsCommand(instance));

                    instance.Invoke();
                    if (instance.HadErrors)
                        return instance.Streams.Error.First().Exception.Message;

                    return GetPsCommand(instance);
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
                    instance.Runspace = runspace;

                    instance.AddScript("Get-PrinterDriver");
                    //string path = Path.Combine("scripts", "printers", "GetPrinterDrivers.ps1");
                    //if (!string.IsNullOrEmpty(path))
                    //{
                    //    try
                    //    {
                    //        instance.AddScript(File.ReadAllText(path));
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        System.Diagnostics.Debug.WriteLine(ex.Message);
                    //        return drivers;
                    //    }
                    //}

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