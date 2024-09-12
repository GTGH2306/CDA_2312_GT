namespace WFListes
{
    partial class FormLists
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelLst = new System.Windows.Forms.Label();
            this.labelNewElement = new System.Windows.Forms.Label();
            this.labelIndexElement = new System.Windows.Forms.Label();
            this.labelProperties = new System.Windows.Forms.Label();
            this.textBoxNewElement = new System.Windows.Forms.TextBox();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.textBoxIndexElement = new System.Windows.Forms.TextBox();
            this.buttonSelectIndex = new System.Windows.Forms.Button();
            this.buttonEmptyList = new System.Windows.Forms.Button();
            this.labelItemsCount = new System.Windows.Forms.Label();
            this.labelSelectedIndex = new System.Windows.Forms.Label();
            this.labelSelectedText = new System.Windows.Forms.Label();
            this.textBoxItemsCount = new System.Windows.Forms.TextBox();
            this.textBoxSelectedIndex = new System.Windows.Forms.TextBox();
            this.textBoxSelectedText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(32, 176);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(96, 134);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // labelLst
            // 
            this.labelLst.AutoSize = true;
            this.labelLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLst.Location = new System.Drawing.Point(32, 144);
            this.labelLst.Name = "labelLst";
            this.labelLst.Size = new System.Drawing.Size(51, 13);
            this.labelLst.TabIndex = 1;
            this.labelLst.Text = "LstListe";
            // 
            // labelNewElement
            // 
            this.labelNewElement.AutoSize = true;
            this.labelNewElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewElement.Location = new System.Drawing.Point(32, 32);
            this.labelNewElement.Name = "labelNewElement";
            this.labelNewElement.Size = new System.Drawing.Size(96, 13);
            this.labelNewElement.TabIndex = 2;
            this.labelNewElement.Text = "Nouvel Elément";
            // 
            // labelIndexElement
            // 
            this.labelIndexElement.AutoSize = true;
            this.labelIndexElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndexElement.Location = new System.Drawing.Point(176, 32);
            this.labelIndexElement.Name = "labelIndexElement";
            this.labelIndexElement.Size = new System.Drawing.Size(87, 13);
            this.labelIndexElement.TabIndex = 3;
            this.labelIndexElement.Text = "Index Elément";
            // 
            // labelProperties
            // 
            this.labelProperties.AutoSize = true;
            this.labelProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProperties.Location = new System.Drawing.Point(176, 144);
            this.labelProperties.Name = "labelProperties";
            this.labelProperties.Size = new System.Drawing.Size(64, 13);
            this.labelProperties.TabIndex = 4;
            this.labelProperties.Text = "Propriétés";
            // 
            // textBoxNewElement
            // 
            this.textBoxNewElement.Location = new System.Drawing.Point(32, 64);
            this.textBoxNewElement.Name = "textBoxNewElement";
            this.textBoxNewElement.Size = new System.Drawing.Size(96, 20);
            this.textBoxNewElement.TabIndex = 5;
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.Location = new System.Drawing.Point(32, 96);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(96, 23);
            this.buttonAddToList.TabIndex = 6;
            this.buttonAddToList.Text = "Ajouter Liste";
            this.buttonAddToList.UseVisualStyleBackColor = true;
            this.buttonAddToList.Click += new System.EventHandler(this.ButtonAddToList_Click);
            // 
            // textBoxIndexElement
            // 
            this.textBoxIndexElement.Location = new System.Drawing.Point(176, 64);
            this.textBoxIndexElement.Name = "textBoxIndexElement";
            this.textBoxIndexElement.Size = new System.Drawing.Size(32, 20);
            this.textBoxIndexElement.TabIndex = 7;
            // 
            // buttonSelectIndex
            // 
            this.buttonSelectIndex.Location = new System.Drawing.Point(224, 64);
            this.buttonSelectIndex.Name = "buttonSelectIndex";
            this.buttonSelectIndex.Size = new System.Drawing.Size(112, 23);
            this.buttonSelectIndex.TabIndex = 8;
            this.buttonSelectIndex.Text = "Sélectionner";
            this.buttonSelectIndex.UseVisualStyleBackColor = true;
            this.buttonSelectIndex.Click += new System.EventHandler(this.buttonSelectIndex_Click);
            // 
            // buttonEmptyList
            // 
            this.buttonEmptyList.Location = new System.Drawing.Point(224, 96);
            this.buttonEmptyList.Name = "buttonEmptyList";
            this.buttonEmptyList.Size = new System.Drawing.Size(112, 23);
            this.buttonEmptyList.TabIndex = 9;
            this.buttonEmptyList.Text = "Vider la Liste";
            this.buttonEmptyList.UseVisualStyleBackColor = true;
            this.buttonEmptyList.Click += new System.EventHandler(this.ButtonEmptyList_Click);
            // 
            // labelItemsCount
            // 
            this.labelItemsCount.AutoSize = true;
            this.labelItemsCount.Location = new System.Drawing.Point(176, 176);
            this.labelItemsCount.Name = "labelItemsCount";
            this.labelItemsCount.Size = new System.Drawing.Size(63, 13);
            this.labelItemsCount.TabIndex = 10;
            this.labelItemsCount.Text = "Items.Count";
            // 
            // labelSelectedIndex
            // 
            this.labelSelectedIndex.AutoSize = true;
            this.labelSelectedIndex.Location = new System.Drawing.Point(176, 208);
            this.labelSelectedIndex.Name = "labelSelectedIndex";
            this.labelSelectedIndex.Size = new System.Drawing.Size(75, 13);
            this.labelSelectedIndex.TabIndex = 11;
            this.labelSelectedIndex.Text = "SelectedIndex";
            // 
            // labelSelectedText
            // 
            this.labelSelectedText.AutoSize = true;
            this.labelSelectedText.Location = new System.Drawing.Point(176, 240);
            this.labelSelectedText.Name = "labelSelectedText";
            this.labelSelectedText.Size = new System.Drawing.Size(28, 13);
            this.labelSelectedText.TabIndex = 12;
            this.labelSelectedText.Text = "Text";
            // 
            // textBoxItemsCount
            // 
            this.textBoxItemsCount.Enabled = false;
            this.textBoxItemsCount.Location = new System.Drawing.Point(256, 176);
            this.textBoxItemsCount.Name = "textBoxItemsCount";
            this.textBoxItemsCount.Size = new System.Drawing.Size(32, 20);
            this.textBoxItemsCount.TabIndex = 13;
            // 
            // textBoxSelectedIndex
            // 
            this.textBoxSelectedIndex.Enabled = false;
            this.textBoxSelectedIndex.Location = new System.Drawing.Point(256, 208);
            this.textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            this.textBoxSelectedIndex.Size = new System.Drawing.Size(32, 20);
            this.textBoxSelectedIndex.TabIndex = 14;
            // 
            // textBoxSelectedText
            // 
            this.textBoxSelectedText.Enabled = false;
            this.textBoxSelectedText.Location = new System.Drawing.Point(256, 240);
            this.textBoxSelectedText.Name = "textBoxSelectedText";
            this.textBoxSelectedText.Size = new System.Drawing.Size(96, 20);
            this.textBoxSelectedText.TabIndex = 15;
            // 
            // FormLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 337);
            this.Controls.Add(this.textBoxSelectedText);
            this.Controls.Add(this.textBoxSelectedIndex);
            this.Controls.Add(this.textBoxItemsCount);
            this.Controls.Add(this.labelSelectedText);
            this.Controls.Add(this.labelSelectedIndex);
            this.Controls.Add(this.labelItemsCount);
            this.Controls.Add(this.buttonEmptyList);
            this.Controls.Add(this.buttonSelectIndex);
            this.Controls.Add(this.textBoxIndexElement);
            this.Controls.Add(this.buttonAddToList);
            this.Controls.Add(this.textBoxNewElement);
            this.Controls.Add(this.labelProperties);
            this.Controls.Add(this.labelIndexElement);
            this.Controls.Add(this.labelNewElement);
            this.Controls.Add(this.labelLst);
            this.Controls.Add(this.listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormLists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les listes et leurs propriétés";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormLists_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label labelLst;
        private System.Windows.Forms.Label labelNewElement;
        private System.Windows.Forms.Label labelIndexElement;
        private System.Windows.Forms.Label labelProperties;
        private System.Windows.Forms.TextBox textBoxNewElement;
        private System.Windows.Forms.Button buttonAddToList;
        private System.Windows.Forms.TextBox textBoxIndexElement;
        private System.Windows.Forms.Button buttonSelectIndex;
        private System.Windows.Forms.Button buttonEmptyList;
        private System.Windows.Forms.Label labelItemsCount;
        private System.Windows.Forms.Label labelSelectedIndex;
        private System.Windows.Forms.Label labelSelectedText;
        private System.Windows.Forms.TextBox textBoxItemsCount;
        private System.Windows.Forms.TextBox textBoxSelectedIndex;
        private System.Windows.Forms.TextBox textBoxSelectedText;
    }
}

