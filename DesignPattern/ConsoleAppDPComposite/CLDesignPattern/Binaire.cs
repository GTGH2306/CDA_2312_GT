using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDesignPattern
{
    public abstract class Binaire : Expression
    {
        protected Expression expressionGauche;
        protected Expression expressionDroite;
        protected Binaire(Expression _expGauche, Expression _expDroite)
        {
            expressionGauche = _expGauche;
            expressionDroite = _expDroite;
        }
    }
}
