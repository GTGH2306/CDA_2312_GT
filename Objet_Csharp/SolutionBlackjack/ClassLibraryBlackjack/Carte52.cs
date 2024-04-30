using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBlackjack
{
    public class Carte52
    {
        private Figure figure;
        private Famille famille;
        public Carte52(Figure _figure, Famille _famille)
        {
            this.figure = _figure;
            this.famille = _famille;
        }
        public override string ToString()
        {
            return (FigureString(this.figure) + " de " + FamilleString(this.famille));
        }
        public static string FamilleString(Famille _famille)
        {
            return _famille switch
            {
                Famille.COEUR => "Coeur",
                Famille.TREFLE => "Trefle",
                Famille.PIQUE => "Pique",
                Famille.CARREAU => "Carreau",
                _ => "Error"
            };
        }
        public static string FigureString(Figure _figure)
        {
            return _figure switch
            {
                Figure.AS => "As",
                Figure.DEUX => "Deux",
                Figure.TROIS => "Trois",
                Figure.QUATRE => "Quatre",
                Figure.CINQ => "Cinq",
                Figure.SIX => "Six",
                Figure.SEPT => "Sept",
                Figure.HUIT => "Huit",
                Figure.NEUF => "Neuf",
                Figure.DIX => "Dix",
                Figure.VALET => "Valet",
                Figure.DAME => "Dame",
                Figure.ROI => "Roi",
                _ => "Error"
            };
        }
        public Famille GetFamille()
        {
            return this.famille;
        }
        public Figure GetFigure()
        {
            return this.figure;
        }
        public enum Famille
        {
            COEUR,
            CARREAU,
            TREFLE,
            PIQUE
        }
        public enum Figure
        {
            AS,
            DEUX,
            TROIS,
            QUATRE,
            CINQ,
            SIX,
            SEPT,
            HUIT,
            NEUF,
            DIX,
            VALET,
            DAME,
            ROI
        }
    }

}
