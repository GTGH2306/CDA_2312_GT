using ClassLibraryJeu421;

namespace ConsoleAppJeu421
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            do
            {
                Console.WriteLine("Bienvenue dans le jeu 421, combien de manches souhaitez vous jouer?");
                saisie = Console.ReadLine();
                JouerPartie(new Partie(int.Parse(saisie)));
                Console.WriteLine("Souhaitez-vous rejouer?\t(N pour Non)");
                saisie = Console.ReadLine();
            } while (saisie != "n" && saisie != "N");
        }
        private static void JouerPartie(Partie _partie)
        {
            string saisie;
            for (int i = 0; i < _partie.NbMancheTotal && _partie.AEncoreDesPointsAJouer(); _partie.NbMancheTotal--)
            {
                Console.WriteLine("Les des sont:\n" + _partie.AfficherDes());
                while (_partie.AEncoreUnLanceMancheCourante() && !_partie.AGagneLaMancheCourante())
                {
                    int[] desARelancer;
                    string[] desARelancerSaisies;

                    Console.WriteLine("Lesquels souhaitez vous relancer?\t(Saisissez les des séparés d'un \";\")");
                    saisie = Console.ReadLine();
                    desARelancerSaisies = saisie.Split(";");
                    desARelancer = new int[desARelancerSaisies.Length];
                    for (int j = 0; j < desARelancerSaisies.Length; j++)
                    {
                        desARelancer[j] = int.Parse(desARelancerSaisies[j]);
                    }
                    _partie.RelancerDes(desARelancer);
                    Console.WriteLine("Les des sont:\n" + _partie.AfficherDes());
                }
                if (_partie.AGagneLaMancheCourante())
                {
                    Console.WriteLine("Manche Gagnée ! :)");
                } else
                {
                    Console.WriteLine("Manche Perdue ! :(");
                }
                _partie.NouvelleManche();
                Console.WriteLine("Score: " + _partie.Score);
            }
            Console.WriteLine(_partie.AffichageResultat());
        }
    }
}