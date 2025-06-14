using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

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
                            PersonInfo personInfo = new PersonInfo()
                            {
                                FirstName = reader["FirstName"]?.ToString() ?? string.Empty,
                                FatherName = reader["FatherName"]?.ToString() ?? string.Empty,
                                MiddleName = reader["MiddleName"]?.ToString() ?? string.Empty,
                                LastName = reader["LastName"]?.ToString() ?? string.Empty,
                                NationalNo = reader["NationalNumber"]?.ToString() ?? string.Empty,
                                Address = reader["Address"]?.ToString() ?? string.Empty,
                                Email = reader["Email"]?.ToString() ?? string.Empty,
                                Phone = reader["Phone"]?.ToString() ?? string.Empty,
                                ProfilePicture = reader["ProfilePicture"]?.ToString() ?? string.Empty,

                                CountryID = (reader["CountryId"] != DBNull.Value)
                                ? Convert.ToInt32(reader["CountryId"])
                                : 0,

                                Gender = (reader["Gender"] != DBNull.Value)
                                ? Convert.ToChar(reader["Gender"])
                                : ' ',

                                DateOfBirth = (reader["DateOfBirth"] != DBNull.Value)
                                ? Convert.ToDateTime(reader["DateOfBirth"])
                                : DateTime.MinValue
                            };

                            logger.Debug($@"Person Info Retrieved: 
                            Name: {personInfo.FirstName} {personInfo.FatherName} {personInfo.MiddleName} {personInfo.LastName}
                            National No: {personInfo.NationalNo}
                            DOB: {personInfo.DateOfBirth.ToShortDateString()}
                            Phone: {personInfo.Phone}
                            Email: {personInfo.Email}
                            Gender: {personInfo.Gender}
                            CountryID: {personInfo.CountryID}
                            Has Profile Picture: {personInfo.ProfilePicture?.Length > 0}"
                            );

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

        public static bool GetPersonInfoByNationalNo(string nationalNo, ref int personID, ref string firstName, ref string fatherName,
            ref string middleName, ref string lastName, DateTime dateOfBirth, ref string address,
            ref string phone, ref string email, ref char Gendor, ref int countryID,
            ref string ProfilePicture)
        {
            bool IsFound = true;
            if (string.IsNullOrEmpty(nationalNo))
                return false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Persons WHERE NationalNumber = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", nationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    personID = Convert.ToInt32(reader["PersonID"]);
                    firstName = reader["FirstName"].ToString();
                    fatherName = reader["FatherName"].ToString();
                    middleName = reader["MiddleName"].ToString();
                    lastName = reader["LastName"].ToString();
                    dateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    address = reader["Address"].ToString();
                    phone = reader["Phone"].ToString();
                    email = (reader["Email"] == DBNull.Value) ? string.Empty : reader["Email"].ToString();
                    Gendor = (char)reader["Gendor"];
                    countryID = Convert.ToInt32(reader["CountryId"]);
                    ProfilePicture = reader["ProfilePicture"].ToString();
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch (Exception)
            {
                IsFound = false;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return IsFound;
        }

        public static int AddNewPerson(string firstName, string fatherName, string middleName,
            string lastName, string nationalNo, DateTime dateOfBirth, string address,
            string phone, string email, char Gendor, int countryID,
            string ProfilePicture)
        {
            int newPersonID = -1;
            string query = @"
                    INSERT INTO Persons (
                        NationalNumber, FirstName, FatherName, MiddleName, LastName, DateOfBirth, 
                        Address, Phone, Email, Gendor, CountryId, ProfilePicture 
                    )   
                    VALUES (
                        @NationalNumber , @FirstName, @FatherName, @MiddleName, @LastName, 
                        @DateOfBirth, @Address, @Phone, @Email, @Gendor, @CountryId, @ProfilePicture
                    ); 
                    SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@NationalNumber", nationalNo);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@FatherName", fatherName);
                command.Parameters.AddWithValue("@MiddleName", middleName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                command.Parameters.AddWithValue("@Gendor", Gendor);
                command.Parameters.AddWithValue("@CountryId", countryID);
                command.Parameters.AddWithValue("@ProfilePicture", string.IsNullOrEmpty(ProfilePicture) ? (object)DBNull.Value : ProfilePicture);


                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result?.ToString(), out int id))
                    {
                        newPersonID = id;
                    }
                }
                catch (Exception)
                {

                    return -1;
                }
            }
            return newPersonID;
        }
    }
}
