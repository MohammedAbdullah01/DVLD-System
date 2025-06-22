using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.PersonAddresses
{
    public class clsPersonAddresseInfo
    {
        public int PersonAddresseID { get; set; }
        public int PersonID { get; set; }
        public int CountryID { get; set; }
        public int GovernorateID { get; set; }
        public int CityID { get; set; }
        public string BuildNo { get; set; }
        public string Street { get; set; }

    }
}
