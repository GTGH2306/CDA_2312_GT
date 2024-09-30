namespace WFControlLibrary
{
    partial class ProductionTabPage
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxOverallFlawRateProd = new System.Windows.Forms.TextBox();
            this.textBoxLastHourFlawRateProd = new System.Windows.Forms.TextBox();
            this.textBoxNbCratesSinceStartProd = new System.Windows.Forms.TextBox();
            this.labelOverallFlawRateProd = new System.Windows.Forms.Label();
            this.labelLastHourFlawRateProd = new System.Windows.Forms.Label();
            this.labelNbCratesSinceStartProd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxOverallFlawRateProd
            // 
            this.textBoxOverallFlawRateProd.Enabled = false;
            this.textBoxOverallFlawRateProd.Location = new System.Drawing.Point(240, 80);
            this.textBoxOverallFlawRateProd.Name = "textBoxOverallFlawRateProd";
            this.textBoxOverallFlawRateProd.Size = new System.Drawing.Size(100, 20);
            this.textBoxOverallFlawRateProd.TabIndex = 12;
            // 
            // textBoxLastHourFlawRateProd
            // 
            this.textBoxLastHourFlawRateProd.Enabled = false;
            this.textBoxLastHourFlawRateProd.Location = new System.Drawing.Point(240, 48);
            this.textBoxLastHourFlawRateProd.Name = "textBoxLastHourFlawRateProd";
            this.textBoxLastHourFlawRateProd.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastHourFlawRateProd.TabIndex = 11;
            // 
            // textBoxNbCratesSinceStartProd
            // 
            this.textBoxNbCratesSinceStartProd.Enabled = false;
            this.textBoxNbCratesSinceStartProd.Location = new System.Drawing.Point(240, 16);
            this.textBoxNbCratesSinceStartProd.Name = "textBoxNbCratesSinceStartProd";
            this.textBoxNbCratesSinceStartProd.Size = new System.Drawing.Size(100, 20);
            this.textBoxNbCratesSinceStartProd.TabIndex = 10;
            // 
            // labelOverallFlawRateProd
            // 
            this.labelOverallFlawRateProd.AutoSize = true;
            this.labelOverallFlawRateProd.Location = new System.Drawing.Point(16, 80);
            this.labelOverallFlawRateProd.Name = "labelOverallFlawRateProd";
            this.labelOverallFlawRateProd.Size = new System.Drawing.Size(151, 13);
            this.labelOverallFlawRateProd.TabIndex = 9;
            this.labelOverallFlawRateProd.Text = "Taux défaut depuis démarrage";
            // 
            // labelLastHourFlawRateProd
            // 
            this.labelLastHourFlawRateProd.AutoSize = true;
            this.labelLastHourFlawRateProd.Location = new System.Drawing.Point(16, 48);
            this.labelLastHourFlawRateProd.Name = "labelLastHourFlawRateProd";
            this.labelLastHourFlawRateProd.Size = new System.Drawing.Size(94, 13);
            this.labelLastHourFlawRateProd.TabIndex = 8;
            this.labelLastHourFlawRateProd.Text = "Taux défaut heure";
            // 
            // labelNbCratesSinceStartProd
            // 
            this.labelNbCratesSinceStartProd.AutoSize = true;
            this.labelNbCratesSinceStartProd.Location = new System.Drawing.Point(16, 16);
            this.labelNbCratesSinceStartProd.Name = "labelNbCratesSinceStartProd";
            this.labelNbCratesSinceStartProd.Size = new System.Drawing.Size(200, 13);
            this.labelNbCratesSinceStartProd.TabIndex = 7;
            this.labelNbCratesSinceStartProd.Text = "Nombres de caisses depuis le démarrage";
            // 
            // ProductionTabPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.textBoxOverallFlawRateProd);
            this.Controls.Add(this.textBoxLastHourFlawRateProd);
            this.Controls.Add(this.textBoxNbCratesSinceStartProd);
            this.Controls.Add(this.labelOverallFlawRateProd);
            this.Controls.Add(this.labelLastHourFlawRateProd);
            this.Controls.Add(this.labelNbCratesSinceStartProd);
            this.Name = "ProductionTabPage";
            this.Size = new System.Drawing.Size(356, 117);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOverallFlawRateProd;
        private System.Windows.Forms.TextBox textBoxLastHourFlawRateProd;
        private System.Windows.Forms.TextBox textBoxNbCratesSinceStartProd;
        private System.Windows.Forms.Label labelOverallFlawRateProd;
        private System.Windows.Forms.Label labelLastHourFlawRateProd;
        private System.Windows.Forms.Label labelNbCratesSinceStartProd;
    }
}
