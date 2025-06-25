using DVLDBusinessLayer.PersonAddresses;
using DVLDDataAccessLayer.EntityMapperUtilities;
using DVLDDataAccessLayer.PersonAddresses.Governorates;
using DVLDDataAccessLayer.Result_Helper;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace DVLDDataAccessLayer.PersonAddresses.Cities
{
    public class clsCityDataAccess 
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public static clsCityInfoResult GetAllCities(int GovernorateID)
        {
            List<clsCityInfo> Cities = new List<clsCityInfo>();
            clsGovernorateInfo Governorate = new clsGovernorateInfo { GovernorateID = GovernorateID };

            const string query = @"SELECT C.id, C.NameEN, C.NameAR, 
                                    G.NameEN as GovernorateNameEN, 
                                    G.NameAR as GovernorateNameAR 
                                FROM Cities as C
                                INNER JOIN Governorates as G
                                ON G.id = C.GovernorateId
                                WHERE GovernorateId = @GovernorateID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GovernorateId", GovernorateID);

                    connection.Open();
                    _logger.Debug("Database connection opened successfully");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            _logger.Warn($"No cities found for GovernorateID {GovernorateID}");
                            return clsResultBuilder.BuildCityResult(Cities, 
                                "No cities found for the specified governorate.");
                        }

                        while (reader.Read())
                        {
                            Cities.Add(clsEntityMapper.MapToCity(reader));
                        }

                        _logger.Info($"{Cities.Count} cities were retrieved from the database.");

                        return clsResultBuilder.BuildCityResult(Cities,"Cities retrieved successfully");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                _logger.Error($"SQL error while retrieving cities: {sqlEx.Message}", sqlEx);

                return clsResultBuilder.BuildCityResult(Cities, $"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                _logger.Error($"Unexpected error while retrieving cities: {ex.Message}", ex);
                return clsResultBuilder.BuildCityResult(Cities, $"Unexpected error: {ex.Message}");
            }
        }

        public static clsCityInfoResult GetCityByID(int CityID)
        {
            clsCityInfo city = new clsCityInfo();
            if(CityID <= 0)
            {
                _logger.Warn("Invalid CityID provided.");

                return clsResultBuilder.BuildCityResult(city,
                    "Invalid CityID provided.");
            }

            const string query = @"SELECT 
                                    C.id, C.NameEN, C.NameAR,
                                    G.NameEN as GovernorateNameEN, 
                                    G.NameAR as GovernorateNameAR
                                FROM Cities as C
                                INNER JOIN Governorates as G
                                ON G.id = C.GovernorateId
                                WHERE C.id = @CityID";

            using (Sql )
        }
    }
}
