using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFDefilement
{
    public partial class FormDefilement : Form
    {
        private Color finalColor;
        public FormDefilement() : this(Color.Black) {}

        private void UpdateViewWithModele()
        {
            // a partir de finalColor
            this.hScrollBarRed.Value = this.finalColor.R;
            this.numericUpDownRed.Value = this.finalColor.R;
            this.hScrollBarGreen.Value = this.finalColor.G;
            this.numericUpDownGreen.Value = this.finalColor.G;
            this.hScrollBarBlue.Value = this.finalColor.B;
            this.numericUpDownBlue.Value = this.finalColor.B;
            this.textBoxFinalColor.BackColor = this.finalColor;
        }

        public FormDefilement(Color _startingColor)
        {
            InitializeComponent();
            this.finalColor = _startingColor;
            UpdateViewWithModele();
        }

        private void HScrollBarRed_ValueChanged(object sender, EventArgs e)
        {
            this.finalColor = Color.FromArgb(this.hScrollBarRed.Value, this.finalColor.G, this.finalColor.B);
            UpdateViewWithModele();
        }

        private void HScrollBarGreen_ValueChanged(object sender, EventArgs e)
        {
            this.finalColor = Color.FromArgb(this.finalColor.R, this.hScrollBarGreen.Value, this.finalColor.B);
            UpdateViewWithModele();
        }

        private void HScrollBarBlue_ValueChanged(object sender, EventArgs e)
        {
            this.finalColor = Color.FromArgb(this.finalColor.R, this.finalColor.G, this.hScrollBarBlue.Value);
            UpdateViewWithModele();
        }

        private void NumericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            this.finalColor = Color.FromArgb((int)this.numericUpDownRed.Value, this.finalColor.G, this.finalColor.B);
            UpdateViewWithModele();
        }

        private void NumericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            this.finalColor = Color.FromArgb(this.finalColor.R, (int)this.numericUpDownGreen.Value, this.finalColor.B);
            UpdateViewWithModele();
        }

        private void NumericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            this.finalColor = Color.FromArgb(this.finalColor.R, this.finalColor.G, (int)this.numericUpDownBlue.Value);
            UpdateViewWithModele();
        }

        private void ButtonNewWindow_Click(object sender, EventArgs e)
        {
            new FormDefilement(this.finalColor).ShowDialog();
        }
    }
}
