using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using static OnboardingHelper_NetCore.EnumHelper;

namespace OnboardingHelper_NetCore.wrappers
{
    public class AccountWrapper
    {
        /// <summary>
        /// Get the collection of accounts to create. This collection is Read-Only and can only be modified using the
        /// methods in <see cref="AccountWrapper"/>.
        /// </summary>
        public static IReadOnlyCollection<Account> Accounts { get { return accounts; } }

        private static List<Account> accounts = new List<Account>();

        public static ErrorCodes AddAccount(Account a)
        {
            if (accounts.Any(acct => acct.Username.Equals(a.Username)))
                return ErrorCodes.ACCOUNT_ALREADY_EXISTS;
            accounts.Add(a);
            return ErrorCodes.NO_ERROR;
        }

        public static ErrorCodes RemoveAccount(Account a)
        {
            if (accounts.Contains(a))
                accounts.Remove(a);
            else
                return ErrorCodes.ACCOUNT_DOES_NOT_EXIST;

            return ErrorCodes.NO_ERROR;
        }

        public static Account GetAccount(string username)
        {
            return accounts.FirstOrDefault(a => a.Username.Equals(username));
        }
    }

    public struct Account
    {
        public string Username { get; private set; }

        public SecureString Password { get; private set; }

        public string Comment { get; private set; }

        public AccountType AccountType { get; private set; }

        public bool DoesPasswordExpire { get; private set; }

        public bool RequirePasswordChange { get; private set; }

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
