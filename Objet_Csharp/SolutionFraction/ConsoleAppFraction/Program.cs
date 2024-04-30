using ClassLibraryFraction;
using System.Runtime.CompilerServices;

namespace ConsoleAppFraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fracTest = new Fraction(12, 7);
            Console.WriteLine(new Fraction(fracTest));
            Console.WriteLine(new Fraction(9));
            Console.WriteLine(new Fraction());

            fracTest.Oppose();
            Console.WriteLine(fracTest);
            fracTest.Inverse();
            Console.WriteLine(fracTest);

            Fraction fracTest2 = new Fraction(120, -150);
            Console.WriteLine(fracTest2.ToDisplay());
            Console.WriteLine(new Fraction(1, 2) + new Fraction(1, 4));
            Console.WriteLine(new Fraction(3, 4) - new Fraction(1, 4));
            Console.WriteLine(new Fraction(2, 4) * new Fraction(4, 2));
            Console.WriteLine(new Fraction(2, 4) / new Fraction(4, 2));

            Fraction fracTestImpossible = new Fraction(2, 0);

        }
    }
}