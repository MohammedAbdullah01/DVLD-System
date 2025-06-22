using DVLDBusinessLayer.CommonValidators;
using DVLDBusinessLayer.Interface;
using DVLDBusinessLayer.Validator;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer.Person.Validator
{
    internal class PersonValidator : IValidator<clsPerson>
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        public ValidationResult Validate(clsPerson entity)
        {
           ValidationResult result = new ValidationResult { IsValid = true };

            if (entity == null)
            {
                result.AddErrors("Person object cannot be null.");
                return result;
            }

            if(string.IsNullOrWhiteSpace(entity.FirstName))
                result.AddErrors("First Name is required");

            if (string.IsNullOrWhiteSpace(entity.FatherName))
                result.AddErrors("Father Name is required");

            if (string.IsNullOrWhiteSpace(entity.MiddleName))
                result.AddErrors("Middle Name is required");

            if (string.IsNullOrWhiteSpace(entity.LastName))
                result.AddErrors("Last Name is required");

            if (string.IsNullOrWhiteSpace(entity.NationalNo))
                result.AddErrors("National No is required");

            if (string.IsNullOrWhiteSpace(entity.Phone))
                result.AddErrors("Phone is required");

            if (!ValidationUtils.IsValidEmail(entity.Email))
                result.AddErrors("Invalid email format");

            if (entity.Gender != 'M' && entity.Gender != 'F')
                result.AddErrors("Gender must be Male (M) or Female (F)");

            if(!ValidationUtils.IsValidDateOfBirth(entity.DateOfBirth))
                result.AddErrors("Invalid date of birth");

            if (!ValidationUtils.IsValidPhone(entity.Phone))
                result.AddErrors("Invalid phone number");

            if (!result.IsValid)
                _logger.Debug($"Person validation failed. PersonID: {entity.PersonID}, " +
                    $"Errors: {string.Join(", ", result.Errors)}");

            return result;
        }
    }
}
