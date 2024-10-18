using ClassLibrary;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WpfLoan.Models;

namespace WpfLoan
{
    public class LoanVM : ViewModel
    {
        private readonly LoanDomain loanModel;


        private string textBoxName;
        private string textBoxCapital;

        public bool ValidateButtonEnabled
        {
            get
            {
                return !HasErrors && textBoxCapital != string.Empty && textBoxName != string.Empty;
            }
        }

        public Dictionary<LoanDomain.Periodicities, string> Periodicities = new Dictionary<LoanDomain.Periodicities, string>()
        {
            {LoanDomain.Periodicities.Monthly, "Mensuelle"},
            {LoanDomain.Periodicities.Bimonthly, "Bimestrielle"},
            {LoanDomain.Periodicities.Termly, "Trimestrielle"},
            {LoanDomain.Periodicities.HalfYearly, "Semestrielle"},
            {LoanDomain.Periodicities.Yearly, "Annuelle"}
        };
        public string Name
        {
            get
            {
                return this.textBoxName;
            }
            set
            {
                ClearErrors(nameof(Name));
                this.textBoxName = value;
                OnPropertyChanged(nameof(Name));
                if (Regex.IsMatch(value, "^[a-zA-Z-]+$") && value.Length > 0)
                {
                    this.loanModel.Name = value;
                } else
                {
                    AddError(nameof(Name), "Le nom est invalide.");
                }
                OnPropertyChanged(nameof(ValidateButtonEnabled));
            }
        }
        public string CapitalBorrowed
        {
            get
            {
                return this.textBoxCapital;
            }
            set
            {
                ClearErrors(nameof(CapitalBorrowed));
                this.textBoxCapital = value;
                OnPropertyChanged(nameof(Name));
                if (decimal.TryParse(value, out decimal _number) && _number > 0)
                {
                    this.loanModel.CapitalBorrowed = _number;
                    RefreshResults();
                } else
                {
                    AddError(nameof(CapitalBorrowed), "Le montant saisi est invalide.");
                }
                OnPropertyChanged(nameof(ValidateButtonEnabled));
            }
        }
        public int PeriodicityInMonths
        {
            get { return this.loanModel.PeriodicityInMonths; }
        }
        public string NbOfRepayments
        {
            get
            {
                return this.loanModel.GetNbOfRepayments().ToString();
            }
        }
        public string RepaymentsSum
        {
            get
            {
                return Math.Round(this.loanModel.GetRepaymentsSum(), 2).ToString() + " €";
            }
        }
        public int DurationInMonths
        {
            get
            {
                return this.loanModel.DurationInMonths;
            }
            set
            {
                this.loanModel.DurationInMonths = value;
                OnPropertyChanged(nameof(DurationInMonths));
                RefreshResults();
            }
        }
        public double YearlyInterestInPercent
        {
            get { return this.loanModel.YearlyInterestInPercent; }
        }

        public void SetYearlyInterest(string _newYearlyInterestInPercent)
        {
            string newYearlyInterest = _newYearlyInterestInPercent.Replace("%", string.Empty);
            if (double.TryParse(newYearlyInterest, out double _nb))
            {
                this.loanModel.YearlyInterestInPercent = _nb;
                RefreshResults();
            }
        }

        public void SetPeriodicity(string _periodicityString)
        {
            foreach (KeyValuePair<LoanDomain.Periodicities, string> _periodicity in this.Periodicities)
            {
                if (_periodicityString == _periodicity.Value)
                {
                    this.loanModel.PeriodicityInMonths = (int)_periodicity.Key;
                    RefreshResults();
                }
            }
        }

        public void RefreshResults()
        {
            OnPropertyChanged(nameof(NbOfRepayments));
            OnPropertyChanged(nameof(RepaymentsSum));
        }

        public LoanVM(int _loanId)
        {
            this.textBoxName = string.Empty;
            this.textBoxCapital = string.Empty;

            this.loanModel = new LoanDomain(_loanId);
            this.loanModel.Load();
            this.Name = loanModel.Name;
            this.CapitalBorrowed = loanModel.CapitalBorrowed.ToString();
            SetPeriodicity(loanModel.PeriodicityInMonths.ToString());
            SetYearlyInterest(loanModel.YearlyInterestInPercent.ToString());
            this.DurationInMonths = this.loanModel.DurationInMonths;

        }
        public LoanVM()
        {
            this.loanModel = new LoanDomain();
            this.textBoxName = string.Empty;
            this.textBoxCapital = string.Empty;
        }

        public void Save()
        {
            this.loanModel.Save();
        }
    }
}
