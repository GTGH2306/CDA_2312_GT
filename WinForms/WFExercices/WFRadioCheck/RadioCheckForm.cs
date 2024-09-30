using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFRadioCheck
{
    public partial class RadioCheckForm : Form
    {
        public RadioCheckForm(): this(string.Empty) {}

        public RadioCheckForm(string startingString)
        {
            InitializeComponent();
            this.textBoxInput.Text = startingString;
            this.labelEnteredText.Text = startingString;
        }

        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
            AdjustLabelCase_CheckedChanged(sender, e);
            if (this.textBoxInput.Text.Length > 0)
            {
                this.groupBoxChoice.Enabled = true;
            } else
            {
                this.groupBoxChoice.Enabled = false;
            }
        }

        private void CheckBoxFontBgColor_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxFontBgClr.Visible = this.checkBoxFontBgColor.Checked;
            FontBgToSelectedClr_CheckedChanged(sender, e);
        }
        private void CheckBoxFontColor_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxFontClr.Visible = this.checkBoxFontColor.Checked;
            FontClrToSelectedClr_CheckedChanged(sender, e);
        }
        private void CheckBoxCase_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxFontCase.Visible = this.checkBoxCase.Checked;
            AdjustLabelCase_CheckedChanged(sender, e);
        }
        private void FontBgToSelectedClr_CheckedChanged(object sender, EventArgs e)
        {
            if (this.groupBoxFontBgClr.Visible)
            {
                foreach (RadioButton _rad in this.groupBoxFontBgClr.Controls)
                {
                    if (_rad.Checked)
                    {
                        this.labelEnteredText.BackColor = Color.FromName((string)_rad.Tag);
                    }
                }
            } else
            {
                this.labelEnteredText.BackColor = DefaultBackColor;
            }
        }

        private void FontClrToSelectedClr_CheckedChanged(object sender, EventArgs e)
        {
            if (this.groupBoxFontClr.Visible)
            {
                foreach (RadioButton _rad in this.groupBoxFontClr.Controls)
                {
                    if (_rad.Checked)
                    {
                        this.labelEnteredText.ForeColor = Color.FromName((string)_rad.Tag);
                    }
                }
            }
            else
            {
                this.labelEnteredText.ForeColor = DefaultForeColor;
            }
        }
        private void AdjustLabelCase_CheckedChanged(object sender, EventArgs e)
        {
            if (this.groupBoxFontCase.Visible)
            {
                if (this.radioButtonLowerCase.Checked)
                {
                    this.labelEnteredText.Text = this.textBoxInput.Text.ToLower();
                } else if (this.radioButtonUpperCase.Checked)
                {
                    this.labelEnteredText.Text = this.textBoxInput.Text.ToUpper();
                }
            } else
            {
                this.labelEnteredText.Text = this.textBoxInput.Text;
            }
        }
    }
}
