using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    internal class Oeuf : IStadeDevolution
    {
        private static Oeuf? stadeOeuf = null;
        private Oeuf() {}

        public static Oeuf Instance()
        {
            if (stadeOeuf == null)
            {
                stadeOeuf = new Oeuf();
            }
            return stadeOeuf;
        }

        public bool SeDeplacer()
        {
            return false;
        }

        public IStadeDevolution SeMetamorphoser()
        {
            return Larve.Instance();
        }
        public override string ToString()
        {
            return ("stade:Oeuf");
        }
    }
}
