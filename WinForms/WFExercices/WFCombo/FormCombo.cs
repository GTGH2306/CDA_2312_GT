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

        private void ButtonComboToListAll_Click(object sender, EventArgs e)
        {
            while (this.comboBoxCountries.Items.Count > 0)
            {
                this.listBoxCountries.Items.Add(this.comboBoxCountries.Items[0]);
                this.comboBoxCountries.Items.RemoveAt(0);
            }
            EnableButtonsCheck();
        }
        private void ButtonListToComboAll_Click(object sender, EventArgs e)
        {
            while (this.listBoxCountries.Items.Count > 0)
            {
                this.comboBoxCountries.Items.Add(this.listBoxCountries.Items[0]);
                this.listBoxCountries.Items.RemoveAt(0);
            }
            EnableButtonsCheck();
        }
        private void ButtonComboToList_Click(object sender, EventArgs e)
        {
            if (this.comboBoxCountries.Items.Count > 0 && this.comboBoxCountries.SelectedItem != null)
            {
                int index = this.comboBoxCountries.SelectedIndex;
                this.listBoxCountries.Items.Add(this.comboBoxCountries.SelectedItem);
                this.comboBoxCountries.Items.Remove(this.comboBoxCountries.SelectedItem);
                if(index < this.comboBoxCountries.Items.Count)
                {
                    this.comboBoxCountries.SelectedIndex = index;
                }
                else if (index == this.comboBoxCountries.Items.Count && index >= 1)
                {
                    this.comboBoxCountries.SelectedIndex = index - 1;
                } else if (this.comboBoxCountries.Items.Count == 0)
                {
                    this.comboBoxCountries.Text = string.Empty;
                }
                EnableButtonsCheck();
            }
        }
        private void ButtonListToCombo_Click(object sender, EventArgs e)
        {
            if (this.listBoxCountries.Items.Count > 0 && this.listBoxCountries.SelectedItem != null)
            {
                int index = this.listBoxCountries.SelectedIndex;
                this.comboBoxCountries.Items.Add(this.listBoxCountries.SelectedItem);
                this.listBoxCountries.Items.Remove(this.listBoxCountries.SelectedItem);
                if (index < this.listBoxCountries.Items.Count)
                {
                    this.listBoxCountries.SetSelected(index, true);
                } else if (index == this.listBoxCountries.Items.Count && index >= 1)
                {
                    this.listBoxCountries.SetSelected(index - 1, true);
                }
                EnableButtonsCheck();
            }
        }
        private void EnableButtonsCheck()
        {
            this.buttonAdd.Enabled = this.comboBoxCountries.SelectedItem != null;
            this.buttonRemove.Enabled = this.listBoxCountries.SelectedItem != null;
            this.buttonAddAll.Enabled = this.comboBoxCountries.Items.Count > 0;
            this.buttonRemoveAll.Enabled = this.listBoxCountries.Items.Count > 0;
            this.buttonMoveDown.Enabled = this.listBoxCountries.SelectedIndex < this.listBoxCountries.Items.Count - 1 && this.listBoxCountries.SelectedIndex >= 0;
            this.buttonMoveUp.Enabled = this.listBoxCountries.SelectedIndex > 0;
        }

        private void ListBoxCountries_SelectedValueChanged(object sender, EventArgs e)
        {
            EnableButtonsCheck();
        }
        private void ComboBoxCountries_SelectedValueChanged(object sender, EventArgs e)
        {
            EnableButtonsCheck();
            this.listBoxCountries.ClearSelected();
        }

        private void ButtonMoveUp_Click(object sender, EventArgs e)
        {
            if (this.listBoxCountries.SelectedItem != null
                && this.listBoxCountries.Items.Count > 0
                && this.listBoxCountries.SelectedIndex > 0)
            {
                int originalIndex = this.listBoxCountries.SelectedIndex;
                string item = (string)this.listBoxCountries.SelectedItem;
                this.listBoxCountries.Items.RemoveAt(originalIndex);
                this.listBoxCountries.Items.Insert(originalIndex - 1, item);
                this.listBoxCountries.SetSelected(originalIndex - 1, true);
            }
        }

        private void ButtonMoveDown_Click(object sender, EventArgs e)
        {
            if (this.listBoxCountries.SelectedItem != null
                && this.listBoxCountries.Items.Count > 0
                && this.listBoxCountries.SelectedIndex < this.listBoxCountries.Items.Count - 1)
            {
                int originalIndex = this.listBoxCountries.SelectedIndex;
                string item = (string)this.listBoxCountries.SelectedItem;
                this.listBoxCountries.Items.RemoveAt(originalIndex);
                this.listBoxCountries.Items.Insert(originalIndex + 1, item);
                this.listBoxCountries.SetSelected(originalIndex + 1, true);
            }
        }

        private void ComboBoxAddToCombo_DropDown(object sender, EventArgs e)
        {
            if (!this.comboBoxCountries.Items.Contains(this.comboBoxCountries.Text)
                && !this.listBoxCountries.Items.Contains(this.comboBoxCountries.Text)
                && this.comboBoxCountries.Text.Length > 1)
            {
                this.comboBoxCountries.Items.Add(this.comboBoxCountries.Text);
                this.comboBoxCountries.Text = string.Empty;
            }
        }
    }
}
