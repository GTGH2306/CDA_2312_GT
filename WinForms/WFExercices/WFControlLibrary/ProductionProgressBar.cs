using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLObjet;

namespace WFControlLibrary
{
    public partial class ProductionProgressBar: UserControl
    {
        public int ProgressValue
        {
            get { return this.progressBarProd.Value; }
            set { this.progressBarProd.Value = value;}
        }
        public ProductionProgressBar() : this('0', new Production()) { }
        public ProductionProgressBar(char _name, Production _production)
        {
            InitializeComponent();

            this.labelProd.Text = "Production " + _name.ToString();
            this.progressBarProd.Maximum = _production.GetCrateGoal();
            this.Tag = _production;
        }
    }
}
