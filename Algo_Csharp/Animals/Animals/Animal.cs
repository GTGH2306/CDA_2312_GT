using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        private string specie;

        public string Specie {
            get {return this.specie;}
            set {this.specie = value;}
        }

        public Animal(string _specie){
            this.specie = _specie;
        }

        public void Eat()
        {
            Console.WriteLine(this.specie + " mange.");
        }

        public void Move()
        {
            Console.WriteLine(this.specie + " se déplace.");
        }
    }
}
