using CLTelecomande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace WFCLCommands
{
    public class CommandFillBar : ICommand
    {
        private ProgressBar progressBar;
        private int barBeforeFilling;
        public CommandFillBar(ProgressBar _bar)
        {
            this.progressBar = _bar;
        }

        public void Execute()
        {
            this.barBeforeFilling = this.progressBar.Value;
            this.progressBar.Value = this.progressBar.Maximum;
        }

        public void Reverse()
        {
            this.progressBar.Value = this.barBeforeFilling;
        }
    }
}
