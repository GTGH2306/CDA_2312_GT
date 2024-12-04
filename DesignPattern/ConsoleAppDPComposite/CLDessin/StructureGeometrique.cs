namespace CLDessin
{
    public abstract class StructureGeometrique
    {
        protected int posX;
        protected int posY;

        public virtual int PosX { get { return posX; } }
        public virtual int PosY { get { return posY; } }

        public abstract int Hauteur();
        public abstract int Largeur();
        public abstract void SAfficher(IVisiteurStructures _visiteur);

        public bool Overlap(int _x, int _y)
        {
            if (_x >= this.PosX && _x <= this.PosX + Largeur() &&
                _y >= this.PosY && _y <= this.posY + Hauteur())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Overlap(StructureGeometrique _structure)
        {
            if (
                this.Overlap(_structure.PosX, _structure.PosY) ||
                this.Overlap(_structure.PosX + _structure.Largeur(), _structure.PosY) ||
                this.Overlap(_structure.PosX, _structure.PosY + _structure.Hauteur()) ||
                this.Overlap(_structure.PosX + _structure.Largeur(), _structure.PosY + _structure.Hauteur()) ||
                _structure.Overlap(this.PosX, this.PosY) ||
                _structure.Overlap(this.PosX + this.Largeur(), this.PosY) ||
                _structure.Overlap(this.PosX, this.PosY + this.Hauteur()) ||
                _structure.Overlap(this.PosX + this.Largeur(), this.PosY + this.Hauteur())
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
