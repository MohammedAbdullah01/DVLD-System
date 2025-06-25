using DVLDBusinessLayer.PersonAddresses;
using DVLDDataAccessLayer.Person;
using DVLDDataAccessLayer.PersonAddresses;
using DVLDDataAccessLayer.PersonAddresses.Cities;
using DVLDDataAccessLayer.PersonAddresses.Countries;
using DVLDDataAccessLayer.PersonAddresses.Governorates;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.EntityMapperUtilities
{
    public static class clsEntityMapper
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public static clsPersonInfo MapReaderToPerson(SqlDataReader reader)
        {
            if (reader == null || !reader.HasRows)
            {
                _logger.Warn("No data found in reader to map to clsPersonInfo");
                return null;
            }

            _logger.Debug("Mapping SqlDataReader to clsPersonInfo");
            return new clsPersonInfo()
            {
                PersonID = (int)reader["id"],
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
                                : DateTime.MinValue,

                PersonAddresseInfo = MapReaderToPersonAddress(reader)
            };
        }

        public static clsCityInfo MapToCity(SqlDataReader reader)
        {
            if (reader == null || !reader.HasRows)
            {
                _logger.Warn("No data found in reader to map to City Info");
                return null;
            }

            _logger.Debug("Mapping SqlDataReader to City Info");
            return new clsCityInfo
            {
                CityID = (int)reader["id"],
                NameEN = reader["NameEN"].ToString(),
                NameAR = reader["NameAR"].ToString()
            };
        }

        public static clsGovernorateInfo MapToGovernorate(SqlDataReader reader, int GovernorateID = 0)
        {
            if (reader == null || !reader.HasRows)
            {
                _logger.Warn("No data found in reader to map to Governorate Info");
                return null;
            }

            _logger.Debug("Mapping SqlDataReader to Governorate Info");

            return new clsGovernorateInfo
            {
                GovernorateID = GovernorateID == 0 ? (int)reader["id"] : GovernorateID,
                GovernorateNameEN = reader["NameEN"].ToString(),
                GovernorateNameAR = reader["NameAR"].ToString()
            };
        }

        public static clsCountryInfo MapToCountry(SqlDataReader reader, int countryID = 0)
        {
            if (reader == null || !reader.HasRows)
            {
                _logger.Warn("No data found in reader to map to Country Info");
                return null;
            }

            _logger.Debug("Mapping SqlDataReader to Country Info");
            return new clsCountryInfo
            {
                CountryID = countryID == 0 ? (int)reader["id"] : countryID,
                NameEN = reader["CountryNameEN"].ToString(),
                NameAR = reader["CountryNameAR"].ToString()
            };
        }

        public static clsPersonAddressInfo MapReaderToPersonAddress(SqlDataReader reader)
        {
            if(reader == null || !reader.HasRows)
            {
                _logger.Warn("No data found in reader to map to PersonAddress Info");
                return null;
            }

            _logger.Debug("Mapping SqlDataReader to PersonAddress Info");

            clsCountryInfoResult countryInfoResult = clsCountryDataAccess.GetCountryByID(
                Convert.ToInt32(reader["CountryId"]));

            clsCityInfoResult clsCityInfoResult = clsCityDataAccess.GetCityByID(
                Convert.ToInt32(reader["CityId"]));

            clsGovernorateInfoResult governorateInfoResult = clsGovernorateDataAccess.GetGovernorateByID(
                Convert.ToInt32(reader["GovernorateId"]));

            return new clsPersonAddressInfo
            {
                Country = countryInfoResult.Found ? countryInfoResult.Country : null,
                City = clsCityInfoResult.Found ? clsCityInfoResult.City : null,
                Governorate = governorateInfoResult.Found ? governorateInfoResult.Governorate : null,
                PersonAddresseID = (int)reader["PersonAddresseID"],
                PersonID = (int)reader["PersonID"],
                BuildNo = reader["BuildNo"]?.ToString() ?? string.Empty,
                Street = reader["Street"]?.ToString() ?? string.Empty,
            };

        }
    }
}
