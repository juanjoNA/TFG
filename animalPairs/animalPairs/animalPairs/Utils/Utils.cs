using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace animalPairs.Utils
{
    public class Utils
    {
        public static bool isValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return true;
            }

            if (password.Length >= 6 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber))
            {
                return true;
            }
            
            return false;
        }

        public static bool isValidEmail(string email)
        {
            var regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            return regex.IsMatch(email) && !email.EndsWith(".");
        }
    }


}
