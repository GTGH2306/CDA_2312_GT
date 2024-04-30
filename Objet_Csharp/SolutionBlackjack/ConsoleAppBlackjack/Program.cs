using ClassLibraryBlackjack;

namespace ConsoleAppBlackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Joueur playerTest = new Joueur();
            List<Carte52> mainTest = new List<Carte52>();
            mainTest.Add(new Carte52(Carte52.Figure.AS, Carte52.Famille.TREFLE));
            mainTest.Add(new Carte52(Carte52.Figure.SEPT, Carte52.Famille.CARREAU));
            mainTest.Add(new Carte52(Carte52.Figure.AS, Carte52.Famille.PIQUE));
            playerTest.setMain(mainTest);
            List<int> retourAttendu = new List<int>();
            retourAttendu.Add(29);
            retourAttendu.Add(19);
            retourAttendu.Add(9);

            foreach (int i in playerTest.GetPossibleMainValue())
            {
                Console.WriteLine(i);
            }

        }
    }
}