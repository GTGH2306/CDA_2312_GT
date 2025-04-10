using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFizzBuzz
{
    public static class FizzBuzzTDD
    {
        public static string Roll(int _number)
        {
            if (_number % 15 == 0) return "FizzBuzz";
            if (_number % 3 == 0) return "Fizz";
            if (_number % 5 == 0) return "Buzz";
            return _number.ToString();
        }
    }
}
