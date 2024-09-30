namespace WFToutEmballe
{
    partial class TimeSpeedInput
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
            this.labelTimeSpeed = new System.Windows.Forms.Label();
            this.maskedTextBoxTimeSpeed = new System.Windows.Forms.MaskedTextBox();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTimeSpeed
            // 
            this.labelTimeSpeed.AutoSize = true;
            this.labelTimeSpeed.Location = new System.Drawing.Point(32, 32);
            this.labelTimeSpeed.Name = "labelTimeSpeed";
            this.labelTimeSpeed.Size = new System.Drawing.Size(166, 13);
            this.labelTimeSpeed.TabIndex = 0;
            this.labelTimeSpeed.Text = "Multpilicateur de vitesse du temps";
            // 
            // maskedTextBoxTimeSpeed
            // 
            this.maskedTextBoxTimeSpeed.Location = new System.Drawing.Point(32, 48);
            this.maskedTextBoxTimeSpeed.Mask = "99999";
            this.maskedTextBoxTimeSpeed.Name = "maskedTextBoxTimeSpeed";
            this.maskedTextBoxTimeSpeed.Size = new System.Drawing.Size(48, 20);
            this.maskedTextBoxTimeSpeed.TabIndex = 1;
            this.maskedTextBoxTimeSpeed.ValidatingType = typeof(int);
            this.maskedTextBoxTimeSpeed.TextChanged += new System.EventHandler(this.maskedTextBoxTimeSpeed_TextChanged);
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(128, 64);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(75, 23);
            this.buttonValidate.TabIndex = 2;
            this.buttonValidate.Text = "Valider";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // TimeSpeedInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 113);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.maskedTextBoxTimeSpeed);
            this.Controls.Add(this.labelTimeSpeed);
            this.Name = "TimeSpeedInput";
            this.Text = "Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTimeSpeed;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTimeSpeed;
        private System.Windows.Forms.Button buttonValidate;
    }
}