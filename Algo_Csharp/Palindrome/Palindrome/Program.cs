using System.Text;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            do
            {
                Console.WriteLine("Saisissez une entrée: ");
                saisie = Console.ReadLine();

                if (IsPalindrome(Unform(saisie)) == result.Vrai)
                {
                    Console.WriteLine(saisie + " est un palindrome.");
                }
                else if (IsPalindrome(Unform(saisie)) == result.Faux)
                {
                    Console.WriteLine(saisie + " n'est pas un palindrome.");
                } else if (IsPalindrome(Unform(saisie)) == result.Vide)
                {
                    Console.WriteLine("CHAÎNE VIDE, MERCI D'APPRENDRE A ECRIRE");
                } else if (IsPalindrome(Unform(saisie)) == result.Insuf)
                {
                    Console.WriteLine("BESOIN DE PLUS D'UN CARACTERE");
                } else
                {
                    Console.WriteLine("ERROR, OUT OF BOUNDS");
                }

            } while (saisie != "q");
        }

        static string Unform(string _phrase)
        {
            StringBuilder retour = new StringBuilder();

            _phrase = _phrase.ToLower();
            for (int i = 0; i < _phrase.Length; i++)
            {
                if (_phrase[i] != ' ')
                {
                    retour.Append(_phrase[i]);
                }
            }
            return retour.ToString();
        }

        static result IsPalindrome(string _phrase)
        {
            result retour;
            if (_phrase.Length > 1)
            {
                StringBuilder reverse = new StringBuilder();
                for (int i = 0; i < _phrase.Length; i++)
                {
                    reverse.Append(_phrase[(_phrase.Length - 1) - i]);
                }

                if (reverse.ToString() == _phrase)
                {
                    retour = result.Vrai;
                }
                else
                {
                    retour = result.Faux;
                }
            } else if (_phrase.Length == 1)
            {
                retour = result.Insuf;
            } else
            {
                retour = result.Vide;
            }
            return retour;
        }

        enum result
        {
            Vrai,
            Faux,
            Vide,
            Insuf
        }
    }
}