using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLLampe
{
    public class CommandTurnOnLamp : ICommand
    {
        private readonly Lamp lamp;
        public CommandTurnOnLamp(Lamp _lamp)
        {
            this.lamp = _lamp;
        }

        public void Execute()
        {
            this.lamp.TurnOn();
        }
    }
}
