
using CLDessin;
using System.Diagnostics;

namespace WFAppFigures
{
    public partial class FormFigures : Form
    {
        private static SolidBrush SelectionBrush = new SolidBrush(Color.FromArgb(80, 100, 100, 255));
        private bool mouseIsDown = false;

        private Dessin canvas;
        private Point selectStartPoint;
        private Point selectEndPoint;
        private List<StructureGeometrique> selectedStructures = new List<StructureGeometrique>();
        public FormFigures()
        {
            InitializeComponent();

            this.canvas = new Dessin(0, 0);
            Dessin bonom = new Dessin(100, 100);
            Cercle tete = new Cercle(100, 100, 25);
            Triangle torse = new Triangle(100, 200, -50, 50);
            CLDessin.Rectangle jambeg = new CLDessin.Rectangle(100, 200, 40, 20);
            CLDessin.Rectangle jambed = new CLDessin.Rectangle(130, 200, 40, 20);
            Cercle soleil = new Cercle(250, 50, 10);

            this.canvas.AddStructure(bonom);
            this.canvas.AddStructure(soleil);

            bonom.AddStructure(tete);
            bonom.AddStructure(torse);
            bonom.AddStructure(jambeg);
            bonom.AddStructure(jambed);

            this.canvas.AddStructure(new Triangle(500, 300, 150, 200));

        }

        public void panelPaint_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            VisiteurWinforms visitor = new VisiteurWinforms(g);

            foreach (StructureGeometrique _struct in this.canvas.Structures)
            {
                _struct.SAfficher(visitor);
            }

            if (this.selectedStructures.Count > 0)
            {
                new Dessin(this.selectStartPoint.X, this.selectEndPoint.Y, this.selectedStructures).SAfficher(visitor);
            }


            if (this.mouseIsDown)
            {
                System.Drawing.Rectangle selectionRectangle = GetSelectionRectangle();
                g.FillRectangle(SelectionBrush, selectionRectangle);
                g.DrawRectangle(Pens.Blue, selectionRectangle);
            }
        }

        private void panelPaint_MouseDown(object sender, MouseEventArgs e)
        {
            this.selectStartPoint = new Point(e.Location.X, e.Location.Y);
            this.mouseIsDown = true;
        }

        private System.Drawing.Rectangle GetSelectionRectangle()
        {
            Point selStart;
            int width;
            int height;

            //Le rectangle va de gauche à droite, de bas en haut
            if (this.selectStartPoint.X < this.selectEndPoint.X && this.selectStartPoint.Y > this.selectEndPoint.Y)
            {
                selStart = new Point(this.selectStartPoint.X, this.selectEndPoint.Y);
                width = this.selectEndPoint.X - this.selectStartPoint.X;
                height = this.selectStartPoint.Y - this.selectEndPoint.Y;
            }
            //Le rectangle va de droite à gauche, de bas en haut
            else if (this.selectStartPoint.X > this.selectEndPoint.X && this.selectStartPoint.Y > this.selectEndPoint.Y)
            {
                selStart = new Point(this.selectEndPoint.X, this.selectEndPoint.Y);
                width = this.selectStartPoint.X - this.selectEndPoint.X;
                height = this.selectStartPoint.Y - this.selectEndPoint.Y;
            }
            //Le rectangle va de droite à gauche de haut en bas
            else if (this.selectStartPoint.X > this.selectEndPoint.X && this.selectStartPoint.Y < this.selectEndPoint.Y)
            {
                selStart = new Point(this.selectEndPoint.X, this.selectStartPoint.Y);
                width = this.selectStartPoint.X - this.selectEndPoint.X;
                height = this.selectEndPoint.Y - this.selectStartPoint.Y;
            }
            //Le rectangle va de gauche à droite de haut en bas
            else
            {
                selStart = new Point(this.selectStartPoint.X, this.selectStartPoint.Y);
                width = this.selectEndPoint.X - this.selectStartPoint.X;
                height = this.selectEndPoint.Y - this.selectStartPoint.Y;
            }

            return new System.Drawing.Rectangle(selStart.X, selStart.Y, width, height);

        }

        private void panelPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.selectEndPoint = new Point(e.Location.X, e.Location.Y);
                panelPaint.Invalidate();
            }

        }

        private void panelPaint_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseIsDown = false;
            this.selectedStructures = new List<StructureGeometrique>();
            MakeSelection();
            RefreshButtons();

            panelPaint.Invalidate();


        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            if (CanGroupSelection())
            {
                this.canvas.Grouper(this.selectedStructures);
                this.selectedStructures = new List<StructureGeometrique>();
                RefreshButtons();
                panelPaint.Invalidate();
            }
        }

        private void buttonUngroup_Click(object sender, EventArgs e)
        {
            if (CanUngroupSelection())
            {
                Dessin selected = (Dessin)this.selectedStructures[0];
                this.canvas.Dissocier(selected);
                this.selectedStructures = new List<StructureGeometrique>();
                RefreshButtons();
                panelPaint.Invalidate();
            }
        }

        private bool CanGroupSelection()
        {
            return this.selectedStructures.Count > 1;
        }
        private bool CanUngroupSelection()
        {
            return this.selectedStructures.Count == 1 && this.selectedStructures[0].GetType() == typeof(Dessin);
        }
        private void RefreshButtons()
        {
            this.buttonGroup.Enabled = CanGroupSelection();
            this.buttonUngroup.Enabled = CanUngroupSelection();
        }
        private void MakeSelection()
        {
            System.Drawing.Rectangle selection = GetSelectionRectangle();
            CLDessin.Rectangle reactangleVerif = new CLDessin.Rectangle(selection.X, selection.Y, selection.Height, selection.Width);

            foreach (StructureGeometrique _structure in this.canvas.Structures)
            {
                if (reactangleVerif.Overlap(_structure))
                {
                    this.selectedStructures.Add(_structure);
                }
            }
        }
    }
}
