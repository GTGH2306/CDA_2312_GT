using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMemento
{
    public interface IMemento
    {
        public abstract void Restore();
    }
}
