namespace Bissextile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            do
            {

                Console.WriteLine("Saisissez une année ou q pour Quitter:");
                saisie = Console.ReadLine();
                if (saisie != "q")
                {
                    if (IsBissextile(int.Parse(saisie)))
                    {
                        Console.WriteLine(saisie + " est bissextile.");
                    } else
                    {
                        Console.WriteLine(saisie + " n'est pas bissextile.");
                    }

                }
            } while (saisie != "q");
        }

        static bool IsBissextile(int annee)
        {
            if ((annee % 4 == 0 && annee % 100 != 0) || (annee % 400 == 0 && annee % 100 == 0))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}