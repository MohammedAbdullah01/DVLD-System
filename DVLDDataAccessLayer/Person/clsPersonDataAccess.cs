using DVLDDataAccessLayer.EntityMapperUtilities;
using DVLDDataAccessLayer.PersonAddresses;
using DVLDDataAccessLayer.Result_Helper;
using NLog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Policy;

namespace DVLDDataAccessLayer.Person
{
    public class clsPersonDataAccess
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private static readonly Dictionary<string, string> AllowedFields = new Dictionary<string, string>()
        {
            { "id", "id" },
            { "NationalNumber", "NationalNumber" },
            { "Phone", "Phone" },
            { "Email", "Email" }
        };
        public static clsPersonInfoResult GetPersonInfoByID(int personID)
        {
            if (personID <= 0)
            {
                logger.Warn($"Invalid PersonID provided: {personID}");
                return clsResultBuilder.BuildPersonResult(null , "Invalid PersonID provided: {personID}");
            }

            logger.Info($"Starting to Get Person Info By ID: {personID}");

            const string query = @"SELECT 
                                    P.*, 
                                    Pa.id as PersonAddresseID, Pa.BuildNo, Pa.Street, 
                                    Pa.CountryId, Pa.CityId, Pa.GovernorateId,
                                    Co.NameEn as CountryName,   
                                    Co.NameAr as CountryNameAr,
                                    Gv.NameEn as GovernorateName,
                                    Gv.NameAr as GovernorateNameAr,
                                    Ci.NameEn as CityName,
                                    Ci.NameAr as CityNameAr

                                FROM Persons P

                                INNER JOIN PersonAddresses Pa
                                ON P.id = Pa.PersonID

                                INNER JOIN Countries Co
                                ON Co.id = Pa.CountryId

                                INNER JOIN Governorates Gv
                                ON Gv.id = Pa.GovernorateId

                                INNER JOIN Cities Ci
                                ON Ci.id = Pa.CityId       

                                WHERE  P.id = @PersonID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
                    connection.Open();
                    logger.Debug($"Connection to database opened successfully for PersonID: {personID}");
                
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            clsPersonInfo personInfo = clsEntityMapper.MapReaderToPerson(reader);

                            LoggerDebugPersonInfoRetrieved(personInfo);

                            logger.Info($"Successfully retrieved person info for ID: {personID}");

                            return clsResultBuilder.BuildPersonResult(personInfo, 
                                $"Person found with ID: {personID}");
                        }

                        logger.Warn($"No person found with ID: {personID}");

                        return clsResultBuilder.BuildPersonResult(null, 
                            $"No person found with ID: {personID}");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                logger.Error($"SQL Error retrieving person info for ID: {personID}. " +
                    $"Exception: {sqlEx.Message}", sqlEx);

                return clsResultBuilder.BuildPersonResult(null,
                            $"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                logger.Error($"General error retrieving person info for ID: {personID}. " +
                    $"Exception: {ex.Message}" , ex);

