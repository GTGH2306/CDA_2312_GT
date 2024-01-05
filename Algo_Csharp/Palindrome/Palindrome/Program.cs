using System.Text;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            Result retourSaisie;
            do
            {
                Console.WriteLine("Saisissez une entrée: ");
                saisie = Console.ReadLine();
                retourSaisie = CtrlSaisie(saisie);
                if (retourSaisie != Result.Quit) {
                    switch (retourSaisie)
                    {
                        case Result.Valide:
                            if (IsPalindrome(saisie))
                            {
                                Console.WriteLine(saisie + " est un palindrome.");
                            }
                            else
                            {
                                Console.WriteLine(saisie + " n'est pas un palindrome.");
                            }
                            break;
                        case Result.Vide:
                            Console.WriteLine("CHAÎNE VIDE, MERCI D'APPRENDRE A ECRIRE");
                            break;
                        case Result.Insuf:
                            Console.WriteLine("BESOIN DE PLUS D'UN CARACTERE");
                            break;
                        default:
                            Console.WriteLine("ERROR, OUT OF BOUNDS");
                            break;
                    }
                }
            } while (retourSaisie != Result.Quit);
        }

        public static Result CtrlSaisie(string _saisie)
        {
            Result retour;
            _saisie = _saisie.ToLower();
            if (_saisie.Length > 1)
            {
                retour = Result.Valide;
            }
            else if (_saisie == "q")
            {
                retour = Result.Quit;
            }
            else if (_saisie.Length == 1)
            {
                retour = Result.Insuf;
            }
            else
            {
                retour = Result.Vide;
            }
            return retour;
        }

        public static bool IsPalindrome(string _phrase)
        {
            bool retour = true;
            _phrase = _phrase.ToLower().Replace(" ", "");
            int jusqua = _phrase.Length / 2;
            int i = 0;
            int j = _phrase.Length - 1;
            while (i < jusqua && retour == true)
            {
                if (_phrase[i] != _phrase[j])
                {
                    retour = false;
                }
                i++;
                j--;
            }
            return retour;
        }

        public enum Result
        {
            Valide,
            Vide,
            Insuf,
            Quit
        }
    }
}