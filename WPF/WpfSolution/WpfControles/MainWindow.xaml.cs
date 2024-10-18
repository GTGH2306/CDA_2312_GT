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

namespace WpfControles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new TransactionVM();
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new TransactionVM();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Êtes-vous sûr de vouloir fermer?", "Fermer", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ValidateButton_Click(object sender, RoutedEventArgs e)
        {
            TransactionVM vm = (TransactionVM)this.DataContext;
            if (!vm.HasErrors)
            {
                new WindowValidated(vm.TransactionModel).ShowDialog();
            }
        }
    }
}