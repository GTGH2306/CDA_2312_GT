using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDessin
{
    public class Triangle : StructureGeometrique
    {
        private readonly int hauteur;
        private readonly int largeur;

        public Triangle(int _x, int _y, int _hauteur, int _largeur)
        {
            this.posX = _x;
            this.posY = _y;
            this.hauteur = _hauteur;
            this.largeur = _largeur;
        }

        public override int Hauteur()
        {
            return hauteur;
        }

        public override int Largeur()
        {
            return largeur;
        }

        public override void SAfficher(IVisiteurStructures _visiteur)
        {
            _visiteur.Afficher(this);
        }
    }
}
