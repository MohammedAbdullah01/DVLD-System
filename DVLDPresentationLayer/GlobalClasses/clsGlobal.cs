using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDPresentationLayer.GlobalClasses
{
    public class clsGlobal
    {
        //public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string username , string password)
        {
            return false; 
        }

        public static bool GetStoredCredential(ref string username, ref string password)
        {
            return false;
        }
    }
}
