using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public interface IStadeDevolution
    {
        public abstract IStadeDevolution SeMetamorphoser();
        public abstract bool SeDeplacer();
        public abstract string ToString();
    }
}
