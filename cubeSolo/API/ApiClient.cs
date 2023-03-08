// Importation de cubeSolo.API et cubeSolo.Models pour pouvoir être utilisé
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.Http;
using System.Net;

// Nom du namespace est cubeSolo.API
namespace cubeSolo.API
{
    // Class ApiClient
    internal class ApiClient
    {
        // URL de base de mon API
        private const string baseUrl = @"https://localhost:7257/api";

        // Création d'une Méthode PostItem avec comme paramètre json T est un paramètre de type générique et url de type string
        public static bool PostItem<T>(T json, string url)
        {
            //const string baseUrl = @"https://localhost:7257/api";

            // instruction qui crée une nouvelle instance de la classe HttpClientHandler et l'assigne à une variable nommée clientHandler
            HttpClientHandler clientHandler = new HttpClientHandler();

            // Désactivation du SSL. Sans cela nous ne pouvons pas envoyer nos données a l'API
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            
            // Création de l'url avec la baseUrl défini plutôt et l'url que nous envoyons en paramètre
            url = baseUrl + url;

            // instruction qui crée une nouvelle instance de la classe HttpClient et l'assigne à une variable nommée client
            HttpClient client = new HttpClient(clientHandler);
            // Création d'un variable content qui créer un objet sous forme de json
            using (var content = new StringContent(JsonConvert.SerializeObject(json), System.Text.Encoding.UTF8, "application/json"))
            {
                // sDebug.WriteLine(content.ToString);

                // Envoie du code et sauvegarde 

                // Effectue une requête HTTP POST en utilisant un objet HttpClient nommé client, en envoyant les données spécifiées dans le paramètre content et l'URL spécifiée dans le paramètre url.
                HttpResponseMessage result = client.PostAsync(url, content).Result;
                // Affichage du Code d'erreur que renvoie l'API
                Console.WriteLine(result.StatusCode);
                // Création d'une condition pour vérifier le status Code que renvoie l'API return true si le status est OK
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    return true;
                // Si l'API ne retourne pas true sauvegarde de l'erreur que nous renvoie l'API
                string returnValue = result.Content.ReadAsStringAsync().Result;

                // Affichage de l'erreur que nous renvoie l'API
                throw new Exception($"Failed to POST data: ({result.StatusCode}): {returnValue}");
            }
        }
    }
}
