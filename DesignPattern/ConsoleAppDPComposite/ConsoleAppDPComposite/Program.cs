using CLDesignPattern;

namespace ConsoleAppDPComposite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition monAddition = new Addition(new Entier(3), new Addition(new Entier(2), new Entier(3)));
            Console.WriteLine(monAddition.Formate());
            Console.WriteLine(new Entier(3).Formate());


            Addition monOperation = new Addition(new Entier(14), new Soustraction(new Entier(5), new Entier(3)));
            Console.WriteLine(monOperation.Formate());
        }
    }
}
