using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nomadic
{
    static class Reg
    {
        public static bool ValidateEmail(string emailAddress)
        {
            var regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            return Regex.IsMatch(emailAddress, regex, RegexOptions.IgnoreCase);
        }
        public static bool ValidatePassword(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(password))
            {
                return false;
            }
            else if (!hasUpperChar.IsMatch(password))
            {
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(password))
            {
                return false;
            }
            else if (!hasNumber.IsMatch(password))
            {
                return false;
            }
            else if (!hasSymbols.IsMatch(password))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
