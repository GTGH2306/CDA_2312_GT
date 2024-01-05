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
                retourSaisie = IsPalindrome(saisie);
                if (retourSaisie != Result.Quit) {
                    switch (retourSaisie)
                    {
                        case Result.Vrai:
                            Console.WriteLine(saisie + " est un palindrome.");
                            break;
                        case Result.Faux:
                            Console.WriteLine(saisie + " n'est pas un palindrome.");
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

        public static Result IsPalindrome(string _phrase)
        {
            Result retour;
            _phrase = _phrase.ToLower().Replace(" ", "");
            
            int jusqua;
            if (_phrase.Length > 1)
            {
                if (_phrase.Length % 2 == 0)
                {
                    jusqua = _phrase.Length / 2;
                }
                else
                {
                    jusqua = (_phrase.Length - 1) / 2;
                }
                int j = _phrase.Length - 1;
                retour = Result.Vrai;
                for (int i = 0; i < jusqua; i++)
                {
                    if (_phrase[i] != _phrase[j])
                    {
                        retour = Result.Faux;
                    }
                    j--;
                }
            } else if (_phrase == "q")
            {
                retour = Result.Quit;
            } else if (_phrase.Length == 1)
            {
                retour = Result.Insuf;
            } else
            {
                retour = Result.Vide;
            }
            return retour;
        }

        public enum Result
        {
            Vrai,
            Faux,
            Vide,
            Insuf,
            Quit
        }
    }
}