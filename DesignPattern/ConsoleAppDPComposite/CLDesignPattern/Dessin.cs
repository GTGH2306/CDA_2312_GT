using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDesignPattern
{
    public class Dessin : StructureGeometrique
    {
        private List<StructureGeometrique> structures;

        public Dessin() : this(0, 0, new List<StructureGeometrique>()) { }
        public Dessin(int _posX, int _posY) : this(_posX, _posY, new List<StructureGeometrique>()) { }
        public Dessin(int _posX, int _posY, List<StructureGeometrique> _structures) : base(_posX, _posY)
        {
            this.structures = _structures;
        }
        public override string AfficheToi()
        {
            string result = "Dessin en position [" + this.positionX + ", " + this.positionY + "] composé de:";
            if (this.structures.Count == 0)
            {
                result += "\nRien";
            }
            else
            {
                foreach (StructureGeometrique _structure in this.structures)
                {
                    result += "\n" + _structure.AfficheToi();
                }
            }
            result += "\nFin du dessin.";
            return result;
        }
        public void AjouterStructure(StructureGeometrique _structure)
        {
            this.structures.Add(_structure);
        }

        public override int GetEndX()
        {
            int result = this .positionX;
            foreach (StructureGeometrique _structure in this.structures)
            {
                if (_structure.GetEndX() > result)
                {
                    result = _structure.GetEndX();
                }
            }
            return result;
        }

        public override int GetEndY()
        {
            int result = this.positionX;
            foreach (StructureGeometrique _structure in this.structures)
            {
                if (_structure.GetEndY() > result)
                {
                    result = _structure.GetEndY();
                }
            }
            return result;
        }

        public List<StructureGeometrique> GetStructures()
        {
            return this.structures;
        }
    }
}
