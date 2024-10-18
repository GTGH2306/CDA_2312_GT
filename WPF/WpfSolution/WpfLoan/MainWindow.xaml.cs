using ClassLibrary;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfLoan.Models;

namespace WpfLoan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(int _loanId)
        {
            InitializeComponent();
            LoanVM dataContext = _loanId >=0 ? new LoanVM(_loanId) : new LoanVM();
            this.DataContext = dataContext;
            HScrollBar.Value = dataContext.DurationInMonths;
            foreach (KeyValuePair<LoanDomain.Periodicities, string> _periodicity in dataContext.Periodicities)
            {
                PeriodicitiesListBox.Items.Add(_periodicity.Value);
                if((int)_periodicity.Key == dataContext.PeriodicityInMonths)
                {
                    PeriodicitiesListBox.SelectedItem = _periodicity.Value;
                }
            }
            foreach (RadioButton _radio in Radios.Children)
            {
                string? radioValue = _radio.Tag.ToString();
                if (radioValue != null && double.TryParse(radioValue, out double _radioNb) && _radioNb == dataContext.YearlyInterestInPercent)
                {
                     _radio.IsChecked = true;
                } else
                {
                    _radio.IsChecked = false;
                }
            }
        }

        public MainWindow() : this(-1) { }

        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            LoanVM dataContext = (LoanVM)this.DataContext;
            ScrollBar scrollBar = (ScrollBar)sender;
            RoundDuration();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(this.DataContext != null)
            {
                LoanVM dataContext = (LoanVM)this.DataContext;
                RadioButton radio = (RadioButton)sender;
                string newValue = radio.Content != null ? (string)radio.Content : "";
                dataContext.SetYearlyInterest(newValue);
            }
        }

        private void PeriodicitiesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            LoanVM dataContext = (LoanVM)this.DataContext;
            dataContext.SetPeriodicity((string)listBox.SelectedItem);
            HScrollBar.SmallChange = dataContext.PeriodicityInMonths;
            HScrollBar.LargeChange = dataContext.PeriodicityInMonths;

            RoundDuration();
        }

        private void RoundDuration()
        {
            LoanVM context = (LoanVM)this.DataContext;
            if (context != null)
            {
                int nextNumberPossible = (int)Math.Ceiling(HScrollBar.Value);
                while (nextNumberPossible % context.PeriodicityInMonths != 0)
                {
                    nextNumberPossible++;
                }

                context.DurationInMonths = nextNumberPossible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoanVM viewModel = (LoanVM)this.DataContext;
            viewModel.Save();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}