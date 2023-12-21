using System.Net.NetworkInformation;
using System.Text;

namespace Pendu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int erreursRestant = 6;
            string motVictoire;
            string motEnCours ="";

            Console.WriteLine("Saisissez le mot à trouver");
            motVictoire = Console.ReadLine();
            for (int i = 0; i < motVictoire.Length; i++)
            {
                if (i == 0 || i == motVictoire.Length - 1)
                {
                    motEnCours += motVictoire[i];
                }
                else
                {
                    motEnCours += "-";
                }
            }
            Console.Clear();
            Console.WriteLine(motEnCours);

            
            while (erreursRestant > 0 && motVictoire != motEnCours)
            {
                Console.WriteLine("Il vous reste " + erreursRestant + " erreurs.\nProposez une lettre pour " + motEnCours + ":");
                char essai = Console.ReadLine()[0];

                if (motEnCours != Essai(motVictoire, motEnCours, essai))
                {
                    motEnCours = Essai(motVictoire, motEnCours, essai);
                } else
                {
                    erreursRestant--;
                }
            }
            
            if (motVictoire == motEnCours)
            {
                Console.WriteLine("Vous avez trouvé ! Le mot est " + motVictoire);
            } else
            {
                Console.WriteLine("Perdu. Le mot était " + motVictoire);
            }
            
        }

        
        static string Essai(string _motVictoire, string _motEnCours, char _essai)
        {
            for (int i = 0; i < _motVictoire.Length; i++)
            {
                if (_essai == _motVictoire[i] && _motVictoire[i] != _motEnCours[i])
                {
                    StringBuilder sb = new StringBuilder(_motEnCours);
                    sb[i] = _motVictoire[i];
                    _motEnCours = sb.ToString();
                }
            }
            return _motEnCours;
        }

        
    }
}