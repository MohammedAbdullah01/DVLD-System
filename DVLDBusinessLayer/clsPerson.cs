using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsPerson
    {
        public int Id { get; private set; }
        public int  NationalNumber { get; private set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
	    public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string ProfilePicture { get; set; }
    }
}
