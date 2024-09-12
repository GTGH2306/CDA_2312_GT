using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBonjour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Text = "truc muche";
           
        }

        private void buttonDisBonjour_Click(object sender, EventArgs e)
        {
          /* DialogResult humeurDuMoment= MessageBox.Show("Tu vas bien?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (humeurDuMoment == DialogResult.Yes)
            {
                MessageBox.Show("Travaille");
            }
          */

            FormHumeur formHumeur = new FormHumeur();
            DialogResult dr = formHumeur.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;



            string nouveauTexte= textBox1.Text;
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
