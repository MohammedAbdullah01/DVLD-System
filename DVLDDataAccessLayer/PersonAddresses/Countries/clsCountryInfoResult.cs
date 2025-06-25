using DVLDDataAccessLayer.MessageContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.PersonAddresses.Countries
{
    public class clsCountryInfoResult
    {
        public bool Found { get; set; }
        public List<clsCountryInfo> Countries { get; set; }
        public clsCountryInfo Country { get; set; }
        public Message GetMessage { get; set; }
    }
}
