namespace WFRadioCheck
{
    partial class RadioCheckForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEnterText = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.groupBoxChoice = new System.Windows.Forms.GroupBox();
            this.checkBoxCase = new System.Windows.Forms.CheckBox();
            this.checkBoxFontColor = new System.Windows.Forms.CheckBox();
            this.checkBoxFontBgColor = new System.Windows.Forms.CheckBox();
            this.groupBoxFontBgClr = new System.Windows.Forms.GroupBox();
            this.radioButtonBgClrBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonBgClrGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonBgClrRed = new System.Windows.Forms.RadioButton();
            this.groupBoxFontClr = new System.Windows.Forms.GroupBox();
            this.radioButtonFontClrBlack = new System.Windows.Forms.RadioButton();
            this.radioButtonFontClrWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonFontClrRed = new System.Windows.Forms.RadioButton();
            this.groupBoxFontCase = new System.Windows.Forms.GroupBox();
            this.radioButtonUpperCase = new System.Windows.Forms.RadioButton();
            this.radioButtonLowerCase = new System.Windows.Forms.RadioButton();
            this.labelEnteredText = new System.Windows.Forms.Label();
            this.groupBoxChoice.SuspendLayout();
            this.groupBoxFontBgClr.SuspendLayout();
            this.groupBoxFontClr.SuspendLayout();
            this.groupBoxFontCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEnterText
            // 
            this.labelEnterText.AutoSize = true;
            this.labelEnterText.Location = new System.Drawing.Point(32, 32);
            this.labelEnterText.Name = "labelEnterText";
            this.labelEnterText.Size = new System.Drawing.Size(90, 13);
            this.labelEnterText.TabIndex = 0;
            this.labelEnterText.Text = "Tapez votre texte";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(32, 48);
            this.textBoxInput.MaxLength = 20;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(160, 20);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            // 
            // groupBoxChoice
            // 
            this.groupBoxChoice.Controls.Add(this.checkBoxCase);
            this.groupBoxChoice.Controls.Add(this.checkBoxFontColor);
            this.groupBoxChoice.Controls.Add(this.checkBoxFontBgColor);
            this.groupBoxChoice.Enabled = false;
            this.groupBoxChoice.Location = new System.Drawing.Point(288, 32);
            this.groupBoxChoice.Name = "groupBoxChoice";
            this.groupBoxChoice.Size = new System.Drawing.Size(192, 112);
            this.groupBoxChoice.TabIndex = 2;
            this.groupBoxChoice.TabStop = false;
            this.groupBoxChoice.Text = "Choix";
            // 
            // checkBoxCase
            // 
            this.checkBoxCase.AutoSize = true;
            this.checkBoxCase.Location = new System.Drawing.Point(16, 80);
            this.checkBoxCase.Name = "checkBoxCase";
            this.checkBoxCase.Size = new System.Drawing.Size(55, 17);
            this.checkBoxCase.TabIndex = 2;
            this.checkBoxCase.Text = "Casse";
            this.checkBoxCase.UseVisualStyleBackColor = true;
            this.checkBoxCase.CheckedChanged += new System.EventHandler(this.CheckBoxCase_CheckedChanged);
            // 
            // checkBoxFontColor
            // 
            this.checkBoxFontColor.AutoSize = true;
            this.checkBoxFontColor.Location = new System.Drawing.Point(16, 48);
            this.checkBoxFontColor.Name = "checkBoxFontColor";
            this.checkBoxFontColor.Size = new System.Drawing.Size(135, 17);
            this.checkBoxFontColor.TabIndex = 1;
            this.checkBoxFontColor.Text = "Couleur des caractères";
            this.checkBoxFontColor.UseVisualStyleBackColor = true;
            this.checkBoxFontColor.CheckedChanged += new System.EventHandler(this.CheckBoxFontColor_CheckedChanged);
            // 
            // checkBoxFontBgColor
            // 
            this.checkBoxFontBgColor.AutoSize = true;
            this.checkBoxFontBgColor.Location = new System.Drawing.Point(16, 16);
            this.checkBoxFontBgColor.Name = "checkBoxFontBgColor";
            this.checkBoxFontBgColor.Size = new System.Drawing.Size(101, 17);
            this.checkBoxFontBgColor.TabIndex = 0;
            this.checkBoxFontBgColor.Text = "Couleur du fond";
            this.checkBoxFontBgColor.UseVisualStyleBackColor = true;
            this.checkBoxFontBgColor.CheckedChanged += new System.EventHandler(this.CheckBoxFontBgColor_CheckedChanged);
            // 
            // groupBoxFontBgClr
            // 
            this.groupBoxFontBgClr.Controls.Add(this.radioButtonBgClrBlue);
            this.groupBoxFontBgClr.Controls.Add(this.radioButtonBgClrGreen);
            this.groupBoxFontBgClr.Controls.Add(this.radioButtonBgClrRed);
            this.groupBoxFontBgClr.Location = new System.Drawing.Point(32, 128);
            this.groupBoxFontBgClr.Name = "groupBoxFontBgClr";
            this.groupBoxFontBgClr.Size = new System.Drawing.Size(96, 112);
            this.groupBoxFontBgClr.TabIndex = 3;
            this.groupBoxFontBgClr.TabStop = false;
            this.groupBoxFontBgClr.Text = "Fond";
            this.groupBoxFontBgClr.Visible = false;
            // 
            // radioButtonBgClrBlue
            // 
            this.radioButtonBgClrBlue.AutoSize = true;
            this.radioButtonBgClrBlue.Location = new System.Drawing.Point(16, 80);
            this.radioButtonBgClrBlue.Name = "radioButtonBgClrBlue";
            this.radioButtonBgClrBlue.Size = new System.Drawing.Size(46, 17);
            this.radioButtonBgClrBlue.TabIndex = 2;
            this.radioButtonBgClrBlue.TabStop = true;
            this.radioButtonBgClrBlue.Tag = "Blue";
            this.radioButtonBgClrBlue.Text = "Bleu";
            this.radioButtonBgClrBlue.UseVisualStyleBackColor = true;
            this.radioButtonBgClrBlue.CheckedChanged += new System.EventHandler(this.FontBgToSelectedClr_CheckedChanged);
            // 
            // radioButtonBgClrGreen
            // 
            this.radioButtonBgClrGreen.AutoSize = true;
            this.radioButtonBgClrGreen.Location = new System.Drawing.Point(16, 48);
            this.radioButtonBgClrGreen.Name = "radioButtonBgClrGreen";
            this.radioButtonBgClrGreen.Size = new System.Drawing.Size(44, 17);
            this.radioButtonBgClrGreen.TabIndex = 1;
            this.radioButtonBgClrGreen.TabStop = true;
            this.radioButtonBgClrGreen.Tag = "Green";
            this.radioButtonBgClrGreen.Text = "Vert";
            this.radioButtonBgClrGreen.UseVisualStyleBackColor = true;
            this.radioButtonBgClrGreen.CheckedChanged += new System.EventHandler(this.FontBgToSelectedClr_CheckedChanged);
            // 
            // radioButtonBgClrRed
            // 
            this.radioButtonBgClrRed.AutoSize = true;
            this.radioButtonBgClrRed.Location = new System.Drawing.Point(16, 16);
            this.radioButtonBgClrRed.Name = "radioButtonBgClrRed";
            this.radioButtonBgClrRed.Size = new System.Drawing.Size(57, 17);
            this.radioButtonBgClrRed.TabIndex = 0;
            this.radioButtonBgClrRed.TabStop = true;
            this.radioButtonBgClrRed.Tag = "Red";
            this.radioButtonBgClrRed.Text = "Rouge";
            this.radioButtonBgClrRed.UseVisualStyleBackColor = true;
            this.radioButtonBgClrRed.CheckedChanged += new System.EventHandler(this.FontBgToSelectedClr_CheckedChanged);
            // 
            // groupBoxFontClr
            // 
            this.groupBoxFontClr.Controls.Add(this.radioButtonFontClrBlack);
            this.groupBoxFontClr.Controls.Add(this.radioButtonFontClrWhite);
            this.groupBoxFontClr.Controls.Add(this.radioButtonFontClrRed);
            this.groupBoxFontClr.Location = new System.Drawing.Point(160, 128);
            this.groupBoxFontClr.Name = "groupBoxFontClr";
            this.groupBoxFontClr.Size = new System.Drawing.Size(96, 112);
            this.groupBoxFontClr.TabIndex = 4;
            this.groupBoxFontClr.TabStop = false;
            this.groupBoxFontClr.Text = "Caractères";
            this.groupBoxFontClr.Visible = false;
            // 
            // radioButtonFontClrBlack
            // 
            this.radioButtonFontClrBlack.AutoSize = true;
            this.radioButtonFontClrBlack.Location = new System.Drawing.Point(16, 80);
            this.radioButtonFontClrBlack.Name = "radioButtonFontClrBlack";
            this.radioButtonFontClrBlack.Size = new System.Drawing.Size(44, 17);
            this.radioButtonFontClrBlack.TabIndex = 2;
            this.radioButtonFontClrBlack.TabStop = true;
            this.radioButtonFontClrBlack.Tag = "Black";
            this.radioButtonFontClrBlack.Text = "Noir";
            this.radioButtonFontClrBlack.UseVisualStyleBackColor = true;
            this.radioButtonFontClrBlack.CheckedChanged += new System.EventHandler(this.FontClrToSelectedClr_CheckedChanged);
            // 
            // radioButtonFontClrWhite
            // 
            this.radioButtonFontClrWhite.AutoSize = true;
            this.radioButtonFontClrWhite.Location = new System.Drawing.Point(16, 48);
            this.radioButtonFontClrWhite.Name = "radioButtonFontClrWhite";
            this.radioButtonFontClrWhite.Size = new System.Drawing.Size(52, 17);
            this.radioButtonFontClrWhite.TabIndex = 1;
            this.radioButtonFontClrWhite.TabStop = true;
            this.radioButtonFontClrWhite.Tag = "White";
            this.radioButtonFontClrWhite.Text = "Blanc";
            this.radioButtonFontClrWhite.UseVisualStyleBackColor = true;
            this.radioButtonFontClrWhite.CheckedChanged += new System.EventHandler(this.FontClrToSelectedClr_CheckedChanged);
            // 
            // radioButtonFontClrRed
            // 
            this.radioButtonFontClrRed.AutoSize = true;
            this.radioButtonFontClrRed.Location = new System.Drawing.Point(16, 16);
            this.radioButtonFontClrRed.Name = "radioButtonFontClrRed";
            this.radioButtonFontClrRed.Size = new System.Drawing.Size(57, 17);
            this.radioButtonFontClrRed.TabIndex = 0;
            this.radioButtonFontClrRed.TabStop = true;
            this.radioButtonFontClrRed.Tag = "Red";
            this.radioButtonFontClrRed.Text = "Rouge";
            this.radioButtonFontClrRed.UseVisualStyleBackColor = true;
            this.radioButtonFontClrRed.CheckedChanged += new System.EventHandler(this.FontClrToSelectedClr_CheckedChanged);
            // 
            // groupBoxFontCase
            // 
            this.groupBoxFontCase.Controls.Add(this.radioButtonUpperCase);
            this.groupBoxFontCase.Controls.Add(this.radioButtonLowerCase);
            this.groupBoxFontCase.Location = new System.Drawing.Point(288, 160);
            this.groupBoxFontCase.Name = "groupBoxFontCase";
            this.groupBoxFontCase.Size = new System.Drawing.Size(192, 80);
            this.groupBoxFontCase.TabIndex = 5;
            this.groupBoxFontCase.TabStop = false;
            this.groupBoxFontCase.Text = "Casse";
            this.groupBoxFontCase.Visible = false;
            // 
            // radioButtonUpperCase
            // 
            this.radioButtonUpperCase.AutoSize = true;
            this.radioButtonUpperCase.Location = new System.Drawing.Point(16, 48);
            this.radioButtonUpperCase.Name = "radioButtonUpperCase";
            this.radioButtonUpperCase.Size = new System.Drawing.Size(78, 17);
            this.radioButtonUpperCase.TabIndex = 1;
            this.radioButtonUpperCase.TabStop = true;
            this.radioButtonUpperCase.Text = "Majuscules";
            this.radioButtonUpperCase.UseVisualStyleBackColor = true;
            this.radioButtonUpperCase.CheckedChanged += new System.EventHandler(this.AdjustLabelCase_CheckedChanged);
            // 
            // radioButtonLowerCase
            // 
            this.radioButtonLowerCase.AutoSize = true;
            this.radioButtonLowerCase.Location = new System.Drawing.Point(16, 16);
            this.radioButtonLowerCase.Name = "radioButtonLowerCase";
            this.radioButtonLowerCase.Size = new System.Drawing.Size(78, 17);
            this.radioButtonLowerCase.TabIndex = 0;
            this.radioButtonLowerCase.TabStop = true;
            this.radioButtonLowerCase.Text = "Minuscules";
            this.radioButtonLowerCase.UseVisualStyleBackColor = true;
            this.radioButtonLowerCase.CheckedChanged += new System.EventHandler(this.AdjustLabelCase_CheckedChanged);
            // 
            // labelEnteredText
            // 
            this.labelEnteredText.AutoSize = true;
            this.labelEnteredText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnteredText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelEnteredText.Location = new System.Drawing.Point(32, 80);
            this.labelEnteredText.Name = "labelEnteredText";
            this.labelEnteredText.Size = new System.Drawing.Size(92, 20);
            this.labelEnteredText.TabIndex = 6;
            this.labelEnteredText.Tag = "";
            this.labelEnteredText.Text = "Placeholder";
            // 
            // RadioCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 276);
            this.Controls.Add(this.labelEnteredText);
            this.Controls.Add(this.groupBoxFontCase);
            this.Controls.Add(this.groupBoxFontClr);
            this.Controls.Add(this.groupBoxFontBgClr);
            this.Controls.Add(this.groupBoxChoice);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelEnterText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "RadioCheckForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChackBox et RadioButton";
            this.groupBoxChoice.ResumeLayout(false);
            this.groupBoxChoice.PerformLayout();
            this.groupBoxFontBgClr.ResumeLayout(false);
            this.groupBoxFontBgClr.PerformLayout();
            this.groupBoxFontClr.ResumeLayout(false);
            this.groupBoxFontClr.PerformLayout();
            this.groupBoxFontCase.ResumeLayout(false);
            this.groupBoxFontCase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterText;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.GroupBox groupBoxChoice;
        private System.Windows.Forms.CheckBox checkBoxFontBgColor;
        private System.Windows.Forms.CheckBox checkBoxCase;
        private System.Windows.Forms.CheckBox checkBoxFontColor;
        private System.Windows.Forms.GroupBox groupBoxFontBgClr;
        private System.Windows.Forms.GroupBox groupBoxFontClr;
        private System.Windows.Forms.GroupBox groupBoxFontCase;
        private System.Windows.Forms.RadioButton radioButtonBgClrBlue;
        private System.Windows.Forms.RadioButton radioButtonBgClrGreen;
        private System.Windows.Forms.RadioButton radioButtonBgClrRed;
        private System.Windows.Forms.RadioButton radioButtonFontClrBlack;
        private System.Windows.Forms.RadioButton radioButtonFontClrWhite;
        private System.Windows.Forms.RadioButton radioButtonFontClrRed;
        private System.Windows.Forms.RadioButton radioButtonUpperCase;
        private System.Windows.Forms.RadioButton radioButtonLowerCase;
        private System.Windows.Forms.Label labelEnteredText;
    }
}

