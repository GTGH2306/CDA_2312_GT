using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBlackjack
{
    public class JeuDeCartes52
    {
        private List<Carte52> cartes;

        public JeuDeCartes52(int _nbDeJeux)
        {
            cartes = new List<Carte52>();
            foreach (Carte52.Famille _famille in Enum.GetValues<Carte52.Famille>())
            {
                foreach (Carte52.Figure _figure in Enum.GetValues<Carte52.Figure>())
                {
                    for (int i = 0; i < _nbDeJeux; i++)
                    {
                        cartes.Add(new Carte52(_figure, _famille));
                    }
                }
            }
        }
        public JeuDeCartes52() : this(1) { }
        public List<Carte52> GetCartes()
        {
            return cartes;
        }
        public Carte52 TirerCarte()
        {
            Carte52 retour;
            int indexCarte = new Random().Next(this.cartes.Count);
            retour = this.cartes[indexCarte];
            this.cartes.RemoveAt(indexCarte);
            return retour;
        }
    }
}
