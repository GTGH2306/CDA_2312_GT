using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLObjet
{
    public class Loan
    {
        public string Name { get; set; }
        public decimal CapitalBorrowed { get; set; }
        public int DurationInMonths { get; set; }
        public int PeriodicityInMonths { get; set; }
        public double YearlyInterestInPercent { get; set; }

        public Loan() : this("NoName", 0, 0, 0, 0) {}
        public Loan(Loan _loanToClone) : this(_loanToClone.Name, _loanToClone.CapitalBorrowed, _loanToClone.DurationInMonths, _loanToClone.PeriodicityInMonths, _loanToClone.YearlyInterestInPercent){ }
        public Loan(string _name, decimal _capital, int _duration, int _periodicity, double _yearlyInterest)
        {
            this.Name = _name;
            this.CapitalBorrowed = _capital;
            this.DurationInMonths = _duration;
            this.PeriodicityInMonths = _periodicity;
            this.YearlyInterestInPercent = _yearlyInterest;
        }

        public double GetNbOfRepayments()
        {
            return this.DurationInMonths / (double)this.PeriodicityInMonths;
        }

        public decimal GetRepaymentsSum()
        {
            decimal result;
            decimal K = this.CapitalBorrowed;
            double t = this.YearlyInterestInPercent / 12 * this.PeriodicityInMonths / 100;
            double n = this.GetNbOfRepayments();

            if (this.CapitalBorrowed > 0)
            {
                result = K * (decimal)(t / (1 - Math.Pow(1 + t, -n))); 
                return result;
            } else
            {
                return 0;
            }
        }
    }
}
