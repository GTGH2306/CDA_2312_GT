namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien de nombre à la suite souhaitez vous afficher?");
            int n;
            string saisie = Console.ReadLine();
            int.TryParse(saisie, out n);
            Console.WriteLine(SuiteFibonacciRecursive(n));
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

        static string SuiteFibonacciRecursive(int _nombre)
        {
            string resultat;
            resultat = "0\n1";
            string[] resultatTab = resultat.Split('\n');

            if (_nombre >= 2)
            {
                resultat += SuiteFibonacciRecursive(_nombre - 1) + "\n" + (long.Parse(resultatTab[resultatTab.Length - 1]) + long.Parse(resultatTab[resultatTab.Length - 2]));
            } else
            {
                resultat = "Les " + _nombre + " premiers nombres de la suite de fibonacci sont:\n" + resultat;
            }
            return resultat;

        }


    }
}