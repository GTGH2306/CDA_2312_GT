namespace WFCombo
{
    partial class FormCombo
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
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxCountries = new System.Windows.Forms.ListBox();
            this.buttonAddAll = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelTarget = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Items.AddRange(new object[] {
            "France",
            "Belgique",
            "Bulgarie",
            "Espagne",
            "Allemagne",
            "Japon",
            "Portugal",
            "Grece"});
            this.comboBoxCountries.Location = new System.Drawing.Point(32, 48);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(128, 21);
            this.comboBoxCountries.TabIndex = 0;
            this.comboBoxCountries.SelectedValueChanged += new System.EventHandler(this.ComboBoxCountries_SelectedValueChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(176, 48);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(48, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = ">";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // listBoxCountries
            // 
            this.listBoxCountries.FormattingEnabled = true;
            this.listBoxCountries.Location = new System.Drawing.Point(240, 48);
            this.listBoxCountries.Name = "listBoxCountries";
            this.listBoxCountries.Size = new System.Drawing.Size(112, 134);
            this.listBoxCountries.TabIndex = 2;
            this.listBoxCountries.SelectedValueChanged += new System.EventHandler(this.ListBoxCountries_SelectedValueChanged);
            // 
            // buttonAddAll
            // 
            this.buttonAddAll.Location = new System.Drawing.Point(176, 80);
            this.buttonAddAll.Name = "buttonAddAll";
            this.buttonAddAll.Size = new System.Drawing.Size(48, 23);
            this.buttonAddAll.TabIndex = 3;
            this.buttonAddAll.Text = ">>";
            this.buttonAddAll.UseVisualStyleBackColor = true;
            this.buttonAddAll.Click += new System.EventHandler(this.ButtonAddAll_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(176, 128);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(48, 23);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "<";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Location = new System.Drawing.Point(176, 160);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(48, 23);
            this.buttonRemoveAll.TabIndex = 5;
            this.buttonRemoveAll.Text = "<<";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.ButtonRemoveAll_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Location = new System.Drawing.Point(256, 192);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(32, 32);
            this.buttonMoveUp.TabIndex = 6;
            this.buttonMoveUp.Text = "↑";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Location = new System.Drawing.Point(304, 192);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(32, 32);
            this.buttonMoveDown.TabIndex = 7;
            this.buttonMoveDown.Text = "↓";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(80, 32);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(41, 13);
            this.labelSource.TabIndex = 8;
            this.labelSource.Text = "Source";
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(272, 32);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(30, 13);
            this.labelTarget.TabIndex = 9;
            this.labelTarget.Text = "Cible";
            // 
            // FormCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 257);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.buttonMoveDown);
            this.Controls.Add(this.buttonMoveUp);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddAll);
            this.Controls.Add(this.listBoxCountries);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxCountries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormCombo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCountries;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxCountries;
        private System.Windows.Forms.Button buttonAddAll;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelTarget;
    }
}

