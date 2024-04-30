using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFraction
{
    public class FractionException : Exception
    {
        public FractionException()
        {
        }
        public FractionException(string _message) : base(_message)
        {
        }
        public FractionException(string _message, Exception _inner) : base(_message, _inner)
        {
        }
    }
}
