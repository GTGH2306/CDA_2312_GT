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

namespace WFControlLibrary
{
    public partial class ProductionTabPage : UserControl
    {
        public string TextNbCrates
        {
            get { return this.textBoxNbCratesSinceStartProd.Text; }
            set { this.textBoxNbCratesSinceStartProd.Text = value; }
        }
        public string TextFlawedLastHour
        {
            get { return this.textBoxLastHourFlawRateProd.Text; }
            set { this.textBoxLastHourFlawRateProd.Text = value; }
        }
        public string TextFlawedOverall
        {
            get { return this.textBoxOverallFlawRateProd.Text; }
            set { this.textBoxOverallFlawRateProd.Text = value; }
        }
        public ProductionTabPage() : this('0', new Production()) { }
        public ProductionTabPage(char _name, Production _production)
        {
            InitializeComponent();
            this.textBoxNbCratesSinceStartProd.Text = _production.GetNbOfCrates().ToString();
            this.textBoxLastHourFlawRateProd.Text = _production.GetFlawedCrateOfLastHourPercent().ToString();
            this.textBoxOverallFlawRateProd.Text = _production.GetFlawedCrateSinceBeginningRate().ToString();
            this.Tag = _production;
        }
    }
}
