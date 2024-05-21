using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryJeu421
{
    public class Partie
    {
        private readonly int nbPointMancheGagnee;
        private readonly int nbPointManchePerdue;
        private int nbMancheTotal;
        private int score;
        private Manche mancheCourante;
        public int Score { get => this.score; }
        public int NbMancheTotal { get => this.nbMancheTotal; set => nbMancheTotal = value; }
        public Partie(int _nbManche)
        {
            this.nbMancheTotal = _nbManche;
            this.score = nbMancheTotal * 10;
            this.nbPointManchePerdue = 10;
            this.nbPointMancheGagnee = 30;
            this.mancheCourante = new Manche();
        }
        public bool AGagneLaPartie()
        {
            return this.score > 0 && !AEncoreUneMancheAJouer();
        }
        public bool AEncoreUneMancheAJouer()
        {
            return this.nbMancheTotal > 0;
        }
        public bool AEncoreDesPointsAJouer()
        {
            return this.score > 0;
        }
        public void NouvelleManche()
        {
            this.score += this.mancheCourante.EstGagnee() ? this.nbPointMancheGagnee : -this.nbPointManchePerdue;
            this.mancheCourante = new Manche();
        }
        public string AffichageResultat()
        {
            StringBuilder retour = new StringBuilder();
            if (AGagneLaPartie())
            {
                retour.Append("Vous avez gagné!");
            } else
            {
                retour.Append("Vous avez perdu!");
            }
            return retour.ToString();
        }
        public string AfficherDes()
        {
            return this.mancheCourante.AffichageResultat();
        }
        public bool AEncoreUnLanceMancheCourante()
        {
            return this.mancheCourante.AEncoreUnLancer();
        }
        public void RelancerDes(int[] _deARelancer)
        {
            this.mancheCourante.Lancer(_deARelancer);
        }
        public bool AGagneLaMancheCourante()
        {
            return this.mancheCourante.EstGagnee();
        }
    }
}
