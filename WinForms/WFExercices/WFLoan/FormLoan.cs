using CLObjet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CLObjet.Transaction;
using System.Xml.Linq;

namespace WFLoan
{
    public partial class FormLoan : Form
    {
        public static readonly Loan DefaultLoan = new Loan("", 0, 1, 1, 7);
        public static readonly Dictionary<int, string> Periodicities = new Dictionary<int, string>
        {
            {1, "Mensuelle"},
            {2, "Bimestrielle"},
            {3, "Trimestrielle"},
            {6, "Semestrielle"},
            {12, "Annuelle"}
        };

        private Loan InitialLoan;
        private Loan ModifiedLoan;
        public FormLoan() : this(DefaultLoan){ }

        public FormLoan(Loan _loan)
        {
            InitializeComponent();
            this.InitialLoan = _loan;
            this.ModifiedLoan = new Loan(_loan);
            foreach(KeyValuePair<int, string> _periodicity in Periodicities)
            {
                this.listBoxPeriodicity.Items.Add(_periodicity.Value);
            }
            RefreshView();
        }

        public void RefreshView()
        {
            this.textBoxName.Text = LoanController.ValidateName(this.textBoxName.Text) ? this.ModifiedLoan.Name : this.textBoxName.Text;
            this.hScrollBarDuration.Value = this.ModifiedLoan.DurationInMonths;
            this.labelDurationInMonths.Text = this.ModifiedLoan.DurationInMonths.ToString();
            bool periodicityNotFound = true;
            bool interestNotFound = true;
            foreach (KeyValuePair<int, string> _item in Periodicities)
            {
                if(this.ModifiedLoan.PeriodicityInMonths == _item.Key)
                {
                    this.listBoxPeriodicity.SelectedItem = _item.Value;
                    periodicityNotFound = false;
                }
            }
            if (periodicityNotFound)
            {
                this.errorProvider.SetError(this.listBoxPeriodicity,
                    "Périodicité reglée sur tout les " + this.ModifiedLoan.PeriodicityInMonths + " mois.");
            }

            foreach (RadioButton _radio in this.groupBoxInterestRadios.Controls)
            {
                if (this.ModifiedLoan.YearlyInterestInPercent == double.Parse(_radio.Tag.ToString()))
                {
                    _radio.Checked = true;
                    interestNotFound = false;
                }
            }
            if (interestNotFound)
            {
                this.errorProvider.SetError(this.groupBoxInterestRadios, "Taux fixé à " + this.ModifiedLoan.YearlyInterestInPercent + "%");
            } else
            {
                this.errorProvider.SetError(this.groupBoxInterestRadios, string.Empty);
            }
            this.labelRepaymentsAmount.Text = Math.Ceiling(this.ModifiedLoan.GetNbOfRepayments()).ToString();
            decimal roundedRepayment = Math.Round(this.ModifiedLoan.GetRepaymentsSum() * 100) / 100;
            this.labelRepaymentsSum.Text = roundedRepayment + " €";
            if (this.textBoxName.Text.Length <= 0 || this.textBoxCapital.Text.Length <= 0 || !this.Validate())
            {
                this.buttonOk.Enabled = false;
            }
            else
            {
                this.buttonOk.Enabled = true;
            }
        }
        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            if (LoanController.ValidateName(this.textBoxName.Text))
            {
                this.ModifiedLoan.Name = this.textBoxName.Text;
                this.errorProvider.SetError(this.textBoxName, string.Empty);
            } else
            {
                this.errorProvider.SetError(this.textBoxName, "Nom invalide");
            }
            RefreshView();
        }
        private void TextBoxCapital_TextChanged(object sender, EventArgs e)
        {
            if (LoanController.ValidateCapital(this.textBoxCapital.Text))
            {
                this.ModifiedLoan.CapitalBorrowed = decimal.Parse(this.textBoxCapital.Text);
                this.errorProvider.SetError(this.textBoxCapital, string.Empty);
            }
            else
            {
                this.errorProvider.SetError(this.textBoxCapital, "Somme invalide");
            }
            RefreshView();
        }
        private void HScrollBarDuration_ValueChanged(object sender, EventArgs e)
        {
            this.ModifiedLoan.DurationInMonths = this.hScrollBarDuration.Value;
            this.labelDurationInMonths.Text = this.hScrollBarDuration.Value.ToString();
            RefreshView();
        }
        private void ListBoxPeriodicity_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, string> _periodicity in Periodicities)
            {
                if (_periodicity.Value == this.listBoxPeriodicity.SelectedItem.ToString())
                {
                    this.ModifiedLoan.PeriodicityInMonths = _periodicity.Key;
                }
            }
            RefreshView();
        }
        private new bool Validate()
        {
            return
                LoanController.ValidateName(this.textBoxName.Text) &&
                LoanController.ValidateCapital(this.textBoxCapital.Text) &&
                this.ModifiedLoan.CapitalBorrowed > 0 &&
                this.ModifiedLoan.GetRepaymentsSum() > 0;
        }

        private void RadioButtonInterestPercent_EnabledChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                this.ModifiedLoan.YearlyInterestInPercent = double.Parse(radio.Tag.ToString());
            }
            RefreshView();
        }



        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.InitialLoan = this.ModifiedLoan;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
