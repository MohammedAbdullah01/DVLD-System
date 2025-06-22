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
        public static clsPersonAddresseResult AddNewPersonAddresse(int PersonID , clsPersonAddresseInfo PersonAddresseInfo)
        {
            clsPersonAddresseResult resultPersonAddresse = new clsPersonAddresseResult();

            if (PersonID <= 0)
            {
                resultPersonAddresse.Found = false;
                resultPersonAddresse.ErrorMessage = "Invalid PersonID";
                return resultPersonAddresse;
            }

            if (!clsPersonDataAccess.IsPersonExistsID(PersonID))
            {
                resultPersonAddresse.Found = false;
                resultPersonAddresse.ErrorMessage = "Person does not exist.";
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
                    AddPersonAddresseParameters(command, PersonID, PersonAddresseInfo);

                    connection.Open();

                    object resultSql = command.ExecuteScalar();

                    if (resultSql != null && int.TryParse(resultSql?.ToString(), out int insertedPersonAddresse))
                    {

                        PersonAddresseInfo.PersonAddresseID = insertedPersonAddresse;

                        logger.Info($"Person Addresse added successfully with Person ID: {PersonID}, Address ID {insertedPersonAddresse}");

                        resultPersonAddresse.Found = true;
                        resultPersonAddresse.PersonAddresseInfo = PersonAddresseInfo;
                        return resultPersonAddresse;
                    }
                    else
                    {
                        logger.Warn($"Failed to get inserted Person Addresse for PersonID : {PersonID}");
                        resultPersonAddresse.Found = false;
                        resultPersonAddresse.ErrorMessage = "Failed to retrieve new Person Addresse";
                        return resultPersonAddresse;
                    }
                }

            }
            catch (SqlException sqlEx)
            {
                logger.Error($"SQL Error adding new person addresse for PersonID : {PersonID}. Exception: {sqlEx.Message}", sqlEx);
                resultPersonAddresse.Found = false;
                resultPersonAddresse.ErrorMessage = $"Database error: {sqlEx.Message}";
                return resultPersonAddresse;
            }
            catch (Exception ex)
            {
                logger.Error($"General error adding new person addresse: {PersonID}. Exception: {ex.Message}", ex);
                resultPersonAddresse.Found = false;
                resultPersonAddresse.ErrorMessage = $"Unexpected error: {ex.Message}";
                return resultPersonAddresse;
            }
        }

        //Helper Methods 
        private static void AddPersonAddresseParameters(SqlCommand command, int PersonId ,clsPersonAddresseInfo info)
        {
            command.Parameters.AddWithValue("@PersonID", PersonId);
            command.Parameters.AddWithValue("@CountryId", info.CountryID > 0 ? (object)info.CountryID : DBNull.Value);
            command.Parameters.AddWithValue("@GovernorateId", info.GovernorateID > 0 ? (object)info.GovernorateID : DBNull.Value);
            command.Parameters.AddWithValue("@CityId", info.CityID > 0 ? (object)info.CityID : DBNull.Value);
            command.Parameters.AddWithValue("@BuildNo", info.BuildNo ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Street", info.Street ?? (object)DBNull.Value);
        }
    }
}
