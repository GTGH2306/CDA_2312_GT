using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDessin
{
    public class Cercle : StructureGeometrique
    {
        private int rayon;
        public Cercle(int _x, int _y, int _r)
        {
            this.posX = _x;
            this.posY = _y;
            this.rayon = _r;
        }

        public override int Hauteur()
        {
            return rayon * 2;
        }

        public override int Largeur()
        {
            return Hauteur();
        }

        public override void SAfficher(IVisiteurStructures _visiteur)
        {
            _visiteur.Afficher(this);
        }
    }
}
