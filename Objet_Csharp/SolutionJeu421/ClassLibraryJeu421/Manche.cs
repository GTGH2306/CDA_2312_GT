using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryJeu421
{
    internal class Manche
    {
        private int nbLancerRestant;
        private readonly int nbLancerMax;
        private De[] des;
        public Manche()
        {
            this.nbLancerMax = 3;
            this.des = new De[3];
            this.nbLancerRestant = this.nbLancerMax;
            for (int i = 0; i < this.des.Length; i++)
            {
                this.des[i] = new De();
            }
            this.Lancer(new int[] {1, 2, 3});
        }
        public void Lancer(int[] _deAJeter)
        {
            for (int i = 0; i < _deAJeter.Length; i++)
            {
                this.des[_deAJeter[i] - 1].Jeter();
            }
            this.nbLancerRestant--;
        }
        private bool DesDeMancheContientDe(int _valeurDe)
        {
            bool retour = false;
            for(int i = 0; i < this.des.Length && !retour; i++)
            {
                if (this.des[i].Valeur == _valeurDe)
                {
                    retour = true;
                }
            }
            return retour;
        }
        public bool EstGagnee()
        {
            bool retour;
            
            if (DesDeMancheContientDe(4) && DesDeMancheContientDe(2) && DesDeMancheContientDe(1))
            {
                retour = true;
            } else
            {
                retour = false;
            }

            return retour;
        }
        public bool AEncoreUnLancer()
        {
            return this.nbLancerRestant > 0;
        }
        public string AffichageResultat()
        {
            StringBuilder retourBuilder = new StringBuilder();
            for (int i = 0; i < this.des.Length; i++)
            {
                retourBuilder.Append("Dé " + (i + 1) + ") " + this.des[i].Valeur);
                if (i != this.des.Length - 1)
                {
                    retourBuilder.Append("\n");
                }
            }
            return retourBuilder.ToString();
        }
    }
}
