using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal
    {
        private string name;

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }

        public Dog(string _name) : base("Chien")
        {
            this.name = _name;
        }

        public void Bark()
        {
            Console.WriteLine(this.name + " aboie.");
        }

        public new void Eat()
        {
            Console.WriteLine(this.name + " mange de la pâtée.");
        }



    }
}
