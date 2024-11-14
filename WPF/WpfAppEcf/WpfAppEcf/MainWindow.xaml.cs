using CLEcf;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppEcf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InscriptionVM dataContext = new InscriptionVM();
            this.DataContext = dataContext;
            foreach (KeyValuePair<Inscription.Training, string> _training in InscriptionVM.TraingingName)
            {
                if (_training.Value != string.Empty)
                {
                    trainingsList.Items.Add(_training.Value);
                }
            }
        }

        private void trainingsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InscriptionVM dataContext = (InscriptionVM)this.DataContext;
            string trainingSelected = (string)trainingsList.SelectedItem;
            dataContext.SelectedTraining = trainingSelected;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InscriptionVM dataContext = (InscriptionVM)this.DataContext;
            if (dataContext.IsValid)
            {
                new WindowValidated(dataContext.Model).ShowDialog();
            } else
            {
                MessageBox.Show("Erreur de saisie.","Erreur",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}