using DVLDDataAccessLayer.EntityMapperUtilities;
using DVLDDataAccessLayer.PersonAddresses.Countries;
using DVLDDataAccessLayer.Result_Helper;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer.PersonAddresses.Governorates
{
    public class clsGovernorateDataAccess
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public static clsGovernorateInfoResult GetAllGovernoratesFoundByCountry(int countryID)
        {
            List<clsGovernorateInfo> Governorates = new List<clsGovernorateInfo>();

            const string query = @"SELECT 
                                    G.id, G.NameEN, G.NameAR ,
                                    C.NameEN as CountryNameEN, 
                                    C.NameAR as CountryNameAR
                                FROM Governorates as G
                                INNER JOIN Countries as C 
                                ON G.CountryId = C.id
                                WHERE CountryId = @CountryId";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CountryId", countryID);

                    connection.Open();
                    _logger.Debug("Database connection opened successfully.");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            _logger.Warn($"No governorates found for CountryID {countryID}.");

                            return clsResultBuilder.BuildGovernorateResult(Governorates,
                                "No governorates found for the specified country.");
                        }

                        while (reader.Read())
                        {
                            clsGovernorateInfo governorate = clsEntityMapper.MapToGovernorate(reader);

                            Governorates.Add(governorate);
                        }

                        _logger.Info($"{Governorates.Count} governorates were retrieved from " +
                            $"the database.");

                        return clsResultBuilder.BuildGovernorateResult(Governorates,
                            "Governorates retrieved successfully");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                _logger.Error($"SQL Error retrieving governorates for " +
                    $"CountryID {countryID}: {sqlEx.Message}", sqlEx);

                return clsResultBuilder.BuildGovernorateResult(Governorates,
                                $"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                _logger.Error($"Unexpected error retrieving governorates for " +
                    $"CountryID {countryID}: {ex.Message}", ex);

                return clsResultBuilder.BuildGovernorateResult(Governorates,
                                $"Unexpected error: {ex.Message}");
            }
        }

        public static clsGovernorateInfoResult GetGovernorateByID(int governorateID)
        {
            clsGovernorateInfo governorate = new clsGovernorateInfo();

            if (governorateID <= 0)
            {
                _logger.Warn("Invalid GovernorateID provided.");
                return clsResultBuilder.BuildGovernorateResult(governorate,
                    "Invalid GovernorateID provided.");
            }
            const string query = @"SELECT 
                                    G.id, G.NameEN, G.NameAR,
                                    C.NameEN as CountryNameEN, 
                                    C.NameAR as CountryNameAR
                                FROM Governorates as G
                                INNER JOIN Countries as C 
                                ON G.CountryId = C.id
                                WHERE G.id = @GovernorateID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GovernorateID", governorateID);
                    connection.Open();
                    _logger.Debug("Database connection opened successfully.");
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            _logger.Warn($"No governorate found for GovernorateID {governorateID}.");
                            return clsResultBuilder.BuildGovernorateResult(governorate,
                                "No governorate found for the specified ID.");
                        }

                        governorate = clsEntityMapper.MapToGovernorate(reader, governorateID);

                        _logger.Info($"Governorate with ID {governorateID} " +
                            $"was retrieved from the database.");

                        return clsResultBuilder.BuildGovernorateResult(governorate,
                            "Governorate retrieved successfully");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                _logger.Error($"SQL Error retrieving governorate with ID {governorateID}: {sqlEx.Message}", sqlEx);
                return clsResultBuilder.BuildGovernorateResult(governorate,
                                $"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                _logger.Error($"Unexpected error retrieving governorate with ID {governorateID}: {ex.Message}", ex);
                return clsResultBuilder.BuildGovernorateResult(governorate,
                                $"Unexpected error: {ex.Message}");
            }
        }
    }
}
