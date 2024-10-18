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
using WpfAdditionneur;

namespace WpfExercices
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new AdderVM();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            AdderVM viewModel = (AdderVM)this.DataContext;
            Button btn = (Button)sender;
            if (int.TryParse(btn.Tag.ToString(), out int _result))
            {
                viewModel.AddNumber(_result);
            }
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            AdderVM viewModel = (AdderVM)this.DataContext;
            viewModel.Calculate();
        }

        private void EmptyButton_Click(object sender, RoutedEventArgs e)
        {
            AdderVM viewModel = (AdderVM)this.DataContext;
            viewModel.Empty();
        }
    }
}