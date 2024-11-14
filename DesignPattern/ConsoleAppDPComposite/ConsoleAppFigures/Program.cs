using CLDesignPattern;

namespace ConsoleAppFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dessin canvas = new Dessin();
            Dessin bonhomme = new Dessin(2, 3);
            Cercle soleil = new Cercle(10, 1, 1);
            Cercle tete = new Cercle(3, 2, 2);
            Triangle torse = new Triangle(3, 6, 2);
            Rectangle jambeDroite = new Rectangle(3 , 9, 1, 2);
            Rectangle jambeGauche = new Rectangle(5, 9, 1, 2);

            bonhomme.AjouterStructure(tete);
            bonhomme.AjouterStructure(torse);
            bonhomme.AjouterStructure(jambeGauche);
            bonhomme.AjouterStructure(jambeDroite);
            canvas.AjouterStructure(bonhomme);
            canvas.AjouterStructure(soleil);

            Console.WriteLine(canvas.AfficheToi());
        }
    }
}
