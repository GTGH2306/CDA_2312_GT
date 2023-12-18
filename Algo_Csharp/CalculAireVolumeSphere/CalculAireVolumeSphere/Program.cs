namespace CalculAireVolumeSphere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez le rayon de la sphère: ");
            float rayon = float.Parse(Console.ReadLine());
            float aire = (float)(4 * (Math.PI) * Math.Pow(rayon, 2));
            Console.WriteLine("L'aire de la sphère est de " + aire);
            float volume = (float)((4d / 3d) * Math.PI * Math.Pow(rayon, 3));
            Console.WriteLine("Le volume de la sphère est de " + volume);
        }
    }
}