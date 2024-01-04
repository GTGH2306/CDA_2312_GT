using System.Security.Cryptography;

namespace Barnabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] sommesTest = {0, 1, 0.5, 3, 2, 1.8};
            int[] magasinsAttendu = {0, 0, 0, 2, 1, 1};

            for (int i = 0; i < sommesTest.Length; i++)
            {
                Console.WriteLine(FonctionBarnabe(sommesTest[i]));
                if (TestingBarnabe(sommesTest[i], magasinsAttendu[i]))
                {
                    Console.WriteLine("Pour une somme de " + sommesTest[i] + "euros, test réussi");
                }
                else
                {
                    Console.WriteLine("Pour une somme de " + sommesTest[i] + "euros, test raté");
                }
            }
        }

        public static bool TestingBarnabe(double _sommeTest, int _magasinAttendu)
        {
            if (FonctionBarnabe(_sommeTest) == _magasinAttendu)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static int FonctionBarnabe(double _somme)
        {
            int retour = 0;
            if (_somme > 1) {
                while (_somme > 0)
                {
                    if ((_somme - ((_somme / 2) + 1)) > 0)
                    {
                        _somme -= (_somme / 2) + 1;
                        retour++;
                    }
                    else
                    {
                        _somme = 0;
                        retour++;
                    }
                }
            }
            return retour;
        }
    }
}