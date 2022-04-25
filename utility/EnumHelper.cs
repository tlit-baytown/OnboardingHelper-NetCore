using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnboardingHelper_NetCore.EnumHelper;

namespace OnboardingHelper_NetCore
{
    public class EnumHelper
    {
        public enum ErrorCodes
        {
            [Description("")]
            NO_ERROR = 0,
            [Description("The application has already been added to the collection.")]
            APPLICATION_ALREADY_EXISTS = 2,
            [Description("The application is not present in the collection.")]
            APPLICATION_DOES_NOT_EXIST = 4,
            [Description("The account has already been added to the collection.")]
            ACCOUNT_ALREADY_EXISTS = 8,
            [Description("The account is not present in the collection.")]
            ACCOUNT_DOES_NOT_EXIST = 16
        }
    }

    public static class EnumExtensions
    {
        public static string ToDescriptionString(this ErrorCodes val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
