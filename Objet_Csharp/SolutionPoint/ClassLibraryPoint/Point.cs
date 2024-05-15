namespace ClassLibraryPoint
{
    public class Point
    {
        private float abscisse;
        private float ordonnee;

        public Point(float _abscisse, float _ordonnee)
        {
            this.abscisse = _abscisse;
            this.ordonnee = _ordonnee;
        }
        public Point() : this(0, 0)
        {
        }
        public Point(Point _pointRef) : this(_pointRef.abscisse, _pointRef.ordonnee)
        {
        }
        
        public void Deplacer(float _abscisseAjoute, float _ordonneeAjoute)
        {
            this.abscisse += _abscisseAjoute;
            this.ordonnee += _ordonneeAjoute;
        }

        public override string ToString()
        {
            return ("Position X: " + this.abscisse + "\tPosition Y: " + this.ordonnee);
        }

        public Point SymetrieAbscisse()
        {
            return new Point(this.abscisse * -1, this.ordonnee);
        }
        public Point SymetrieOrdonnee()
        {
            return new Point(this.abscisse, this.ordonnee * -1);
        }
        public Point SymetrieOrigine()
        {
            return this.SymetrieOrdonnee().SymetrieAbscisse();
        }

        public void Permuter()
        {
            (this.ordonnee, this.abscisse) = (this.abscisse, this.ordonnee);
        }
    }
}