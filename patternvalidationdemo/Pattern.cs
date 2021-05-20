using System;
using System.Collections.Generic;
using System.Text;

namespace RegexpPatternValidationDemo
{
    class Pattern
    {
        public static string REZIX_PINCODE = "^[1-9][0-9]{5}$";

            public bool validatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE);
        }
    }
}
