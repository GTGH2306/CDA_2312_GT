namespace WFTelecommande
{
    partial class Configurator
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
            comboBoxBtns = new ComboBox();
            labelBtns = new Label();
            labelReceiver = new Label();
            comboBoxReceiver = new ComboBox();
            labelFnct = new Label();
            comboBoxFunctions = new ComboBox();
            buttonConfigOk = new Button();
            SuspendLayout();
            // 
            // comboBoxBtns
            // 
            comboBoxBtns.FormattingEnabled = true;
            comboBoxBtns.Items.AddRange(new object[] { "Action 1", "Action 2", "Action 3" });
            comboBoxBtns.Location = new Point(128, 32);
            comboBoxBtns.Name = "comboBoxBtns";
            comboBoxBtns.Size = new Size(144, 23);
            comboBoxBtns.TabIndex = 0;
            // 
            // labelBtns
            // 
            labelBtns.AutoSize = true;
            labelBtns.Location = new Point(32, 32);
            labelBtns.Name = "labelBtns";
            labelBtns.Size = new Size(49, 15);
            labelBtns.TabIndex = 1;
            labelBtns.Text = "Bouton:";
            // 
            // labelReceiver
            // 
            labelReceiver.AutoSize = true;
            labelReceiver.Location = new Point(32, 64);
            labelReceiver.Name = "labelReceiver";
            labelReceiver.Size = new Size(63, 15);
            labelReceiver.TabIndex = 3;
            labelReceiver.Text = "Recepteur:";
            // 
            // comboBoxReceiver
            // 
            comboBoxReceiver.FormattingEnabled = true;
            comboBoxReceiver.Items.AddRange(new object[] { "List Box", "Progress Bar" });
            comboBoxReceiver.Location = new Point(128, 64);
            comboBoxReceiver.Name = "comboBoxReceiver";
            comboBoxReceiver.Size = new Size(144, 23);
            comboBoxReceiver.TabIndex = 2;
            comboBoxReceiver.SelectedValueChanged += comboBoxReceiver_SelectedValueChanged;
            // 
            // labelFnct
            // 
            labelFnct.AutoSize = true;
            labelFnct.Location = new Point(32, 96);
            labelFnct.Name = "labelFnct";
            labelFnct.Size = new Size(57, 15);
            labelFnct.TabIndex = 5;
            labelFnct.Text = "Fonction:";
            // 
            // comboBoxFunctions
            // 
            comboBoxFunctions.FormattingEnabled = true;
            comboBoxFunctions.Location = new Point(128, 96);
            comboBoxFunctions.Name = "comboBoxFunctions";
            comboBoxFunctions.Size = new Size(144, 23);
            comboBoxFunctions.TabIndex = 4;
            // 
            // buttonConfigOk
            // 
            buttonConfigOk.Location = new Point(128, 160);
            buttonConfigOk.Name = "buttonConfigOk";
            buttonConfigOk.Size = new Size(75, 23);
            buttonConfigOk.TabIndex = 6;
            buttonConfigOk.Text = "Configurer";
            buttonConfigOk.UseVisualStyleBackColor = true;
            buttonConfigOk.Click += buttonConfigOk_Click;
            // 
            // Configurator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 215);
            Controls.Add(buttonConfigOk);
            Controls.Add(labelFnct);
            Controls.Add(comboBoxFunctions);
            Controls.Add(labelReceiver);
            Controls.Add(comboBoxReceiver);
            Controls.Add(labelBtns);
            Controls.Add(comboBoxBtns);
            Name = "Configurator";
            Text = "Configurator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxBtns;
        private Label labelBtns;
        private Label labelReceiver;
        private ComboBox comboBoxReceiver;
        private Label labelFnct;
        private ComboBox comboBoxFunctions;
        private Button buttonConfigOk;
    }
}