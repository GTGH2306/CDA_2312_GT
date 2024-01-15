using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Horse : Herbivorous
    {
        public Horse() : base("Cheval") { }
        
        public new void Eat()
        {
            Console.WriteLine(this.Specie + " mange de l'herbe et du foin.");
        }
        public void Neigh()
        {
            Console.WriteLine(this.Specie + " hénnit.");
        }
    }
}
