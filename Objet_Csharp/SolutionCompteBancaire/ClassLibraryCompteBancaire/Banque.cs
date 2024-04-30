using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompteBancaire
{
    public class Banque
    {
        private List<Compte> mesComptes;
        private int nbComptes;
        private string nom;
        private string ville;

        public Banque() : this("Banque par Defaut", "Ville par Defaut")
        {
        }

        public Banque(string _nom, string _ville)
        {
            this.nbComptes = 0;
            this.nom = _nom;
            this.ville = _ville;
            this.mesComptes = new List<Compte>();
        }

        private void AjouteCompte(Compte _compte)
        {
            nbComptes++;
            mesComptes.Add(_compte);
        }

        public void AjouteCompte(int _num, string _nom, double _solde, double _decouvertAutorise)
        {
            AjouteCompte(new Compte(_num, _decouvertAutorise, _nom, _solde));
        }

        public override string ToString()
        {
            StringBuilder retour = new StringBuilder();

            retour.AppendLine("Banque: " + this.nom + "\tVille: " + this.ville + "\n");
            foreach(Compte _compte in mesComptes)
            {
                retour.Append(_compte.ToString() + "\n");
            }

            return retour.ToString();
        }

        public Compte CompteSup()
        {
            Compte retour;
            retour = new Compte();

            foreach (Compte _compte in mesComptes)
            {
                if (retour.GetSolde() < _compte.GetSolde())
                {
                    retour = _compte;
                }
            }
            return retour;
        }
        public Compte? RendCompte(int _numeroDeCompte)
        {
            Compte? retour = null;
            foreach (Compte _compte in mesComptes)
            {
                if(_compte.GetNumeroCompte() == _numeroDeCompte)
                {
                    retour = _compte;
                }
            }
            return retour;
        }
        public bool Transferer(int _numCompteEmetteur, int _numCompteDestinataire, double _montant)
        {
            bool retour;
            Compte? compteEmetteur = RendCompte(_numCompteEmetteur);
            Compte? compteDestinataire = RendCompte(_numCompteDestinataire);
            retour = compteEmetteur is null || compteDestinataire is null ?
                false : compteEmetteur.Transferer(_montant, compteDestinataire);
            return retour;
        }
    }
}
