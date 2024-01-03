namespace nbJeunes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list1 = new int[] {45, 35, 65, 76, 34, 32, 31, 46, 57, 68, 75, 46, 53, 36, 31, 46, 68, 59, 30, 20};
            int[] list2 = new int[] {15, 5, 5, 6, 4, 2, 11, 16, 7, 8, 7, 3, 13, 16, 11, 18, 8, 9, 19, 3};
            int[] list3 = new int[] {45, 35, 65, 76, 34, 20, 20, 30, 30, 30, 20, 20, 30, 20, 30, 20, 20, 8, 15, 23};

            Console.WriteLine(nbJeunesSaisie(20));
            Console.WriteLine(nbJeunes(list1));
            Console.WriteLine(nbJeunes(list2));
            Console.WriteLine(nbJeunes(list3));
        }

        static string nbJeunesSaisie(int _size)
        {
            int[] listSaisie = new int[_size];

            for (int i = 0; i < listSaisie.Length; i++)
            {
                Console.WriteLine("Saisissez l'âge de la personne n°" + (i + 1) + ":");
                listSaisie[i] = int.Parse(Console.ReadLine());
            }
            return nbJeunes(listSaisie);
        }
        static string nbJeunes(int[] _list)
        {
            int jeunes = 0;
            int vieux = 0;
            int vingt = 0;
            for (int i = 0; i < _list.Length; i++)
            {
                if (_list[i] < 20)
                {
                    jeunes++;
                } else if (_list[i] > 20)
                {
                    vieux++;
                } else
                {
                    vingt++;
                }
            }
            if (jeunes == _list.Count())
            {
                return ("TOUTES LES PERSONNES ONT MOINS DE 20 ANS");
            } else if (vieux == _list.Count())
            {
                return ("TOUTES LES PERSONNES ONT PLUS DE 20 ANS");
            } else
            {
                return (jeunes + " - de 20, " + vieux + " + de 20," + vingt + " = à 20");
            }
        }
    }
}