using System.Text;

namespace ClassLibraryFizzBuzz
{
    public static class FizzBuzz
    {
        public static string RollAll(int _total)
        {
            StringBuilder result = new StringBuilder();
            for(int i = 1; i <= _total; i++)
            {
                result.Append(Roll(i));
                if (i != _total)
                {
                    result.Append('\n');
                }
            }
            return result.ToString();
        }
        public static string RollAll()
        {
            return RollAll(100);
        }
        public static string Roll(int _number)
        {
            StringBuilder result = new StringBuilder();

            if (_number % 5 != 0 && _number % 3 != 0)
            {
                return _number.ToString();
            }
            if (_number % 3 == 0)
            {
                result.Append("Fizz");
            }
            if (_number % 5 == 0)
            {
                result.Append("Buzz");
            }
            return result.ToString();
        }
    }
}
