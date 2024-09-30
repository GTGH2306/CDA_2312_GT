using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFToutEmballe
{
    public partial class TimeSpeedInput : Form
    {
        public int UserInput { get; private set; }
        public TimeSpeedInput()
        {
            InitializeComponent();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void maskedTextBoxTimeSpeed_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(maskedTextBoxTimeSpeed.Text, out int _n))
            {
                this.UserInput = _n;
            }
        }
    }
}
