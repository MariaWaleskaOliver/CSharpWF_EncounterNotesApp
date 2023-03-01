using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assigment3
{
    public class BPmatch
    {
        public static bool IsBPmatch(ref string bloodPressure)
        {
            if (string.IsNullOrWhiteSpace(bloodPressure))
            {
                return false;
            }
            else
            {
                if (_BP.IsMatch(bloodPressure))
                {
                    return true;
                }

                return false;
            }
        }
         private static Regex _BP = new Regex(@"(BP:?) (\d{2,3}/\d{2,3})");
    }
}
