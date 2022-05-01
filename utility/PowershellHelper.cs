using Microsoft.Management.Infrastructure;
using OnboardingHelper_NetCore.wrappers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingHelper_NetCore
{
    public sealed class PowershellHelper
    {
        private static bool _updatePreReqsInstalled = true;

        /// <summary>
        /// Get the list of current printer drivers installed on the current system.
        /// </summary>
        /// <returns>A list of strings containing the exact driver <c>Name</c>s.</returns>
        public static List<string> GetPrinterDriversInstalled()
        {
            List<string> drivers = new List<string>();

            using (PowerShell instance = PowerShell.Create())
            {
                string path = Path.Combine("scripts", "printers", "GetPrinterDrivers.ps1");
                if (!string.IsNullOrEmpty(path))
                {
                    try
                    {
                        instance.AddScript(File.ReadAllText(path));
                    } catch (Exception ex)
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
                        CimInstance i = (CimInstance) obj.BaseObject; //convert base object to CimInstance
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

        private static void InstallUpdatePreReqs()
        {
            //Get Prereqs installed first for Update check.
            using (PowerShell instance = PowerShell.Create())
            {
                string path = Path.Combine("scripts", "windows-update", "PreReq.ps1");
                if (!string.IsNullOrEmpty(path))
                    instance.AddScript(File.ReadAllText(path));
                Collection<PSObject> result = instance.Invoke();
                if (result.Count > 0)
                    _updatePreReqsInstalled = true;
            }
        }

        public static List<UpdateWrapper> GetUpdates()
        {
            List<UpdateWrapper> updates = new List<UpdateWrapper>();

            if (!_updatePreReqsInstalled)
                InstallUpdatePreReqs();

            using (PowerShell instance = PowerShell.Create())
            {
                string path = Path.Combine("scripts", "windows-update", "CheckUpdates.ps1");
                if (!string.IsNullOrEmpty(path))
                {
                    string script = File.ReadAllText(path);
                    instance.AddScript(script);
                }
                
                Collection<PSObject> PSOutput = instance.Invoke();

                foreach (PSObject obj in PSOutput)
                {
                    if (obj != null)
                    {
                        updates.Add(new UpdateWrapper()
                        {
                            KB = obj.Properties["KB"].Value.ToString(),
                            Size = obj.Properties["Size"].Value.ToString(),
                            Title = obj.Properties["Title"].Value.ToString()
                        });
                    }
                }
            }
            
            return updates;
        }
    }
}