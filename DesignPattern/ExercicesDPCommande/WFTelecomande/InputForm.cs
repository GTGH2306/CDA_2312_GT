using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTelecommande
{
    public partial class InputForm : Form
    {
        public InputForm() : this("") {}
        public InputForm(string _prompt)
        {
            InitializeComponent();
            this.labelInput.Text = _prompt;
        }


        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Tag = this.textBoxInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
