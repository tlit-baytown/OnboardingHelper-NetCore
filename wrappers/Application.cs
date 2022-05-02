using System.ComponentModel;
using System.Xml.Serialization;

namespace OnboardingHelper_NetCore.wrappers
{
    [XmlType("application")]
    /// <summary>
    /// Structure to represent an Application that is to be installed on the computer.
    /// </summary>
    public class Application
    {
        /// <summary>
        /// The name of the application.
        /// </summary>
        [XmlAttribute("name")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The name of the application.")]
        [DisplayName("Name")]
        [Category("Application Information")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// An optional description of the application.
        /// </summary>
        [XmlElement("description")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("An optional description of the application.")]
        [DisplayName("Description")]
        [Category("Application Information")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The full path to the application file to be installed.
        /// </summary>
        [XmlElement("path")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The full path to the application file to be installed.")]
        [DisplayName("Name")]
        [Category("Application Information")]
        public string Path { get; set; } = string.Empty;

        /// <summary>
        /// The installation arguments needed for installation via command line.
        /// </summary>
        [XmlElement("install-arguments")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The installation arguments needed for installation via command line.")]
        [DisplayName("Install Arguments")]
        [Category("Application Information")]
        public string InstallArguments { get; set; } = string.Empty;

        /// <summary>
        /// Is the installer file an .MSI file (windows installer)?
        /// <para>If <c>false</c>, the application is assumed to be an .EXE file.</para>
        /// </summary>
        [XmlElement("is-msi")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Is the installer file an .MSI file (windows installer)?")]
        [DisplayName("Is Windows Installer (.msi)?")]
        [Category("Application Information")]
        public bool IsWindowsInstaller { get; set; } = false;

        /// <summary>
        /// Is the installer an ISO disk image? (such is the case for Microsoft Office 2019)
        /// </summary>
        [XmlElement("is-iso-image")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Is the installer an ISO disk image?")]
        [DisplayName("Is ISO Image (.iso)?")]
        [Category("Application Information")]
        public bool IsISOImage { get; set; } = false;

        /// <summary>
        /// Provides a <see cref="FileStream"/> object that represents this application.
        /// </summary>
        [XmlIgnore()]
        [Browsable(false)]
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

        public Application() { }

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

        public byte[] GetFileData()
        {
            using (File)
            {
                return System.IO.File.ReadAllBytes(Path);
            }
        }

        public string GetBase64String()
        {
            byte[] data = GetFileData();
            return Convert.ToBase64String(data);
        }
    }
}
