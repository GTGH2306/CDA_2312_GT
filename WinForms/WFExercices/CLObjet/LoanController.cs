using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CLObjet
{
    public class LoanController
    {
        public static bool ValidateName(string _name)
        {
            return (Regex.IsMatch(_name, "^[a-zA-Z-]+$") && _name.Length > 0);
        }

        public static bool ValidateCapital(string _capital)
        {
            return (decimal.TryParse(_capital, out decimal _number) && _number > 0);
        }
    }
}
