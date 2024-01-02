using System;

namespace FruitsEtLegumes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisie = "";
            List<string> legumes = new List<string>();
            List<double> prix = new List<double>();
            int indexMoinsChere = -1;
            while (saisie != "go")
            {
                Console.WriteLine("Saisissez un fruit/légume (go pour arrêter):");
                saisie = Console.ReadLine();
                if (saisie != "go")
                {
                    legumes.Add(saisie);
                    Console.WriteLine("Saisissez le prix au kg:");
                    prix.Add(double.Parse(Console.ReadLine()));
                    if (verifMoinsCher(prix))
                    {
                        indexMoinsChere = prix.Count - 1;
                    }
                }
            }
            for (int i = 0; i < legumes.Count; i++)
            {
                Console.WriteLine("1 kilogramme de " + legumes[i] + " coute " + prix[i] + " euros.");
            }
            Console.WriteLine("Légume/fruit le moins cher au kilo: " + legumes[indexMoinsChere]);

        }

        static bool verifMoinsCher(List<double> _listePrix)
        {
            bool retour = true;
            if (_listePrix.Count > 1)
            {
                for (int i = 0; i < _listePrix.Count - 1; i++)
                {
                    if (_listePrix[_listePrix.Count - 1] > _listePrix[i])
                    {
                        retour = false;
                    }
                }
            }
            return retour;
        }
    }
}