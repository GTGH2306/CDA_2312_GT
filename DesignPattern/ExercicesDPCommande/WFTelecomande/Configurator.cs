using CLTelecomande;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WFCLCommands;
using static System.Net.Mime.MediaTypeNames;

namespace WFTelecommande
{
    public partial class Configurator : Form
    {
        private Remote remote;
        private ListBox listBox;
        private ProgressBar progressBar;
        private string lastinput = "";


        public Configurator() : this(new Remote(), new ListBox(), new ProgressBar()) { }

        public Configurator(Remote _remote, ListBox _listbox, ProgressBar _bar)
        {
            InitializeComponent();
            this.remote = _remote;
            this.listBox = _listbox;
            this.progressBar = _bar;

        }

        private void comboBoxReceiver_SelectedValueChanged(object sender, EventArgs e)
        {
            string? selection = this.comboBoxReceiver.SelectedItem?.ToString();
            this.comboBoxFunctions.Items.Clear();
            if (selection != null)
            {
                switch (selection)
                {
                    case "List Box":
                        this.comboBoxFunctions.Items.Add("Ajouter texte");
                        this.comboBoxFunctions.Items.Add("Vider liste");
                        break;
                    case "Progress Bar":
                        this.comboBoxFunctions.Items.Add("Remplir");
                        this.comboBoxFunctions.Items.Add("Vider");
                        this.comboBoxFunctions.Items.Add("Ajouter pourcent");
                        break;
                }
            }
        }

        private void buttonConfigOk_Click(object sender, EventArgs e)
        {
            int button = 0;
            switch (this.comboBoxBtns.SelectedItem?.ToString())
            {
                case "Action 1":
                    button = 1;
                    break;
                case "Action 2":
                    button = 2;
                    break;
                case "Action 3":
                    button = 3;
                    break;
            }


            InputForm dialog;
            if (button > 0)
            {
                switch (this.comboBoxFunctions.SelectedItem?.ToString())
                {
                    case "Ajouter texte":
                        dialog = new InputForm("Saisissez le texte à ajouter:");
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            string? text = dialog.Tag?.ToString();
                            if (text != null && text != string.Empty)
                            {
                                this.remote.SetCommand(button, typeof(CommandAddText), new object[] { this.listBox, text } );
                            }
                        }
                        break;
                    case "Vider liste":
                        this.remote.SetCommand(button, typeof(CommandClearText), new object[] { this.listBox });
                        break;
                    case "Remplir":
                        this.remote.SetCommand(button, typeof(CommandFillBar), new object[] { this.progressBar });
                        break;
                    case "Vider":
                        this.remote.SetCommand(button, typeof(CommandEmptyBar), new object[] { this.progressBar });
                        break;
                    case "Ajouter pourcent":
                        dialog = new InputForm("Saisissez le pourcentage à ajouter:");
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            string? text = dialog.Tag?.ToString();
                            if (text != null && text != string.Empty && int.TryParse(text, out int _result))
                            {
                                this.remote.SetCommand(button, typeof(CommandAddToBar), new object[] { this.progressBar, _result });
                            }
                        }
                        break;
                }
            }

        }
    }
}
