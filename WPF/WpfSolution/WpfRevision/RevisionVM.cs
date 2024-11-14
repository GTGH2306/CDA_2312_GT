using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfRevision
{
    public class RevisionVM : ViewModel
    {
        private readonly AdditionneurRevision domain;
        private string firstNbTextBox;
        private string secondNbTextBox;

        public string FirstNb
        {
            get
            {
                return firstNbTextBox;
            }
            set
            {
                ClearErrors(nameof(FirstNb));
                this.firstNbTextBox = value;
                if (int.TryParse(value, out int _nb))
                {
                    this.domain.FirstNb = _nb;
                } else
                {
                    AddError(nameof(FirstNb), "Nombre invalide.");
                }
                OnPropertyChanged(nameof(FirstNb));
                OnPropertyChanged(nameof(HasNoErrors));
            }
        }
        public string SecondNb
        {
            get
            {
                return secondNbTextBox;
            }
            set
            {
                ClearErrors(nameof(SecondNb));
                this.secondNbTextBox = value;
                if (int.TryParse(value, out int _nb))
                {
                    this.domain.SecondNb = _nb;
                }
                else
                {
                    AddError(nameof(SecondNb), "Nombre invalide.");
                }
                OnPropertyChanged(nameof(SecondNb));
                OnPropertyChanged(nameof(HasNoErrors));
            }
        }
        public string Sum
        {
            get
            {
                return this.domain.Sum.ToString();
            }
        }
        public bool HasNoErrors
        {
            get
            {
                return !HasErrors && firstNbTextBox != string.Empty && secondNbTextBox != string.Empty;
            }
        }
        public RevisionVM()
        {
            this.domain = new AdditionneurRevision();
            this.firstNbTextBox = string.Empty;
            this.secondNbTextBox = string.Empty;
        }
        public void UpdateSum()
        {
            OnPropertyChanged(nameof(Sum));
        }
    }
}
