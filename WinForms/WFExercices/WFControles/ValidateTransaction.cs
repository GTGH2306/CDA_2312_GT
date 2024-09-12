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
    public partial class ValidateTransaction : Form
    {
        public ValidateTransaction(Transaction _transaction)
        {
            InitializeComponent();
            this.labelName.Text += _transaction.GetName();
            this.labelDate.Text +=
                _transaction.GetDate().Day + "/" +
                _transaction.GetDate().Month + "/" +
                _transaction.GetDate().Year;

            this.labelAmount.Text += _transaction.GetAmount();
            this.labelCode.Text += _transaction.GetCode();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
