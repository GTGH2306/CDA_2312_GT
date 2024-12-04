using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLLampe
{
    public class Lamp
    {
        private bool isOn;
        public Lamp()
        {
            this.isOn = false;
        }

        public void TurnOn()
        {
            this.isOn = true;
            Console.WriteLine("Lumière allumée !");
        }
        public void TurnOff()
        {
            this.isOn = false;
            Console.WriteLine("Lumière éteinte...");
        }
    }
}
