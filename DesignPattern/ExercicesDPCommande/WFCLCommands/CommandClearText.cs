using CLTelecomande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WFCLCommands
{
    public class CommandClearText : ICommand
    {
        private ListBox listBox;
        private List<string> textCleared;

        public CommandClearText(ListBox _listBox)
        {
            this.listBox = _listBox;
            this.textCleared = new List<string>();
        }
        public void Execute()
        {
            while (this.listBox.Items.Count > 0)
            {
                this.textCleared.Add((string)this.listBox.Items[0]);
                this.listBox.Items.RemoveAt(0);
            }
        }

        public void Reverse()
        {
            foreach (string _textRemoved in this.textCleared)
            {
                this.listBox.Items.Add(_textRemoved);
            }
        }
    }
}
