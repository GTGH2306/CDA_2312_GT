using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLObjet
{
    public class Crate
    {
        private readonly DateTime dateOfCreation;
        private readonly bool flawed;
        public Crate() : this(DateTime.Now, 0) { }
        public Crate(DateTime _dateOfCreation) : this(_dateOfCreation, 0) { }
        public Crate(double _flawedPercentageChance) : this(DateTime.Now, _flawedPercentageChance) { }
        public Crate(DateTime _dateOfCreation, double _flawedPercentageChance)
        {
            this.dateOfCreation = _dateOfCreation;
            double rdmNb = RdmSingle.GetInstance().NextDouble() * 100;
            this.flawed = rdmNb < _flawedPercentageChance;
        }

        public bool IsFlawed() { return flawed; }
        public DateTime GetDateOfCreation() { return dateOfCreation; }
    }
}
