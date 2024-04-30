using System.Xml.Schema;

namespace ClassLibraryBlackjack
{
    public class Joueur
    {
        private List<Carte52> main;

        public Joueur()
        {
            main = new List<Carte52>();
        }

        public List<Carte52> GetMain()
        {
            return main;
        }
        public void setMain(List<Carte52> _main)
        {
            this.main = _main;
        }
        public List<int> GetPossibleMainValue()
        {
            List<int> retour = new List<int>();
            int nombreAs = 0;
            int valeurMax = 0;
            foreach (Carte52 _card in this.main)
            {
                if (_card.GetFigure() == Carte52.Figure.AS)
                {
                    nombreAs++;
                    valeurMax += 11;
                }
                valeurMax += _card.GetFigure() switch
                {
                    Carte52.Figure.DEUX => 2,
                    Carte52.Figure.TROIS => 3,
                    Carte52.Figure.QUATRE => 4,
                    Carte52.Figure.CINQ => 5,
                    Carte52.Figure.SIX => 6,
                    Carte52.Figure.SEPT => 7,
                    Carte52.Figure.HUIT => 8,
                    Carte52.Figure.NEUF => 9,
                    Carte52.Figure.DIX => 10,
                    Carte52.Figure.VALET => 10,
                    Carte52.Figure.DAME => 10,
                    Carte52.Figure.ROI => 10,
                    _ => 0
                };
            }
            for (int i = 0; i <= nombreAs; i++)
            {
                retour.Add(valeurMax - i * 10);
            }
            return retour;
        }
        public void DemanderCarte()
        {

        }
    }
}