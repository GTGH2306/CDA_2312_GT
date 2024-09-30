namespace WFControlLibrary
{
    partial class UCTrafficLightButtons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTrafficLightButtons));
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGreen
            // 
            this.buttonGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGreen.Image = ((System.Drawing.Image)(resources.GetObject("buttonGreen.Image")));
            this.buttonGreen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGreen.Location = new System.Drawing.Point(0, 0);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(32, 56);
            this.buttonGreen.TabIndex = 0;
            this.buttonGreen.Text = "X";
            this.buttonGreen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGreen.UseVisualStyleBackColor = true;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRed.Image = ((System.Drawing.Image)(resources.GetObject("buttonRed.Image")));
            this.buttonRed.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRed.Location = new System.Drawing.Point(32, 0);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(32, 56);
            this.buttonRed.TabIndex = 1;
            this.buttonRed.Text = "X";
            this.buttonRed.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRed.UseVisualStyleBackColor = true;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYellow.Image = ((System.Drawing.Image)(resources.GetObject("buttonYellow.Image")));
            this.buttonYellow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonYellow.Location = new System.Drawing.Point(64, 0);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(32, 56);
            this.buttonYellow.TabIndex = 2;
            this.buttonYellow.Text = "X";
            this.buttonYellow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonYellow.UseVisualStyleBackColor = true;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // UCTrafficLightButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonGreen);
            this.Name = "UCTrafficLightButtons";
            this.Size = new System.Drawing.Size(96, 56);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonYellow;
    }
}
