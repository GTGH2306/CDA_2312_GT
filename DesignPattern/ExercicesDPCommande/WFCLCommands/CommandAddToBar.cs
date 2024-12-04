using CLTelecomande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCLCommands
{
    public class CommandAddToBar : ICommand
    {
        private ProgressBar progressBar;
        private int barBeforeAdding;
        private int percentToAdd;
        public CommandAddToBar(ProgressBar _bar, int _percentToAdd)
        {
            this.progressBar = _bar;
            this.percentToAdd = _percentToAdd;
        }

        public void Execute()
        {
            this.barBeforeAdding = this.progressBar.Value;
            this.progressBar.Value += this.percentToAdd;
        }

        public void Reverse()
        {
            this.progressBar.Value = this.barBeforeAdding;
        }
    }
}
