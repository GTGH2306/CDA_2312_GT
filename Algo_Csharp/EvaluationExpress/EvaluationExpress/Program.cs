namespace EvaluationExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = new int[] { 2, 4, 1, 8, 6, 14, 23, 25, 7, 42 };
            int valeurHaute;
            int valeurHauteCarre;
            double moyenne;

            valeurHaute = ValHaute(numbers);
            valeurHauteCarre = (int)Math.Pow(valeurHaute, 2);
            moyenne = CalculMoyenne(numbers);
            

            Console.WriteLine("Bienvenue dans le programme de calcul du tableau d'entier\n" +
                "Moyenne des valeurs du tableau : " + moyenne + "\n" +
                "Valeur la plus grande (" + valeurHaute + ") élevée au carré : " + valeurHauteCarre);
            

        }

        static double CalculMoyenne(int[] _tab) //Calcul la moyenne des nombres d'un tableau
        {
            int total;
            double retour;

            total = 0;
            for (int i = 0; i < _tab.Length; i++)
            {
                total += _tab[i];
            }
            retour = (double)total / _tab.Length;
            return retour;
        }

        static int ValHaute(int[] _tab) //Renvoi la valeur la plus haute
        {
            int retour;

            retour = _tab[0];

            for (int i = 1; i < _tab.Length; i++)
            {
                if (_tab[i] > retour)
                {
                    retour = _tab[i];
                }
            }
            return retour;
        }
    }
}