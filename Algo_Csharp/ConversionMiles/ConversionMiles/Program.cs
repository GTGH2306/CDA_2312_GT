namespace ConversionMiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            do
            {
                do
                {
                    Console.WriteLine("Saisissez une distance à convertir:\t\t(Q pour Quitter)");
                    saisie = Console.ReadLine();
                    saisie = saisie.ToLower();

                    if (CtrlSaisie(saisie) == RetourSaisie.Invalide)
                    {
                        Console.WriteLine("Saisie invalide.");
                    }
                } while (CtrlSaisie(saisie) == RetourSaisie.Invalide);



                if (CtrlSaisie(saisie) != RetourSaisie.Quit)
                {

                    if (CtrlSaisie(saisie) == RetourSaisie.FromKM)
                    {
                        double km = double.Parse(saisie.Substring(0, saisie.IndexOf("km")));
                        double mi = km / 1.609;

                        Console.WriteLine(Math.Round(km * 100) / 100 + "km = " + Math.Round(mi * 100) / 100 + "mi");
                    } else if (CtrlSaisie(saisie) == RetourSaisie.FromMI)
                    {
                        double mi = double.Parse(saisie.Substring(0, saisie.IndexOf("mi")));
                        double km = mi * 1.609;

                        Console.WriteLine(Math.Round(km * 100) / 100 + "km = " + Math.Round(mi * 100) / 100 + "mi");
                    } else
                    {
                        double km = double.Parse(saisie);
                        double mi = km / 1.609;

                        Console.WriteLine(Math.Round(km * 100) / 100 + "km = " + Math.Round(mi * 100) / 100 + "mi");
                    }
                }

            }while (CtrlSaisie(saisie) != RetourSaisie.Quit);
        }

        static RetourSaisie CtrlSaisie(string _saisie)
        {
            RetourSaisie retour;

            if(_saisie == "q" || _saisie == "je veux quitter svp, merci.")
            {
                retour = RetourSaisie.Quit;
            } else if (double.TryParse(_saisie, out _))
            {
                retour = RetourSaisie.Defaut;
            } else if (_saisie.EndsWith("km") && (double.TryParse(_saisie.Substring(0, _saisie.IndexOf("km")), out _)))
            {
                retour = RetourSaisie.FromKM;
            }
            else if (_saisie.EndsWith("mi") && (double.TryParse(_saisie.Substring(0, _saisie.IndexOf("mi")), out _)))
            {
                retour = RetourSaisie.FromMI;
            } else
            {
                retour = RetourSaisie.Invalide;
            }
            return retour;
        }

        enum RetourSaisie
        {
            Defaut,
            FromKM,
            FromMI,
            Quit,
            Invalide
        }
    }
}