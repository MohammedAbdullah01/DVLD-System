using DVLDDataAccessLayer.PersonAddresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.Person
{
    public class clsPersonInfo
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NationalNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }
        public string ProfilePicture { get; set; }
        public clsPersonAddressInfo PersonAddresseInfo { get; set; }
    }
}
