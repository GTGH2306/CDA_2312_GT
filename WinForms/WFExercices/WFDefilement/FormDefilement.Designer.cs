namespace WFDefilement
{
    partial class FormDefilement
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
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.labelBlue = new System.Windows.Forms.Label();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.textBoxRedColor = new System.Windows.Forms.TextBox();
            this.textBoxGreenColor = new System.Windows.Forms.TextBox();
            this.textBoxBlueColor = new System.Windows.Forms.TextBox();
            this.textBoxFinalColor = new System.Windows.Forms.TextBox();
            this.buttonNewWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.Location = new System.Drawing.Point(96, 48);
            this.hScrollBarRed.Maximum = 264;
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(176, 17);
            this.hScrollBarRed.TabIndex = 0;
            this.hScrollBarRed.ValueChanged += new System.EventHandler(this.HScrollBarRed_ValueChanged);
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(288, 48);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownRed.TabIndex = 1;
            this.numericUpDownRed.ValueChanged += new System.EventHandler(this.NumericUpDownRed_ValueChanged);
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(32, 48);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(39, 13);
            this.labelRed.TabIndex = 2;
            this.labelRed.Text = "Rouge";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(32, 80);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(26, 13);
            this.labelGreen.TabIndex = 5;
            this.labelGreen.Text = "Vert";
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(288, 80);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownGreen.TabIndex = 4;
            this.numericUpDownGreen.ValueChanged += new System.EventHandler(this.NumericUpDownGreen_ValueChanged);
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.Location = new System.Drawing.Point(96, 80);
            this.hScrollBarGreen.Maximum = 264;
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(176, 17);
            this.hScrollBarGreen.TabIndex = 3;
            this.hScrollBarGreen.ValueChanged += new System.EventHandler(this.HScrollBarGreen_ValueChanged);
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(32, 112);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(28, 13);
            this.labelBlue.TabIndex = 8;
            this.labelBlue.Text = "Bleu";
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(288, 112);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownBlue.TabIndex = 7;
            this.numericUpDownBlue.ValueChanged += new System.EventHandler(this.NumericUpDownBlue_ValueChanged);
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.Location = new System.Drawing.Point(96, 112);
            this.hScrollBarBlue.Maximum = 264;
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(176, 17);
            this.hScrollBarBlue.TabIndex = 6;
            this.hScrollBarBlue.ValueChanged += new System.EventHandler(this.HScrollBarBlue_ValueChanged);
            // 
            // textBoxRedColor
            // 
            this.textBoxRedColor.BackColor = System.Drawing.Color.Red;
            this.textBoxRedColor.Enabled = false;
            this.textBoxRedColor.Location = new System.Drawing.Point(352, 48);
            this.textBoxRedColor.Name = "textBoxRedColor";
            this.textBoxRedColor.Size = new System.Drawing.Size(48, 20);
            this.textBoxRedColor.TabIndex = 9;
            // 
            // textBoxGreenColor
            // 
            this.textBoxGreenColor.BackColor = System.Drawing.Color.Green;
            this.textBoxGreenColor.Enabled = false;
            this.textBoxGreenColor.Location = new System.Drawing.Point(352, 80);
            this.textBoxGreenColor.Name = "textBoxGreenColor";
            this.textBoxGreenColor.Size = new System.Drawing.Size(48, 20);
            this.textBoxGreenColor.TabIndex = 10;
            // 
            // textBoxBlueColor
            // 
            this.textBoxBlueColor.BackColor = System.Drawing.Color.Blue;
            this.textBoxBlueColor.Enabled = false;
            this.textBoxBlueColor.Location = new System.Drawing.Point(352, 112);
            this.textBoxBlueColor.Name = "textBoxBlueColor";
            this.textBoxBlueColor.Size = new System.Drawing.Size(48, 20);
            this.textBoxBlueColor.TabIndex = 11;
            // 
            // textBoxFinalColor
            // 
            this.textBoxFinalColor.Location = new System.Drawing.Point(64, 160);
            this.textBoxFinalColor.Multiline = true;
            this.textBoxFinalColor.Name = "textBoxFinalColor";
            this.textBoxFinalColor.Size = new System.Drawing.Size(304, 80);
            this.textBoxFinalColor.TabIndex = 12;
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.Location = new System.Drawing.Point(176, 256);
            this.buttonNewWindow.Name = "buttonNewWindow";
            this.buttonNewWindow.Size = new System.Drawing.Size(96, 23);
            this.buttonNewWindow.TabIndex = 13;
            this.buttonNewWindow.Text = "Nouvelle Fenêtre";
            this.buttonNewWindow.UseVisualStyleBackColor = true;
            this.buttonNewWindow.Click += new System.EventHandler(this.ButtonNewWindow_Click);
            // 
            // FormDefilement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 305);
            this.Controls.Add(this.buttonNewWindow);
            this.Controls.Add(this.textBoxFinalColor);
            this.Controls.Add(this.textBoxBlueColor);
            this.Controls.Add(this.textBoxGreenColor);
            this.Controls.Add(this.textBoxRedColor);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.hScrollBarRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormDefilement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defilement";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBarRed;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.HScrollBar hScrollBarGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
        private System.Windows.Forms.HScrollBar hScrollBarBlue;
        private System.Windows.Forms.TextBox textBoxRedColor;
        private System.Windows.Forms.TextBox textBoxGreenColor;
        private System.Windows.Forms.TextBox textBoxBlueColor;
        private System.Windows.Forms.TextBox textBoxFinalColor;
        private System.Windows.Forms.Button buttonNewWindow;
    }
}

