using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMemento
{
    public class SavedText : IMemento
    {
        private readonly Commentary savedState;
        private readonly SaveableText originator;
        public SavedText(SaveableText _originator)
        {
            this.originator = _originator;
            this.savedState = new Commentary(_originator.CurrentState);
        }

        public void Restore()
        {
            this.originator.CurrentState = this.savedState;
        }
    }
}
