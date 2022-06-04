using Microsoft.Management.Infrastructure;
using Microsoft.PowerShell;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Net;
using System.Security;
using Zest_Script.settings;

namespace Zest_Script.Powershell
{
    /// <summary>
    /// Classes to handle interacting with Powershell from the Zest Script program.
    /// </summary>
    public sealed class PSHelper
    {
        private PSHelper() { }

        private static string pathToScripts = Properties.Settings.Default.PathToScripts;
        private static string pathToKeyFiles = Properties.Settings.Default.PathToKeyFiles;
        private static string uniqueName = Guid.NewGuid().ToString()[..8] + ".ps1"; //use the first 8 characters of the GUID as the script name for simplicity

        /// <summary>
        /// Get the full path to the auto-generated script file.
        /// </summary>
        public static string FullScriptPath { get { return Path.Combine(pathToScripts, uniqueName); } }

        /// <summary>
        /// Checks if the directory for storing scripts exists as well as the current script file. Creates them if they don't exist.
        ///
        /// </summary>
        /// <returns>True if directory and file was created successfully. False, otherwise.</returns>
        public static bool SetEnvironment()
        {
            try
            {
                if (!Directory.Exists(pathToScripts))
                    Directory.CreateDirectory(pathToScripts);
                if (!File.Exists(FullScriptPath))
                    File.Create(FullScriptPath).Close();
                return true;
            } catch (Exception) { return false; }
        }

        /// <summary>
        /// Compiles and creates the PowerShell script based on Configuration values present in <see cref="Configuration"/>.
        /// </summary>
        /// <returns>The <see cref="Path"/> to the script file.</returns>
        public static string CreateScript()
        {
            WriteHeader();
            WriteBasicInfo();

            return FullScriptPath;
        }

        private static void WriteComment(StreamWriter file, string comment, bool appendNewLine = true)
        {
            if (appendNewLine)
                file.WriteLine("#" + comment);
            else
                file.Write("#" + comment);
        }

        private static void WriteDescriptionText(StreamWriter file, string text, Color foreground, Color background, bool appendNewLine = true)
        {
            if (appendNewLine)
                file.WriteLine($"Write-Host \"{text}\" -ForegroundColor {foreground.Name} -BackgroundColor {background.Name}");
            else
                file.Write($"Write-Host \"{text}\" -ForegroundColor {foreground.Name} -BackgroundColor {background.Name}");
        }

        private static void WriteLine(StreamWriter file)
        {
            file.WriteLine();
        }

        private static void WriteStatement(StreamWriter file, string statement, bool appendNewLine = true)
        {
            if (appendNewLine)
                file.WriteLine(statement);
            else
                file.Write(statement);
        }

        private static void WriteDescriptionText(StreamWriter file, string text, bool appendNewLine = true) => 
            WriteDescriptionText(file, text, Color.DarkRed, Color.White, appendNewLine);

        private static void WriteHeader()
        {
            using StreamWriter file = new(Path.Combine(pathToScripts, uniqueName), append: true);
            WriteComment(file, $"ZestScript - Version {Application.ProductVersion}");
            WriteComment(file, "Auto-generated Powershell script for onboarding a new computer.");
            WriteLine(file);
            WriteLine(file);

            WriteComment(file, "Import modules needed by script");
            WriteStatement(file, "Import-Module Microsoft.PowerShell.Management");
            WriteStatement(file, "Import-Module PrintManagement");
            WriteLine(file);

            WriteDescriptionText(file, "Saving the current execution policy to a variable and setting policy to Unrestricted.");
            WriteStatement(file, "$currentExecutionPolicy=Get-ExecutionPolicy -Scope LocalMachine");
            WriteStatement(file, "Set-ExecutionPolicy -ExecutionPolicy Unrestricted -Scope LocalMachine -Force");
            WriteLine(file);
        }

