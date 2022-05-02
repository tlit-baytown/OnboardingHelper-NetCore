using System.ComponentModel;
using System.Xml.Serialization;

namespace Zest_Script.wrappers
{
    /// <summary>
    /// Represents an Application that is to be installed on the computer. This class cannot be inherited.
    /// </summary>
    [XmlType("application")]
    public sealed class Application
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
        [DisplayName("Path")]
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
        public FileStream? File
        {
            get
            {
                try
                {
                    if (System.IO.File.Exists(Path))
                        return System.IO.File.OpenRead(Path);
                    else
                        return null;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.EventLog.WriteEntry("Application", $"There was an error reading application data: {ex.Message}",
                        System.Diagnostics.EventLogEntryType.Warning);
                    return null;
                }
            }
        }

        /// <summary>
        /// Create a new empty application.
        /// </summary>
        public Application() { }

        /// <summary>
        /// Create a new application with the specified arguments.
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
        /// Create a new application with the specified arguments.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        public Application(string name, string path) : this(name, "", path, "", false, false) { }

        /// <summary>
        /// Create a new application with the specified arguments.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        /// <param name="installArguments"></param>
        public Application(string name, string path, string installArguments) : this(name, "", path, installArguments, false, false) { }

        /// <summary>
        /// Create a new application with the specified arguments.
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

        /// <summary>
        /// Get a byte array representing the file's data.
        /// </summary>
        /// <returns>A byte array with the file's contents or <c>null</c> if the file could not be read.</returns>
        public byte[]? GetFileData()
        {
            try
            {
                if (File != null)
                {
                    byte[] buffer = new byte[File.Length];
                    File.Read(buffer, 0, buffer.Length);

                    return buffer;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application", $"There was an error reading application data: {ex.Message}",
                        System.Diagnostics.EventLogEntryType.Warning);
            }
            return null;
        }

        /// <summary>
        /// Get a base64 string representing the file's data.
        /// </summary>
        /// <returns>A base64 string or an empty string if the file could not be read.</returns>
        public string GetBase64String()
        {
            byte[]? data = GetFileData();
            if (data == null)
                return string.Empty;

            return Convert.ToBase64String(data);
        }
    }
}
