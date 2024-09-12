using CLObjet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFControles
{
    public partial class FormControles : Form
    {
        public FormControles()
        {
            InitializeComponent();
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            TextBox NameBox = (TextBox)sender;
            if (!Transaction.ValidateName(NameBox.Text, out List<Transaction.Error> _errors))
            {
                string ErrorMsg = "";
                if (_errors.Contains(Transaction.Error.NameIsTooShort))
                {
                    ErrorMsg += "Le nom est trop court.\n";
                }
                if (_errors.Contains(Transaction.Error.NameIsTooLong))
                {
                    ErrorMsg += "Le nom est trop long.\n";
                }
                if (_errors.Contains(Transaction.Error.NameInvalidCharacter))
                {
                    ErrorMsg += "Le nom contient un ou plusieurs caractères invalides.\n";
                }
                this.errorProvider.SetError(NameBox, ErrorMsg);
            } else
            {
                this.errorProvider.SetError(NameBox, string.Empty);
            }

            EnableDisableValidateButton();
        }

        private void TextBoxCode_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox CodeBox = (MaskedTextBox)sender;
            if (!Transaction.ValidateCode(CodeBox.Text, out List<Transaction.Error> _errors))
            {
                string ErrorMsg = "";
                if (_errors.Contains(Transaction.Error.CodeIsTooShort))
                {
                    ErrorMsg += "Le Code Postal trop court.\n";
                }
                if (_errors.Contains(Transaction.Error.CodeIsTooLong))
                {
                    ErrorMsg += "Le Code Postal trop long.\n";
                }
                if (_errors.Contains(Transaction.Error.CodeInvalidCharacter))
                {
                    ErrorMsg += "Le Code Postal contient un ou plusieurs caractères invalides.\n";
                }
                this.errorProvider.SetError(CodeBox, ErrorMsg);
            } else
            {
                this.errorProvider.SetError(CodeBox, string.Empty);
            }

            EnableDisableValidateButton();
        }

        private void TextBoxAmount_TextChanged(object sender, EventArgs e)
        {
            TextBox AmountBox = (TextBox)sender;
            if (!Transaction.ValidateAmount(AmountBox.Text, out List<Transaction.Error> _errors))
            {
                string ErrorMsg = "";
                if (_errors.Contains(Transaction.Error.AmountCannotBeNegative))
                {
                    ErrorMsg += "Le montant ne peut être négatif.\n";
                }
                if (_errors.Contains(Transaction.Error.AmountCouldNotDoubleParse))
                {
                    ErrorMsg += "Le montant n'est pas une somme valide.\n";
                }
                this.errorProvider.SetError(AmountBox, ErrorMsg);
            } else
            {
                this.errorProvider.SetError(AmountBox, string.Empty);
            }

            EnableDisableValidateButton();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.textBoxAmount.Text = string.Empty;
            this.textBoxCode.Text = string.Empty;
            this.textBoxName.Text = string.Empty;
            this.textBoxDate.Text = string.Empty;

            this.errorProvider.Clear();
            EnableDisableValidateButton();
        }

        private void TextBoxDate_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox DateBox = (MaskedTextBox)sender;
            if (!Transaction.ValidateDate(DateBox.Text, out List<Transaction.Error> _errors))
            {
                string ErrorMsg = "";
                if (_errors.Contains(Transaction.Error.DateNotEnoughParameters))
                {
                    ErrorMsg += "La date ne contient pas assez de paramêtres.\n";
                }
                if (_errors.Contains(Transaction.Error.DateCouldNotIntParse))
                {
                    ErrorMsg += "La date contient des caractères invalides.\n";
                }
                if (_errors.Contains(Transaction.Error.DateTooManyParameters))
                {
                    ErrorMsg += "La date ne contient trop de paramêtres.\n";
                }
                if (_errors.Contains(Transaction.Error.DateAnteriorToToday))
                {
                    ErrorMsg += "La date est antérieur à aujourd'hui.\n";
                }
                if (_errors.Contains(Transaction.Error.DateIsNotAValideDate))
                {
                    ErrorMsg += "La date n'est pas une date valide.\n";
                }
                this.errorProvider.SetError(DateBox, ErrorMsg);
            } else
            {
                this.errorProvider.SetError(DateBox, string.Empty);
            }

            EnableDisableValidateButton();
        }

        private void ButtonValidate_Click(object sender, EventArgs e)
        {
            string name;
            DateTime date;
            double amount;
            string code;
            Transaction transaction;

            if(Transaction.ValidateAmount(this.textBoxAmount.Text, out _) &&
                Transaction.ValidateName(this.textBoxName.Text, out _) &&
                Transaction.ValidateCode(this.textBoxCode.Text, out _) &&
                Transaction.ValidateDate(this.textBoxDate.Text, out _))
            {
                name = this.textBoxName.Text;
                date = Transaction.StringToDate(this.textBoxDate.Text);
                amount = double.Parse(this.textBoxAmount.Text);
                code = this.textBoxCode.Text;
                transaction = new Transaction(name, date, amount, code);

                new ValidateTransaction(transaction).ShowDialog();
            }
        }

        public void EnableDisableValidateButton()
        {
            if (Transaction.ValidateAmount(this.textBoxAmount.Text, out _) &&
                Transaction.ValidateName(this.textBoxName.Text, out _) &&
                Transaction.ValidateCode(this.textBoxCode.Text, out _) &&
                Transaction.ValidateDate(this.textBoxDate.Text, out _))
            {
                this.buttonValidate.Enabled = true;
            }
            else
            {
                this.buttonValidate.Enabled = false;
            }
        }

        private void FormControles_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Fin de l'application", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
