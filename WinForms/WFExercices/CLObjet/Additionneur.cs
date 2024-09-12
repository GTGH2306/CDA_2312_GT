using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLObjet
{
    public class Additionneur
    {
        private List<int> Nombres;
        public Additionneur() {
            this.Nombres = new List<int>();
        }

        public void AjouterNombre(int _nb)
        {
            this.Nombres.Add(_nb);
        }

        public int Calculer()
        {
            int result = 0;
            foreach (int _nb in this.Nombres)
            {
                result += _nb;
            }

            this.Nombres = new List<int> { result };
            
            return result;
        }
    }
}
