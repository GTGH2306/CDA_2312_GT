using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    internal class Chrysalide : IStadeDevolution
    {
        private static Chrysalide? stadeChrysalide = null;
        private Chrysalide() { }

        public static Chrysalide Instance()
        {
            if (stadeChrysalide == null)
            {
                stadeChrysalide = new Chrysalide();
            }
            return stadeChrysalide;
        }

        public bool SeDeplacer()
        {
            return false;
        }

        public IStadeDevolution SeMetamorphoser()
        {
            return Papillon.Instance();
        }
        public override string ToString()
        {
            return ("stade:Chrysalide");
        }
    }
}
