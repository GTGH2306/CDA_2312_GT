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
            if (this.stadeCourant == this.stadeCourant.SeMetamorphoser())
            {
                aPuSeMetamorphoser = false;
            } else
            {
                this.stadeCourant = this.stadeCourant.SeMetamorphoser();
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