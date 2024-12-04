using CLTelecomande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WFCLCommands
{
    public class CommandAddText : ICommand
    {
        private string textAdded;
        private ListBox listbox;
        public CommandAddText(ListBox _list, string _textToAdd)
        {
            this.listbox = _list;
            this.textAdded = _textToAdd;



        }
        public void Execute()
        {
            this.listbox.Items.Add(this.textAdded);
        }

        public void Reverse()
        {
            int i = this.listbox.Items.Count - 1;
            bool reversed = false;
            while (i >= 0 && !reversed)
            {
                if (this.listbox.Items[i].ToString() == this.textAdded)
                {
                    this.listbox.Items.RemoveAt(i);
                    reversed = true;
                }
                i--;
            }
        }
    }
}
