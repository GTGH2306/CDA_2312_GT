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
using System.IO;
using System.Text.Json;

namespace WFLoan
{
    public partial class FormLoan : Form
    {
        public static readonly string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/LoanApp/loan.json";
       

        public static readonly Dictionary<Loan.Periodicities, string> Periodicities = new Dictionary<Loan.Periodicities, string>
        {
            {Loan.Periodicities.Monthly, "Mensuelle"},
            {Loan.Periodicities.Bimonthly, "Bimestrielle"},
            {Loan.Periodicities.Termly, "Trimestrielle"},
            {Loan.Periodicities.HalfYearly, "Semestrielle"},
            {Loan.Periodicities.Yearly, "Annuelle"}
        };

        private Loan initialLoan;
        private Loan modifiedLoan;
        public FormLoan() : this(new Loan()){ }

        public FormLoan(Loan _loan)
        {
            InitializeComponent();
            this.initialLoan = _loan;
            this.modifiedLoan = new Loan(_loan);

            this.textBoxName.Text = _loan.Name;
            this.textBoxCapital.Text = _loan.CapitalBorrowed > 0? _loan.CapitalBorrowed.ToString() : string.Empty;
            
            foreach(KeyValuePair<Loan.Periodicities, string> _periodicity in Periodicities)
            {
                this.listBoxPeriodicity.Items.Add(_periodicity.Value);
            }
            RefreshView();
        }

        public void RefreshView()
        {
            this.textBoxName.Text = LoanController.ValidateName(this.textBoxName.Text) ? this.modifiedLoan.Name : this.textBoxName.Text;
            this.hScrollBarDuration.Value = this.modifiedLoan.DurationInMonths;
            this.labelDurationInMonths.Text = this.modifiedLoan.DurationInMonths.ToString();
            bool periodicityNotFound = true;
            bool interestNotFound = true;
            foreach (KeyValuePair<Loan.Periodicities, string> _item in Periodicities)
            {
                if(this.modifiedLoan.PeriodicityInMonths == (int)_item.Key)
                {
                    this.listBoxPeriodicity.SelectedItem = _item.Value;
                    periodicityNotFound = false;
                }
            }
            if (periodicityNotFound)
            {
                this.errorProvider.SetError(this.listBoxPeriodicity,
                    "Périodicité reglée sur tout les " + this.modifiedLoan.PeriodicityInMonths + " mois.");
            }

            foreach (RadioButton _radio in this.groupBoxInterestRadios.Controls)
            {
                if (this.modifiedLoan.YearlyInterestInPercent == double.Parse(_radio.Tag.ToString()))
                {
                    _radio.Checked = true;
                    interestNotFound = false;
                }
            }
            if (interestNotFound)
            {
                this.errorProvider.SetError(this.groupBoxInterestRadios, "Taux fixé à " + this.modifiedLoan.YearlyInterestInPercent + "%");
            } else
            {
                this.errorProvider.SetError(this.groupBoxInterestRadios, string.Empty);
            }
            this.labelRepaymentsAmount.Text = Math.Ceiling(this.modifiedLoan.GetNbOfRepayments()).ToString();
            decimal roundedRepayment = Math.Round(this.modifiedLoan.GetRepaymentsSum() * 100) / 100;
            this.labelRepaymentsSum.Text = roundedRepayment + " €";
            if (this.textBoxName.Text.Length <= 0 || this.textBoxCapital.Text.Length <= 0 || !this.Validate())
            {
                this.buttonSave.Enabled = false;
            }
            else
            {
                this.buttonSave.Enabled = true;
            }
            this.buttonDelete.Enabled = File.Exists(filepath);
        }
        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            if (LoanController.ValidateName(this.textBoxName.Text))
            {
                this.modifiedLoan.Name = this.textBoxName.Text;
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
                this.modifiedLoan.CapitalBorrowed = decimal.Parse(this.textBoxCapital.Text);
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
            this.modifiedLoan.DurationInMonths = this.hScrollBarDuration.Value;
            this.labelDurationInMonths.Text = this.hScrollBarDuration.Value.ToString();
            RefreshView();
        }
        private void ListBoxPeriodicity_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Loan.Periodicities, string> _periodicity in Periodicities)
            {
                if (_periodicity.Value == this.listBoxPeriodicity.SelectedItem.ToString())
                {
                    this.modifiedLoan.PeriodicityInMonths = (int)_periodicity.Key;
                    this.hScrollBarDuration.Minimum = (int)_periodicity.Key;
                    this.hScrollBarDuration.SmallChange = (int)_periodicity.Key;
                    int nextSuitableIncrement = this.hScrollBarDuration.Value;
                    while (nextSuitableIncrement % (int)_periodicity.Key != 0) 
                    {
                        nextSuitableIncrement++;
                    }
                    if (nextSuitableIncrement > this.hScrollBarDuration.Maximum)
                    {
                        nextSuitableIncrement--;
                        while (nextSuitableIncrement % (int)_periodicity.Key != 0)
                        {
                            nextSuitableIncrement--;
                        }
                    }
                    this.modifiedLoan.DurationInMonths = nextSuitableIncrement;
                }
            }
            RefreshView();
        }
        private new bool Validate()
        {
            return
                LoanController.ValidateName(this.textBoxName.Text) &&
                LoanController.ValidateCapital(this.textBoxCapital.Text) &&
                this.modifiedLoan.CapitalBorrowed > 0 &&
                this.modifiedLoan.GetRepaymentsSum() > 0;
        }
        private void RadioButtonInterestPercent_EnabledChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                this.modifiedLoan.YearlyInterestInPercent = double.Parse(radio.Tag.ToString());
            }
            RefreshView();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                this.initialLoan = new Loan(this.modifiedLoan);
                SaveLoan(this.initialLoan);
            }
            RefreshView();
        }

        private static void SaveLoan(Loan _loanToSave)
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //Si le dossier n'existe pas dans appdata, on le créer
            if (!Directory.Exists(appdata + @"/LoanApp"))
            {
                Directory.CreateDirectory(appdata + @"/LoanApp");
            }
            //Serialisation de Loan
            string jsonString = JsonSerializer.Serialize(_loanToSave,
                new JsonSerializerOptions { WriteIndented = true });
            //Sauvegarde dans un fichier
            File.WriteAllText(appdata + @"/LoanApp/loan.json", jsonString);
        }

        public static Loan LoadLoan()
        {
            Loan result;

            if (File.Exists(filepath))
            {
                string jsonString = File.ReadAllText(filepath);
                result = JsonSerializer.Deserialize<Loan>(jsonString);
            } else
            {
                result= new Loan();
            }

            return result;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/LoanApp/loan.json";
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }
            RefreshView();
        }
    }
}
