using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    internal class Larve : IStadeDevolution
    {
        private static Larve? stadeLarve = null;
        private Larve() { }

        public static Larve Instance()
        {
            if (stadeLarve == null)
            {
                stadeLarve = new Larve();
            }
            return stadeLarve;
        }

        public bool SeDeplacer()
        {
            return true;
        }

        public IStadeDevolution SeMetamorphoser()
        {
            return Chrysalide.Instance();
        }
        public override string ToString()
        {
            return ("stade:Larve");
        }
    }
}
