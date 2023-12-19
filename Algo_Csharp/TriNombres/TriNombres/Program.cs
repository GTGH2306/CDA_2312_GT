namespace TriNombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            do
            {
                do
                {
                    Console.WriteLine("Saisissez la taille de votre tableau: ");
                    saisie = Console.ReadLine();
                } while (saisie is null);
                int[] tab = new int[int.Parse(saisie)];

                for (int i = 0; i < tab.Length; i++)
                {
                    Console.WriteLine("Saisissez nombre en position " + i + ":");
                    tab[i] = int.Parse(Console.ReadLine());
                }

                tab = TriCroissant(tab);

                Console.WriteLine();
                for (int i = 0; i < tab.Length; i++)
                {
                    if (i < tab.Length - 1)
                    {
                        Console.Write(tab[i] + " < ");
                    } else
                    {
                        Console.WriteLine(tab[i]);
                    }
                    
                }
                Console.WriteLine("Souhaitez-vous reccommencer? (o pour Oui)");
                saisie = Console.ReadLine();

            } while (saisie.Equals("o"));
        }



        static int[] TriCroissant(int[] atrier)
        {
            for (int i = 0; i < atrier.Length; i++) //On prend un nombre i
            {
                for (int j = 0; j < atrier.Length; j++) //Qu'on compare avec chaque nombre du tableau
                {
                    if (atrier[i] < atrier[j]) //Si i est plus petit que le nombre comparé, on échange
                    {
                        (atrier[j], atrier[i]) = (atrier[i], atrier[j]); //Tuple, échangeant les deux valeurs sans besoin d'une valeur tampon
                    }
                }
            }
            return atrier;
        }
    }
}