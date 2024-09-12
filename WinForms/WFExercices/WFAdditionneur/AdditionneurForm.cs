using CLObjet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAdditionneur
{
    public partial class AdditionneurForm : Form
    {
        private Additionneur Additionneur;
        public AdditionneurForm()
        {
            InitializeComponent();
            this.Additionneur = new Additionneur();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            int Number = int.Parse((string)Btn.Tag);
            this.TextBox.Text += Number + "+";
            this.Additionneur.AjouterNombre(Number);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            this.TextBox.Text += " = " + this.Additionneur.Calculer() + "+";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.Additionneur = new Additionneur();
            this.TextBox.Text = String.Empty;
        }
    }
}
