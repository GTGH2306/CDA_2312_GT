using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCombo
{
    public partial class FormCombo : Form
    {
        public FormCombo()
        {
            InitializeComponent();
            EnableButtonsCheck();

        }

        private void ButtonAddAll_Click(object sender, EventArgs e)
        {
            while (this.comboBoxCountries.Items.Count > 0)
            {
                this.listBoxCountries.Items.Add(this.comboBoxCountries.Items[0]);
                this.comboBoxCountries.Items.RemoveAt(0);
            }
            EnableButtonsCheck();
        }
        private void ButtonRemoveAll_Click(object sender, EventArgs e)
        {
            while (this.listBoxCountries.Items.Count > 0)
            {
                this.comboBoxCountries.Items.Add(this.listBoxCountries.Items[0]);
                this.listBoxCountries.Items.RemoveAt(0);
            }
            EnableButtonsCheck();
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (this.comboBoxCountries.Items.Count > 0 && this.comboBoxCountries.SelectedItem != null)
            {
                this.listBoxCountries.Items.Add(this.comboBoxCountries.SelectedItem);
                this.comboBoxCountries.Items.Remove(this.comboBoxCountries.SelectedItem);
                EnableButtonsCheck();
            }
        }
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (this.listBoxCountries.Items.Count > 0 && this.listBoxCountries.SelectedItem != null)
            {
                this.comboBoxCountries.Items.Add(this.listBoxCountries.SelectedItem);
                this.listBoxCountries.Items.Remove(this.listBoxCountries.SelectedItem);
                EnableButtonsCheck();
            }
        }
        private void EnableButtonsCheck()
        {
            this.buttonAdd.Enabled = this.comboBoxCountries.SelectedItem != null;
            this.buttonRemove.Enabled = this.listBoxCountries.SelectedItem != null;
            this.buttonAddAll.Enabled = this.comboBoxCountries.Items.Count > 0;
            this.buttonRemoveAll.Enabled = this.listBoxCountries.Items.Count > 0;
        }

        private void ListBoxCountries_SelectedValueChanged(object sender, EventArgs e)
        {
            EnableButtonsCheck();
        }
        private void ComboBoxCountries_SelectedValueChanged(object sender, EventArgs e)
        {
            EnableButtonsCheck();
        }
    }
}
