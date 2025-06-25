using DVLDBusinessLayer.PersonAddresses;
using DVLDDataAccessLayer.PersonAddresses.Cities;
using DVLDDataAccessLayer.PersonAddresses.Countries;
using DVLDDataAccessLayer.PersonAddresses.Governorates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.PersonAddresses
{
    public class clsPersonAddressInfo
    {
        public int PersonAddresseID { get; set; }
        public int PersonID { get; set; }
        public clsCountryInfo Country { get; set; }
        public clsGovernorateInfo Governorate { get; set; }
        public clsCityInfo City { get; set; }
        public string BuildNo { get; set; }
        public string Street { get; set; }

    }
}
