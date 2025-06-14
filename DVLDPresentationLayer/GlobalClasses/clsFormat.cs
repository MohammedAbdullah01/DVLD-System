using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDPresentationLayer.GlobalClasses
{
    public class clsFormat
    {
        public static string DateToShort(DateTime date)
        {
            return date.ToString("MM/dd/yyyy");
        }
    }
}
