using CLTelecomande;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFCLCommands;
using WFTelecommande;

namespace WFTelecomande
{
    public partial class TelecommandeForm : Form
    {
        private Remote remote;
        public TelecommandeForm()
        {
            InitializeComponent();
            this.remote = new Remote();
        }

        private void buttonAction_Click(object _sender, EventArgs e)
        {
            Button sender = (Button)_sender;
            string? btnTxt = sender.Tag?.ToString();
            if (int.TryParse(btnTxt, out int _nb))
            {
                this.remote.ButtonPress(_nb);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.remote.Reverse();
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            new Configurator(this.remote, this.listBox, this.progressBar).ShowDialog();
        }
    }
}
