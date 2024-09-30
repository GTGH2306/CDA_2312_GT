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

namespace WFControlLibrary
{
    public partial class UCTrafficLightButtons : UserControl
    {
        public delegate void UCTrafficLightButtonClickedEventHandler(UCTrafficLightButtons _sender, Color _colorClicked);
        public event UCTrafficLightButtonClickedEventHandler UCTrafficLightButtonClicked;
        public bool GreenEnabled
        {
            get { return this.buttonGreen.Enabled; }
            set { this.buttonGreen.Enabled = value; }
        }
        public bool YellowEnabled
        {
            get { return this.buttonYellow.Enabled; }
            set { this.buttonYellow.Enabled = value; }
        }
        public bool RedEnabled
        {
            get { return this.buttonRed.Enabled; }
            set { this.buttonRed.Enabled = value; }
        }
        public UCTrafficLightButtons() : this(new KeyValuePair<char, Production>('U', new Production())) {}
        public UCTrafficLightButtons(KeyValuePair<char, Production> _prod)
        {
            InitializeComponent();
            this.Tag = _prod.Value;
            this.buttonGreen.Text = _prod.Key.ToString();
            this.buttonYellow.Text = _prod.Key.ToString();
            this.buttonRed.Text = _prod.Key.ToString();
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            if (this.UCTrafficLightButtonClicked != null)
            {
                UCTrafficLightButtonClicked(this, Color.Green);
            }
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            if (this.UCTrafficLightButtonClicked != null)
            {
                UCTrafficLightButtonClicked(this, Color.Red);
            }
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            if (this.UCTrafficLightButtonClicked != null)
            {
                UCTrafficLightButtonClicked(this, Color.Yellow);
            }
        }
    }
}
