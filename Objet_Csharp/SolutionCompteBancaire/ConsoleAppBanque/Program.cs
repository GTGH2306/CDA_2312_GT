using ClassLibraryCompteBancaire;

namespace ConsoleAppBanque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banque maBanque = new Banque("SuperThune", "Poitou-Charentes");

            maBanque.AjouteCompte(1, "Tristan", 5, -10);
            maBanque.AjouteCompte(2, "Aurelien",13500, -500);
            maBanque.AjouteCompte(3, "Anthony", 12500, -2000);

            Console.WriteLine(maBanque);

            Console.WriteLine("Le plus riche\n" + maBanque.CompteSup());

            Console.WriteLine("Compte 1:\n" + maBanque.RendCompte(1));

            Console.WriteLine("Compte 5:\n" + maBanque.RendCompte(5));

            if (maBanque.Transferer(3, 1, 250))
            {
                Console.WriteLine("Transfert Reussi");
            } else
            {
                Console.WriteLine("Transfert Echoué");
            }

            if (maBanque.Transferer(3, 5, 250))
            {
                Console.WriteLine("Transfert Reussi");
            }
            else
            {
                Console.WriteLine("Transfert Echoué");
            }
        }
    }
}