using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEcf
{
    public class ViewModel : INotifyPropertyChanged, INotifyDataErrorInfo
    {

        private readonly Dictionary<string, List<string>> errorsByPropertyName = new Dictionary<string, List<string>>();

        //Booléen indiquant s'il y'a des erreurs
        public bool HasErrors => errorsByPropertyName.Count > 0;

        public event PropertyChangedEventHandler? PropertyChanged;

        //Evenement qui est activé à chaque fois qu'une erreur est ajouté ou retiré
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;


        protected void OnPropertyChanged(string _property)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_property));
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
        protected void OnErrorsChanged(string _property)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(_property));
        }

        //Ajoute une erreur
        protected void AddError(string propertyName, string error)
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
        protected void ClearErrors(string _property)
        {
            if (errorsByPropertyName.ContainsKey(_property))
            {
                errorsByPropertyName.Remove(_property);
                OnErrorsChanged(_property);
            }
        }
    }
}
