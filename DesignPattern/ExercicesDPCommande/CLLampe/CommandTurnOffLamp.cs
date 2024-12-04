using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLLampe
{
    public class CommandTurnOffLamp : ICommand
    {
        private readonly Lamp lamp;
        public CommandTurnOffLamp(Lamp _lamp)
        {
            this.lamp = _lamp;
        }

        public void Execute()
        {
            this.lamp.TurnOff();
        }
    }
}
