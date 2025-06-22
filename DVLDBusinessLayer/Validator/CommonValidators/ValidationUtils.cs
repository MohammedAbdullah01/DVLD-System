using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer.CommonValidators
{
    public static class ValidationUtils
    {
        public static bool IsValidEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var add = new System.Net.Mail.MailAddress(email.Trim());
                return email == add.Address;
            }
            catch
            {

                return false ;
            }
        }

        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            phone = phone.Trim();   

            if(phone.Length != 11 || !phone.All(char.IsDigit))
                return false;

            string[] validPrefixes = { "010", "011", "012", "015" };

            foreach (string prefix in validPrefixes)
            {
                if(phone.StartsWith(prefix))
                    return true;
            }
            return false ;
        }

        public static bool IsValidDateOfBirth(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;

            if(dateOfBirth > today)
                return false;

            int age = today.Year - dateOfBirth.Year;

            if (dateOfBirth > today.AddYears(-age))
                age--;

            return age >= 18 && age <= 90;
        }
    }
}
