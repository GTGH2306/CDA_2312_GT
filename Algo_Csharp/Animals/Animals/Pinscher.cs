using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Pinscher : Dog
    {
        public Pinscher(string _name) : base(_name) { }

        public new void Move()
        {
            Console.WriteLine(this.Name + " se déplace.");
            this.Bark();
        }
    }
}
