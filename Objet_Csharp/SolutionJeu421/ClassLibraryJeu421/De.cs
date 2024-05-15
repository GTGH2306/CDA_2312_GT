namespace ClassLibraryJeu421
{
    internal class De : IComparable<De>
    {
        private int valeur;
        private readonly int nbFaces;

        public int Valeur { get => valeur; }
        public int NbFaces { get => nbFaces; }
        public De(int _nbFaces)
        {
            this.nbFaces = _nbFaces;
            this.Jeter();
        }
        public De() : this(6)
        {
        }
        public int CompareTo(De? other)
        {
            return this.Valeur - other.Valeur;
        }
        public void Jeter()
        {
            this.valeur = Alea.Instance().Nouveau(1, this.nbFaces);
        }
    }
}