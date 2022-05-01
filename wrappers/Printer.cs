using System.Xml.Serialization;

namespace OnboardingHelper_NetCore.wrappers
{
    //See: https://www.action1.com/blog/2020/01/03/how-to-install-and-remove-printer-with-powershell-on-windows/
    [XmlType("printer")]
    public class Printer
    {
        [XmlAttribute("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The comment to associate with this printer.
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; } = string.Empty;

        /// <summary>
        /// The name of the driver to install this printer with.
        /// <para>This driver MUST exist in the computer's driver store. If it doesn't, <see cref="ShouldCreateDriver"/> should be true
        /// so the program can create the driver.</para>
        /// </summary>
        [XmlElement("driver-name")]
        public string DriverName { get; set; } = string.Empty;

        /// <summary>
        /// The path to an <c>.inf</c> file containing printer driver information.
        /// <para>If empty, the program will assume the driver is already installed and will attempt to 
        /// install the printer using <see cref="DriverName"/>.</para>
        /// </summary>
        [XmlElement("inf-driver")]
        public string INFPath { get; set; } = string.Empty;

        /// <summary>
        /// The hostname or IP address of the printer to install.
        /// </summary>
        [XmlElement("hostname")]
        public string Hostname { get; set; } = string.Empty;

        /// <summary>
        /// Specifies the name of the port that is used or created for the printer.
        /// </summary>
        [XmlElement("port-name")]
        public string PortName { get; set; } = string.Empty;

        /// <summary>
        /// If printer to add is a shared network printer, specifies the name of the printer to connect to.
        /// <para>This should be in the form: \\server\printer</para>
        /// </summary>
        [XmlElement("connection-name")]
        public string ConnectionName { get; set; } = string.Empty;

        /// <summary>
        /// Specifies the name to share the printer with if <see cref="IsShared"/> is <c>true</c>.
        /// </summary>
        [XmlElement("share-name")]
        public string ShareName { get; set; } = string.Empty;

        /// <summary>
        /// Should this printer be shared on the network?
        /// </summary>
        [XmlElement("shared")]
        public bool IsShared { get; set; } = false;

        /// <summary>
        /// Should the driver be created from the <see cref="INFPath"/>?
        /// <para>This should be false if <see cref="INFPath"/> is <c>empty</c>, a non-existent path, or already exists on the system.</para>
        /// </summary>
        [XmlElement("create-driver")]
        public bool ShouldCreateDriver { get; set; } = false;

        public Printer() { }

        public Printer(string name, string comment, string driverName, string iNFPath, string hostname, string portName, string connectionName, string shareName, bool isShared, bool shouldCreateDriver)
        {
            Name = name;
            Comment = comment;
            DriverName = driverName;
            INFPath = iNFPath;
            Hostname = hostname;
            PortName = portName;
            ConnectionName = connectionName;
            ShareName = shareName;
            IsShared = isShared;
            ShouldCreateDriver = shouldCreateDriver;
        }
    }
}
