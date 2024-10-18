using ClassLibrary;
using ClassLibraryExceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace WpfControles
{
    class TransactionVM : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        public MonetaryTransaction TransactionModel { get; set; }

        private bool buttonValidateEnabled;
        private string amountInput = string.Empty;

        //Créer un dictionnaire de messages d'erreurs par propriétées.
        private readonly Dictionary<string, List<string>> errorsByPropertyName = new Dictionary<string, List<string>>();
        private static readonly Dictionary<TransactionValidation, string> errorMessages = new Dictionary<TransactionValidation, string>()
        {
            {TransactionValidation.Valid, " est valide." },
            {TransactionValidation.InvalidCharacter, " contient un caractère invalide." },
            {TransactionValidation.IsTooLong, " contient trop de caractères." },
            {TransactionValidation.IsTooShort, " ne contient pas assez de caractères." },
            {TransactionValidation.CannotBeNegative, " ne peux contenir de valeur négative." },
            {TransactionValidation.AnteriorToToday, " ne peux contenir de date antérieur à aujourd'hui." }
        };
        public bool ButtonValidateEnabled
        {
            get { return buttonValidateEnabled; }
            set
            {
                this.buttonValidateEnabled = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ButtonValidateEnabled)));

            }
        }

        public string Name
        {
            get { return TransactionModel.Name; }
            set
            {
                ClearErrors(nameof(Name));
                try
                {
                    TransactionModel.Name = value;
                    GetPropertyChanged(nameof(this.Name));
                }
                catch (TransactionArgumentException _exception)
                {
                    AddError(nameof(Name), "Le nom" + errorMessages[_exception.InvalidInputReason]);
                }
                ButtonValidateEnabled = !HasErrors && AreAllInputSet();
            }
        }
        public DateTime Date
        {
            get { return TransactionModel.Date; }
            set
            {
                ClearErrors(nameof(Date));

                try
                {
                    TransactionModel.Date = value;
                    GetPropertyChanged(nameof(this.Date));
                }
                catch (TransactionArgumentException _exception)
                {
                    AddError(nameof(Date), "La date" + errorMessages[_exception.InvalidInputReason]);
                }
                ButtonValidateEnabled = !HasErrors && AreAllInputSet();
            }
        }
        public string Amount
        {
            get { return amountInput; }
            set
            {
                amountInput = value;
                ClearErrors(nameof(Amount));
                try
                {
                    if (decimal.TryParse(value, out decimal _parsed))
                    {
                        TransactionModel.Amount = _parsed;
                    } else
                    {
                        AddError(nameof(Amount), "Le montant est invalide.");
                    }
                    GetPropertyChanged(nameof(this.Amount));
                }
                catch (TransactionArgumentException _exception)
                {
                    AddError(nameof(Amount), "Le montant" + errorMessages[_exception.InvalidInputReason]);
                }
                ButtonValidateEnabled = !HasErrors && AreAllInputSet();
            }
        }
        public string ZipCode
        {
            get { return TransactionModel.ZipCode; }
            set
            {
                ClearErrors(nameof(ZipCode));
                try
                {
                    TransactionModel.ZipCode = value;
                    GetPropertyChanged(nameof(this.ZipCode));
                }
                catch (TransactionArgumentException _exception)
                {
                    AddError(nameof(ZipCode), "Le code postal" + errorMessages[_exception.InvalidInputReason]);
                }
                ButtonValidateEnabled = !HasErrors && AreAllInputSet();
            }
        }

        //Booléen indiquant s'il y'a des erreurs
        public bool HasErrors => errorsByPropertyName.Count > 0;

        public event PropertyChangedEventHandler? PropertyChanged;

        //Evenement qui est activé à chaque fois qu'une erreur est ajouté ou retiré
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public TransactionVM()
        {
            this.TransactionModel = new MonetaryTransaction();
            this.TransactionModel.Date = DateTime.Now.AddDays(1);
        }

        private void GetPropertyChanged(string _property)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_property));
        }

        private bool AreAllInputSet()
        {
            return
                Name != string.Empty &&
                Amount != string.Empty &&
                ZipCode != string.Empty;
        }

        //Sert à l'interface à obtenir les erreurs
        public IEnumerable GetErrors(string? propertyName)
        {
            if (propertyName == null)
            {
                propertyName = string.Empty;
            }
            if (errorsByPropertyName.ContainsKey(propertyName))
            {
                return errorsByPropertyName[propertyName];
            }
            else
            {
                return null;
            }
        }

        //Est appelé pour signaler que les erreurs on changé et lancer l'event en conséquence
        private void OnErrorsChanged(string _property)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(_property));
        }

        //Ajoute une erreur
        private void AddError(string propertyName, string error)
        {
            //Si la propriété n'est pas déjà dans la liste, l'ajoute
            if (!errorsByPropertyName.ContainsKey(propertyName))
            {
                errorsByPropertyName[propertyName] = new List<string>();
            }
            //Si l'erreur n'existe pas dans la liste correspondante a cette propriété, l'ajoute
            if (!errorsByPropertyName[propertyName].Contains(error))
            {
                errorsByPropertyName[propertyName].Add(error);
                OnErrorsChanged(propertyName);
            }
        }

        //Retire les erreurs liées à une propriété
        private void ClearErrors(string _property)
        {
            if (errorsByPropertyName.ContainsKey(_property))
            {
                errorsByPropertyName.Remove(_property);
                OnErrorsChanged(_property);
            }
        }
    }
}
