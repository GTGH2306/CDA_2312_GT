using CLTelecomande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WFCLCommands
{
    public class CommandEmptyBar : ICommand
    {
        private ProgressBar progressBar;
        private int barBeforeEmptying;
        public CommandEmptyBar(ProgressBar _bar)
        {
            this.progressBar = _bar;
        }

        public void Execute()
        {
            this.barBeforeEmptying = this.progressBar.Value;
            this.progressBar.Value = this.progressBar.Minimum;
        }

        public void Reverse()
        {
            this.progressBar.Value = this.barBeforeEmptying;
        }
    }
}
