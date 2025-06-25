using DVLDBusinessLayer.CommonValidators;
using DVLDBusinessLayer.Interface;
using DVLDBusinessLayer.Validator;
using DVLDDataAccessLayer.Person;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer.Person.Validator
{
    public class PersonValidator : IValidator<clsPerson>
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

        private void ValidateNationalNumberUniqueness(clsPerson person, ValidationResult result)
        {
            if(person.Mode == clsPerson.enMode.AddNew && 
                clsPersonDataAccess.IsPersonExistsNationalNumber(person.NationalNo))
            {
                result.AddErrors("National Number already exists");

                _logger.Warn($"Duplicate national number registration attempted. " +
                    $"NationalNo: {person.NationalNo}");
            }

            if (person.Mode == clsPerson.enMode.Update)
            {
                clsPerson existingPerson = clsPerson.Find(person.NationalNo);
                if (existingPerson != null && existingPerson.PersonID != person.PersonID)
                {
                    result.AddErrors("National Number already exists for another person");

                    _logger.Warn($"National number conflict during update. PersonID: " +
                        $"{person.PersonID}, NationalNo: {person.NationalNo}, " +
                        $"ConflictingPersonID: {existingPerson.PersonID}");
                }
            }
        }

        private void ValidatePhoneUniqueness(clsPerson person , ValidationResult result)
        {
            if (string.IsNullOrWhiteSpace(person.Phone))
                return;

            if(person.Mode == clsPerson.enMode.AddNew && 
                clsPersonDataAccess.IsPersonExistsPhone(person.Phone))
            {
                result.AddErrors("Phone number already exists");

                _logger.Warn($"Duplicate phone number registration attempted. Phone: {person.Phone}");
            }


        }
    }
}
