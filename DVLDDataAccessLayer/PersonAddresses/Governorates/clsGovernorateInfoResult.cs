using DVLDDataAccessLayer.MessageContainer;
using DVLDDataAccessLayer.PersonAddresses.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.PersonAddresses.Governorates
{
    public class clsGovernorateInfoResult
    {
        public bool Found { get; set; }
        public List<clsGovernorateInfo> Governorates { get; set; }
        public clsGovernorateInfo Governorate { get; set; }
        public Message GetMessage { get; set; }
    }
}
