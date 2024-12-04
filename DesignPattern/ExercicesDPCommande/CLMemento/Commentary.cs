using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMemento
{
    public class Commentary
    {
        public string Text { set;  get; }
        public Commentary()
        {
            this.Text = string.Empty;
        }
        public Commentary(Commentary _commentaryToClone)
        {
            this.Text = _commentaryToClone.Text;
        }
    }
}
