using Microsoft.Management.Infrastructure;
using Microsoft.PowerShell;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Net;
using System.Security;
using Zest_Script.settings;
using Zest_Script.wrappers;

namespace Zest_Script.Powershell
{
    /// <summary>
    /// Classes to handle interacting with Powershell from the Zest Script program.
    /// </summary>
    public sealed class PSHelper
    {
        private PSHelper() { }

        private static string pathToScripts = Properties.Settings.Default.PathToScripts;
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
            //If script has already been created, overwrite it.
            if (Configuration.Instance.HasBeenOnboarded)
                File.Create(FullScriptPath).Close();

            WriteHeader();
            WriteBasicInfo();
            WriteAccounts();

            return FullScriptPath;
        }

        /// <summary>
        /// Write a comment line to the script file. This is a line preceeded by a pound (#) symbol.
        /// </summary>
        /// <param name="file">The file to write to.</param>
        /// <param name="comment">The comment.</param>
        /// <param name="appendNewLine">Whether a new line should be included. Default = True.</param>
        private static void WriteComment(StreamWriter file, string comment, bool appendNewLine = true)
        {
            if (appendNewLine)
                file.WriteLine("#" + comment);
            else
                file.Write("#" + comment);
        }

        /// <summary>
        /// Write descriptive text to the script file. This is a line with the specified foreground and background color that serves to
        /// provide information to the user about what the script is doing.
        /// </summary>
        /// <param name="file">The file to write to.</param>
        /// <param name="text">The text to write.</param>
        /// <param name="foreground">The foreground color.</param>
        /// <param name="background">The background color.</param>
        /// <param name="appendNewLine">Whether a new line should be included. Default = True.</param>
        private static void WriteDescriptionText(StreamWriter file, string text, Color foreground, Color background, bool appendNewLine = true)
        {
            if (appendNewLine)
                file.WriteLine($"Write-Host \"{text}\" -ForegroundColor {foreground.Name} -BackgroundColor {background.Name}");
            else
                file.Write($"Write-Host \"{text}\" -ForegroundColor {foreground.Name} -BackgroundColor {background.Name}");
        }

        /// <summary>
        /// Write descriptive text to the script file. This is a line with a DarkRed foreground color and White background color that serves to
        /// provide information to the user about what the script is doing.
        /// </summary>
        /// <param name="file">The file to write to.</param>
        /// <param name="text">The text to write.</param>
        /// <param name="appendNewLine">Whether a new line should be included. Default = True.</param>
        private static void WriteDescriptionText(StreamWriter file, string text, bool appendNewLine = true) =>
            WriteDescriptionText(file, text, Color.DarkRed, Color.White, appendNewLine);

        /// <summary>
        /// Writes a blank new line the specified file.
        /// </summary>
        /// <param name="file">The file to write to.</param>
        private static void WriteLine(StreamWriter file)
        {
            file.WriteLine();
        }

        /// <summary>
        /// Writes a PowerShell command to the file for execution.
        /// </summary>
        /// <param name="file">The file to write to.</param>
        /// <param name="cmd">The command to write.</param>
        /// <param name="appendNewLine">Whether a new line should be included. Default = True.</param>
        private static void WriteCmd(StreamWriter file, string cmd, bool appendNewLine = true)
        {
            if (appendNewLine)
                file.WriteLine(cmd);
            else
                file.Write(cmd);
        }

        /// <summary>
        /// Writes an indented line to the file.
        /// </summary>
        /// <param name="file">The file to write to.</param>
        /// <param name="line">The line to write.</param>
        /// <param name="appendNewLine">Whether a new line should be included. Default = True.</param>
        private static void WriteFunctionLine(StreamWriter file, string line, bool appendNewLine = true)
        {
            if (appendNewLine)
                file.WriteLine("\t" + line);
            else
                file.Write("\t" + line);
        }

        private static void WriteHeader()
        {
            using StreamWriter file = new(FullScriptPath, append: true);

            WriteComment(file, "Auto-generated PowerShell script for onboarding a new computer.");
            WriteDescriptionText(file, $"ZestScript - Version {System.Windows.Forms.Application.ProductVersion}", Color.White, Color.DarkGreen);
            WriteLine(file);

            WriteComment(file, "Import modules needed by script");
            WriteCmd(file, "Import-Module Microsoft.PowerShell.Management");
            WriteCmd(file, "Import-Module PrintManagement");
            WriteLine(file);

            WriteFunctions(file);

            WriteDescriptionText(file, "Saving the current execution policy to a variable and setting policy to Unrestricted.");
            WriteCmd(file, "$currentExecutionPolicy=Get-ExecutionPolicy -Scope LocalMachine");
            WriteCmd(file, "Set-ExecutionPolicy -ExecutionPolicy Unrestricted -Scope LocalMachine -Force");
            WriteLine(file);
        }

