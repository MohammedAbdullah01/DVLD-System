using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.PersonAddresses
{
    public class clsPersonAddresseResult
    {
        public bool Found { get; set; }
        public clsPersonAddresseInfo PersonAddresseInfo { get; set; }
        public string ErrorMessage { get; set; }
    }
}
