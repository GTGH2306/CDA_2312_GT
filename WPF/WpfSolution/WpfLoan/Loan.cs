using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLoan.Models
{
    public partial class Loan
    {
        public Loan() : this("", 0, 1, 1, 7) { }
        public Loan(Loan _loanToClone) : this(_loanToClone.Name, _loanToClone.CapitalBorrowed, _loanToClone.DurationInMonths, _loanToClone.PeriodicityInMonths, _loanToClone.YearlyInterestPercent) { }
        public Loan(string _name, decimal _capital, int _duration, int _periodicity, decimal _yearlyInterest)
        {
            Name = _name;
            CapitalBorrowed = _capital;
            DurationInMonths = _duration;
            PeriodicityInMonths = _periodicity;
            YearlyInterestPercent = _yearlyInterest;
        }

        public double GetNbOfRepayments()
        {
            return DurationInMonths / (double)PeriodicityInMonths;
        }

        public decimal GetRepaymentsSum()
        {
            decimal result;
            decimal K = CapitalBorrowed;
            double t = (double)(YearlyInterestPercent / 12 * PeriodicityInMonths / 100);
            double n = GetNbOfRepayments();

            if (CapitalBorrowed > 0)
            {
                result = K * (decimal)(t / (1 - Math.Pow(1 + t, -n)));
                return result;
            }
            else
            {
                return 0;
            }
        }

        public enum Periodicities
        {
            Monthly = 1,
            Bimonthly = 2,
            Termly = 3,
            HalfYearly = 6,
            Yearly = 12
        }
    }
}
