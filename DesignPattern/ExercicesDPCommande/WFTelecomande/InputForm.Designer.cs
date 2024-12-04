namespace WFTelecommande
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelInput = new Label();
            textBoxInput = new TextBox();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(48, 48);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(144, 15);
            labelInput.TabIndex = 0;
            labelInput.Text = "Saisissez le texte à ajouter:";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(48, 80);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(352, 23);
            textBoxInput.TabIndex = 1;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(176, 128);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 2;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 175);
            Controls.Add(buttonOk);
            Controls.Add(textBoxInput);
            Controls.Add(labelInput);
            Name = "InputForm";
            Text = "InputForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInput;
        private TextBox textBoxInput;
        private Button buttonOk;
    }
}