        /// <summary>
        /// Writes the function definitions to the top of the script file.
        /// </summary>
        /// <param name="file">The file to write to.</param>
        private static void WriteFunctions(StreamWriter file)
        {
            WriteComment(file, "Function Definitions");
            WriteCmd(file, "Function Add-Account($username, $base64password, $comment, $accountType, $passwordExpires, $requirePWChange)");
            WriteCmd(file, "{");
            WriteFunctionLine(file, "$rawPw = [System.Text.Encoding]::UTF8.GetString([System.Convert]::FromBase64String($base64password))");
            WriteFunctionLine(file, "$pw = ConvertTo-SecureString $rawPW -AsPlainText -Force");
            WriteFunctionLine(file, "New-LocalUser -Name $username -Password $pw -Description $comment -AccountNeverExpires | Set-LocalUser -PasswordNeverExpires $passwordExpires");
            WriteCmd(file, "}");
            WriteLine(file);
        }

        private static void WriteBasicInfo()
        {
            using StreamWriter file = new(FullScriptPath, append: true);

            WriteDescriptionText(file, "Setting computer name...");
            if (Configuration.Instance.BasicInfo.ComputerName.Equals(""))
                WriteDescriptionText(file, "Computer name was empty. Skipping...");
            else
            {
                WriteCmd(file, $"Rename-Computer -NewName \"{Configuration.Instance.BasicInfo.ComputerName}\"", false);
                if (Properties.Settings.Default.RestartAfterComputerNameSet)
                    WriteCmd(file, "-Restart");
            }
            WriteLine(file);

            if (!Configuration.Instance.BasicInfo.Domain.Equals("")) //domain is not empty
            {
                WriteDescriptionText(file, "Adding computer to domain...");

                string domain = Configuration.Instance.BasicInfo.Domain;
                string username = Configuration.Instance.BasicInfo.DomainUsername;
                string base64Pass = Configuration.Instance.BasicInfo.Base64DomainPassword;

                WriteCmd(file, $"$domain = \"{domain}\"");
                WriteCmd(file, $"$domainUsername = \"{username}\"");
                WriteCmd(file, $"$base64DomainPassword = \"{base64Pass}\"");
                WriteCmd(file, $"$rawDomainPassword = [System.Text.Encoding]::UTF8.GetString([System.Convert]::FromBase64String($base64DomainPassword))");
                WriteCmd(file, $"$domainPassword = ConvertTo-SecureString $rawDomainPassword -AsPlainText -Force");
                WriteCmd(file, $"[PSCredential]$credential = New-Object System.Management.Automation.PSCredential ($domainUsername, $domainPassword)");

                WriteCmd(file, $"Add-Computer -DomainName $domain -Credential $credential -Force");
            }
            else
                WriteDescriptionText(file, "No domain specified. Skipping...");

            WriteLine(file);

            //Timezone and NTP
            WriteDescriptionText(file, "Setting TimeZone info...");
            WriteCmd(file, $"Set-TimeZone -Name \"{Configuration.Instance.BasicInfo.TimeZone.Id}\"");
            WriteCmd(file, "Start-Service w32time");
            WriteCmd(file, "w32tm /register");
            WriteCmd(file, $"w32tm /config /syncfromflags:manual /manualpeerlist:\"{Configuration.Instance.BasicInfo.PrimaryNTPServer}\"");
            
            if (Configuration.Instance.BasicInfo.PerformTimeSync)
                WriteCmd(file, "w32tm /resync /force");
        }

        private static void WriteAccounts()
        {
            using StreamWriter file = new(FullScriptPath, append: true);

            WriteDescriptionText(file, "Creating user accounts...");
            foreach (Account acct in Configuration.Instance.Accounts)
            {
                WriteDescriptionText(file, $"Adding account: {acct.Username}");
                WriteCmd(file, $"Add-Account \"{acct.Username}\" \"{acct.Base64Password}\" \"{acct.Comment}\" ${acct.DoesPasswordExpire} ${acct.RequirePasswordChange}");
            }
        }
        //            WriteCmd(file, "function Add-Account($username, $base64password, $comment, $accountType, $passwordExpires, $requirePWChange)");

        ///// <summary>
        ///// Creates a unique key file to use for encrypting and decrypting credentials.
        ///// Saves the file in the location specified by <see cref="Properties.Settings.PathToKeyFiles"/> with the unique script name as the file name.
        ///// </summary>
        //public static void CreateKeyFile()
        //{
        //    if (!Directory.Exists(pathToKeyFiles))
        //        Directory.CreateDirectory(pathToKeyFiles);

        //    using (PowerShell instance = PowerShell.Create())
        //    {
        //        instance.AddScript($"$KeyFile={Path.Combine(pathToKeyFiles, uniqueName)}.key");
        //        instance.AddStatement().AddScript("$Key=New-Object Byte[] 16");
        //        instance.AddStatement().AddScript("[System.Security.Cryptography.RNGCryptoServiceProvider]::Create().GetBytes($Key)");
        //        instance.AddStatement().AddScript("$Key | Out-File $KeyFile");
        //    }
        //}

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