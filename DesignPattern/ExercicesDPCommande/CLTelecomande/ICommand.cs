using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLTelecomande
{
    public interface ICommand
    {
        public abstract void Execute();
        public abstract void Reverse();
    }
}
