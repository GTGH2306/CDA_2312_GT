using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    internal class Papillon : IStadeDevolution
    {
        private static Papillon? stadePapillon = null;
        private Papillon() { }

        public static Papillon Instance()
        {
            if (stadePapillon == null)
            {
                stadePapillon = new Papillon();
            }
            return stadePapillon;
        }

        public bool SeDeplacer()
        {
            return true;
        }

        public IStadeDevolution SeMetamorphoser()
        {
            return Instance();
        }
        public override string ToString()
        {
            return ("stade:Papillon");
        }
    }
}
