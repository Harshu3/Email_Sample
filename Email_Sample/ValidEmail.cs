using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Email_Sample
{
    public class ValidEmail
    {
        public string email = "^[a-z]{3,}(([.|+]{1})?([-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.com|net(.com|au)?$";

        public string CheckValidEmail(string data)
        {
            Console.Write("\n" + data + ": ");
            string res = Regex.IsMatch(data, email) ? "Valid" : "Invalid";
            return res;
        }
    }
}
