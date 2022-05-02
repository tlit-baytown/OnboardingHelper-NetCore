using System.ComponentModel;
using System.Reflection;
using static Zest_Script.EnumHelper;

namespace Zest_Script
{
    /// <summary>
    /// Class that holds Enum classes and extension methods.
    /// </summary>
    public sealed class EnumHelper
    {
        /// <summary>
        /// Represents the various codes that can be returned by methods.
        /// </summary>
        public enum ReturnCodes
        {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
            [Description("No error has occured.")]
            NO_ERROR = 0,
            [Description("The application has already been added to the collection.")]
            APPLICATION_ALREADY_EXISTS = 2,
            [Description("The application is not present in the collection.")]
            APPLICATION_DOES_NOT_EXIST = 4,
            [Description("The account has already been added to the collection.")]
            ACCOUNT_ALREADY_EXISTS = 8,
            [Description("The account is not present in the collection.")]
            ACCOUNT_DOES_NOT_EXIST = 16,
            [Description("The WiFi profile has already been added to the collection.")]
            WIFI_ALREADY_EXISTS = 32,
            [Description("The WiFi profile is not present in the collection.")]
            WIFI_DOES_NOT_EXIST = 64,
            [Description("The VPN profile has already been added to the collection.")]
            VPN_ALREADY_EXISTS = 128,
            [Description("The VPN profile is not present in the collection.")]
            VPN_DOES_NOT_EXIST = 256,
            [Description("The RDP file has already been added to the collection.")]
            RDP_ALREADY_EXISTS = 512,
            [Description("The RDP file is not present in the collection.")]
            RDP_DOES_NOT_EXIST = 1024,
            [Description("The drive mapping has already been added to the collection.")]
            MAPPED_DRIVE_ALREADY_EXISTS = 2048,
            [Description("The drive mapping is not present in the collection.")]
            MAPPED_DRIVE_DOES_NOT_EXIST = 4096,
            [Description("The printer has already been added to the collection.")]
            PRINTER_ALREADY_EXISTS = 8192,
            [Description("The printer is not present in the collection.")]
            PRINTER_DOES_NOT_EXIST = 16384
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }

    /// <summary>
    /// Extension methods for Enums defined in <see cref="EnumHelper"/>.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Get the description string associated with the specified <see cref="ReturnCodes"/> value.
        /// </summary>
        /// <param name="val"></param>
        /// <returns>The description of the value or <c>null</c> if the <see cref="DescriptionAttribute"/> attribute was not found.</returns>
        public static string? ToDescriptionString(this ReturnCodes val)
        {
            Type t = val.GetType();
            try
            {
                FieldInfo? fInfo = t.GetField(val.ToString());
                if (fInfo != null)
                {
                    object[]? customAttributes = fInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                    if (customAttributes != null)
                    {
                        DescriptionAttribute[] attributes = (DescriptionAttribute[])customAttributes;
                        return attributes.Length > 0 ? attributes[0].Description : null;
                    }
                }
            }
            catch (Exception ex) when (ex is TypeLoadException || ex is ArgumentNullException
                  || ex is InvalidOperationException || ex is NotSupportedException)
            {
                System.Diagnostics.EventLog.WriteEntry("Application",
                    $"Exception occured in Zest Script while attempting to read description attribute of value: {ex.Message}",
                    System.Diagnostics.EventLogEntryType.Error);
            }
            return null;
        }
    }
}
