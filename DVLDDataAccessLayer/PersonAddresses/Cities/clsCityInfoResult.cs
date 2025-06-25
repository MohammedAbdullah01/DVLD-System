using DVLDBusinessLayer.PersonAddresses;
using DVLDDataAccessLayer.MessageContainer;
using DVLDDataAccessLayer.PersonAddresses.Governorates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.PersonAddresses.Cities
{
    public class clsCityInfoResult
    {
        public bool Found { get; set; }
        public List<clsCityInfo> Cities { get; set; }
        public clsCityInfo City { get; set; }
        public Message GetMessage { get; set; }
    }
}
