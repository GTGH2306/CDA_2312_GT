using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryJeu421
{
    interface IManche
    {
        public abstract bool EstGagnee();
        public abstract bool AEncoreUnLancer();
        public abstract void Lancer(int[] _deAJeter);
        public abstract string AffichageResultat();
    }
}
