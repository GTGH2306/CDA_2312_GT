using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Giraffe : Herbivorous
    {
        public Giraffe() : base("Giraffe") { }

        public new void Move()
        {
            Console.WriteLine(this.Specie + " se déplace doucement.");
        }

        public void Moo()
        {
            Console.WriteLine(this.Specie + " meugle.");
        }
    }
}
