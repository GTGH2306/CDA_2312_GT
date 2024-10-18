using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAdditionneur
{
    public class AdderVM : INotifyPropertyChanged
    {
        private Adder adder;

        public event PropertyChangedEventHandler? PropertyChanged;
        private string stringToShow;
        public string StringToShow
        {
            get { return stringToShow; }
            set
            {
                stringToShow = value;
                this.GetPropertyChanged(nameof(this.StringToShow));
            }
        }
        public AdderVM()
        {
            this.adder = new Adder();
            stringToShow = string.Empty;
        }

        public void AddNumber(int _nbToAdd)
        {
            this.adder.AddNumber(_nbToAdd);
            this.StringToShow += _nbToAdd.ToString() + "+";
        }

        public void Empty()
        {
            this.adder = new Adder();
            this.StringToShow = string.Empty;
        }

        public void Calculate()
        {
            this.StringToShow += " = " + this.adder.GetResult().ToString() + "+";
        }

        protected void GetPropertyChanged(string _propertyChanged)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_propertyChanged));
        }
    }
}
