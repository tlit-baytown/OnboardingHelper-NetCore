using System.ComponentModel;
using System.Net;
using System.Security;
using System.Text;
using System.Xml.Serialization;

namespace Zest_Script.wrappers
{
    /// <summary>
    /// Represents a drive mapping to shared network resource.
    /// </summary>
    [XmlType("mapped-drive")]
    public class MappedDrive
    {
        /// <summary>
        /// The <see cref="wrappers.DriveLetter"/> to use for this drive mapping, if applicable (i.e. <see cref="AssignNextAvailableLetter"/> is <c>false</c>.
        /// </summary>
        [XmlAttribute("drive-letter")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The drive letter that will be used for this drive mapping. If 'Assign Next Available Letter' is true, this letter has no meaning.")]
        [DisplayName("Drive Letter")]
        [Category("Drive Mapping")]
        public DriveLetter DriveLetter { get; set; } = DriveLetter.Z;

        /// <summary>
        /// The path to a share or folder to map on the <see cref="DriveLetter"/> or next available letter if <see cref="AssignNextAvailableLetter"/> is <c>true</c>.
        /// </summary>
        [XmlElement("drive-path")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The path to a share or folder to map on the 'Drive Letter'.")]
        [DisplayName("Path")]
        [Category("Drive Mapping")]
        public string Path { get; set; } = string.Empty;

        /// <summary>
        /// The username used to connect to the shared drive, if applicable (i.e. <see cref="ConnectUsingDifferentCredentials"/> is <c>true</c>.
        /// </summary>
        [XmlElement("username")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The username that is used to connect to the shared drive.")]
        [DisplayName("Username")]
        [Category("Drive Mapping")]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// A secure version of the user's password, if applicable (i.e. <see cref="ConnectUsingDifferentCredentials"/> is <c>true</c>.
        /// </summary>
        [XmlIgnore()]
        [Browsable(false)]
        public SecureString Password { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;

        /// <summary>
        /// The base64 representation of <see cref="Password"/> for display and saving in the configuration.
        /// </summary>
        [XmlElement("password")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("A representation of the password (in base64) that is used to connect to the shared drive.")]
        [DisplayName("Password")]
        [Category("Drive Mapping")]
        public string Base64Password { get; set; } = string.Empty;

        /// <summary>
        /// Indicates whether this drive mapping should use the next available letter on the user's operating system.
        /// <para>If <c>true</c>, <see cref="DriveLetter"/> is not used.</para>
        /// </summary>
        [XmlElement("assign-next-letter")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates whether this drive mapping should use the next available letter on the user's operating system.")]
        [DisplayName("Assign Next Available Letter?")]
        [Category("Drive Mapping")]
        public bool AssignNextAvailableLetter { get; set; } = false;

        /// <summary>
        /// Indicates whether this drive mapping should attempt to reconnect on user's sign-in.
        /// </summary>
        [XmlElement("persistent")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates whether this drive mapping should attempt to reconnect on user's sign-in.")]
        [DisplayName("Persistent?")]
        [Category("Drive Mapping")]
        public bool ReconnectAtSignIn { get; set; } = true;

        /// <summary>
        /// Indicates whether to use the currently logged in user's credentials to attempt connection to the shared drive.
        /// </summary>
        [XmlElement("use-different-creds")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates whether to use the currently logged in user's credentials to attempt connection to the shared drive.")]
        [DisplayName("Connect Using Different Credentials?")]
        [Category("Drive Mapping")]
        public bool ConnectUsingDifferentCredentials { get; set; } = false;

        /// <summary>
        /// Create an empty mapped drive.
        /// </summary>
        public MappedDrive() { }

        /// <summary>
        /// Set the base64 version of the user's password if <see cref="Password"/> is not empty.
        /// </summary>
        public void SetBase64Password()
        {
            if (Password.Length != 0)
                Base64Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(
                    Utility.ConvertToUnsecureString(Password)));
        }

        /// <summary>
        /// Set the secure version of the user's password if <see cref="Base64Password"/> is not empty.
        /// </summary>
        public void SetPasswordFromBase64()
        {
            if (!Base64Password.Equals(string.Empty))
                Password = new NetworkCredential("",
                    Encoding.UTF8.GetString(Convert.FromBase64String(Base64Password))).SecurePassword;
        }

        /// <summary>
        /// Create a new mapped drive with the supplied arguments.
        /// </summary>
        /// <param name="driveLetter"></param>
        /// <param name="path"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="assignNextAvailableLetter"></param>
        /// <param name="reconnectAtSignIn"></param>
        /// <param name="connectUsingDifferentCredentials"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public MappedDrive(DriveLetter driveLetter, string path, string username, SecureString password, bool assignNextAvailableLetter, bool reconnectAtSignIn, bool connectUsingDifferentCredentials)
        {
            DriveLetter = driveLetter;
            Path = path ?? throw new ArgumentNullException(nameof(path));
            Username = username;
            Password = password;
            SetBase64Password();
            AssignNextAvailableLetter = assignNextAvailableLetter;
            ReconnectAtSignIn = reconnectAtSignIn;
            ConnectUsingDifferentCredentials = connectUsingDifferentCredentials;
        }

        /// <summary>
        /// Create a new mapped drive with the supplied arguments.
        /// </summary>
        /// <param name="driveLetter"></param>
        /// <param name="path"></param>
        /// <param name="assignNextAvailableLetter"></param>
        /// <param name="reconnectAtSignIn"></param>
        /// <param name="connectUsingDifferentCredentials"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public MappedDrive(DriveLetter driveLetter, string path, bool assignNextAvailableLetter, bool reconnectAtSignIn, bool connectUsingDifferentCredentials)
        {
            DriveLetter = driveLetter;
            Path = path ?? throw new ArgumentNullException(nameof(path));
            AssignNextAvailableLetter = assignNextAvailableLetter;
            ReconnectAtSignIn = reconnectAtSignIn;
            ConnectUsingDifferentCredentials = connectUsingDifferentCredentials;
        }

        /// <summary>
        /// Create a new mapped drive with the supplied arguments.
        /// </summary>
        /// <param name="driveLetter"></param>
        /// <param name="path"></param>
        /// <param name="reconnectAtSignIn"></param>
        /// <param name="connectUsingDifferentCredentials"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public MappedDrive(DriveLetter driveLetter, string path, bool reconnectAtSignIn, bool connectUsingDifferentCredentials)
        {
            DriveLetter = driveLetter;
            Path = path ?? throw new ArgumentNullException(nameof(path));
            ReconnectAtSignIn = reconnectAtSignIn;
            ConnectUsingDifferentCredentials = connectUsingDifferentCredentials;
        }

        /// <summary>
        /// Create a new mapped drive with the supplied arguments.
        /// </summary>
        /// <param name="driveLetter"></param>
        /// <param name="path"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="connectUsingDifferentCredentials"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public MappedDrive(DriveLetter driveLetter, string path, string username, SecureString password, bool connectUsingDifferentCredentials)
        {
            DriveLetter = driveLetter;
            Path = path ?? throw new ArgumentNullException(nameof(path));
            Username = username;
            Password = password;
            SetBase64Password();
            ConnectUsingDifferentCredentials = connectUsingDifferentCredentials;
        }

        /// <summary>
        /// Create a new mapped drive with the supplied arguments.
        /// </summary>
        /// <param name="driveLetter"></param>
        /// <param name="path"></param>
        /// <param name="reconnectAtSignIn"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public MappedDrive(DriveLetter driveLetter, string path, bool reconnectAtSignIn)
        {
            DriveLetter = driveLetter;
            Path = path ?? throw new ArgumentNullException(nameof(path));
            ReconnectAtSignIn = reconnectAtSignIn;
        }

        /// <summary>
        /// Create a new mapped drive with the supplied arguments.
        /// </summary>
        /// <param name="driveLetter"></param>
        /// <param name="path"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public MappedDrive(DriveLetter driveLetter, string path)
        {
            DriveLetter = driveLetter;
            Path = path ?? throw new ArgumentNullException(nameof(path));
        }
    }

    /// <summary>
    /// Represents valid drive letters for a mapped drive.
    /// </summary>
    public enum DriveLetter
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        A, B, C, D, E, F, G, H,
        I, J, K, L, M, N, O, P,
        Q, R, S, T, U, V, W, X,
        Y, Z
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
