using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CLDessin
{
    public class Dessin : StructureGeometrique
    {
        private readonly List<StructureGeometrique> structures;
        public List<StructureGeometrique> Structures
        {
            get
            {
                return structures;
            }
        }
        public Dessin(int _x, int _y) : this(_x, _y, new List<StructureGeometrique>()) { }
        public Dessin(int _x, int _y, List<StructureGeometrique> _structures)
        {
            this.posX = _x;
            this.posY = _y;
            this.structures = _structures;
        }

        public override int PosX
        {
            get
            {
                if (this.structures.Count > 0)
                {
                    int result = this.structures[0].PosX;
                    foreach (StructureGeometrique _s in this.structures)
                    {
                        if (_s.PosX < result)
                        {
                            result = _s.PosX;
                        }
                    }
                    return result;
                }
                else
                {
                    return this.posX;
                }
            }
        }
        public override int PosY
        {
            get
            {
                if (this.structures.Count > 0)
                {
                    int result = this.structures[0].PosY;
                    foreach (StructureGeometrique _s in this.structures)
                    {
                        if (_s.PosY < result)
                        {
                            result = _s.PosY;
                        }
                    }
                    return result;
                }
                else
                {
                    return this.posY;
                }
            }
        }
        public override int Hauteur()
        {
            if (this.structures.Count > 0)
            {
                int result = this.structures[0].Hauteur();
                foreach (StructureGeometrique _s in this.structures)
                {
                    if ((_s.PosY + _s.Hauteur()) - this.PosY > result)
                    {
                        result = (_s.PosY + _s.Hauteur()) - this.PosY;
                    }
                }
                return result;
            }
            else
            {
                return 0;
            }
        }
        public override int Largeur()
        {
            if (this.structures.Count > 0)
            {
                int result = this.structures[0].Largeur();
                foreach (StructureGeometrique _s in this.structures)
                {
                    if ((_s.PosX + _s.Largeur()) - this.PosX > result)
                    {
                        result = (_s.PosX + _s.Largeur()) - this.PosX;
                    }
                }
                return result;
            }
            else
            {
                return 0;
            }
        }

        public override void SAfficher(IVisiteurStructures _visiteur)
        {
            _visiteur.Afficher(this);

            foreach (StructureGeometrique _structure in this.structures)
            {
                _structure.SAfficher(_visiteur);
            }
        }

        public void AddStructure(StructureGeometrique _structure)
        {
            this.structures.Add(_structure);
        }
        public void Grouper(List<StructureGeometrique> _structures)
        {
            List<StructureGeometrique> validStructures = new List<StructureGeometrique>();
            Dessin drawingToAdd = new Dessin(this.PosX, this.PosY);
            foreach (StructureGeometrique _struct in _structures)
            {
                if (this.structures.Contains(_struct))
                {
                    validStructures.Add(_struct);
                }
            }
            if (validStructures.Count > 1)
            {
                foreach (StructureGeometrique _structure in validStructures)
                {
                    drawingToAdd.AddStructure(_structure);
                    this.structures.Remove(_structure);
                }
                this.structures.Add(drawingToAdd);
            }
        }

        public void Dissocier(Dessin _dessin)
        {
            if (this.structures.Contains(_dessin))
            {
                foreach(StructureGeometrique _structure in _dessin.Structures)
                {
                    this.structures.Add(_structure);
                    this.structures.Remove(_dessin);
                }
            }
        }
    }
}
