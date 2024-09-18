using CLObjet;

namespace ConsoleAppTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loan loan = new Loan("Toto", 150000, 120, 3, 8);
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
        }
    }
}
