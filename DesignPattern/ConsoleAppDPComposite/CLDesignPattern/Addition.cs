using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDesignPattern
{
    public class Addition : Binaire
    {
        public Addition(Expression _expGauche, Expression _expDroite) : base(_expGauche, _expDroite) { }

        public override int GetValeur()
        {
            return this.expressionGauche.GetValeur() + this.expressionDroite.GetValeur();
        }

        public override string ToString()
        {
            return this.expressionGauche.ToString() + " + " + this.expressionDroite.ToString();
        }
    }
}
