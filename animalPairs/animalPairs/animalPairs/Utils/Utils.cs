using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            if (password.Length < 7 || !password.Any(char.IsUpper) || !password.Any(char.IsLower) || password.Contains(" "))
            {
                return false;
            }
            
            return true;
        }
    }
}