                return clsResultBuilder.BuildPersonResult(null,
                            $"Unexpected error: {ex.Message}");
            }
        }

        public static clsPersonInfoResult GetPersonInfoByNationalNo(string nationalNo)
        {
            if (string.IsNullOrEmpty(nationalNo))
            {
                logger.Warn($"Invalid Provided National Number: {nationalNo}");
                return new clsPersonInfoResult { Found = false };
            }


            logger.Info($"Starting to Get Person Info By National Number: {nationalNo}");

            const string query = @"SELECT 
                                    P.*, 
                                    Pa.id as PersonAddresseID, Pa.BuildNo, Pa.Street, 
                                    Pa.CountryId, Pa.CityId, Pa.GovernorateId,
                                    Co.NameEn as CountryName,   
                                    Co.NameAr as CountryNameAr,
                                    Gv.NameEn as GovernorateName,
                                    Gv.NameAr as GovernorateNameAr,
                                    Ci.NameEn as CityName,
                                    Ci.NameAr as CityNameAr
                                FROM Persons P
                                INNER JOIN PersonAddresses Pa
                                ON P.id = Pa.PersonID
                                INNER JOIN Countries Co
                                ON Co.id = Pa.CountryId
                                INNER JOIN Governorates Gv
                                ON Gv.id = Pa.GovernorateId
                                INNER JOIN Cities Ci
                                ON Ci.id = Pa.CityId       
                                WHERE  P.NationalNumber = @NationalNo";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", nationalNo);

                    connection.Open();
                    logger.Debug($"Connection to database opened successfully for National Number: {nationalNo}");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            clsPersonInfo personInfo = clsEntityMapper.MapReaderToPerson(reader);

                            LoggerDebugPersonInfoRetrieved(personInfo);

                            logger.Info($"Successfully retrieved person info for " +
                                $"National Number: {nationalNo}");

                            return clsResultBuilder.BuildPersonResult(personInfo, 
                                $"Person found with National Number: {nationalNo}");
                        }

                        logger.Warn($"No person found with National Number: {nationalNo}");

                        return clsResultBuilder.BuildPersonResult(null, 
                            $"No person found with National Number: {nationalNo}");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                logger.Error($"SQL Error retrieving person info for National Number: " +
                    $"{nationalNo}. Exception: {sqlEx.Message}", sqlEx);

                return clsResultBuilder.BuildPersonResult(null, 
                            $"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                logger.Error($"General error retrieving person info for National Number: {nationalNo}. " +
                    $"Exception: {ex.Message}", ex);

                return clsResultBuilder.BuildPersonResult(null, 
                            $"Unexpected error: {ex.Message}");
            }
        }

        public static clsPersonInfoResult AddNewPerson(clsPersonInfo personInfo)
        {
            if (personInfo == null)
            {
                logger.Warn("PersonInfo object is null in AddNewPerson");
                return clsResultBuilder.BuildPersonResult(null, "PersonInfo object cannot be null");
            }

            if (IsPersonExistsNationalNumber(personInfo.NationalNo))
            {
                logger.Warn($"Person with National Number {personInfo.NationalNo} already exists");
                return clsResultBuilder.BuildPersonResult(null, 
                    $"Person with National Number {personInfo.NationalNo} already exists");
            }

            if (IsPersonExistsPhone(personInfo.Phone))
            {
                logger.Warn($"Person with Phone {personInfo.Phone} already exists");
                return clsResultBuilder.BuildPersonResult(null,
                    $"Person with Phone {personInfo.Phone} already exists");
            }

            if (IsPersonExistsEmail(personInfo.Email))
            {
                logger.Warn($"Person with Email {personInfo.Email} already exists");
                return clsResultBuilder.BuildPersonResult(null,
                    $"Person with Email {personInfo.Email} already exists");
            }

            const string query = @"INSERT INTO Persons (
                                    NationalNumber, FirstName, FatherName, MiddleName, 
                                    LastName, DateOfBirth, Address, Phone, Email, Gender, 
                                    ProfilePicture)   
                                VALUES (
                                    @NationalNumber, @FirstName, @FatherName, @MiddleName,
                                    @LastName, @DateOfBirth, @Address, @Phone, @Email, 
                                    @Gender, @ProfilePicture ); 
                                SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                AddPersonParameters(command, personInfo);

                                object result = command.ExecuteScalar();

                                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                                {
                                    personInfo.PersonID = insertedID;

                                    personInfo.PersonAddresseInfo =
                                        clsPersonAddressDataAccess.AddNewPersonAddress(
                                        personInfo.PersonAddresseInfo , connection).PersonAddresse;

                                    logger.Info($"Person added successfully with ID: {insertedID}," +
                                                $" Name: {personInfo.FirstName} {personInfo.LastName}");

                                    transaction.Commit();

                                    return clsResultBuilder.BuildPersonResult(personInfo,
                                        $"New person added with ID: {insertedID}");
                                }

                                transaction.Rollback();
                                logger.Warn($"Failed to get inserted PersonID for person: " +
                                    $"{personInfo.FirstName} {personInfo.LastName}");

                                return clsResultBuilder.BuildPersonResult(null,
                                    "Failed to retrieve new person ID");
                            }
                        }
                        catch (SqlException sqlEx)
                        {
                            transaction.Rollback();
                            logger.Error($"SQL Error adding new person: {personInfo.FirstName} {personInfo.LastName}. " +
                                         $"Exception: {sqlEx.Message}", sqlEx);
                            return clsResultBuilder.BuildPersonResult(null,
                                $"Database error: {sqlEx.Message}");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            logger.Error($"General error adding new person: {personInfo.FirstName} {personInfo.LastName}. " +
                                         $"Exception: {ex.Message}", ex);
                            return clsResultBuilder.BuildPersonResult(null,
                                $"Unexpected error: {ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    logger.Error($"Failed to open database connection. Exception: {ex.Message}", ex);
                    return clsResultBuilder.BuildPersonResult(null,
                        $"Connection error: {ex.Message}");
                }
            }
        }

        public static clsPersonInfoResult UpdatePerson(clsPersonInfo personInfo)
        {
            if (personInfo == null)
            {
                logger.Warn("PersonInfo object is null in UpdatePerson");
                return clsResultBuilder.BuildPersonResult(null, "PersonInfo object cannot be null");
            }

            if (!IsPersonExistsID(personInfo.PersonID))
            {
                logger.Warn($"Person with ID {personInfo.PersonID} does not exist");
                return clsResultBuilder.BuildPersonResult(null, $"Person with ID {personInfo.PersonID} does not exist");
            }

            const string query = @"
        UPDATE Persons SET 
            NationalNumber = @NationalNumber, 
            FirstName = @FirstName, 
            FatherName = @FatherName, 
            MiddleName = @MiddleName, 
            LastName = @LastName, 
            DateOfBirth = @DateOfBirth, 
            Address = @Address, 
            Phone = @Phone, 
            Email = @Email, 
            Gender = @Gender, 
            ProfilePicture = @ProfilePicture 
        WHERE id = @PersonID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    using (SqlCommand command = new SqlCommand(query, connection, transaction))
                    {
                        AddPersonParameters(command, personInfo);
                        command.Parameters.AddWithValue("@PersonID", personInfo.PersonID);

                        logger.Debug($"Transaction started for updating person ID: {personInfo.PersonID}");

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            try
                            {
                                personInfo.PersonAddresseInfo =
                                    clsPersonAddressDataAccess.UpdatePersonAddresse(
                                        personInfo.PersonAddresseInfo, connection).PersonAddresse;

                                transaction.Commit();

                                logger.Info($"Person updated successfully. ID: {personInfo.PersonID}, NationalNumber = {personInfo.NationalNo}");
                                return clsResultBuilder.BuildPersonResult(personInfo, $"Person updated successfully with ID: {personInfo.PersonID}");
                            }
                            catch (Exception addrEx)
                            {
                                transaction.Rollback();
                                logger.Error($"Address update failed for PersonID: {personInfo.PersonID}. Rolled back transaction. Exception: {addrEx.Message}", addrEx);
                                return clsResultBuilder.BuildPersonResult(null, $"Address update failed: {addrEx.Message}");
                            }
                        }

                        transaction.Rollback();
                        logger.Warn($"No rows affected during update for PersonID: {personInfo.PersonID}");
                        return clsResultBuilder.BuildPersonResult(null, "Update failed - no rows affected");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                logger.Error($"SQL Error updating person ID: {personInfo.PersonID}. Exception: {sqlEx.Message}", sqlEx);
                return clsResultBuilder.BuildPersonResult(null, $"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                logger.Error($"General error updating person ID: {personInfo.PersonID}. Exception: {ex.Message}", ex);
                return clsResultBuilder.BuildPersonResult(null, $"Unexpected error: {ex.Message}");
            }
        }

        public static bool DeletePerson(int personID)
        {
            if(personID <= 0)
            {
                logger.Warn($"Invalid PersonID provided for deletion: {personID}");
                return false;
            }

            if(!IsPersonExistsID(personID))
            {
                logger.Warn($"Person with ID {personID} does not exist - cannot delete");
                return false;
            }

            const string query = "DELETE FROM Persons WHERE id = @PersonID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query , connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);

                    logger.Debug($"Connection opened for deleting person ID: {personID}");
                    connection.Open();

                    logger.Info($"Attempting to delete person Address with ID: {personID}");

                    if(!clsPersonAddressDataAccess.DeletePersonAddresseByPersonID(personID))
                    {
                        logger.Warn($"Failed to delete person address for PersonID: {personID}");
                        return false;
                    }

                    int rowAffected = command.ExecuteNonQuery();

                    if (rowAffected > 0)
                    {
                        logger.Info($"Person deleted successfully. ID: {personID}");
                        return true;
                    }
                    logger.Warn($"No rows affected during deletion for PersonID: {personID}");
                    return false;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.Error($"SQL Error deleting person ID: {personID}. Exception: {sqlEx.Message}", sqlEx);
                return false;
            }
            catch (Exception ex)
            {
                logger.Error($"General error deleting person ID: {personID}. Exception: {ex.Message}", ex);
                return false;
            }
        }

        public static bool IsPersonExistsID(int personID)
        {
            if(personID <= 0)
            {
                logger.Debug($"Invalid PersonID provided for existence check: {personID}");
                return false;
            }

            return IsPersonExistsByField("id", personID);
        }

        public static bool IsPersonExistsNationalNumber(string nationalNo)
        {
            return IsPersonExistsByField("NationalNumber", nationalNo);
        }

        public static bool IsPersonExistsPhone(string Phone)
        {
            return IsPersonExistsByField("Phone", Phone);
        }

        public static bool IsPersonExistsEmail(string Email)
        {
            return IsPersonExistsByField("Email", Email);
        }

        public static List<clsPersonInfo> GetAllPersons()
        {
            logger.Info("Starting to retrieve all persons");

            List<clsPersonInfo> persons = new List<clsPersonInfo>();
            const string query = @"SELECT 
                                    P.*, 
                                    Pa.id as PersonAddresseID, Pa.BuildNo, Pa.Street, 
                                    Pa.CountryId, Pa.CityId, Pa.GovernorateId,
                                    Co.NameEn as CountryName,   
                                    Co.NameAr as CountryNameAr,
                                    Gv.NameEn as GovernorateName,
                                    Gv.NameAr as GovernorateNameAr,
                                    Ci.NameEn as CityName,
                                    Ci.NameAr as CityNameAr
                                FROM Persons P
                                INNER JOIN PersonAddresses Pa
                                ON P.id = Pa.PersonID
                                INNER JOIN Countries Co
                                ON Co.id = Pa.CountryId
                                INNER JOIN Governorates Gv
                                ON Gv.id = Pa.GovernorateId
                                INNER JOIN Cities Ci
                                ON Ci.id = Pa.CityId
                                ORDER BY FirstName";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    logger.Debug("Connection opened for retrieving all persons");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clsPersonInfo personInfo = clsEntityMapper.MapReaderToPerson(reader);
                            persons.Add(personInfo);
                        }
                    }
                }

                logger.Info($"Successfully retrieved {persons.Count} persons");
                return persons;
            }
            catch (SqlException sqlEx)
            {
                logger.Error($"SQL Error retrieving all persons. Exception: {sqlEx.Message}", sqlEx);
                return new List<clsPersonInfo>(); // Return empty list on error
            }
            catch (Exception ex)
            {
                logger.Error($"General error retrieving all persons. Exception: {ex.Message}", ex);
                return new List<clsPersonInfo>(); // Return empty list on error
            }
        }

        //Helper Methods 
        private static void AddPersonParameters(SqlCommand command , clsPersonInfo personInfo)
        {
            command.Parameters.AddWithValue("@NationalNumber", personInfo.NationalNo);
            command.Parameters.AddWithValue("@FirstName", personInfo.FirstName);
            command.Parameters.AddWithValue("@FatherName", personInfo.FatherName);
            command.Parameters.AddWithValue("@MiddleName", personInfo.MiddleName);
            command.Parameters.AddWithValue("@LastName", personInfo.LastName);
            command.Parameters.AddWithValue("@DateOfBirth", personInfo.DateOfBirth);
            command.Parameters.AddWithValue("@Address", personInfo.Address);
            command.Parameters.AddWithValue("@Phone", personInfo.Phone);
            command.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(personInfo.Email) ? (object)DBNull.Value : personInfo.Email);
            command.Parameters.AddWithValue("@Gender", personInfo.Gender);
            command.Parameters.AddWithValue("@ProfilePicture", string.IsNullOrEmpty(personInfo.ProfilePicture) ? (object)DBNull.Value : personInfo.ProfilePicture);
        }

        private static void LoggerDebugPersonInfoRetrieved(clsPersonInfo personInfo)
        {
            logger.Debug("Person Info Retrieved: Name: {FullName}, National No: {NationalNo}, DOB: {DateOfBirth}, Phone: {Phone}, Email: {Email}, Gender: {Gender}, CountryID: {CountryID}, Has Profile Picture: {HasProfilePicture}",
                $"{personInfo.FirstName} {personInfo.FatherName} {personInfo.MiddleName} {personInfo.LastName}".Trim(),
                personInfo.NationalNo,
                personInfo.DateOfBirth.ToShortDateString(),
                personInfo.Phone,
                personInfo.Email,
                personInfo.Gender,
                !string.IsNullOrEmpty(personInfo.ProfilePicture)
            );
        }

        private static bool IsPersonExistsByField(string fieldName, object value)
        {
            if(!AllowedFields.ContainsKey(fieldName))
            {
                logger.Debug($"Field '{fieldName}' is not allowed for existence check.");
                return false;
            }

            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                logger.Debug($"Invalid value for field '{fieldName}': {value}");
                return false;
            }

            logger.Debug($"Checking if person exists where {fieldName} = {value}");

            string query = $"SELECT COUNT(1) FROM Persons WHERE {AllowedFields[fieldName]} = @value";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@value", value);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    bool exists = count > 0;

                    logger.Debug($"Existence check result for {fieldName} = {value}: {(exists ? "Exists" : "Does Not Exist")}");
                    return exists;
                }
            }
            catch (SqlException ex)
            {
                logger.Error($"SQL Error during existence check for {fieldName} = {value}. Message: {ex.Message}", ex);
                return false;
            }
            catch (Exception ex)
            {
                logger.Error($"General error during existence check for {fieldName} = {value}. Message: {ex.Message}", ex);
                return false;
            }
        }
    }
}
