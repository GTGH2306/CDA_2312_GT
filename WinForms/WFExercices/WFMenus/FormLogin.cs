using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFMenus
{
    public partial class FormLogin : Form
    {
        public string InputLogin { get; private set; }
        public string InputPassword { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            this.InputLogin = this.textBoxLogin.Text;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            this.InputPassword = this.textBoxPassword.Text;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
