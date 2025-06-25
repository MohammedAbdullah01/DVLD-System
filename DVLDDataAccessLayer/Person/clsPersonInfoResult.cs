using DVLDDataAccessLayer.MessageContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.Person
{
    public class clsPersonInfoResult
    {
        public bool Found { get; set; }
        public clsPersonInfo Person { get; set; }
        public Message MessageContainer { get; set; }
    }
}
