using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Animals
{
    public class Bee : Animal
    {
        public Bee() : base("Abeille") { }

        public void Buzz()
        {
            Console.WriteLine( this.Specie + " bourdonne.");
        }

        public new void Move()
        {
            Console.WriteLine(this.Specie + " se déplace en volant.");
        }

        public new void Eat()
        {
            Console.WriteLine(this.Specie + " buttine du polen.");
        }

    }
}
