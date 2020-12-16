using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace treeStar
{
    /// <summary>
    /// Repository of staic validation methods
    /// </summary>
    public class Validator
    {
        public static bool IsPresent(string input)
        {
            bool isValid = true; // assume is true and check otherwise

            if(input == null || input == "")
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
