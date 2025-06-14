using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDPresentationLayer.GlobalClasses
{
    public class clsValidation
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidInteger(string number)
        {
            return int.TryParse(number, out _);
        }

        public static bool IsValidFloat(string number)
        {
            return float.TryParse(number, out _);
        }

        public static bool IsValidNumber(string number)
        {
            // This method checks if the string is a valid integer or float
            return IsValidInteger(number) || IsValidFloat(number);
        }
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Simple validation for phone number format (e.g., 123-456-7890)
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{3}-\d{3}-\d{4}$");
        }
        public static bool IsValidDate(DateTime date)
        {
            return date <= DateTime.Now;
        }
    }
}
