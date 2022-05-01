using System.Net;
using System.Security;
using System.Text;
using System.Xml.Serialization;

namespace OnboardingHelper_NetCore.wrappers
{
    [XmlType("mapped-drive")]
    public class MappedDrive
    {
        [XmlAttribute("drive-letter")]
        public DriveLetter DriveLetter { get; set; } = DriveLetter.Z;

        [XmlElement("drive-path")]
        public string Path { get; set; } = string.Empty;

        [XmlElement("username")]
        public string Username { get; set; } = string.Empty;

        [XmlIgnore()]
        public SecureString Password { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;

        [XmlElement("password")]
        public string Base64Password { get; set; } = string.Empty;

        [XmlElement("assign-next-letter")]
        public bool AssignNextAvailableLetter { get; set; } = false;

        [XmlElement("persistent")]
        public bool ReconnectAtSignIn { get; set; } = true;

        [XmlElement("use-different-creds")]
        public bool ConnectUsingDifferentCredentials { get; set; } = false;

        public MappedDrive() { }

        public void SetBase64Password()
        {
            if (Password.Length != 0)
                Base64Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(
                    Utility.ConvertToUnsecureString(Password)));
        }

        public void SetPasswordFromBase64()
        {
            if (!Base64Password.Equals(string.Empty))
                Password = new NetworkCredential("",
                    Encoding.UTF8.GetString(Convert.FromBase64String(Base64Password))).SecurePassword;
        }

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

        public MappedDrive(DriveLetter driveLetter, string path, bool assignNextAvailableLetter, bool reconnectAtSignIn, bool connectUsingDifferentCredentials)
        {
            DriveLetter = driveLetter;
            Path = path ?? throw new ArgumentNullException(nameof(path));
            AssignNextAvailableLetter = assignNextAvailableLetter;
            ReconnectAtSignIn = reconnectAtSignIn;
            ConnectUsingDifferentCredentials = connectUsingDifferentCredentials;
        }

        public MappedDrive(DriveLetter driveLetter, string path, bool reconnectAtSignIn, bool connectUsingDifferentCredentials)
        {
            DriveLetter = driveLetter;
            Path = path ?? throw new ArgumentNullException(nameof(path));
            ReconnectAtSignIn = reconnectAtSignIn;
            ConnectUsingDifferentCredentials = connectUsingDifferentCredentials;
        }

        public MappedDrive(DriveLetter driveLetter, string path, string username, SecureString password, bool connectUsingDifferentCredentials)
        {
            DriveLetter = driveLetter;
            Path = path ?? throw new ArgumentNullException(nameof(path));
            Username = username;
            Password = password;
            SetBase64Password();
            ConnectUsingDifferentCredentials = connectUsingDifferentCredentials;
        }

        public MappedDrive(DriveLetter driveLetter, string path, bool reconnectAtSignIn)
        {
            DriveLetter = driveLetter;
            Path = path ?? throw new ArgumentNullException(nameof(path));
            ReconnectAtSignIn = reconnectAtSignIn;
        }

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
        A, B, C, D, E, F, G, H,
        I, J, K, L, M, N, O, P,
        Q, R, S, T, U, V, W, X,
        Y, Z
    }
}
