using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer.Person
{
    public class clsPersonDataAccess
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public static PersonInfoResult GetPersonInfoByID(int personID)
        {
            if (personID <= 0)
            {
                logger.Warn("Invalid PersonID provided: {0}", personID);
                return new PersonInfoResult { Found = false };
            }

            logger.Info($"Starting to Get Person Info By ID: {personID}");

            const string query = "SELECT * FROM Persons WHERE PersonID = @PersonID";
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
                            clsPersonInfo personInfo = MapReaderToPerson(reader);

                            LoggerDebugPersonInfoRetrieved(personInfo);

                            logger.Info($"Successfully retrieved person info for ID: {personID}");

                            return new PersonInfoResult { Found = true, Person = personInfo };
                        }
                        else
                        {
                            logger.Warn($"No person found with ID: {personID}");
                            return new PersonInfoResult { Found = false };
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                logger.Error($"SQL Error retrieving person info for ID: {personID}. Exception: {sqlEx.Message}", sqlEx);
                return new PersonInfoResult { Found = false, ErrorMessage = $"Database error: {sqlEx.Message}" };
            }
            catch (Exception ex)
            {
                logger.Error($"General error retrieving person info for ID: {personID}. Exception: {ex.Message}" , ex);
                return new PersonInfoResult { Found = false, ErrorMessage = $"Unexpected error: {ex.Message}" };
            }
        }

        public static PersonInfoResult GetPersonInfoByNationalNo(string nationalNo)
        {
            if (string.IsNullOrEmpty(nationalNo))
            {
                logger.Warn($"Invalid Provided National Number: {nationalNo}");
                return new PersonInfoResult { Found = false };
            }


            logger.Info($"Starting to Get Person Info By National Number: {nationalNo}");
            const string query = "SELECT * FROM Persons WHERE NationalNumber = @NationalNo";

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
                            clsPersonInfo personInfo = MapReaderToPerson(reader);

                            LoggerDebugPersonInfoRetrieved(personInfo);

                            logger.Info($"Successfully retrieved person info for National Number: {nationalNo}");

                            return new PersonInfoResult { Found = true, Person = personInfo };
                        }
                        else
                        {
                            logger.Warn($"No person found with National Number: {nationalNo}");
                            return new PersonInfoResult { Found = false };
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                logger.Error($"SQL Error retrieving person info for National Number: {nationalNo}. Exception: {sqlEx.Message}", sqlEx);
                return new PersonInfoResult { Found = false, ErrorMessage = $"Database error: {sqlEx.Message}" };
            }
            catch (Exception ex)
            {
                logger.Error($"General error retrieving person info for National Number: {nationalNo}. Exception: {ex.Message}", ex);
                return new PersonInfoResult { Found = false, ErrorMessage = $"Unexpected error: {ex.Message}" };
            }
        }

        public static PersonInfoResult AddNewPerson(clsPersonInfo personInfo)
        {
            int newPersonID = -1;
            const string query = @"
                    INSERT INTO Persons (
                        NationalNumber, FirstName, FatherName, MiddleName, LastName, DateOfBirth, 
                        Address, Phone, Email, Gender, ProfilePicture 
                    )   
                    VALUES (
                        @NationalNumber , @FirstName, @FatherName, @MiddleName, @LastName, 
                        @DateOfBirth, @Address, @Phone, @Email, @Gender, @ProfilePicture
                    ); 
                    SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    AddPersonParameters(command, personInfo);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result?.ToString(), out int insertedID))
                    {
                        personInfo.PersonID = insertedID;
                        logger.Info($"Person added successfully with ID: {newPersonID}," +
                                    $" Name: {personInfo.FirstName} {personInfo.LastName}");

                        return new PersonInfoResult { Found = true, Person = personInfo };
                    }
                    else
                    {
                        logger.Warn($"Failed to get inserted PersonID for person: { personInfo.FirstName} {personInfo.LastName}");
                        return new PersonInfoResult { Found = false, ErrorMessage = "Failed to retrieve new person ID" };
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                logger.Error($"SQL Error adding new person: {personInfo.FirstName} {personInfo.LastName}. Exception: {sqlEx.Message}", sqlEx);
                return new PersonInfoResult { Found = false, ErrorMessage = $"Database error: {sqlEx.Message}" };
            }
            catch (Exception ex)
            {
                logger.Error($"General error adding new person: {personInfo.FirstName} {personInfo.LastName}. Exception: {ex.Message}", ex);
                return new PersonInfoResult { Found = false, ErrorMessage = $"Unexpected error: {ex.Message}" };
            }
        }

        public static PersonInfoResult UpdatePerson(clsPersonInfo personInfo)
        { 
            if(personInfo == null)
            {
                logger.Warn("PersonInfo object is null in UpdatePerson");
                return new PersonInfoResult { Found = false, ErrorMessage = "Person information is required" };
            }

            if(personInfo.PersonID <= 0)
            {
                logger.Warn($"Invalid PersonID provided for update: {personInfo.PersonID}");
                return new PersonInfoResult { Found = false, ErrorMessage = "Valid Person ID is required for update" };
            }

            if (!IsPersonExistsID(personInfo.PersonID))
            {
                logger.Warn($"Person with ID {personInfo.PersonID} does not exist");
                return new PersonInfoResult { Found = false, ErrorMessage = "Person not found" };
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
                    CountryId = @CountryId, 
                    ProfilePicture = @ProfilePicture 
                WHERE PersonID = @PersonID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query , connection))
                {
                    AddPersonParameters(command , personInfo);
                    command.Parameters.AddWithValue("@PersonID", personInfo.PersonID);

                    connection.Open();
                    logger.Debug($"Connection opened for updating person ID: {personInfo.PersonID}");

                    int rowAffected = command.ExecuteNonQuery();

                    if (rowAffected > 0) 
                    {
                        logger.Info($"Person updated successfully. ID: {personInfo.PersonID}, Name: {personInfo.FirstName} {personInfo.LastName}");
                        return new PersonInfoResult { Found = true, Person = personInfo };
                    }
                    else 
                    {
                        logger.Warn($"No rows affected during update for PersonID: {personInfo.PersonID}");
                        return new PersonInfoResult { Found = false, ErrorMessage = "Update failed - no rows affected" };
                    }
                }
            }
            catch(SqlException sqlEx)
            {
                logger.Error($"SQL Error updating person ID: {personInfo.PersonID}. Exception: {sqlEx.Message}", sqlEx);
                return new PersonInfoResult { Found = false, ErrorMessage = $"Database error: {sqlEx.Message}" };
            }
            catch(Exception ex)
            {
                logger.Error($"General error updating person ID: {personInfo.PersonID}. Exception: {ex.Message}", ex);
                return new PersonInfoResult { Found = false, ErrorMessage = $"Unexpected error: {ex.Message}" };
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

            const string query = "DELETE FROM Persons WHERE personID = @PersonID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query , connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);

                    connection.Open();
                    logger.Debug($"Connection opened for deleting person ID: {personID}");

                    int rowAffected = command.ExecuteNonQuery();

                    if (rowAffected > 0)
                    {
                        logger.Info($"Person deleted successfully. ID: {personID}");
                        return true;
                    }
                    else
                    {
                        logger.Warn($"No rows affected during deletion for PersonID: {personID}");
                        return false;
                    }
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

            logger.Debug($"Checking if person exists with ID: {personID}");

            const string query = "SELECT COUNT(1) FROM Persons WHERE PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query , connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@PersonID", personID);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    bool IsExists = count > 0;

                    logger.Debug($"Person existence check for ID {personID}: {IsExists}");

                    return IsExists;
                }
                catch (SqlException sqlEx)
                {
                    logger.Error($"SQL Error checking person existence for ID: {personID}. Exception: {sqlEx.Message}", sqlEx);
                    return false;
                }
                catch(Exception ex)
                {
                    logger.Error($"General error checking person existence for ID: {personID}. Exception: {ex.Message}", ex);
                    return false;
                }
            }
        }

        public static bool IsPersonExistsNationalNumber(string nationalNo)
        {
            if(string.IsNullOrEmpty(nationalNo))
            {
                logger.Debug($"Invalid National Number provided for existence check: {nationalNo}");
                return false;
            }

            logger.Debug($"Checking if person exists with National Number: {nationalNo}");

            const string query = "SELECT COUNT(1) FROM Persons WHERE NationalNumber = @nationalNo";

            try 
            { 
                using (SqlConnection connection = new SqlConnection (clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query , connection))
                {
                    command.Parameters.AddWithValue("@nationalNo", nationalNo);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();
                    bool IsExists = count > 0;

                    logger.Debug($"Person existence check for National Number {nationalNo}: {IsExists}");
                    return IsExists;
                }
            }
            catch(SqlException sqlEx)
            {
                logger.Error($"SQL Error checking person existence for National Number: {nationalNo}. Exception: {sqlEx.Message}", sqlEx);
                return false ;
            }
            catch(Exception ex)
            {
                logger.Error($"General error checking person existence for National Number: {nationalNo}. Exception: {ex.Message}", ex);
                return false;
            }
        }

        public static List<clsPersonInfo> GetAllPersons()
        {
            logger.Info("Starting to retrieve all persons");

            List<clsPersonInfo> persons = new List<clsPersonInfo>();
            const string query = @"SELECT 
                                        NationalNumber, FirstName, FatherName, MiddleName, LastName,  
                                        DateOfBirth, Address, Phone, 
                                    CASE 
                                        WHEN Gender = 'M' THEN 'Male'
                                        ELSE 'Female' 
                                    END as GenderCaption, 
                                        Email, ProfilePicture, PA.BuildNo, PA.Street,
                                        CO.NameEn as CountryName, GOV.NameEn as GovernorateName, 
                                        CI.NameEn as CityName
                                    FROM Persons  

                                    INNER JOIN PersonAddresses as PA
                                    ON Persons.id = PA.PersonID  

                                    INNER JOIN Countries as CO 
                                    ON CO.id = PA.CountryId 

                                    INNER JOIN Governorates as GOV 
                                    ON GOV.id = PA.GovernorateId

                                    INNER JOIN Cities as CI
                                    ON CI.id = PA.CityId
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
                            clsPersonInfo personInfo = MapReaderToPerson(reader);
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

        private static clsPersonInfo MapReaderToPerson(SqlDataReader reader)
        {
            return new clsPersonInfo()
            {
                PersonID = (int)reader["PersonID"],
                FirstName = reader["FirstName"]?.ToString() ?? string.Empty,
                FatherName = reader["FatherName"]?.ToString() ?? string.Empty,
                MiddleName = reader["MiddleName"]?.ToString() ?? string.Empty,
                LastName = reader["LastName"]?.ToString() ?? string.Empty,
                NationalNo = reader["NationalNumber"]?.ToString() ?? string.Empty,
                Address = reader["Address"]?.ToString() ?? string.Empty,
                Email = reader["Email"]?.ToString() ?? string.Empty,
                Phone = reader["Phone"]?.ToString() ?? string.Empty,
                ProfilePicture = reader["ProfilePicture"]?.ToString() ?? string.Empty,

                Gender = (reader["Gender"] != DBNull.Value)
                                ? Convert.ToChar(reader["Gender"])
                                : ' ',

                DateOfBirth = (reader["DateOfBirth"] != DBNull.Value)
                                ? Convert.ToDateTime(reader["DateOfBirth"])
                                : DateTime.MinValue
            };
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
    }
}
