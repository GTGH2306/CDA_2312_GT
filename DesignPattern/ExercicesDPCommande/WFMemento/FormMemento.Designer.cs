namespace WFMemento
{
    partial class FormMemento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox = new TextBox();
            buttonSave = new Button();
            buttonUndo = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(32, 32);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(240, 128);
            textBox.TabIndex = 0;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(192, 176);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(80, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Sauvegarder";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonUndo
            // 
            buttonUndo.Location = new Point(32, 176);
            buttonUndo.Name = "buttonUndo";
            buttonUndo.Size = new Size(80, 23);
            buttonUndo.TabIndex = 2;
            buttonUndo.Text = "Annuler";
            buttonUndo.UseVisualStyleBackColor = true;
            buttonUndo.Click += buttonUndo_Click;
            // 
            // FormMemento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 232);
            Controls.Add(buttonUndo);
            Controls.Add(buttonSave);
            Controls.Add(textBox);
            Name = "FormMemento";
            Text = "Form Memento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button buttonSave;
        private Button buttonUndo;
    }
}
