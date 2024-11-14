using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDesignPattern
{
    public class Cercle : StructureGeometrique
    {
        private int rayon;

        public Cercle(int _posX, int _posY, int _rayon) : base(_posX, _posY)
        {
            this.rayon = _rayon;
        }

        public override string AfficheToi()
        {
            return "Cercle en position [" + this.positionX + ", " + this.positionY + "]" +
                " avec un rayon de " + this.rayon + ".";
        }
    }
}
