using CLMemento;
using System.Runtime.InteropServices.ObjectiveC;
using System.Windows.Forms.VisualStyles;

namespace WFMemento
{
    public partial class FormMemento : Form
    {
        private History history;
        private SaveableText saveableText;
        public FormMemento()
        {
            InitializeComponent();
            this.history = new History();
            this.saveableText = new SaveableText();
            this.history.AddMemento(this.saveableText.Save());
        }
        public void textBox_TextChanged(object _sender, EventArgs _e)
        {
            this.saveableText.CurrentState.Text = this.textBox.Text;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //this.history est le gardien
            //this.saveableTexte est le créateur
            this.history.AddMemento(this.saveableText.Save());
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            this.history.Undo();
            this.textBox.Text = this.saveableText.CurrentState.Text;
        }
    }
}
