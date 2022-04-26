using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;

namespace OnboardingHelper_NetCore.wrappers
{
    public class Account
    {
        public string Username { get; set; } = string.Empty;

        public SecureString Password { get; set; } = new NetworkCredential("", string.Empty).SecurePassword;

        public string Comment { get; set; } = string.Empty;

        public AccountType AccountType { get; set; } = AccountType.STANDARD_USER;

        public bool DoesPasswordExpire { get; set; } = false;

        public bool RequirePasswordChange { get; set; } = false;

        public Account() { }

        /// <summary>
        /// Create a new account with the specified username, password (<see cref="SecureString"/>), comment, account type, and whether or not password expires and/or requires change.
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
            Comment = comment;
            AccountType = accountType;
            DoesPasswordExpire = passwordExpires;
            RequirePasswordChange = requirePasswordChange;
        }

        /// <summary>
        /// Create a new account with the specified username, password (<see cref="string"/>), comment, account type, and whether or not password expires and/or requires change.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="comment"></param>
        /// <param name="accountType"></param>
        /// <param name="passwordExpires"></param>
        /// <param name="requirePasswordChange"></param>
        public Account(string username, string password, string comment, AccountType accountType, bool passwordExpires, bool requirePasswordChange)
        {
            Username = username;
            Password = new NetworkCredential("", password).SecurePassword;
            Comment = comment;
            AccountType = accountType;
            DoesPasswordExpire = passwordExpires;
            RequirePasswordChange = requirePasswordChange;
        }

        /// <summary>
        /// Create a new account with the specified username, password (<see cref="SecureString"/>), account type, and whether or not password expires and/or requires change.
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
            Comment = string.Empty;
            AccountType = accountType;
            DoesPasswordExpire = passwordExpires;
            RequirePasswordChange = requirePasswordChange;
        }

        /// <summary>
        /// Create a new account with the specified username, password (<see cref="string"/>), account type, and whether or not password expires and/or requires change.
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
            Comment = string.Empty;
            AccountType = accountType;
            DoesPasswordExpire = passwordExpires;
            RequirePasswordChange = requirePasswordChange;
        }

        /// <summary>
        /// Create a new account with the specified username, password, and account type.
        /// <para><see cref="DoesPasswordExpire"/> and <see cref="RequirePasswordChange"/> default to <c>false</c>.</para>
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="accountType"></param>
        public Account(string username, SecureString password, AccountType accountType) : this(username, password, accountType, false, false) { }

        /// <summary>
        /// Gets an unsecure version of the encrypted password string.
        /// </summary>
        /// <param name="password"></param>
        /// <returns>A decrypted <see cref="string"/> version of the encrypted <see cref="SecureString"/> password.</returns>
        public string ConvertPasswordToUnsecureString(SecureString password)
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(password);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

        /// <summary>
        /// Gets an unsecure version of the encrypted password string.
        /// </summary>
        /// <param name="password"></param>
        /// <returns>A decrypted <see cref="string"/> version of the encrypted <see cref="SecureString"/> password.</returns>
        public string ConvertPasswordToUnsecureString()
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(Password);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

    }

    public enum AccountType
    {
        [Description("Standard User")]
        STANDARD_USER = 2,
        [Description("Administrator")]
        ADMINISTRATOR = 4
    }
}
