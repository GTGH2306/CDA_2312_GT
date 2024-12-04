using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLTelecomande
{
    public class CommandAddText : ICommand
    {
        private string addedText;
        private ListBox listbox;

        public CommandAddText()
        {
            
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public ICommand GetClone()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }
    }
}
