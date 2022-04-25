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


/*
 * public static List<TimeZoneInfo> GetTimezones()
        {
            List<TimeZoneInfo> list = new List<TimeZoneInfo>();

            using (PowerShell instance = PowerShell.Create())
            {
                instance.AddScript("Get-TimeZone -ListAvailable");
                Collection<PSObject> timezones = instance.Invoke();

                foreach (PSObject obj in timezones)
                {
                    if (obj != null)
                    {
                        TimeZoneInfo? t = obj.BaseObject as TimeZoneInfo;
                        if (t != null)
                            list.Add(t);
                    }
                }
            }

            return list;
        }
 */