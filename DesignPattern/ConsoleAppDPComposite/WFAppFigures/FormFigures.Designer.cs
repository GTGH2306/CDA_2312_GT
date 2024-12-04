namespace WFAppFigures
{
    partial class FormFigures
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPaint = new Canvas();
            buttonGroup = new Button();
            buttonUngroup = new Button();
            SuspendLayout();
            // 
            // panelPaint
            // 
            panelPaint.BorderStyle = BorderStyle.Fixed3D;
            panelPaint.Location = new Point(16, 16);
            panelPaint.Name = "panelPaint";
            panelPaint.Size = new Size(912, 576);
            panelPaint.TabIndex = 5;
            panelPaint.Paint += panelPaint_Paint;
            panelPaint.MouseDown += panelPaint_MouseDown;
            panelPaint.MouseMove += panelPaint_MouseMove;
            panelPaint.MouseUp += panelPaint_MouseUp;
            // 
            // buttonGroup
            // 
            buttonGroup.Enabled = false;
            buttonGroup.Location = new Point(944, 16);
            buttonGroup.Name = "buttonGroup";
            buttonGroup.Size = new Size(96, 23);
            buttonGroup.TabIndex = 6;
            buttonGroup.Text = "Grouper";
            buttonGroup.UseVisualStyleBackColor = true;
            buttonGroup.Click += buttonGroup_Click;
            // 
            // buttonUngroup
            // 
            buttonUngroup.Enabled = false;
            buttonUngroup.Location = new Point(944, 48);
            buttonUngroup.Name = "buttonUngroup";
            buttonUngroup.Size = new Size(96, 23);
            buttonUngroup.TabIndex = 7;
            buttonUngroup.Text = "Dissocier";
            buttonUngroup.UseVisualStyleBackColor = true;
            buttonUngroup.Click += buttonUngroup_Click;
            // 
            // FormFigures
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 630);
            Controls.Add(buttonUngroup);
            Controls.Add(buttonGroup);
            Controls.Add(panelPaint);
            Name = "FormFigures";
            Text = "Form Figures";
            ResumeLayout(false);
        }

        #endregion
        private Canvas panelPaint;
        private Button buttonGroup;
        private Button buttonUngroup;
    }
}
