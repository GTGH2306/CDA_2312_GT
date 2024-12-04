using CLDessin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAppFigures
{
    public class VisiteurWinforms : IVisiteurStructures
    {
        private readonly Graphics graphics;

        public VisiteurWinforms(Graphics _graphics)
        {
            this.graphics = _graphics;
        }

        public void Afficher(Cercle _cercle)
        {
            this.graphics.FillEllipse(Brushes.Chartreuse, _cercle.PosX, _cercle.PosY, _cercle.Largeur(), _cercle.Hauteur());
        }

        public void Afficher(CLDessin.Rectangle _rectangle)
        {
            this.graphics.FillRectangle(Brushes.Salmon, _rectangle.PosX, _rectangle.PosY, _rectangle.Largeur(), _rectangle.Hauteur());
        }

        public void Afficher(Triangle _triangle)
        {
            Point up = new Point(_triangle.PosX + (int)Math.Round(_triangle.Largeur() / 2d), _triangle.PosY + _triangle.Hauteur());
            Point left = new Point(_triangle.PosX, _triangle.PosY);
            Point right = new Point(_triangle.PosX + _triangle.Largeur(), _triangle.PosY);
            Point[] points = {up, left, right};

            this.graphics.FillPolygon(Brushes.Tomato, points);
        }

        public void Afficher(Dessin _dessin)
        { 
            this.graphics.DrawRectangle(Pens.Green, _dessin.PosX, _dessin.PosY, _dessin.Largeur(), _dessin.Hauteur());
        }
    }
}
