using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AdditionneurRevision
    {
        public int FirstNb { get; set; }
        public int SecondNb { get; set; }
        public AdditionneurRevision() : this(0, 0)
        { }
        public AdditionneurRevision(int _firstNb, int _secondNb)
        {
            FirstNb = _firstNb;
            SecondNb = _secondNb;
        }
        public int Sum {
        get { return FirstNb + SecondNb; }

        }
    }
}
