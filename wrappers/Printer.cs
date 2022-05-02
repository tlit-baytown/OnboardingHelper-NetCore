using System.ComponentModel;
using System.Xml.Serialization;

namespace Zest_Script.wrappers
{
    //See: https://www.action1.com/blog/2020/01/03/how-to-install-and-remove-printer-with-powershell-on-windows/
    /// <summary>
    /// Represents a printer to install.
    /// </summary>
    [XmlType("printer")]
    public class Printer
    {
        /// <summary>
        /// The name of this printer as it should appear in the control panel and dialogs.
        /// </summary>
        [XmlAttribute("name")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The name of this printer as it should appear in the control panel and dialogs.")]
        [DisplayName("Name")]
        [Category("Printer Information")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The comment to associate with this printer.
        /// </summary>
        [XmlElement("comment")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("An optional comment that can be associated with this printer.")]
        [DisplayName("Comment")]
        [Category("Printer Information")]
        public string Comment { get; set; } = string.Empty;

        /// <summary>
        /// The name of the driver to install this printer with.
        /// <para>This driver MUST exist in the computer's driver store. If it doesn't, <see cref="ShouldCreateDriver"/> should be true
        /// so the program can create the driver.</para>
        /// </summary>
        [XmlElement("driver-name")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The name of the driver to install this printer with.\nThis driver MUST exist in the computer's driver store." +
            " If it doesnt, 'Create Driver' should be true so that a driver with this name can be created.")]
        [DisplayName("Driver Name")]
        [Category("Printer Information")]
        public string DriverName { get; set; } = string.Empty;

        /// <summary>
        /// The path to an <c>.inf</c> file containing printer driver information.
        /// <para>If empty, the program will assume the driver is already installed and will attempt to 
        /// install the printer using <see cref="DriverName"/>.</para>
        /// </summary>
        [XmlElement("inf-driver")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The path to an .inf file containing information about the printer driver.\nIf empty, " +
            "the program will assume the driver is already installed and will attempt to install the printer using 'Driver Name'.")]
        [DisplayName("INF Path")]
        [Category("Printer Information")]
        public string INFPath { get; set; } = string.Empty;

        /// <summary>
        /// The hostname or IP address of the printer to install.
        /// </summary>
        [XmlElement("hostname")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The hostname or IP address of the printer to install.")]
        [DisplayName("Hostname/IP")]
        [Category("Printer Information")]
        public string Hostname { get; set; } = string.Empty;

        /// <summary>
        /// Specifies the name of the port that is used or created for the printer.
        /// </summary>
        [XmlElement("port-name")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The name of the port that is used or created for the printer.")]
        [DisplayName("Port")]
        [Category("Printer Information")]
        public string PortName { get; set; } = string.Empty;

        /// <summary>
        /// If printer to add is a shared network printer, specifies the name of the printer to connect to.
        /// <para>This should be in the form: \\server\printer</para>
        /// </summary>
        [XmlElement("connection-name")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("If the printer is a shared network printer, this is the UNC path of the printer to connect to: \\\\server\\printer")]
        [DisplayName("Connection Name")]
        [Category("Printer Information")]
        public string ConnectionName { get; set; } = string.Empty;

        /// <summary>
        /// Specifies the name to share the printer with if <see cref="IsShared"/> is <c>true</c>.
        /// </summary>
        [XmlElement("share-name")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("If the printer is to be shared on the network, this is the name to share the printer with.")]
        [DisplayName("Share Name")]
        [Category("Printer Information")]
        public string ShareName { get; set; } = string.Empty;

        /// <summary>
        /// Should this printer be shared on the network?
        /// </summary>
        [XmlElement("shared")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates whether this printer is to be shared on the network.")]
        [DisplayName("Share Printer?")]
        [Category("Printer Information")]
        public bool IsShared { get; set; } = false;

        /// <summary>
        /// Should the driver be created from the <see cref="INFPath"/>?
        /// <para>This should be false if <see cref="INFPath"/> is <c>empty</c>, a non-existent path, or already exists on the system.</para>
        /// </summary>
        [XmlElement("create-driver")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates whether the printer driver should be created and installed. This value is automatically set based " +
            "on the value of 'INF Path'.")]
        [DisplayName("Create Driver?")]
        [Category("Printer Information")]
        public bool ShouldCreateDriver { get; set; } = false;

        /// <summary>
        /// Create an empty printer.
        /// </summary>
        public Printer() { }

        /// <summary>
        /// Create a new printer with the specified arguments.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="comment"></param>
        /// <param name="driverName"></param>
        /// <param name="iNFPath"></param>
        /// <param name="hostname"></param>
        /// <param name="portName"></param>
        /// <param name="connectionName"></param>
        /// <param name="shareName"></param>
        /// <param name="isShared"></param>
        /// <param name="shouldCreateDriver"></param>
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
