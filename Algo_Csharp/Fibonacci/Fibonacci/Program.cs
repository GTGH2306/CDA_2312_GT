using System.Numerics;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleFibonacciRecursive();
        }

        static string SuiteFibonacci(int _nombre)
        {
            int position;
            string resultat;
            long nbPrecedent;
            long nbCourant;
            long nbSuivant;

            position = 2;
            resultat = "0\n1";
            nbPrecedent = 0;
            nbCourant = 1;

            if (_nombre > 2)
            {
                while (position < _nombre)
                {
                    nbSuivant = nbPrecedent + nbCourant;
                    resultat += "\n" + nbSuivant;
                    nbPrecedent = nbCourant;
                    nbCourant = nbSuivant;
                    position++;

                }
            }
            else
            {
                _nombre = 2;
            }
            return "Les " + _nombre + " premiers nombres de la suite de fibonacci sont:\n" + resultat;

        }

        static List<BigInteger> SuiteFibonacciRecursive(int _nombre)
        {

            List<BigInteger> resultat;

            if (_nombre > 2)
            {
                resultat = SuiteFibonacciRecursive(_nombre - 1);
                resultat.Add(resultat[^1] + resultat[^2]);
            }
            else
            {
                resultat = new();
                resultat.Add(0);
                resultat.Add(1);
            }

            return resultat;
        }

        static void ConsoleFibonacciRecursive()
        {
            Console.WriteLine("Combien de nombre à la suite souhaitez vous afficher?");
            int n;
            string saisie;
            string affichage;
            List<BigInteger> fibo;

            saisie = Console.ReadLine();
            int.TryParse(saisie, out n);

            fibo = SuiteFibonacciRecursive(n);

            affichage = "Les " + n + " premiers nombres de la suite de fibonacci sont:";
            foreach (BigInteger e in fibo)
            {
                affichage += "\n" + e.ToString();
            }
            Console.WriteLine(affichage);
        }
    }
}