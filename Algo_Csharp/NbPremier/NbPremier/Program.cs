namespace NbPremier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisie = "";
            do
            {
                int nb;
                bool premier = true;
                Console.WriteLine("Saisissez nombre à tester: ");
                nb = int.Parse(Console.ReadLine());

                if (nb > 1)
                {
                    for (int i = 1; i < nb; i++)
                    {
                        if (nb % i == 0 && i != 1 && i != nb)
                        {
                            premier = false;
                        }
                    }
                    if (premier)
                    {
                        Console.WriteLine(nb + " est un nombre premier.");
                    }
                    else
                    {
                        Console.WriteLine(nb + " n'est pas un nombre premier.");
                    }
                }
                else
                {
                    Console.WriteLine("Le nombre ne peux pas être premier.");
                }
                Console.WriteLine("Recommencer? (Q pour Quitter)");
                saisie = Console.ReadLine();
            } while (saisie != "q" || saisie != "Q");
            
        }
    }
}