using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnboardingHelper_NetCore.EnumHelper;

namespace OnboardingHelper_NetCore.wrappers
{
    public static class ApplicationWrapper
    {
        /// <summary>
        /// Get the collection of applications to install. This collection is Read-Only and can only be modified using the
        /// methods in <see cref="ApplicationWrapper"/>.
        /// </summary>
        public static IReadOnlyCollection<Application> Applications { get { return applications; } }

        private static List<Application> applications = new List<Application>();

        public static ErrorCodes AddApplication(Application a)
        {
            if (applications.Any(app => app.Name.Equals(a.Name)))
                return ErrorCodes.APPLICATION_ALREADY_EXISTS;

            applications.Add(a);
            return ErrorCodes.NO_ERROR;
        }

        public static ErrorCodes RemoveApplication(Application a)
        {
            if (applications.Contains(a))
                applications.Remove(a);
            else
                return ErrorCodes.APPLICATION_DOES_NOT_EXIST;

            return ErrorCodes.NO_ERROR;
        }

        public static Application GetApplication(string name)
        {
            return applications.FirstOrDefault(a => a.Name.Equals(name));
        }


    }

    /// <summary>
    /// Structure to represent an Application that is to be installed on the computer.
    /// </summary>
    public struct Application
    {
        /// <summary>
        /// The name of the application.
        /// </summary>
        public string Name { get; private set; } = string.Empty;
        /// <summary>
        /// An optional description of the application.
        /// </summary>
        public string Description { get; private set; } = string.Empty;

        /// <summary>
        /// The full path to the application file to be installed.
        /// </summary>
        public string Path { get; private set; }

        /// <summary>
        /// The installation arguments needed for installation via command line.
        /// </summary>
        public string InstallArguments { get; private set; } = string.Empty;

        /// <summary>
        /// Is the installer file an .MSI file (windows installer)?
        /// <para>If <c>false</c>, the application is assumed to be an .EXE file.</para>
        /// </summary>
        public bool IsWindowsInstaller { get; private set; } = false;

        /// <summary>
        /// Is the installer an ISO disk image? (such is the case for Microsoft Office 2019)
        /// </summary>
        public bool IsISOImage { get; private set; } = false;

        /// <summary>
        /// Provides a <see cref="FileStream"/> object that represents this application.
        /// </summary>
        public FileStream File
        {
            get
            {
                if (System.IO.File.Exists(Path))
                    return System.IO.File.OpenRead(Path);
                else
                    return null;
            }
        }

        /// <summary>
        /// Create a new application with the specified name, description, path, and install arguments.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="path"></param>
        /// <param name="installArguments"></param>
        /// <param name="isIsoImage"></param>
        /// <param name="isWindowsInstaller"></param>
        public Application(string name, string description, string path, string installArguments, bool isWindowsInstaller, bool isIsoImage)
        {
            Name = name;
            Description = description;
            Path = path;
            InstallArguments = installArguments;
            IsWindowsInstaller = isWindowsInstaller;
            IsISOImage = isIsoImage;
        }

        /// <summary>
        /// Create a new application with the specified name and path.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        public Application(string name, string path) : this(name, "", path, "", false, false) { }

        /// <summary>
        /// Create a new application with the specified name, path, and install arguments.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        /// <param name="installArguments"></param>
        public Application(string name, string path, string installArguments) : this(name, "", path, installArguments, false, false) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        /// <param name="installArguments"></param>
        /// <param name="isWindowsInstaller"></param>
        /// <param name="isIsoImage"></param>
        public Application(string name, string path, string installArguments, bool isWindowsInstaller, bool isIsoImage) : this(name, path, installArguments)
        {
            IsWindowsInstaller = isWindowsInstaller;
            IsISOImage = isIsoImage;
        }
    }
}
