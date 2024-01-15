using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Labrador : Dog
    {
        private bool moved;
        public Labrador(string _name) : base(_name)
        {
            this.moved = false;
        }

        public new void Move()
        {
            if (!moved)
            {
                Console.WriteLine(this.Name + " se déplace.");
                moved = true;
            }
            else
            {
                Console.WriteLine(this.Name + " n'écoute pas.");
                moved = false;
            }
        }



    }
}
