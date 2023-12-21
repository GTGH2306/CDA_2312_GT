using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace NbParfait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string saisie = "";
            do
            {
                long[] nbParfaits;

                Console.WriteLine("Combien de nombre parfaits souhaitez-vous afficher ?");
                nbParfaits = new long[int.Parse(Console.ReadLine())];

                for (int i = 0; i < nbParfaits.Length; i++)
                {
                    for (long j = 2; nbParfaits[i] == 0; j++)
                    {
                        if (EstParfait(j) && !(EstPresent(j, nbParfaits)))
                        {
                            nbParfaits[i] = j;
                        }
                    }
                }

                for (int i = 0; i < nbParfaits.Length; i++)
                {
                    Console.WriteLine(nbParfaits[i] + " est un nombre parfait.");
                }

                Console.WriteLine("Quitter? (Q):");
                saisie = Console.ReadLine();
            } while (saisie != "q" && saisie != "Q");

        }

        static bool EstParfait(long _nb)
        {

            bool retour = false;
            long total = 0;

            List<int> diviseurs = new List<int>();
            for (int i = 1; i < _nb; i++)
            {
                if (_nb % i == 0)
                {
                    diviseurs.Add(i);
                }
            }
            for (int i = 0; i < diviseurs.Count; i++)
            {
                total += diviseurs[i];
            }

            if (total == _nb)
            {
                retour = true;
            }
            return retour;
        }

        static bool EstPresent(long _nbTest, long[] _tabTest)
        {
            bool retour = false;
            for (int i = 0; i < _tabTest.Length; i++)
            {
                if (_nbTest == _tabTest[i])
                {
                    retour = true;
                }
            }
            return retour;
        }
    }
}