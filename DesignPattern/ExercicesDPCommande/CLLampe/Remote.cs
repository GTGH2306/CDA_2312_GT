using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLLampe
{
    public class Remote
    {
        private ICommand command;
        
        public Remote(ICommand _command)
        {
            this.command = _command;
        }
        public void SetCommand(ICommand _command)
        {
            this.command = _command;
        }

        public void PressButton()
        {
            this.command.Execute();
        }
    }
}
