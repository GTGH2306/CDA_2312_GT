using CLDomainePersistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLPersistance.LoanPersistance
{
    public class LoanPersistanceSQL : ILoanPersistance
    {
        private static LoanPersistanceSQL? instance;
        public static LoanPersistanceSQL Instance
        {
            get
            {
                if (instance is null)
                {
                    instance = new LoanPersistanceSQL();
                }
                return instance;
            }
        }



        public void Delete(int _loanId)
        {
            Loan? firstOrDefault = LoanDbContextSingleton.Instance.Loans.FirstOrDefault(l => l.Id == _loanId);
            if (firstOrDefault != null)
            {
                LoanDbContextSingleton.Instance.Loans.Remove(firstOrDefault);
                LoanDbContextSingleton.Instance.SaveChanges();
            }
        }

        public int Insert(LoanStruct _loan)
        {
            Loan loanToAdd = new Loan()
            {
                Name = _loan.Name,
                CapitalBorrowed = _loan.CapitalBorrowed,
                DurationInMonths = _loan.DurationInMonths,
                PeriodicityInMonths = _loan.PeriodicityInMonths,
                YearlyInterestPercent = _loan.YearlyInterestPercent
            };
            LoanDbContextSingleton.Instance.Loans.Add(loanToAdd);
            LoanDbContextSingleton.Instance.SaveChanges();
            return loanToAdd.Id;
        }

        public bool Select(int _loanId, out LoanStruct _struct)
        {
            Loan? loanFound = LoanDbContextSingleton.Instance.Loans.FirstOrDefault(l => l.Id == _loanId);
            if (loanFound == null)
            {
                _struct = new LoanStruct();
                return false;
            }
            _struct = new LoanStruct(
                loanFound.Name,
                loanFound.CapitalBorrowed,
                loanFound.DurationInMonths,
                loanFound.PeriodicityInMonths,
                loanFound.YearlyInterestPercent
                );
            return true;
        }

        public void Update(int _loanId, LoanStruct _loan)
        {
            Loan? loanFound = LoanDbContextSingleton.Instance.Loans.FirstOrDefault(l => l.Id == _loanId);
            if (loanFound != null)
            {
                loanFound.Name = _loan.Name;
                loanFound.CapitalBorrowed = _loan.CapitalBorrowed;
                loanFound.DurationInMonths = _loan.DurationInMonths;
                loanFound.PeriodicityInMonths = _loan.PeriodicityInMonths;
                loanFound.YearlyInterestPercent = _loan.YearlyInterestPercent;
                LoanDbContextSingleton.Instance.Loans.Update(loanFound);
                LoanDbContextSingleton.Instance.SaveChanges();
            }

        }
    }
}
