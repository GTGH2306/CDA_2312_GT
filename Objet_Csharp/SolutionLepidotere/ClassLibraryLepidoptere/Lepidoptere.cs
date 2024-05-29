namespace ClassLibraryLepidoptere
{
    public class Lepidoptere
    {
        private IStadeDevolution stadeCourant;

        public Lepidoptere(IStadeDevolution _stadeCourant)
        {
            this.stadeCourant = _stadeCourant;
        }
        public Lepidoptere() : this(Oeuf.Instance()) { }
        
        public bool SeDeplacer()
        {
            return this.stadeCourant.SeDeplacer();
        }
        public bool SeMetamorphoser()
        {
            bool aPuSeMetamorphoser;
            IStadeDevolution metamorphose = this.stadeCourant.SeMetamorphoser();

            if (this.stadeCourant == metamorphose)
            {
                aPuSeMetamorphoser = false;
            } else
            {
                this.stadeCourant = metamorphose;
                aPuSeMetamorphoser = true;
            }
            return aPuSeMetamorphoser;
        }
        public override string ToString()
        {
            return (base.ToString() + " stadeEvolutif:" + this.stadeCourant.ToString().Split(":")[1]) ;
        }
    }
}