using ClassLibraryLepidoptere;

namespace ConsoleAppLepidotere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lepidoptere toto = new Lepidoptere();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(toto.SeDeplacer() ?
                    ("Toto est capable de ce mouvoir") :
                    ("Toto ne peux ce mouvoir")
                    );
                Console.WriteLine(toto);
                Console.WriteLine(toto.SeMetamorphoser() ?
                    ("Toto c'est métamorphosé en " + toto.ToString().Split(":")[1]) :
                    ("Toto n'as pas pu ce métamorphoser"));
                
            }
        }
    }
}