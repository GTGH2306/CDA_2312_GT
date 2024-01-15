using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Herbivorous : Animal
    {
        public Herbivorous(string _specie) : base(_specie) { }

        public new void Eat()
        {
            Console.WriteLine(this.Specie + " mange des végétaux.");
        }
    }
}
