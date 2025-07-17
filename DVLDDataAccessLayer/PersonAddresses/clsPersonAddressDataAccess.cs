using DVLDBusinessLayer.PersonAddresses;
using DVLDDataAccessLayer.Person;
using DVLDDataAccessLayer.PersonAddresses.Cities;
using DVLDDataAccessLayer.PersonAddresses.Countries;
using DVLDDataAccessLayer.PersonAddresses.Governorates;
using DVLDDataAccessLayer.Result_Helper;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.PersonAddresses
{
    public static class clsPersonAddressDataAccess
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        public static clsPersonAddressResult AddNewPersonAddress(clsPersonAddressInfo PersonAddresseInfo,
            SqlConnection connection)
        {
            clsPersonAddressResult resultPersonAddresse = new clsPersonAddressResult();

            if (CheckPersonAddressInfo(PersonAddresseInfo) != null)
            {
                return CheckPersonAddressInfo(PersonAddresseInfo);
            }
            const string query = @"INSERT INTO PersonAddresses (
                                        PersonID, CountryId, GovernorateId, CityId, 
                                        BuildNo, Street) 
                                    VALUES (@PersonID, @CountryId, @GovernorateId, 
                                            @CityId, @BuildNo, @Street); 
                                    SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    AddPersonAddresseParameters(command, PersonAddresseInfo.PersonID, PersonAddresseInfo);

                    connection.Open();

                    object resultSql = command.ExecuteScalar();

                    if (resultSql != null && int.TryParse(resultSql?.ToString(), out int insertedPersonAddresse))
                    {

                        PersonAddresseInfo.PersonAddresseID = insertedPersonAddresse;

                        _logger.Info($"Person Addresse added successfully with Person ID: {PersonAddresseInfo.PersonID}, Address ID {insertedPersonAddresse}");

                        return clsResultBuilder.BuildPersonAddressResult(PersonAddresseInfo,
                            "Person Addresse added successfully");
                    }

                    _logger.Warn($"Failed to get inserted Person Addresse for PersonID : {PersonAddresseInfo.PersonID}");
                    return clsResultBuilder.BuildPersonAddressResult(null,
                        "Failed to retrieve new Person Addresse");
                }
            }
            catch (SqlException sqlEx)
            {
                _logger.Error($"SQL Error adding new person addresse for PersonID : {PersonAddresseInfo.PersonID}. Exception: {sqlEx.Message}", sqlEx);

                return clsResultBuilder.BuildPersonAddressResult(null,
                    $"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                _logger.Error($"General error adding new person addresse: {PersonAddresseInfo.PersonID}. Exception: {ex.Message}", ex);

                return clsResultBuilder.BuildPersonAddressResult(null,
                    $"Unexpected error: {ex.Message}");
            }
        }

        public static clsPersonAddressResult UpdatePersonAddresse(
            clsPersonAddressInfo PersonAddresseInfo,
            SqlConnection connection)
        {
            clsPersonAddressResult resultPersonAddresse = new clsPersonAddressResult();

            if (CheckPersonAddressInfo(PersonAddresseInfo) != null)
            {
                return CheckPersonAddressInfo(PersonAddresseInfo);
            }

            if (PersonAddresseInfo.PersonAddresseID <= 0)
            {
                _logger.Warn("Invalid Person Addresse ID provided for update");

                return clsResultBuilder.BuildPersonAddressResult(null,
                    "Invalid Person Addresse information provided");
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
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    AddPersonAddresseParameters(command, PersonAddresseInfo.PersonID, PersonAddresseInfo);
                    command.Parameters.AddWithValue("@PersonAddresseID", PersonAddresseInfo.PersonAddresseID);

                    int rowAffected = command.ExecuteNonQuery();

                    if (rowAffected > 0)
                    {
                        _logger.Info($"Person Addresse updated successfully for PersonID: {PersonAddresseInfo.PersonID}, Address ID: {PersonAddresseInfo.PersonAddresseID}");

                        return clsResultBuilder.BuildPersonAddressResult(PersonAddresseInfo,
                            "Person Addresse updated successfully");
                    }

                    _logger.Warn($"No rows affected while updating Person Addresse for PersonID: {PersonAddresseInfo.PersonID}, Address ID: {PersonAddresseInfo.PersonAddresseID}");

                    return clsResultBuilder.BuildPersonAddressResult(null,
                        "No rows affected during update");
                }
            }
            catch (SqlException sqlEx)
            {
                _logger.Error($"SQL Error updating Person Addresse for PersonID: {PersonAddresseInfo.PersonID}, Address ID: {PersonAddresseInfo.PersonAddresseID}. Exception: {sqlEx.Message}", sqlEx);

                return clsResultBuilder.BuildPersonAddressResult(null,
                    $"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                _logger.Error($"Error updating Person Addresse for PersonID: {PersonAddresseInfo.PersonID}, Address ID: {PersonAddresseInfo.PersonAddresseID}. Exception: {ex.Message}", ex);

                return clsResultBuilder.BuildPersonAddressResult(null,
                    $"Unexpected error: {ex.Message}");
            }
        }

        public static bool DeletePersonAddresseByPersonID(int PersonID)
        {
            if (PersonID <= 0)
            {
                _logger.Warn("Invalid PersonAddresse The PersonID provided for deletion.");
                return false;
            }
            const string query = @"DELETE FROM PersonAddresses 
                                    WHERE PersonID = @PersonID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    connection.Open();
                    _logger.Debug("Database connection opened successfully.");

                    if(!IsPersonAddressExists(PersonID))
                    {
                        _logger.Warn($"No Person Addresse found with PersonID {PersonID}.");
                        return false;
                    }
                    _logger.Info($"Deleting Person Addresse with for PersonID {PersonID}.");
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                _logger.Error($"SQL Error deleting PersonAddresse with PersonID {PersonID}: {sqlEx.Message}", sqlEx);
                return false;
            }
            catch (Exception ex)
            {
                _logger.Error($"Unexpected error deleting PersonAddresse with PersonID {PersonID}: {ex.Message}", ex);
                return false;
            }
        }

        public static bool IsPersonAddressExists(int PersonID)
        {
            if(PersonID <= 0)
            {
                _logger.Warn($"Invalid PersonID provided: {PersonID}");
                return false;
            }
            const string query = @"SELECT COUNT(1) FROM PersonAddresses WHERE PersonID = @PersonID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    connection.Open();
                    _logger.Debug("Database connection opened successfully.");


                    _logger.Info($"Checking existence of PersonAddresse for PersonID {PersonID}.");
                    if (!clsPersonDataAccess.IsPersonExistsID(PersonID))
                    {
                        _logger.Warn($"Person with ID {PersonID} does not exist.");
                        return false;
                    }
                    
                    _logger.Debug($"Executing query to check existence of PersonAddresse with ID {PersonID}.");
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                _logger.Error($"SQL Error checking existence of PersonAddresse with PersonID {PersonID}: {sqlEx.Message}", sqlEx);
                return false;
            }
            catch (Exception ex)
            {
                _logger.Error($"Unexpected error checking existence of PersonAddresse with PersonID {PersonID}: {ex.Message}", ex);
                return false;
            }

        }

        //Helper Methods 
        private static clsPersonAddressResult CheckPersonAddressInfo(clsPersonAddressInfo PersonAddresseInfo)
        {
            if (PersonAddresseInfo == null)
            {
                _logger.Warn("Person Addresse Info object is null");
                return clsResultBuilder.BuildPersonAddressResult(null ,
                    "Must Be Person Address Info Require");
            }
            if (PersonAddresseInfo.PersonID <= 0)
            {
                _logger.Warn($"Invalid PersonID provided: {PersonAddresseInfo.PersonID}");
                return clsResultBuilder.BuildPersonAddressResult(null,
                    "Invalid PersonID provided");
            }

            if (IsNullCountry(PersonAddresseInfo.Country)  
                || IsNullGovernorate(PersonAddresseInfo.Governorate)
                || IsNullCity(PersonAddresseInfo.City))
            {
                _logger.Warn("Country, Governorate, or City information is missing in Person Addresse Info");
                return clsResultBuilder.BuildPersonAddressResult(null,
                    "Country, Governorate, or City information is required.");
            }

            if (!clsGovernorateDataAccess.IsGovernorateExists(PersonAddresseInfo.Governorate.GovernorateID)
                || !clsCountryDataAccess.IsCountryExists(PersonAddresseInfo.Country.CountryID)
                || !clsCityDataAccess.IsCityExists(PersonAddresseInfo.City.CityID))
            {
                _logger.Warn($"Invalid Country, Governorate, or City for PersonID: {PersonAddresseInfo.PersonID}");
                return clsResultBuilder.BuildPersonAddressResult(null,
                    "Invalid Country, Governorate, or City information provided.");
            }

            if (!clsPersonDataAccess.IsPersonExistsID(PersonAddresseInfo.PersonID))
            {
                _logger.Warn($"Person with ID {PersonAddresseInfo.PersonID} does not exist");

                return clsResultBuilder.BuildPersonAddressResult(null,
                    "Person does not exist");
            }

            return null;
        }

        private static bool IsNullCountry(clsCountryInfo countryInfo)
        {
            return countryInfo == null;
        }

        private static bool IsNullGovernorate(clsGovernorateInfo governorateInfo)
        {
            return governorateInfo == null;
        }

        private static bool IsNullCity(clsCityInfo cityInfo)
        {
            return cityInfo == null;
        }

        private static void AddPersonAddresseParameters(SqlCommand command, int PersonId ,clsPersonAddressInfo info)
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