        private static void WriteBasicInfo()
        {
            using StreamWriter file = new(Path.Combine(pathToScripts, uniqueName), append: true);
            WriteDescriptionText(file, "Setting computer name...");
            if (Configuration.Instance.BasicInfo.ComputerName.Equals(""))
                WriteDescriptionText(file, "Computer name was empty. Skipping...");
            else
            {
                WriteStatement(file, $"Rename-Computer -NewName \"{Configuration.Instance.BasicInfo.ComputerName}\"", false);
                if (Properties.Settings.Default.RestartAfterComputerNameSet)
                    WriteStatement(file, "-Restart");
            }
            WriteLine(file);

            
            file.WriteLine("#Adding computer to domain.");
            if (!Configuration.Instance.BasicInfo.Domain.Equals("")) //domain is not empty
            {
                WriteDescriptionText(file, "Adding computer to domain...");

                string domain = Configuration.Instance.BasicInfo.Domain;
                string username = Configuration.Instance.BasicInfo.DomainUsername;
                string base64Pass = Configuration.Instance.BasicInfo.Base64DomainPassword;

                WriteStatement(file, $"$domain = \"{domain}\"");
                WriteStatement(file, $"$domainUsername = \"{username}\"");
                WriteStatement(file, $"$base64DomainPassword = \"{base64Pass}\"");
                WriteStatement(file, $"$rawDomainPassword = [System.Text.Encoding]::UTF8.GetString([System.Convert]::FromBase64String($base64DomainPassword))");
                WriteStatement(file, $"$domainPassword = ConvertTo-SecureString $rawDomainPassword -AsPlainText -Force");
                WriteStatement(file, $"[PSCredential]$credential = New-Object System.Management.Automation.PSCredential ($domainUsername, $domainPassword)");

                WriteStatement(file, $"Add-Computer -DomainName $domain -Credential $credential -Force");
            }
            else
                WriteDescriptionText(file, "No domain specified. Skipping...");

            WriteLine(file);
        }

        /// <summary>
        /// Creates a unique key file to use for encrypting and decrypting credentials.
        /// Saves the file in the location specified by <see cref="Properties.Settings.PathToKeyFiles"/> with the unique script name as the file name.
        /// </summary>
        public static void CreateKeyFile()
        {
            if (!Directory.Exists(pathToKeyFiles))
                Directory.CreateDirectory(pathToKeyFiles);

            using (PowerShell instance = PowerShell.Create())
            {
                instance.AddScript($"$KeyFile={Path.Combine(pathToKeyFiles, uniqueName)}.key");
                instance.AddStatement().AddScript("$Key=New-Object Byte[] 16");
                instance.AddStatement().AddScript("[System.Security.Cryptography.RNGCryptoServiceProvider]::Create().GetBytes($Key)");
                instance.AddStatement().AddScript("$Key | Out-File $KeyFile");
            }
        }

        ///// <summary>
        ///// Initialize the Powershell environment in the application's Runspace so that scripts can run. This method should be the first method
        ///// called in <see cref="PSHelper"/> before any other methods.
        ///// <para>Sets the execution policy to 'Unrestricted' and installs required modules. The policy is set back to what it was after the application is closed.</para>
        ///// </summary>
        ///// <returns>True if the environment was initialized successfully; False otherwise.</returns>
        //public static bool InitializePSEnvironment()
        //{
        //    runspace.Open();
        //    using (PowerShell instance = PowerShell.Create())
        //    {
        //        instance.Runspace = runspace;


        //        //Install modules and set up pre-req environment
        //        string path = Path.Combine("scripts", "Prereqs.ps1");
        //        if (!string.IsNullOrEmpty(path))
        //        {
        //            try
        //            {
        //                instance.AddStatement().AddScript(File.ReadAllText(path));

        //                instance.Invoke();
        //                if (!instance.HadErrors)
        //                    _isIntialized = true;
        //            }
        //            catch (Exception ex)
        //            {
        //                System.Diagnostics.Debug.WriteLine(ex.Message);

        //                if (instance.HadErrors)
        //                    System.Diagnostics.Debug.WriteLine(instance.Streams.Error.First().Exception.Message);

        //                _isIntialized = false;
        //            }
        //        }
        //        else
        //            _isIntialized = false;
        //    }

        //    return _isIntialized;
        //}

