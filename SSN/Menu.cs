using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SSN
{
    class Menu
    {
        public static bool Show(string VId)
        {
            Regex comparator = new Regex(@"^(?!666|000|9\d{2})\d{3}-(?!00)\d{2}-(?!0{4})\d{4}$");

            if (VId == null)
            {
                return false;
            }
            else
            {
                bool matching = comparator.IsMatch(VId);
                if (matching)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
