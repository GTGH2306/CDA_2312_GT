using ClassLibraryCompteBancaire;

namespace ConsoleAppCompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compte compteTristan = new Compte(1, -1000, "Tristan", 8500);
            Compte compteAurelien = new Compte(2, -525, "Aurelien", 12000);
            Compte compteToto = new Compte();
            Console.WriteLine(compteTristan + "\n");
            Console.WriteLine(compteAurelien + "\n");
            Console.WriteLine(compteToto + "\n");

            compteTristan.Transferer(8750,compteAurelien);
            compteAurelien.Transferer(855000, compteToto);

            Console.WriteLine(compteTristan + "\n");
            Console.WriteLine(compteAurelien + "\n");
            Console.WriteLine(compteToto + "\n");

            if (compteToto.Superieur(compteTristan))
            {
                Console.WriteLine("Optimus est plus riche que Tristan");
            }
        }
    }
}