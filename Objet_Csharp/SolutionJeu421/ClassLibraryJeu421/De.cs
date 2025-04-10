using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo(assemblyName: "421Tests")]
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
            int retour = this.Valeur - other.Valeur;
            if (retour < 0)
            {
                retour = -1;
            } else if (retour > 0)
            {
                retour = 1;
            } else
            {
                retour = 0;
            }
            return retour;
        }
        public void Jeter()
        {
            this.valeur = Alea.Instance().Nouveau(1, this.nbFaces);
        }
        internal void Jeter(INextable _alea)
        {
            this.valeur = _alea.Nouveau(1, this.nbFaces);
        }
        public static bool operator >(De _a, De _b) => _a.valeur > _b.valeur;
        public static bool operator <(De _a, De _b) => _a.valeur < _b.valeur;
        public static bool operator >=(De _a, De _b) => _a.valeur >= _b.valeur;
        public static bool operator <=(De _a, De _b) => _a.valeur <= _b.valeur;
        public static bool operator ==(De _a, De _b) => _a.valeur == _b.valeur;
        public static bool operator !=(De _a, De _b) => _a.valeur != _b.valeur;
    }
}