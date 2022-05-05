using System.Windows.Forms;
using System.Security.Principal;
using System.Diagnostics;

namespace Zest_Script
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool elevated = CheckIfRunningAsAdmin();
            if (Debugger.IsAttached || elevated)
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm());
            }
            else
            {
                MessageBox.Show(null, "This application requires Administrator privilages to run correctly.\n" +
                        "Please restart the application as an administrator.", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private static bool CheckIfRunningAsAdmin()
        {
            bool isElevated;
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            return isElevated;
        }
    }
}