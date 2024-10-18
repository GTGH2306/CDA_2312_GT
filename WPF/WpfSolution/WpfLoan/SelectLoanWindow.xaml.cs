using ClassLibrary;
using CLDomainePersistance;
using CLPersistance.LoanPersistance;
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
using WpfLoan.Models;

namespace WpfLoan
{
    /// <summary>
    /// Logique d'interaction pour SelectLoanWindow.xaml
    /// </summary>
    public partial class SelectLoanWindow : Window
    {
        public SelectLoanWindow()
        {
            InitializeComponent();
        }

        private void ModifyButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(UserInput.Text, out int _input))
            {
                if (LoanPersistanceSQL.Instance.Select(_input, out _))
                {
                    new MainWindow(_input).Show();
                    this.Close();
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(UserInput.Text, out int _input))
            {
                LoanPersistanceSQL.Instance.Delete(_input);
            }

        }

        private void NewLoanButton_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
