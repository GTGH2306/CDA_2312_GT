using System.Security.Cryptography;

namespace JeuZeroDeux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valPlayer, valOrdi;
            int scorePlayer = 0;
            int scoreOrdi = 0;
            Random rnd = new Random();
            do
            {
                do
                {
                    Console.WriteLine("Saisissez un nombre entre 0 et 2 (nombre négatif pour quitter):");
                    valPlayer = int.Parse(Console.ReadLine());
                } while (valPlayer > 2);
                if (valPlayer >= 0)
                {
                    valOrdi = rnd.Next(0, 3);
                    Console.WriteLine("L'ordinateur a choisi " + valOrdi);
                    switch (valPlayer - valOrdi)
                    {
                        case 0:
                            Console.WriteLine("Egalité");
                            break;
                        case -1:
                            Console.WriteLine("Joueur gagne 1pts");
                            scorePlayer++;
                            break;
                        case -2:
                            Console.WriteLine("Ordinateur gagne 1pts");
                            scoreOrdi ++;
                            break;
                        case 1:
                            Console.WriteLine("Ordinateur gagne 1pts");
                            scoreOrdi++;
                            break;
                        case 2:
                            Console.WriteLine("Joueur gagne 1pts");
                            scorePlayer ++;
                            break;
                    }
                    Console.WriteLine("Joueur: " + scorePlayer);
                    Console.WriteLine("Ordinateur: " + scoreOrdi)
                        ;
                }
            } while (valPlayer >= 0 && scorePlayer < 10 && scoreOrdi < 10);

            if (scorePlayer > scoreOrdi)
            {
                Console.WriteLine("Le joueur gagne " + scorePlayer + " à " + scoreOrdi);
            } else if (scorePlayer < scoreOrdi)
            {
                Console.WriteLine("L'ordinateur gagne " + scoreOrdi + " à " + scorePlayer);
            } else
            {
                Console.WriteLine("Egalité " + scorePlayer + " à " + scoreOrdi);
            }
        }
    }

}