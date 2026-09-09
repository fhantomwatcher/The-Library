using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TheLibrary.HelperLib
{
    public static class InputValidationHelper
    {
        // Check empty or spaces
        public static bool IsEmpty(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        // Check valid email
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // Check password
        public static bool IsValidPassword(string password)
        {
            return !string.IsNullOrWhiteSpace(password)
                   && password.Length >= 6;
        }
    }
}
