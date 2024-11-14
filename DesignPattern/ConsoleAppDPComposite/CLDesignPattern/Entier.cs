using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDesignPattern
{
    public class Entier : Expression
    {
        private int valeur;
        public Entier(int _valeur)
        {
            valeur = _valeur;
        }

        public override int GetValeur()
        {
            return valeur;
        }

        public override string ToString()
        {
            return valeur.ToString();
        }
    }
}
