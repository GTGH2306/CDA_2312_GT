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
using WFAdditionneur;
using WFCombo;
using WFControles;
using WFDefilement;
using WFLoan;
using WFRadioCheck;

namespace WFMenus
{
    public partial class FormMenus : Form
    {
        private List<int> adderNb;
        public FormMenus()
        {
            InitializeComponent();
            this.timer_Tick(null, null);
            this.toolStripStatusLabelLastOperation.Text = string.Empty;
            List<ToolStripMenuItem> menuItems = this.menuStrip.Items.OfType<ToolStripMenuItem>().ToList();
            foreach (ToolStripMenuItem item in menuItems)
            {
                item.Click += control_Click;
                foreach (ToolStripItem child in item.DropDownItems)
                {
                    child.Click += control_Click;
                }
            }
            List<ToolStripItem> toolStripItems = this.toolStrip.Items.OfType<ToolStripItem>().ToList();
            foreach(ToolStripButton button in this.toolStrip.Items.OfType<ToolStripButton>().ToList())
            {
                button.Click += control_Click;
            }
            foreach(ToolStripSplitButton splitButton in this.toolStrip.Items.OfType<ToolStripSplitButton>().ToList())
            {
                splitButton.Click += control_Click;
                foreach (ToolStripItem child in splitButton.DropDownItems)
                {
                    child.Click += control_Click;
                }
            }
            this.adderNb = new List<int>();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir quitter?", "Fermeture",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool loginSuccess;
            FormLogin loginForm = new FormLogin();
            DialogResult loginResult = loginForm.ShowDialog();
            if (loginResult == DialogResult.OK)
            {
                loginSuccess = loginForm.InputLogin == loginForm.InputPassword;
                this.phase1ToolStripMenuItem.Enabled = loginSuccess;
                this.phase2ToolStripMenuItem.Enabled = loginSuccess;
                this.phase3ToolStripMenuItem.Enabled = loginSuccess;
                this.toolStripSplitButtonPhase3.Enabled = loginSuccess;
                this.windowsToolStripMenuItem.Enabled = loginSuccess;
            }
        }

        private void additionneurToolStripMenuItem_Click(object _sender, EventArgs e)
        {
            AdditionneurForm form = new AdditionneurForm();
            int formNb = GetAvailableAdderNb();
            form.Tag = formNb;
            form.Text = "Additionneur N°" + formNb;
            form.FormClosed += new FormClosedEventHandler(FreeAdderNb_OnClose);
            form.MdiParent = this;
            form.Show();
        }

        private void contrôlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControles form = new FormControles();
            
            form.MdiParent = this;
            form.Show();
        }

        private void casesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadioCheckForm form = new RadioCheckForm();
            form.MdiParent = this;
            form.Show();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCombo form = new FormCombo();
            form.MdiParent = this;
            form.Show();
        }

        private void defilementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDefilement form = new FormDefilement();
            form.MdiParent = this;
            form.Show();
        }

        private void syntheseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoan form = new FormLoan(FormLoan.LoadLoan());
            form.MdiParent = this;
            form.Show();
        }
        private void control_Click(object _sender, EventArgs e)
        {
            ToolStripItem sender = (ToolStripItem)_sender;
            if (sender.Enabled)
            {
                this.toolStripStatusLabelLastOperation.Text = sender.Text;
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void saisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInput inputForm = new FormInput();
            inputForm.MdiParent = this;
            inputForm.Show();
            inputForm.FormClosed += new FormClosedEventHandler(OpenRadioForm_OnClose);
        }

        private int GetAvailableAdderNb()
        {
            int possibleNumber = 1;
            if (this.adderNb.Count > 0)
            {
                while (adderNb.Contains(possibleNumber))
                {
                    possibleNumber++;
                }
            }
            this.adderNb.Add(possibleNumber);
            return possibleNumber;
        }
        private void FreeAdderNb_OnClose(object sender, EventArgs e)
        {
            Form form = (Form)sender;
            int nbToFree = int.Parse(form.Tag.ToString());
            this.adderNb.Remove(nbToFree);
        }
        private void OpenRadioForm_OnClose(object _sender, EventArgs e)
        {
            FormInput formInput = (FormInput)_sender;
            RadioCheckForm radioForm = new RadioCheckForm(formInput.UserInput);
            radioForm.MdiParent = formInput.MdiParent;
            radioForm.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabelDate.Text = DateTime.Now.ToString();
        }
    }
}
