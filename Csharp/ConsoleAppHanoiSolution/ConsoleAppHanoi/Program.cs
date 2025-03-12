using ClassLibraryHanoi;

namespace ConsoleAppHanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game hanoi = new Game(5);
            Console.WriteLine(hanoi.ToString());
            hanoi.Pile();
            Console.WriteLine(hanoi.ToString());
        }
    }
}
