using DVLDBusinessLayer.PersonAddresses;
using DVLDDataAccessLayer.MessageContainer;
using DVLDDataAccessLayer.Person;
using DVLDDataAccessLayer.PersonAddresses.Cities;
using DVLDDataAccessLayer.PersonAddresses.Countries;
using DVLDDataAccessLayer.PersonAddresses.Governorates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.Result_Helper
{
    public static class clsResultBuilder
    {
        public static clsCityInfoResult BuildCityResult(clsCityInfo city, string message)
        {
            return new clsCityInfoResult
            {
                Found = city != null,

                City = city,

                GetMessage = city != null
                    ? Message.FromSuccess(message)
                    : Message.FromError(message)
            };
        }

        public static clsCityInfoResult BuildCityResult(List<clsCityInfo> cities, string message)
        {
            return new clsCityInfoResult
            {
                Found = cities.Count > 0,

                Cities = cities.Count > 0 ? cities : null,

                GetMessage = cities.Count == 0 
                    ? Message.FromError(message) 
                    : Message.FromSuccess(message)
            };
        }

        public static clsGovernorateInfoResult BuildGovernorateResult(clsGovernorateInfo gov,  string message)
        {
            return new clsGovernorateInfoResult
            {
                Found = gov != null,
                Governorate = gov,
                GetMessage = gov != null
                    ? Message.FromSuccess(message)
                    : Message.FromError(message)
            };
        }

        public static clsGovernorateInfoResult BuildGovernorateResult(List<clsGovernorateInfo> govs, string message)
        {
            return new clsGovernorateInfoResult
            {
                Found = govs.Count > 0,

                Governorates = govs.Count > 0 ? govs : null,

                GetMessage = govs.Count == 0 
                    ? Message.FromError(message) 
                    : Message.FromSuccess(message)
            };
        }

        public static clsCountryInfoResult BuildCountryResult(clsCountryInfo country, string message)
        {
            return new clsCountryInfoResult
            {
                Found = country != null,

                Country = country,

                GetMessage = country != null 
                    ?  Message.FromSuccess(message) 
                    : Message.FromError(message)
            };
        }

        public static clsCountryInfoResult BuildCountryResult(List<clsCountryInfo> countries, string message)
        {
            return new clsCountryInfoResult
            {
                Found = countries.Count > 0,

                Countries = countries.Count > 0 ? countries : null,

                GetMessage = countries.Count == 0 
                    ? Message.FromError(message) 
                    : Message.FromSuccess(message)
            };
        }

        public static clsPersonInfoResult BuildPersonResult(clsPersonInfo person, string message)
        {
            return new clsPersonInfoResult
            {
                Found = person != null,
                Person = person,
                MessageContainer = person != null 
                    ? Message.FromSuccess(message) 
                    : Message.FromError(message)
            };
        }
}
}
