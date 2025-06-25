using DVLDDataAccessLayer.Person;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.PersonAddresses
{
    public static class clsPersonAddresseDataAccess
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public static clsPersonAddresseResult AddNewPersonAddresse(clsPersonAddresseInfo PersonAddresseInfo)
        {
            clsPersonAddresseResult resultPersonAddresse = new clsPersonAddresseResult();

            if (PersonAddresseInfo.PersonID <= 0)
            {
                resultPersonAddresse.Found = false;
                resultPersonAddresse.ErrorMessage = "Invalid PersonID";
                return resultPersonAddresse;
            }

            if (!clsPersonDataAccess.IsPersonExistsID(PersonAddresseInfo.PersonID))
            {
                resultPersonAddresse.Found = false;
                resultPersonAddresse.ErrorMessage = "Person does not exist";
                return resultPersonAddresse;
            }

            const string query = @"INSERT INTO PersonAddresses (
                                            PersonID, CountryId, GovernorateId, CityId, 
                                            BuildNo, Street) 
                                        VALUES (@PersonID, @CountryId, @GovernorateId, 
                                                @CityId, @BuildNo, @Street); 
                                        SELECT SCOPE_IDENTITY();";

            
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query , connection))
                {
                    AddPersonAddresseParameters(command, PersonAddresseInfo.PersonID, PersonAddresseInfo);

                    connection.Open();

                    object resultSql = command.ExecuteScalar();

                    if (resultSql != null && int.TryParse(resultSql?.ToString(), out int insertedPersonAddresse))
                    {

                        PersonAddresseInfo.PersonAddresseID = insertedPersonAddresse;

                        logger.Info($"Person Addresse added successfully with Person ID: {PersonAddresseInfo.PersonID}, Address ID {insertedPersonAddresse}");

                        resultPersonAddresse.Found = true;
                        resultPersonAddresse.PersonAddresseInfo = PersonAddresseInfo;
                        return resultPersonAddresse;
                    }
                    else
                    {
                        logger.Warn($"Failed to get inserted Person Addresse for PersonID : {PersonAddresseInfo.PersonID}");
                        resultPersonAddresse.Found = false;
                        resultPersonAddresse.ErrorMessage = "Failed to retrieve new Person Addresse";
                        return resultPersonAddresse;
                    }
                }

            }
            catch (SqlException sqlEx)
            {
                logger.Error($"SQL Error adding new person addresse for PersonID : {PersonAddresseInfo.PersonID}. Exception: {sqlEx.Message}", sqlEx);
                resultPersonAddresse.Found = false;
                resultPersonAddresse.ErrorMessage = $"Database error: {sqlEx.Message}";
                return resultPersonAddresse;
            }
            catch (Exception ex)
            {
                logger.Error($"General error adding new person addresse: {PersonAddresseInfo.PersonID}. Exception: {ex.Message}", ex);
                resultPersonAddresse.Found = false;
                resultPersonAddresse.ErrorMessage = $"Unexpected error: {ex.Message}";
                return resultPersonAddresse;
            }
        }

        public static clsPersonAddresseResult UpdatePersonAddresse(clsPersonAddresseInfo PersonAddresseInfo)
        {
            clsPersonAddresseResult resultPersonAddresse = new clsPersonAddresseResult();

            if (PersonAddresseInfo.PersonID <= 0)
            {
                logger.Warn($"Invalid PersonID provided for update: {PersonAddresseInfo.PersonID}");
                resultPersonAddresse.Found = false;
                resultPersonAddresse.ErrorMessage = "Invalid PersonID.";
                return resultPersonAddresse;
            }

            if (PersonAddresseInfo == null || PersonAddresseInfo.PersonAddresseID <= 0)
            {
                logger.Warn("Person Addresse Info object is null in UpdatePerson");
                resultPersonAddresse.Found = false;
                resultPersonAddresse.ErrorMessage = "Invalid address information.";
                return resultPersonAddresse;
            }

            if (!clsPersonDataAccess.IsPersonExistsID(PersonAddresseInfo.PersonID))
            {
                logger.Warn($"Person with ID {PersonAddresseInfo.PersonID} does not exist");
                resultPersonAddresse.Found = false;
                resultPersonAddresse.ErrorMessage = "Person does not exist.";
                

            }

            const string query = @"UPDATE PersonAddresses 
                                SET CountryId = @CountryId,
                                    GovernorateId = @GovernorateId,
                                    CityId = @CityId,
                                    BuildNo = @BuildNo,
                                    Street = @Street
                                WHERE PersonID = @PersonID AND id = @PersonAddresseID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    AddPersonAddresseParameters(command, PersonAddresseInfo.PersonID, PersonAddresseInfo);
                    command.Parameters.AddWithValue("@PersonAddresseID", PersonAddresseInfo.PersonAddresseID);

                    connection.Open();

                    int rowAffected = command.ExecuteNonQuery();

                    if (rowAffected > 0)
                    {
                        logger.Info($"Person Addresse updated successfully for PersonID: {PersonAddresseInfo.PersonID}, Address ID: {PersonAddresseInfo.PersonAddresseID}");
                        resultPersonAddresse.Found = true;
                        resultPersonAddresse.PersonAddresseInfo = PersonAddresseInfo;
                    }
                    else
                    {
                        logger.Warn($"No rows affected while updating Person Addresse for PersonID: {PersonAddresseInfo.PersonID}, Address ID: {PersonAddresseInfo.PersonAddresseID}");
                        resultPersonAddresse.Found = false;
                        resultPersonAddresse.ErrorMessage = "No rows affected during update.";
                    }

                    return resultPersonAddresse;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.Error($"SQL Error updating Person Addresse for PersonID: {PersonAddresseInfo.PersonID}, Address ID: {PersonAddresseInfo.PersonAddresseID}. Exception: {sqlEx.Message}", sqlEx);
                resultPersonAddresse.Found = false;
                resultPersonAddresse.ErrorMessage = $"Database error: {sqlEx.Message}";
                return resultPersonAddresse;
            }
            catch (Exception ex)
            {
                logger.Error($"Error updating Person Addresse for PersonID: {PersonAddresseInfo.PersonID}, Address ID: {PersonAddresseInfo.PersonAddresseID}. Exception: {ex.Message}", ex);
                resultPersonAddresse.Found = false;
                resultPersonAddresse.ErrorMessage = $"Unexpected error: {ex.Message}";
                return resultPersonAddresse;
            }
            
        }

        //public static clsPersonAddresseResult GetPersonAddresseByPersonID(int PersonID)
        //{
        //    clsPersonAddresseResult resultPersonAddresse = new clsPersonAddresseResult();
        //    if (PersonID <= 0)
        //    {
        //        logger.Warn($"Invalid PersonID provided: {PersonID}");
        //        resultPersonAddresse.Found = false;
        //        resultPersonAddresse.ErrorMessage = "Invalid PersonID.";
        //        return resultPersonAddresse;
        //    }
        //    if (!clsPersonDataAccess.IsPersonExistsID(PersonID))
        //    {
        //        logger.Warn($"Person with ID {PersonID} does not exist");
        //        resultPersonAddresse.Found = false;
        //        resultPersonAddresse.ErrorMessage = "Person does not exist.";
        //        return resultPersonAddresse;
        //    }
        //    const string query = @"SELECT id, PersonID, CountryId, GovernorateId, CityId, 
        //                                BuildNo, Street 
        //                            FROM PersonAddresses 
        //                            WHERE PersonID = @PersonID";
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@PersonID", PersonID);
        //            connection.Open();
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (!reader.HasRows)
        //                {
        //                    logger.Info($"No addresses found for PersonID: {PersonID}");
        //                    resultPersonAddresse.Found = false;
        //                    resultPersonAddresse.ErrorMessage = "No addresses found for the specified person.";
        //                    return resultPersonAddresse;
        //                }
        //                while (reader.Read())
        //                {
        //                    clsPersonAddresseInfo personAddressInfo = new clsPersonAddresseInfo
        //                    {
        //                        PersonAddresseID = reader.GetInt32(reader.GetOrdinal("id")),
        //                        PersonID = reader.GetInt32(reader.GetOrdinal("PersonID")),
        //                        Country = new clsCountryInfo { CountryID = reader.IsDBNull(reader.GetOrdinal("CountryId")) ? 0 : reader.GetInt32(reader.GetOrdinal("CountryId")) },
        //                        Governorate = new clsGovernorateInfo { GovernorateID = reader.IsDBNull(reader.GetOrdinal("GovernorateId")) ? 0 : reader.GetInt32(reader.GetOrdinal("GovernorateId")) },
        //                        City = new clsCityInfo { CityID = reader.Is

        //Helper Methods 
        private static void AddPersonAddresseParameters(SqlCommand command, int PersonId ,clsPersonAddresseInfo info)
        {
            command.Parameters.AddWithValue("@PersonID", PersonId);
            command.Parameters.AddWithValue("@CountryId", info.Country.CountryID > 0 ? (object)info.Country.CountryID : DBNull.Value);
            command.Parameters.AddWithValue("@GovernorateId", info.Governorate.GovernorateID > 0 ? (object)info.Governorate.GovernorateID : DBNull.Value);
            command.Parameters.AddWithValue("@CityId", info.City.CityID > 0 ? (object)info.City.CityID : DBNull.Value);
            command.Parameters.AddWithValue("@BuildNo", info.BuildNo ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Street", info.Street ?? (object)DBNull.Value);
        }
    }
}
