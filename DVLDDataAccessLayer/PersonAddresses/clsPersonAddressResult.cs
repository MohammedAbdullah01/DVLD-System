using DVLDDataAccessLayer.MessageContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.PersonAddresses
{
    public class clsPersonAddressResult
    {
        public bool Found { get; set; }
        public clsPersonAddressInfo PersonAddresse { get; set; }
        public Message GetMessage { get; set; }
    }
}
