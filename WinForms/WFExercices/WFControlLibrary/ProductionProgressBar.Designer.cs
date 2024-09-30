namespace WFControlLibrary
{
    partial class ProductionProgressBar
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
            this.labelProd = new System.Windows.Forms.Label();
            this.progressBarProd = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProd.Location = new System.Drawing.Point(0, 0);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(101, 20);
            this.labelProd.TabIndex = 2;
            this.labelProd.Text = "Production O";
            // 
            // progressBarProd
            // 
            this.progressBarProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarProd.Location = new System.Drawing.Point(128, 0);
            this.progressBarProd.Name = "progressBarProd";
            this.progressBarProd.Size = new System.Drawing.Size(336, 23);
            this.progressBarProd.TabIndex = 3;
            // 
            // ProductionProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBarProd);
            this.Controls.Add(this.labelProd);
            this.Name = "ProductionProgressBar";
            this.Size = new System.Drawing.Size(468, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.ProgressBar progressBarProd;
    }
}
