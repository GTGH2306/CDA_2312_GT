using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDessin
{
    public interface IVisiteurStructures
    {
        public abstract void Afficher(Cercle _cercle);
        public abstract void Afficher(Rectangle _rectangle);
        public abstract void Afficher(Triangle _triangle);
        public abstract void Afficher(Dessin _dessin);
    }
}
