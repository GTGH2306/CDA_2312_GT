namespace ClassLibraryBouteille
{
    public class Bouteille
    {
        private double capaciteMaxEnMl;
        private double quantiteLiquideEnMl;
        private bool estOuverte;

        public Bouteille() : this(1000) {}
        

        public Bouteille(double _capaciteMaxEnMl)
        {
            this.capaciteMaxEnMl = _capaciteMaxEnMl;
            this.quantiteLiquideEnMl = _capaciteMaxEnMl;
            this.estOuverte = false;
        }

        public bool Ouvrir()
        {
            bool ouvertureSucces;

            if (!estOuverte)
            {
                this.estOuverte = true;
                ouvertureSucces = true;
            } else
            {
                ouvertureSucces = false;
            }

            return ouvertureSucces;
        }

        public bool Fermer()
        {
            bool fermetureSucces;

            if (estOuverte)
            {
                this.estOuverte = false;
                fermetureSucces = true;
            }
            else
            {
                fermetureSucces = false;
            }

            return fermetureSucces;
        }

        public bool Remplir(double _quantiteLiquideEnMl)
        {
            bool remplirSucces;

            if (this.estOuverte &&
                _quantiteLiquideEnMl > 0 &&
                this.quantiteLiquideEnMl < this.capaciteMaxEnMl)
            {
                this.quantiteLiquideEnMl += _quantiteLiquideEnMl;
                remplirSucces = true;
            } else
            {
                remplirSucces = false;
            }

            return remplirSucces;
        }

        public bool Vider(double _quantiteLiquideEnMl)
        {
            bool viderSucces;

            if (this.estOuverte &&
                this.quantiteLiquideEnMl > 0 &&
                _quantiteLiquideEnMl > 0)
            {
                this.quantiteLiquideEnMl -= _quantiteLiquideEnMl > this.quantiteLiquideEnMl ? _quantiteLiquideEnMl : this.quantiteLiquideEnMl;
                viderSucces = true;
            }
            else
            {
                viderSucces = false;
            }

            return viderSucces;
        }

        public bool RemplirTout()
        {
            return this.Remplir(this.capaciteMaxEnMl - this.quantiteLiquideEnMl);
        }

        public bool ViderTout()
        {
            return this.Vider(this.quantiteLiquideEnMl);
        }

        public bool getEstOuverte()
        {
            return this.estOuverte;
        }

        public double getCapaciteMaxEnMl()
        {
            return this.capaciteMaxEnMl;
        }

        public double getQuantiteLiquideEnMl()
        {
            return this.quantiteLiquideEnMl;
        }

        public void setEstOuverte(bool _estOuverte)
        {
            this.estOuverte = _estOuverte;
        }

        public void setCapaciteMaxEnMl(double _capaciteMaxEnMl)
        {
            this.capaciteMaxEnMl = _capaciteMaxEnMl;
        }
        public void setQuantiteLiquideEnMl(double _quantiteLiquideEnMl)
        {
            this.quantiteLiquideEnMl = _quantiteLiquideEnMl;
        }
    }
}