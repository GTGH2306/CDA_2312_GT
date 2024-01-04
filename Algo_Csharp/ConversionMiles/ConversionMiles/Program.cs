using System.Text;

namespace ConversionMiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            RetourSaisie retourSaisie;
            const double rapportKmMi = 1.609;
            double km, mi;
            const string KM = "Km";
            const string MI = "Mi";

            do
            {
                do
                {
                    Console.WriteLine("Saisissez une distance à convertir:\t\t(Q pour Quitter)");
                    saisie = Console.ReadLine();
                    retourSaisie = CtrlSaisie(saisie);

                    if (retourSaisie == RetourSaisie.Invalide)
                    {
                        Console.WriteLine("Saisie invalide.");
                    }
                } while (retourSaisie == RetourSaisie.Invalide); //Demande une valeur tant qu'elle n'est pas valide



                if (retourSaisie != RetourSaisie.Quit) //N'execute pas le programme si l'utilateur à quitté
                {
                    switch (retourSaisie)
                    {
                        case RetourSaisie.FromKM:
                            km = ToDouble(saisie);
                            mi = km / rapportKmMi;
                            break;
                        case RetourSaisie.FromMI:
                            mi = ToDouble(saisie);
                            km = mi * rapportKmMi;
                            break;
                        default:
                            km = double.NaN;
                            mi = double.NaN;
                            Console.WriteLine("Erreur: Unité non programmée");
                            break;
                    }

                    Console.WriteLine((Math.Round(km * 100) / 100) + KM + " = " + (Math.Round(mi * 100) / 100) + MI + ".");
                }

            }while (retourSaisie != RetourSaisie.Quit);
        }

        static double ToDouble(string _valeur) //Converti un string en double en retirant les caractères
        {
            int virgule = 0;
            StringBuilder noTextString = new();

            for (int i = 0; i < _valeur.Length; i++)
            {
                if (_valeur[i] == '-' && i == 0)
                {
                    noTextString.Append(_valeur[i]);
                } else if (_valeur[i] == ',' && virgule == 0)
                {
                    noTextString.Append(_valeur[i]);
                    virgule++;
                } else if (Char.IsNumber(_valeur[i]))
                {
                    noTextString.Append(_valeur[i]);
                }
            }
            return double.Parse(noTextString.ToString());
        }

        static RetourSaisie CtrlSaisie(string _saisie) //Renvoi une enum retour selon la saisie en paramêtre
        {
            RetourSaisie retour;
            _saisie = _saisie.ToLower();

            if (_saisie == "q" || _saisie == "je veux quitter svp, merci.")
            {
                retour = RetourSaisie.Quit;
            } else if (double.TryParse(_saisie, out _) || (_saisie.EndsWith("km") && (double.TryParse(_saisie.Substring(0, _saisie.IndexOf("km")), out _))))
            {
                retour = RetourSaisie.FromKM;
            } else if (_saisie.EndsWith("mi") && (double.TryParse(_saisie.Substring(0, _saisie.IndexOf("mi")), out _)))
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
            FromKM,
            FromMI,
            Quit,
            Invalide
        }
    }
}