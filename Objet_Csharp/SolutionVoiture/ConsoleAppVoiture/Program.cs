using LibVoiture;

namespace ConsoleAppVoiture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bagnole totomobile = new Bagnole();
            Console.WriteLine(totomobile + "\n");
            Console.WriteLine(totomobile.Avancer()); //false
            Console.WriteLine(totomobile.Demarrer()); //true
            Console.WriteLine(totomobile.Demarrer()); //false
            Console.WriteLine(totomobile.Avancer()); //true, delta 1
            Console.WriteLine(totomobile.Avancer()); //true, delta 2
            Console.WriteLine(totomobile.Avancer()); //true, delta 3
            Console.WriteLine(totomobile + "\n");
            Console.WriteLine(totomobile.Reculer());//false, delta 2
            Console.WriteLine(totomobile + "\n");
            totomobile.Freiner(); //delta 1, roues= freinage
            Console.WriteLine(totomobile + "\n");
            totomobile.Freiner(); //delta 0, roues= arret
            Console.WriteLine(totomobile + "\n");
        }

    }
}