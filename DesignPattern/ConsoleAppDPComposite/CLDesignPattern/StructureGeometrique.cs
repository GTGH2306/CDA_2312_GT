using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDesignPattern
{
    public abstract class StructureGeometrique
    {
        protected int positionX;
        protected int positionY;

        public int[] Position
        {
            get
            {
                return [ positionX, positionY ];
            }
        }

        public StructureGeometrique(int _posX, int _posY)
        {
            this.positionX = _posX;
            this.positionY = _posY;
        }

        public abstract string AfficheToi();
        public abstract int GetEndX();
        public abstract int GetEndY();
    }
}
