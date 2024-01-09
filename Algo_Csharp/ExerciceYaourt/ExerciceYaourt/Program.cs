using System.Security;
using System.Text.Json;

namespace ExerciceYaourt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] votes = VoteGetter("https://api.devoldere.net/polls/yoghurts/");
            
            //Tableau de votes pour tests contenant 6 Vert, 5 Rouge, 4 Bleu, 3 Jaune, 2 Orange
            //string[] votes = new string[] {"blue", "red", "red", "red", "red", "red", "green", "green", "green", "green", "green", "green", "orange", "orange", "yellow" , "yellow", "yellow", "blue", "blue", "blue" };
            
            int[] votesCount = new int[] {0, 0, 0, 0, 0};
            string[] votesOrder = new string[] {"Rouge", "Vert", "Orange", "Jaune", "Bleu"};
            int votesAutre = 0;

            foreach (string vote in votes)
            {
                switch (vote)
                {
                    case "red":
                        votesCount[0]++;
                        break;
                    case "green":
                        votesCount[1]++;
                        break;
                    case "orange":
                        votesCount[2]++;
                        break;
                    case "yellow":
                        votesCount[3]++;
                        break;
                    case "blue":
                        votesCount[4]++;
                        break;
                    default:
                        votesAutre++;
                        break;
                }
            }

            if (votesAutre == 0)
            {
                TriDecroissant(ref votesCount, ref votesOrder);

                for (int i = 0; i < votesCount.Length; i++)
                    {
                    Console.WriteLine(votesOrder[i] + ": " + votesCount[i] + " votes.");
                    }
                Console.WriteLine(votesOrder[0] + " " + votesOrder[1]);
            } else
            {
                Console.WriteLine("Vote invalide car il y'a " + votesAutre + " vote(s) non reconnus.");
            }


        }

        public static string[] VoteGetter(string _url)
        {
            string[] retour;

            //Créer une instance de client HTTP
            HttpClient client = new HttpClient();

            //Récupère la réponse de l'API en utilisant la méthode ".GetAsync(_url)"
            HttpResponseMessage response = client.GetAsync(_url).Result;

            //Retourne le résultat de l'API sous form de string
            string reponse = response.Content.ReadAsStringAsync().Result;

            //Deserialize la réponse en créeant un objet "JsonDocument"
            JsonDocument jsonDocument = JsonDocument.Parse(reponse);

            //Créer un element json root
            JsonElement root = jsonDocument.RootElement;
            //Récupère l'élément json "results" du root
            JsonElement tableauResultats = root.GetProperty("results");

            //Indique que le tableau retour est aussi long que le tableau récupéré
            retour = new string[tableauResultats.GetArrayLength()];

            //Converti chaque élément du tableau json en string et les ajoutons au tableau retour
            for (int i = 0; i < retour.Length; i++)
            {
                retour[i] = tableauResultats.EnumerateArray().ElementAt(i).ToString();
            }

            //Libère les resources prise par HttpClient
            client.Dispose();

            return retour;
        }

        public static void TriDecroissant(ref int[] atrier, ref string[] correspondance)
        {
            for (int i = 0; i < atrier.Length; i++) //On prend un nombre i
            {
                for (int j = 0; j < atrier.Length; j++) //Qu'on compare avec chaque nombre du tableau
                {
                    if (atrier[i] > atrier[j]) //Si i est plus grand que le nombre comparé, on échange
                    {
                        (atrier[j], atrier[i]) = (atrier[i], atrier[j]); //Tuple, échangeant les deux valeurs sans besoin d'une valeur tampon
                        (correspondance[j], correspondance[i]) = (correspondance[i], correspondance[j]);
                    }
                }
            }
        }
    }
}
