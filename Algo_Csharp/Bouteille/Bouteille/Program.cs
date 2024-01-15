namespace Bouteille
{
    public class Bouteille
    {
        private double pourcentagePleine;
        private bool estOuverte;

        public double PourcentagePleine { get; set; }
        public bool EstOuverte { get; set; }

        public Bouteille()
        {
            pourcentagePleine = 100;
            estOuverte = false;
        }

        public Bouteille(double _pourcent, bool _ouverte)
        {
            pourcentagePleine = _pourcent;
            estOuverte = _ouverte;
        }

        public bool Ouvrir()
        {
            bool retour;
            if (estOuverte)
            {
                retour = false;
            }else
            {
                estOuverte = true;
                retour = true;
            }
            return retour;
        }

        public bool Fermer()
        {
            bool retour;
            if (!estOuverte)
            {
                retour = false;
            }
            else
            {
                estOuverte = false;
                retour = true;
            }
            return retour;
        }

        public void Remplir(double _pourcent)
        {
            if (estOuverte)
            {
                if (_pourcent + PourcentagePleine < 100)
                {
                    pourcentagePleine += _pourcent;
                }
                else
                {
                    pourcentagePleine = 100;
                }
            }
        }

        public void Vider(double _pourcent)
        {
            if (estOuverte)
            {
                if (pourcentagePleine - _pourcent > 0)
                {
                    pourcentagePleine -= _pourcent;
                }
                else
                {
                    pourcentagePleine = 0;
                }
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille evian, vitel;

            evian = new();
            vitel = new(25, true);

            evian.Ouvrir();

        }
    }
}