using CLDomainePersistance;
using CLPersistance.LoanPersistance;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class LoanDomain
    {
        private int id;
        private ILoanPersistance loanPersistance = LoanPersistanceSQL.Instance;
        public string Name { get; set; } = "";
        public decimal CapitalBorrowed { get; set; } = 0;
        public int DurationInMonths { get; set; } = 1;
        public int PeriodicityInMonths { get; set; } = 1;
        public double YearlyInterestInPercent { get; set; } = 7;

        public LoanDomain(int _loanId)
        {
            this.id = _loanId;
            Load();
        }
        public LoanDomain() { }
        public LoanDomain(LoanStruct _loanStruct) : this(
            _loanStruct.Name,
            _loanStruct.CapitalBorrowed,
            _loanStruct.DurationInMonths,
            _loanStruct.PeriodicityInMonths,
            (double)_loanStruct.YearlyInterestPercent
            ) { }
        public LoanDomain(LoanDomain _loanToClone) : this(
            _loanToClone.Name,
            _loanToClone.CapitalBorrowed,
            _loanToClone.DurationInMonths,
            _loanToClone.PeriodicityInMonths,
            _loanToClone.YearlyInterestInPercent) { }
        public LoanDomain(string _name, decimal _capital, int _duration, int _periodicity, double _yearlyInterest)
        {
            this.id = -1;
            Name = _name;
            CapitalBorrowed = _capital;
            DurationInMonths = _duration;
            PeriodicityInMonths = _periodicity;
            YearlyInterestInPercent = _yearlyInterest;
        }
       
        public double GetNbOfRepayments()
        {
            return DurationInMonths / (double)PeriodicityInMonths;
        }

        public decimal GetRepaymentsSum()
        {
            decimal result;
            decimal K = CapitalBorrowed;
            double t = YearlyInterestInPercent / 12 * PeriodicityInMonths / 100;
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

        public void Load()
        {
            if(this.id >= 0)
            {
                if (this.loanPersistance.Select(this.id, out LoanStruct _struct))
                {
                    this.Name = _struct.Name;
                    this.CapitalBorrowed = _struct.CapitalBorrowed;
                    this.DurationInMonths = _struct.DurationInMonths;
                    this.PeriodicityInMonths = _struct.PeriodicityInMonths;
                    this.YearlyInterestInPercent = (double)_struct.YearlyInterestPercent;
                }
            }
        }

        public void Save()
        {
            if (this.id > 0)
            {
                this.loanPersistance.Update(this.id ,this.GetStruct());
            } else
            {
                this.loanPersistance.Insert(this.GetStruct());
            }
        }

        public LoanStruct GetStruct()
        {
            return new LoanStruct
            {
                Name = this.Name,
                CapitalBorrowed = this.CapitalBorrowed,
                DurationInMonths = this.DurationInMonths,
                PeriodicityInMonths = this.PeriodicityInMonths,
                YearlyInterestPercent = (decimal)this.YearlyInterestInPercent
            };
        }
    }
}
