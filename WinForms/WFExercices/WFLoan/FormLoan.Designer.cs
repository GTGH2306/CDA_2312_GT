namespace WFLoan
{
    partial class FormLoan
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
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelCapital = new System.Windows.Forms.Label();
            this.textBoxCapital = new System.Windows.Forms.TextBox();
            this.hScrollBarDuration = new System.Windows.Forms.HScrollBar();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelDurationInMonths = new System.Windows.Forms.Label();
            this.labelPeriodicity = new System.Windows.Forms.Label();
            this.listBoxPeriodicity = new System.Windows.Forms.ListBox();
            this.groupBoxInterestRadios = new System.Windows.Forms.GroupBox();
            this.radioButtonNinePercent = new System.Windows.Forms.RadioButton();
            this.radioButtonHeightPercent = new System.Windows.Forms.RadioButton();
            this.radioButtonSevenPercent = new System.Windows.Forms.RadioButton();
            this.labelRepaymentsText = new System.Windows.Forms.Label();
            this.labelRepaymentsAmount = new System.Windows.Forms.Label();
            this.labelRepaymentsSum = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxInterestRadios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(32, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nom";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(128, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Location = new System.Drawing.Point(32, 64);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(87, 13);
            this.labelCapital.TabIndex = 2;
            this.labelCapital.Text = "Capital Emprunté";
            // 
            // textBoxCapital
            // 
            this.textBoxCapital.Location = new System.Drawing.Point(128, 64);
            this.textBoxCapital.Name = "textBoxCapital";
            this.textBoxCapital.Size = new System.Drawing.Size(100, 20);
            this.textBoxCapital.TabIndex = 3;
            this.textBoxCapital.TextChanged += new System.EventHandler(this.TextBoxCapital_TextChanged);
            // 
            // hScrollBarDuration
            // 
            this.hScrollBarDuration.LargeChange = 12;
            this.hScrollBarDuration.Location = new System.Drawing.Point(208, 128);
            this.hScrollBarDuration.Maximum = 191;
            this.hScrollBarDuration.Minimum = 1;
            this.hScrollBarDuration.Name = "hScrollBarDuration";
            this.hScrollBarDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hScrollBarDuration.Size = new System.Drawing.Size(144, 17);
            this.hScrollBarDuration.TabIndex = 4;
            this.hScrollBarDuration.Value = 191;
            this.hScrollBarDuration.ValueChanged += new System.EventHandler(this.HScrollBarDuration_ValueChanged);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(32, 128);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(90, 26);
            this.labelDuration.TabIndex = 5;
            this.labelDuration.Text = "Durée en mois du\r\nremboursement";
            // 
            // labelDurationInMonths
            // 
            this.labelDurationInMonths.AutoSize = true;
            this.labelDurationInMonths.Location = new System.Drawing.Point(144, 128);
            this.labelDurationInMonths.Name = "labelDurationInMonths";
            this.labelDurationInMonths.Size = new System.Drawing.Size(25, 13);
            this.labelDurationInMonths.TabIndex = 6;
            this.labelDurationInMonths.Text = "999";
            // 
            // labelPeriodicity
            // 
            this.labelPeriodicity.AutoSize = true;
            this.labelPeriodicity.Location = new System.Drawing.Point(32, 208);
            this.labelPeriodicity.Name = "labelPeriodicity";
            this.labelPeriodicity.Size = new System.Drawing.Size(146, 13);
            this.labelPeriodicity.TabIndex = 7;
            this.labelPeriodicity.Text = "Périodicité de remboursement";
            // 
            // listBoxPeriodicity
            // 
            this.listBoxPeriodicity.FormattingEnabled = true;
            this.listBoxPeriodicity.Location = new System.Drawing.Point(32, 224);
            this.listBoxPeriodicity.Name = "listBoxPeriodicity";
            this.listBoxPeriodicity.Size = new System.Drawing.Size(224, 69);
            this.listBoxPeriodicity.TabIndex = 8;
            this.listBoxPeriodicity.SelectedValueChanged += new System.EventHandler(this.ListBoxPeriodicity_SelectedValueChanged);
            // 
            // groupBoxInterestRadios
            // 
            this.groupBoxInterestRadios.Controls.Add(this.radioButtonNinePercent);
            this.groupBoxInterestRadios.Controls.Add(this.radioButtonHeightPercent);
            this.groupBoxInterestRadios.Controls.Add(this.radioButtonSevenPercent);
            this.groupBoxInterestRadios.Location = new System.Drawing.Point(400, 32);
            this.groupBoxInterestRadios.Name = "groupBoxInterestRadios";
            this.groupBoxInterestRadios.Size = new System.Drawing.Size(96, 112);
            this.groupBoxInterestRadios.TabIndex = 9;
            this.groupBoxInterestRadios.TabStop = false;
            this.groupBoxInterestRadios.Text = "Taux d\'intérêt";
            // 
            // radioButtonNinePercent
            // 
            this.radioButtonNinePercent.AutoSize = true;
            this.radioButtonNinePercent.Location = new System.Drawing.Point(32, 80);
            this.radioButtonNinePercent.Name = "radioButtonNinePercent";
            this.radioButtonNinePercent.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNinePercent.TabIndex = 2;
            this.radioButtonNinePercent.TabStop = true;
            this.radioButtonNinePercent.Tag = "9";
            this.radioButtonNinePercent.Text = "9%";
            this.radioButtonNinePercent.UseVisualStyleBackColor = true;
            this.radioButtonNinePercent.Click += new System.EventHandler(this.RadioButtonInterestPercent_EnabledChanged);
            // 
            // radioButtonHeightPercent
            // 
            this.radioButtonHeightPercent.AutoSize = true;
            this.radioButtonHeightPercent.Location = new System.Drawing.Point(32, 48);
            this.radioButtonHeightPercent.Name = "radioButtonHeightPercent";
            this.radioButtonHeightPercent.Size = new System.Drawing.Size(39, 17);
            this.radioButtonHeightPercent.TabIndex = 1;
            this.radioButtonHeightPercent.TabStop = true;
            this.radioButtonHeightPercent.Tag = "8";
            this.radioButtonHeightPercent.Text = "8%";
            this.radioButtonHeightPercent.UseVisualStyleBackColor = true;
            this.radioButtonHeightPercent.Click += new System.EventHandler(this.RadioButtonInterestPercent_EnabledChanged);
            // 
            // radioButtonSevenPercent
            // 
            this.radioButtonSevenPercent.AutoSize = true;
            this.radioButtonSevenPercent.Location = new System.Drawing.Point(32, 16);
            this.radioButtonSevenPercent.Name = "radioButtonSevenPercent";
            this.radioButtonSevenPercent.Size = new System.Drawing.Size(39, 17);
            this.radioButtonSevenPercent.TabIndex = 0;
            this.radioButtonSevenPercent.TabStop = true;
            this.radioButtonSevenPercent.Tag = "7";
            this.radioButtonSevenPercent.Text = "7%";
            this.radioButtonSevenPercent.UseVisualStyleBackColor = true;
            this.radioButtonSevenPercent.Click += new System.EventHandler(this.RadioButtonInterestPercent_EnabledChanged);
            // 
            // labelRepaymentsText
            // 
            this.labelRepaymentsText.AutoSize = true;
            this.labelRepaymentsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepaymentsText.Location = new System.Drawing.Point(400, 208);
            this.labelRepaymentsText.Name = "labelRepaymentsText";
            this.labelRepaymentsText.Size = new System.Drawing.Size(103, 13);
            this.labelRepaymentsText.TabIndex = 10;
            this.labelRepaymentsText.Text = "Remboursements";
            // 
            // labelRepaymentsAmount
            // 
            this.labelRepaymentsAmount.AutoSize = true;
            this.labelRepaymentsAmount.ForeColor = System.Drawing.Color.Red;
            this.labelRepaymentsAmount.Location = new System.Drawing.Point(352, 208);
            this.labelRepaymentsAmount.Name = "labelRepaymentsAmount";
            this.labelRepaymentsAmount.Size = new System.Drawing.Size(19, 13);
            this.labelRepaymentsAmount.TabIndex = 11;
            this.labelRepaymentsAmount.Text = "99";
            // 
            // labelRepaymentsSum
            // 
            this.labelRepaymentsSum.AutoSize = true;
            this.labelRepaymentsSum.ForeColor = System.Drawing.Color.Red;
            this.labelRepaymentsSum.Location = new System.Drawing.Point(400, 240);
            this.labelRepaymentsSum.Name = "labelRepaymentsSum";
            this.labelRepaymentsSum.Size = new System.Drawing.Size(79, 13);
            this.labelRepaymentsSum.TabIndex = 12;
            this.labelRepaymentsSum.Text = "1 234 567,89 €";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(352, 272);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Sauvegarder";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(448, 304);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(80, 23);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "Fermer";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(448, 272);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 23);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Effacer";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // FormLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 354);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelRepaymentsSum);
            this.Controls.Add(this.labelRepaymentsAmount);
            this.Controls.Add(this.labelRepaymentsText);
            this.Controls.Add(this.groupBoxInterestRadios);
            this.Controls.Add(this.listBoxPeriodicity);
            this.Controls.Add(this.labelPeriodicity);
            this.Controls.Add(this.labelDurationInMonths);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.hScrollBarDuration);
            this.Controls.Add(this.textBoxCapital);
            this.Controls.Add(this.labelCapital);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprunts";
            this.groupBoxInterestRadios.ResumeLayout(false);
            this.groupBoxInterestRadios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelCapital;
        private System.Windows.Forms.TextBox textBoxCapital;
        private System.Windows.Forms.HScrollBar hScrollBarDuration;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelDurationInMonths;
        private System.Windows.Forms.Label labelPeriodicity;
        private System.Windows.Forms.ListBox listBoxPeriodicity;
        private System.Windows.Forms.GroupBox groupBoxInterestRadios;
        private System.Windows.Forms.RadioButton radioButtonNinePercent;
        private System.Windows.Forms.RadioButton radioButtonHeightPercent;
        private System.Windows.Forms.RadioButton radioButtonSevenPercent;
        private System.Windows.Forms.Label labelRepaymentsText;
        private System.Windows.Forms.Label labelRepaymentsAmount;
        private System.Windows.Forms.Label labelRepaymentsSum;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button buttonDelete;
    }
}

