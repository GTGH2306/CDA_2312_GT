using ClassLibraryPoint;
using System.Runtime.CompilerServices;

namespace ConsoleAppPoint
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point pointA = new Point();
            Point pointB = new Point(4, 8);
            Point pointC = new Point(pointB);

            Console.WriteLine(pointA); // 0 0
            Console.WriteLine(pointB); // 4 8
            Console.WriteLine(pointC); // 4 8
            pointC.Deplacer(5, 3);
            Console.WriteLine(pointC); // 5 3
            Point pointD = new Point(pointC.SymetrieAbscisse());
            Console.WriteLine(pointD); // -5 3
            Point pointE = new Point(pointC.SymetrieOrdonnee());
            Console.WriteLine(pointE); // 5 -3
            Point pointF = new Point(pointC.SymetrieOrigine());
            Console.WriteLine(pointF); // -5 -3
            pointB.Permuter();
            Console.WriteLine(pointB); // 8 4
        }
    }
}