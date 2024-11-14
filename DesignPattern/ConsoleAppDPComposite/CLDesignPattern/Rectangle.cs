using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDesignPattern
{
    public class Rectangle : StructureGeometrique
    {
        private int longueur;
        private int largeur;

        public Rectangle(int _posX, int _posY, int _longueur, int _largeur) : base(_posX, _posY)
        {
            this.longueur = _longueur;
            this.largeur = _largeur;
        }
        public override string AfficheToi()
        {
            return "Rectangle en position [" + this.positionX + ", " + this.positionY + "]" +
                " avec une longueur de " + this.longueur + " et une largeur de " + this.largeur + ".";
        }
    }
}
