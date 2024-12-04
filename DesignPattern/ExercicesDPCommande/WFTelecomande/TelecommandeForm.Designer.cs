namespace WFTelecomande
{
    partial class TelecommandeForm
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
            buttonConfig = new Button();
            buttonCancel = new Button();
            buttonActionOne = new Button();
            buttonActionTwo = new Button();
            buttonActionThree = new Button();
            progressBar = new ProgressBar();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // buttonConfig
            // 
            buttonConfig.Location = new Point(16, 32);
            buttonConfig.Name = "buttonConfig";
            buttonConfig.Size = new Size(144, 23);
            buttonConfig.TabIndex = 0;
            buttonConfig.Text = "Configurer";
            buttonConfig.UseVisualStyleBackColor = true;
            buttonConfig.Click += buttonConfig_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(16, 64);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(144, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Annuler";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonActionOne
            // 
            buttonActionOne.Location = new Point(224, 32);
            buttonActionOne.Name = "buttonActionOne";
            buttonActionOne.Size = new Size(80, 23);
            buttonActionOne.TabIndex = 3;
            buttonActionOne.Tag = "1";
            buttonActionOne.Text = "Action 1";
            buttonActionOne.UseVisualStyleBackColor = true;
            buttonActionOne.Click += buttonAction_Click;
            // 
            // buttonActionTwo
            // 
            buttonActionTwo.Location = new Point(224, 64);
            buttonActionTwo.Name = "buttonActionTwo";
            buttonActionTwo.Size = new Size(80, 23);
            buttonActionTwo.TabIndex = 4;
            buttonActionTwo.Tag = "2";
            buttonActionTwo.Text = "Action 2";
            buttonActionTwo.UseVisualStyleBackColor = true;
            buttonActionTwo.Click += buttonAction_Click;
            // 
            // buttonActionThree
            // 
            buttonActionThree.Location = new Point(224, 96);
            buttonActionThree.Name = "buttonActionThree";
            buttonActionThree.Size = new Size(80, 23);
            buttonActionThree.TabIndex = 5;
            buttonActionThree.Tag = "3";
            buttonActionThree.Text = "Action 3";
            buttonActionThree.UseVisualStyleBackColor = true;
            buttonActionThree.Click += buttonAction_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(32, 192);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(256, 23);
            progressBar.TabIndex = 6;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(32, 224);
            listBox.Name = "listBox";
            listBox.Size = new Size(256, 124);
            listBox.TabIndex = 7;
            // 
            // TelecommandeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 370);
            Controls.Add(listBox);
            Controls.Add(progressBar);
            Controls.Add(buttonActionThree);
            Controls.Add(buttonActionTwo);
            Controls.Add(buttonActionOne);
            Controls.Add(buttonCancel);
            Controls.Add(buttonConfig);
            Name = "TelecommandeForm";
            Text = "Telecommande";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonConfig;
        private Button buttonCancel;
        private Button buttonActionOne;
        private Button buttonActionTwo;
        private Button buttonActionThree;
        private ProgressBar progressBar;
        private ListBox listBox;
    }
}