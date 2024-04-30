using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBouteille
{
    public class BouteilleEntreeNonValideException : Exception
    {
        public BouteilleEntreeNonValideException()
        {
        }

        public BouteilleEntreeNonValideException(string _message) : base(_message)
        {
        }

        public BouteilleEntreeNonValideException(string _message, Exception _inner) : base(_message, _inner)
        {
        }
    }
}
