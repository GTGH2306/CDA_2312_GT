using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFListes
{
    public partial class FormLists : Form
    {
        //private List<string> formList;
        public FormLists()
        {
            InitializeComponent();
            //formList = new List<string>()
            //{
            //    "Toto",
            //    "Optimus",
            //    "Joe"
            //};
            //foreach (string item in formList) {
            //    this.listBox.Items.Add(item);
            //}
        }

        private void FormLists_Load(object sender, EventArgs e)
        {
            RefreshPropertiesText();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPropertiesText();
        }

        private void ButtonAddToList_Click(object sender, EventArgs e)
        {
            if (this.textBoxNewElement.Text.Length > 0)
            {
                this.listBox.Items.Add (this.textBoxNewElement.Text);
                this.listBox.SetSelected(this.listBox.Items.Count - 1, true);
                RefreshPropertiesText();
                this.textBoxNewElement.Text = string.Empty;
            }
        }

        private void ButtonEmptyList_Click(object sender, EventArgs e)
        {
            this.listBox.Items.Clear();
            this.RefreshPropertiesText();
        }

        private void RefreshPropertiesText()
        {
            this.textBoxItemsCount.Text = this.listBox.Items.Count.ToString();
            if (this.listBox.SelectedIndex >= 0)
            {
                this.textBoxSelectedIndex.Text = this.listBox.SelectedIndex.ToString();
                this.textBoxSelectedText.Text = this.listBox.SelectedItem.ToString();
            }
            else
            {
                this.textBoxSelectedIndex.Text = string.Empty;
                this.textBoxSelectedText.Text = "¯\\_(ツ)_/¯";
            }
        }

        private void buttonSelectIndex_Click(object sender, EventArgs e)
        {
            if (this.listBox.Items.Count > 0)
            {
                if (int.TryParse(this.textBoxIndexElement.Text, out int _index)
                        && _index >= 0
                        && _index < this.listBox.Items.Count)
                {
                    this.listBox.SetSelected(_index, true);
                }
                else
                {
                    this.listBox.ClearSelected();
                }
                this.RefreshPropertiesText();
            }

            this.textBoxIndexElement.Text = string.Empty;
        }
    }
}
