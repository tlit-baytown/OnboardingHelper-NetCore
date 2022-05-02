using System.ComponentModel;
using System.Net;
using System.Security;
using System.Text;
using System.Xml.Serialization;

namespace Zest_Script.wrappers
{
    /// <summary>
    /// Represents a user account.
    /// </summary>
    [XmlType("account")]
    public class Account
    {
        /// <summary>
        /// The username of the new account.
        /// </summary>
        [XmlAttribute("username")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The username of the new account.")]
        [DisplayName("Username")]
        [Category("Account Information")]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// The secure version of the user's password.
        /// </summary>
        [XmlIgnore()]
        [Browsable(false)]
        public SecureString Password { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;

        /// <summary>
        /// The base64 representation of the <see cref="Password"/> for displaying and saving.
        /// </summary>
        [XmlElement("password")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The base64 representation of the user's password.")]
        [DisplayName("Password")]
        [Category("Account Information")]
        public string Base64Password { get; set; } = string.Empty;

        /// <summary>
        /// An optional comment to be associated with the new account.
        /// </summary>
        [XmlElement("comment")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("A comment associated with the new account.")]
        [DisplayName("Comment")]
        [Category("Account Information")]
        public string Comment { get; set; } = string.Empty;

        /// <summary>
        /// The type of account to create. Defaults to <see cref="AccountType.STANDARD_USER"/>.
        /// </summary>
        [XmlElement("account-type")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The type of account to create. Default is STANDARD USER.")]
        [DisplayName("Account Type")]
        [Category("Account Information")]
        public AccountType AccountType { get; set; } = AccountType.STANDARD_USER;

        /// <summary>
        /// Should the user's password expire?
        /// </summary>
        [XmlElement("password-expires")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates whether or not this user's password should expire.")]
        [DisplayName("Password Expires?")]
        [Category("Account Information")]
        public bool DoesPasswordExpire { get; set; } = false;

        /// <summary>
        /// Is the user required to change their password on first login?
        /// </summary>
        [XmlElement("require-password-change")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Indicates whether or not the user should be required to change the password on first login.")]
        [DisplayName("Require Password Change?")]
        [Category("Account Information")]
        public bool RequirePasswordChange { get; set; } = false;

        /// <summary>
        /// Create a new empty account.
        /// </summary>
        public Account() { }

        /// <summary>
        /// Set the value for <see cref="Password"/> to the correct value depending on the base64 equivalent (<see cref="Base64Password"/>).
        /// </summary>
        public void SetPasswordFromBase64()
        {
            if (!Base64Password.Equals(string.Empty))
                Password = new NetworkCredential(Username,
                    Encoding.UTF8.GetString(Convert.FromBase64String(Base64Password))).SecurePassword;
        }

        /// <summary>
        /// Set the value for <see cref="Base64Password"/> to the correct value depending on the <see cref="Password"/> equivalent.
        /// </summary>
        public void SetBase64FromPassword()
        {
            if (Password.Length != 0)
                Base64Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(
                    Utility.ConvertToUnsecureString(Password)));
        }

        /// <summary>
        /// Create a new account with the specified arguments.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="base64Password"></param>
        /// <param name="comment"></param>
        /// <param name="accountType"></param>
        /// <param name="doesPasswordExpire"></param>
        /// <param name="requirePasswordChange"></param>
        public Account(string username, SecureString password, string base64Password, string comment, AccountType accountType, bool doesPasswordExpire, bool requirePasswordChange)
        {
            Username = username;
            Password = password;
            Base64Password = base64Password;
            Comment = comment;
            AccountType = accountType;
            DoesPasswordExpire = doesPasswordExpire;
            RequirePasswordChange = requirePasswordChange;
        }

        /// <summary>
        /// Create a new account with the specified arguments.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="comment"></param>
        /// <param name="accountType"></param>
        /// <param name="passwordExpires"></param>
        /// <param name="requirePasswordChange"></param>
        public Account(string username, SecureString password, string comment, AccountType accountType, bool passwordExpires, bool requirePasswordChange)
        {
            Username = username;
            Password = password;
            Base64Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(Utility.ConvertToUnsecureString(password)));
            Comment = comment;
            AccountType = accountType;
            DoesPasswordExpire = passwordExpires;
            RequirePasswordChange = requirePasswordChange;
        }

        /// <summary>
        /// Create a new account with the specified arguments.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="base64Password"></param>
        /// <param name="comment"></param>
        /// <param name="accountType"></param>
        /// <param name="passwordExpires"></param>
        /// <param name="requirePasswordChange"></param>
        public Account(string username, string base64Password, string comment, AccountType accountType, bool passwordExpires, bool requirePasswordChange)
        {
            Username = username;
            Password = new NetworkCredential("", Encoding.UTF8.GetString(Convert.FromBase64String(base64Password))).SecurePassword;
            Base64Password = base64Password;
            Comment = comment;
            AccountType = accountType;
            DoesPasswordExpire = passwordExpires;
            RequirePasswordChange = requirePasswordChange;
        }

        /// <summary>
        /// Create a new account with the specified arguments.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="accountType"></param>
        /// <param name="passwordExpires"></param>
        /// <param name="requirePasswordChange"></param>
        public Account(string username, SecureString password, AccountType accountType, bool passwordExpires, bool requirePasswordChange)
        {
            Username = username;
            Password = password;
            Base64Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(Utility.ConvertToUnsecureString(password)));
            Comment = string.Empty;
            AccountType = accountType;
            DoesPasswordExpire = passwordExpires;
            RequirePasswordChange = requirePasswordChange;
        }

        /// <summary>
        /// Create a new account with the specified arguments.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="accountType"></param>
        /// <param name="passwordExpires"></param>
        /// <param name="requirePasswordChange"></param>
        public Account(string username, string password, AccountType accountType, bool passwordExpires, bool requirePasswordChange)
        {
            Username = username;
            Password = new NetworkCredential("", password).SecurePassword;
            Base64Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
            Comment = string.Empty;
            AccountType = accountType;
            DoesPasswordExpire = passwordExpires;
            RequirePasswordChange = requirePasswordChange;
        }

        /// <summary>
        /// Create a new account with the specified arguments.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="accountType"></param>
        public Account(string username, SecureString password, AccountType accountType) : this(username, password, accountType, false, false) { }

    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Represents valid account types.
    /// </summary>
    public enum AccountType
    {
        [Description("Standard User")]
        STANDARD_USER = 2,
        [Description("Administrator")]
        ADMINISTRATOR = 4
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
