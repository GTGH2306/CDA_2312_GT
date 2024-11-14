namespace CLDesignPattern
{
    public abstract class Expression
    {
        public abstract int GetValeur();
        public override abstract string ToString();
        public string Formate()
        {
            return this.ToString() + " = " + this.GetValeur();
        }
    }
}