        ///// <summary>
        ///// Resets the ExecutionPolicy on the computer back to what it was before the on-boarding script ran.
        ///// </summary>
        //public static void DestroyPSEnvironment()
        //{
        //    if (!_isIntialized)
        //        return;

        //    using (PowerShell instance = PowerShell.Create())
        //    {
        //        instance.Runspace = runspace;

        //        instance.AddScript($"Set-ExecutionPolicy -ExecutionPolicy {Policy} -Scope LocalMachine -Force");
        //        instance.Invoke();
        //        if (!instance.HadErrors)
        //        {
        //            _isIntialized = false;
        //            runspace.Close();
        //        }
        //    }
        //}

        //private static ExecutionPolicy GetExecutionPolicy()
        //{
        //    using (PowerShell instance = PowerShell.Create())
        //    {
        //        instance.Runspace = runspace;

        //        instance.AddScript("Get-ExecutionPolicy");
        //        Collection<PSObject> result = instance.Invoke();
        //        if (result.Count > 0)
        //        {
        //            ExecutionPolicy i = (ExecutionPolicy)result[0].BaseObject;
        //            return i;
        //        }
        //        return ExecutionPolicy.Default;
        //    }
        //}

        //private static string GetPsCommand(PowerShell ps)
        //{
        //    string cmdText = string.Empty;
        //    for (int i = 0; i < ps.Commands.Commands.Count; i++)
        //    {
        //        var cmd = ps.Commands.Commands[i];
        //        cmdText += cmd.CommandText;
        //        foreach (var param in cmd.Parameters)
        //        {
        //            if (!string.IsNullOrEmpty(param.Name))
        //                cmdText += " -" + param.Name + ":";

        //            cmdText += param.Value;
        //        }
        //        if (cmd.IsEndOfStatement || i + 1 == ps.Commands.Commands.Count)
        //            cmdText += Environment.NewLine;
        //        else
        //            cmdText += "|";
        //    }
        //    return cmdText;
        //}

        //#region Internal Classes

        //#region Basic Info
        //public sealed class Basic
        //{
        //    private Basic() { }

        //    internal static string JoinDomain(string domain, string username, SecureString password, bool restartAfterJoin = false)
        //    {
        //        if (!_isIntialized)
        //            return "Environment is not initialized!";

        //        using (PowerShell instance = PowerShell.Create())
        //        {
        //            instance.Runspace = runspace;

        //            PSCredential credential = new PSCredential(username, password);
        //            instance.AddStatement()
        //                .AddScript("Add-Computer")
        //                .AddParameter("DomainName", domain)
        //                .AddParameter("Credential", credential)
        //                .AddParameter("Force", "$True");
        //            if (restartAfterJoin)
        //                instance.AddParameter("Restart", "$True");

        //            System.Diagnostics.Debug.WriteLine(GetPsCommand(instance));

        //            instance.Invoke();
        //            if (instance.HadErrors)
        //                return instance.Streams.Error.First().Exception.Message;

        //            return GetPsCommand(instance);
        //        }
        //    }

        //    internal static string SetTimeZone(TimeZoneInfo timeZone, string ntpServer, bool performTimeSync)
        //    {
        //        if (!_isIntialized)
        //            return "Environment is not initialized!";

        //        using (PowerShell instance = PowerShell.Create())
        //        {
        //            instance.Runspace = runspace;

        //            instance.AddStatement()
        //                .AddScript("Set-TimeZone")
        //                .AddParameter("Id", timeZone.Id);

        //            instance.AddStatement()
        //                .AddScript($"w32tm /config /syncfromflags:manual /manualpeerlist:\"{ntpServer}\"");

        //            if (performTimeSync)
        //                instance.AddStatement()
        //                    .AddScript("w32tm /resync /force");

        //            System.Diagnostics.Debug.WriteLine(GetPsCommand(instance));

        //            instance.Invoke();
        //            if (instance.HadErrors)
        //                return instance.Streams.Error.First().Exception.Message;

        //            return GetPsCommand(instance);
        //        }
        //    }
        //}
        //#endregion
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
                List<string> drivers = new List<string>();

                using (PowerShell instance = PowerShell.Create())
                {
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
        //#endregion
    }
}