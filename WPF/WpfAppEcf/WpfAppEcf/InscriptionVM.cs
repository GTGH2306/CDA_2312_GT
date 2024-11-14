using CLEcf;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WpfAppEcf
{
    class InscriptionVM : ViewModel
    {
        private readonly Inscription model;
        private string lastNameTextBox;
        private string firstNameTextBox;
        private DateTime trainingBeginIhm;
        private DateTime trainingEndIhm;

        public static Dictionary<Inscription.Training, string> TraingingName = new Dictionary<Inscription.Training, string>
        {
            {Inscription.Training.None, string.Empty },
            {Inscription.Training.ABCDEV, "ABC-DEV" },
            {Inscription.Training.DWWM, "DWWM" },
            {Inscription.Training.CDA, "CDA" }
        };

        public bool IsValid
        {
            get
            {
                return !HasErrors &&
                    !string.IsNullOrEmpty(LastName) &&
                    !string.IsNullOrEmpty(FirstName) &&
                    TrainingBegin > DateTime.Now &&
                    TrainingEnd > TrainingBegin &&
                    SelectedTraining != string.Empty;
            }
        }

        public string LastName
        {
            get { return lastNameTextBox; }
            set
            {
                lastNameTextBox = value;
                ClearErrors(nameof(LastName));
                if (Regex.IsMatch(value, "^[a-zA-Z-]+$") && value.Length > 0 && value.Length <= 25)
                {
                    this.model.Lastname = value;
                } else
                {
                    AddError(nameof(LastName), "Nom saisi invalide.");
                }
                OnPropertyChanged(nameof(LastName));
                OnPropertyChanged(nameof(IsValid));
            }
        }
        public string FirstName
        {
            get { return firstNameTextBox; }
            set
            {
                firstNameTextBox = value;
                ClearErrors(nameof(FirstName));
                if (Regex.IsMatch(value, "^[a-zA-Z-]+$") && value.Length > 0 && value.Length <= 25)
                {
                    this.model.Firstname = value;
                }
                else
                {
                    AddError(nameof(FirstName), "Nom saisi invalide.");
                }
                OnPropertyChanged(nameof(FirstName));
                OnPropertyChanged(nameof(IsValid));
            }
        }
        
        public Inscription Model
        {
            get => model;
        }

        public DateTime TrainingBegin
        {
            get { return trainingBeginIhm; }
            set
            {
                trainingBeginIhm = value;
                ClearErrors(nameof(TrainingBegin));
                ClearErrors(nameof(TrainingEnd));
                if (value < DateTime.Now)
                {
                    AddError(nameof(TrainingBegin), "La date de début doit être postérieur à aujourd'hui.");
                }
                else if (value > TrainingEnd)
                {
                    AddError(nameof(TrainingEnd), "La date de début doit être postérieur à la date de début de formation.");
                }
                else
                {
                    this.model.TrainingBegin = value;
                }
                OnPropertyChanged(nameof(TrainingBegin));
                OnPropertyChanged(nameof(IsValid));
            }
        }

        public DateTime TrainingEnd
        {
            get { return trainingEndIhm; }
            set
            {
                trainingEndIhm = value;
                ClearErrors(nameof(TrainingEnd));
                if (value > TrainingBegin)
                {
                    this.model.TrainingEnd = value;
                }
                else
                {
                    AddError(nameof(TrainingEnd), "La date de début doit être postérieur à la date de début de formation.");
                }
                OnPropertyChanged(nameof(TrainingEnd));
                OnPropertyChanged(nameof(IsValid));
            }
        }

        public string SelectedTraining
        {
            get { return TraingingName[this.model.TrainingSelected]; }
            set
            {
                ClearErrors(nameof(SelectedTraining));
                if (value != string.Empty)
                {
                    foreach (KeyValuePair<Inscription.Training, string> _training in TraingingName)
                    {
                        if (value == _training.Value)
                        {
                            this.model.TrainingSelected = _training.Key;
                        }
                    }
                } else
                {
                    AddError(nameof(SelectedTraining), "Aucune formation séléctioné");
                }
                OnPropertyChanged(nameof(SelectedTraining));
                OnPropertyChanged(nameof(IsValid));
            }
        }

        public InscriptionVM()
        {
            model = new Inscription();
            lastNameTextBox = string.Empty;
            firstNameTextBox = string.Empty;
            trainingBeginIhm = model.TrainingBegin;
            trainingEndIhm = model.TrainingEnd;
        }
    }
}
