using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMemento
{
    public class SaveableText : IOriginator
    {
        public Commentary CurrentState { get; set; }
        public SaveableText()
        {
            this.CurrentState = new Commentary();
        }

        public IMemento Save()
        {
            return new SavedText(this);
        }
    }
}
