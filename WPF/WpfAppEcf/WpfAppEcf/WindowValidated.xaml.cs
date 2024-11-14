using CLEcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppEcf
{
    /// <summary>
    /// Logique d'interaction pour WindowValidated.xaml
    /// </summary>
    public partial class WindowValidated : Window
    {
        public WindowValidated(Inscription _inscription)
        {
            InitializeComponent();
            string section = InscriptionVM.TraingingName[_inscription.TrainingSelected];
            section += _inscription.TrainingBegin.Year;
            mainLabel.Content = section;
        }
    }
}
