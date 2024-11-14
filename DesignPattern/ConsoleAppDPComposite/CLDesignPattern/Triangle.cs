using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDesignPattern
{
    public class Triangle : StructureGeometrique
    {
        private int longueur;

        public Triangle(int _posX, int _posY, int _longueur) : base(_posX, _posY)
        {
            longueur = _longueur;
        }

        public override string AfficheToi()
        {
            return "Triangle en position [" + this.positionX + ", " + this.positionY + "]" +
                " avec des côtés de " + this.longueur + " de longueur.";
        }
    }
}
