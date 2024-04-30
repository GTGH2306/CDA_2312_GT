using System.Text;

namespace ClassLibraryFraction
{
    public class Fraction
    {
        private int numerateur;
        private int denominateur;

        public Fraction(int _numerateur, int _denominateur)
        {
            try
            {
                if (_denominateur == 0)
                {
                    throw new FractionException("Factionner par 0 est impossible.");
                }
                this.numerateur = _numerateur;
                this.denominateur = _denominateur;
            }
            catch (FractionException _exception)
            {
                Console.WriteLine("Creation de fraction impossible: " + _exception);
            }
        }

        public Fraction(int _numerateur) : this(_numerateur, 1)
        {
        }
        public Fraction() : this(0, 1)
        {
        }

        public Fraction(Fraction _fractionReferente) : this(_fractionReferente.numerateur, _fractionReferente.denominateur)
        {
        }

        public override string ToString()
        {
            return this.denominateur == 1 ?
                this.numerateur.ToString() : (this.numerateur + "/" + this.denominateur);
        }

        public void Inverse()
        {
            (this.numerateur, this.denominateur) = (this.denominateur, this.numerateur);
        }
        public void Oppose()
        {
            this.numerateur *= -1;
        }
        public bool SuperieurA(Fraction _fractionTest)
        {
            return this.GetValue() > _fractionTest.GetValue(); 
        }
        public bool EgalA(Fraction _fractionTest)
        {
            return this.GetValue() == _fractionTest.GetValue();
        }
        private Fraction Reduire()
        {
            int pgcd = this.GetPgcd();
            int numerateurRed = this.numerateur;
            int denominateurRed = this.denominateur;

            if (this.denominateur < 0)
            {
                numerateurRed = this.numerateur * -1;
                denominateurRed = this.denominateur * -1;
            }

            return new Fraction(numerateurRed / pgcd, denominateurRed / pgcd);
        }
        private float GetValue()
        {
            return (float)this.numerateur / (float)this.denominateur;
        }
        private int GetPgcd()
        {
            int a = this.numerateur;
            int b = this.denominateur;
            int pgcd = 1;
            if (a != 0 && b != 0)
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;
                while (a != b)
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                }
                pgcd = a;
            }
            return pgcd;
        }
        public string ToDisplay()
        {
            return this.Reduire().ToString();
        }
        public Fraction Plus(Fraction _autreFraction)
        {
            int addNume =  this.numerateur * _autreFraction.denominateur + _autreFraction.numerateur * this.denominateur;
            int addDeno = this.denominateur * _autreFraction.denominateur;
            return new Fraction(addNume, addDeno).Reduire();
        }
        public Fraction Moins(Fraction _autreFraction)
        {
            int subNume = this.numerateur * _autreFraction.denominateur - _autreFraction.numerateur * this.denominateur;
            int subDeno = this.denominateur * _autreFraction.denominateur;
            return new Fraction(subNume, subDeno).Reduire();
        }
        public Fraction Multiplie(Fraction _autreFraction)
        {
            int multNume = this.numerateur * _autreFraction.numerateur;
            int multDeno = this.denominateur * _autreFraction.denominateur;
            return new Fraction(multNume, multDeno).Reduire();
        }
        public Fraction Divise(Fraction _autreFraction)
        {
            _autreFraction.Inverse();
            return this.Multiplie(_autreFraction);
        }

        //Remplacer operateurs
        public static Fraction operator +(Fraction a, Fraction b)
            => a.Plus(b);
        public static Fraction operator -(Fraction a, Fraction b)
            => a.Moins(b);
        public static Fraction operator *(Fraction a, Fraction b)
            => a.Multiplie(b);
        public static Fraction operator /(Fraction a, Fraction b)
            => a.Divise(b);

    }
}