namespace ClassLibraryCompteBancaire
{
    public class Compte
    {
        private double decouvertAutorise;
        private string nom;
        private readonly int numeroCompte;
        private double solde;
        public Compte() : this(0, 0, "Optimus Prime", 0) {}
        public Compte(int _num, double _decouvertAutorise, string _nom, double _solde)
        {
            this.decouvertAutorise = _decouvertAutorise;
            this.nom = _nom;
            this.solde = _solde;
            this.numeroCompte = _num;
        }
        public double GetSolde()
        {
            return this.solde;
        }
        public int GetNumeroCompte()
        {
            return this.numeroCompte;
        }
        public override string ToString()
        {
            string retour = "";

            //StringBuilder moins gourmand
            retour += ("Numero de compte:\t" + this.numeroCompte + "\n");
            retour += ("Nom du proprietaire:\t" + this.nom + "\n");
            retour += ("Solde du compte:\t" + (Math.Round(this.solde * 100) / 100) + "\n");
            retour += ("Decouvert autorisé:\t" + this.decouvertAutorise + "\n");

            return retour;
        }
        public void Crediter(double _montant)
        {
            this.solde += _montant > 0 ? _montant : 0;
        }
        public bool Debiter(double _montant)
        {
            bool retour;
            if (_montant > 0 && this.solde - _montant >= this.decouvertAutorise)
            {
                solde -= _montant;
                retour = true;
            } else
            {
                retour = false;
            }
            return retour;
        }
        public bool Transferer(double _montant, Compte _destinataire)
        {
            bool retour;
            retour = this.Debiter(_montant);
            if (retour)
            {
                _destinataire.Crediter(_montant);
            }
            return retour;
        }
        public bool Superieur(Compte _compte)
        {
            return this.solde > _compte.solde;
        }
    }
}