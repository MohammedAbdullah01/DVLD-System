using DVLDDataAccessLayer.EntityMapperUtilities;
using DVLDDataAccessLayer.Result_Helper;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.PersonAddresses.Countries
{
    public class clsCountryDataAccess
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        public static clsCountryInfoResult GetAllCountries()
        {
                       List<clsCountryInfo> countries = new List<clsCountryInfo>();
            const string query = @"SELECT id, NameEN, NameAR FROM Countries";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    _logger.Debug("Database connection opened successfully.");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            _logger.Warn("No countries found in the database.");
                            return clsResultBuilder.BuildCountryResult(countries, "No countries found.");
                        }
                        while (reader.Read())
                        {
                            countries.Add(clsEntityMapper.MapToCountry(reader));
                        }

                        _logger.Info($"{countries.Count} countries were retrieved from the database.");
                        
                        return clsResultBuilder.BuildCountryResult(countries, 
                            "Countries retrieved successfully");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                _logger.Error(sqlEx, "SQL error while retrieving countries.");

                return clsResultBuilder.BuildCountryResult(countries, 
                    $"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "An error occurred while retrieving countries.");

                return clsResultBuilder.BuildCountryResult(countries, 
                    "An error occurred while retrieving countries.");
            }
        }

        public static clsCountryInfoResult GetCountryByID(int CountryID)
        {
            clsCountryInfo country = new clsCountryInfo();

            if (CountryID <= 0)
            {
                _logger.Warn("Invalid CountryID provided.");
                return clsResultBuilder.BuildCountryResult(country, "Invalid CountryID provided.");
            }

            const string query = @"SELECT id, NameEN, NameAR FROM Countries WHERE id = @CountryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CountryID", CountryID);
                    connection.Open();
                    _logger.Debug("Database connection opened successfully.");
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            _logger.Warn($"No country found with CountryID {CountryID}.");
                            return clsResultBuilder.BuildCountryResult(country, 
                                "No country found with the specified ID.");
                        }

                        country = clsEntityMapper.MapToCountry(reader, CountryID);
                        
                        _logger.Info($"Country with ID {CountryID} was retrieved from the database.");
                        
                        return clsResultBuilder.BuildCountryResult(country, 
                            "Country retrieved successfully");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                _logger.Error(sqlEx, "SQL error while retrieving country by ID.");
                return clsResultBuilder.BuildCountryResult(country, 
                    $"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "An error occurred while retrieving country by ID.");
                return clsResultBuilder.BuildCountryResult(country, 
                    "An error occurred while retrieving the country.");
            }
        }
    }
}
