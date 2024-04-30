using ClassLibraryBouteille;
using System.Runtime.CompilerServices;

namespace ConsoleAppTestBouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille myBottle = new Bouteille();
            EtatBouteille(myBottle);
            myBottle.Ouvrir();
            myBottle.Remplir(-1);
        }

        static string EtatBouteille(Bouteille _bouteille)
        {
            string etatBouteille;
            etatBouteille = "La bouteille est ";
            etatBouteille += _bouteille.getEstOuverte() ? "ouverte.\n" : "fermée.\n";
            etatBouteille += ("Remplissage: " + _bouteille.getQuantiteLiquideEnMl() + "Ml/" + _bouteille.getCapaciteMaxEnMl() + "Ml.");
            return etatBouteille;
        }
    }
}