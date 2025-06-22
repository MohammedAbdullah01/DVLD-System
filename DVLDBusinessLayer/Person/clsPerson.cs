using DVLDDataAccessLayer.Person;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer.Person
{
    public class clsPerson : clsPersonInfo
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public enum enMode { AddNew , Update}
        public enMode Mode { get; set; } = enMode.AddNew;

        public clsPerson()
        {
            PersonID = 0;
            FirstName = string.Empty;
            FatherName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            NationalNo = string.Empty;
            DateOfBirth = DateTime.Now;
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            Gender = ' ';
            ProfilePicture = string.Empty;
            Mode = enMode.AddNew;

            logger.Debug("New clsPerson instance created in AddNew mode");
        }

        private clsPerson(clsPersonInfo personInfo)
        {
            PersonID = personInfo.PersonID;
            FirstName = personInfo.FirstName;
            FatherName = personInfo.FatherName;
            MiddleName = personInfo.MiddleName;
            LastName = personInfo.LastName;
            NationalNo = personInfo.NationalNo;
            DateOfBirth = personInfo.DateOfBirth;
            Address = personInfo.Address;
            Phone = personInfo.Phone;
            Email = personInfo.Email;
            Gender = personInfo.Gender;
            ProfilePicture = personInfo.ProfilePicture;
            Mode = enMode.Update;

            logger.Debug($"clsPerson loaded from database - ID: {PersonID}, National No: {NationalNo}");
        }

        public static clsPerson Find(int personID)
        {
            logger.Info($"Attempting to find person with ID: {personID}");

            if (personID <= 0)
            {
                logger.Error("Invalid person ID provided. Must be greater than 0.");
                return null;
            }

            try
            {
                PersonInfoResult result = clsPersonDataAccess.GetPersonInfoByID(personID);

                if (result.Found && result != null)
                {
                    logger.Info($"Person found successfully - ID: {result.Person.PersonID}, " +
                        $"Name: {result.Person.FirstName}");

                    return new clsPerson(result.Person);
                }
                logger.Warn($"Person with ID {personID} not found.");
                return null;

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Error occurred while finding person by ID: {personID}");
                return null;
            }
        }

        public static clsPerson Find(string nationalNo)
        {
            logger.Info($"Attempting to find person by nationalNo: {nationalNo}");

            if (string.IsNullOrEmpty(nationalNo))
            {
                logger.Error("Empty or null National Number provided");
                return null;
            }

            try
            {
                PersonInfoResult result = clsPersonDataAccess.GetPersonInfoByNationalNo(nationalNo);

                if (result.Found && result != null)
                {
                    logger.Info($"Person found successfully - NationalNo: {result.Person.NationalNo}, " +
                        $"ID: {result.Person.PersonID}");

                    return new clsPerson(result.Person);
                }
                logger.Warn($"Person with NationalNo {nationalNo} not found.");
                return null;

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Error occurred while finding person by NationalNo: {nationalNo}");
                return null;
            }
        }

         
    }
}
