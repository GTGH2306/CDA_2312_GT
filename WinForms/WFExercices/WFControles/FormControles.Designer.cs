namespace WFControles
{
    partial class FormControles
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
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelDateFormat = new System.Windows.Forms.Label();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCode = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
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
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(32, 64);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(32, 96);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(46, 13);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Montant";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(32, 128);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(64, 13);
            this.labelCode.TabIndex = 3;
            this.labelCode.Text = "Code Postal";
            // 
            // labelDateFormat
            // 
            this.labelDateFormat.AutoSize = true;
            this.labelDateFormat.Location = new System.Drawing.Point(256, 64);
            this.labelDateFormat.Name = "labelDateFormat";
            this.labelDateFormat.Size = new System.Drawing.Size(79, 13);
            this.labelDateFormat.TabIndex = 8;
            this.labelDateFormat.Text = "(JJ/MM/AAAA)";
            // 
            // buttonValidate
            // 
            this.buttonValidate.Enabled = false;
            this.buttonValidate.Location = new System.Drawing.Point(256, 128);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(75, 23);
            this.buttonValidate.TabIndex = 5;
            this.buttonValidate.Text = "Valider";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.ButtonValidate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(256, 160);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Effacer";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(128, 96);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 3;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.TextBoxAmount_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(128, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(144, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(128, 64);
            this.textBoxDate.Mask = "00/00/0000";
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 2;
            this.textBoxDate.ValidatingType = typeof(System.DateTime);
            this.textBoxDate.TextChanged += new System.EventHandler(this.TextBoxDate_TextChanged);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(128, 128);
            this.textBoxCode.Mask = "00000";
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(64, 20);
            this.textBoxCode.TabIndex = 4;
            this.textBoxCode.TextChanged += new System.EventHandler(this.TextBoxCode_TextChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 194);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.labelDateFormat);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormControles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Controles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormControles_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelDateFormat;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.MaskedTextBox textBoxDate;
        private System.Windows.Forms.MaskedTextBox textBoxCode;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

