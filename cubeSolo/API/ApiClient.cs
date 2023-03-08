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


namespace cubeSolo.API
{
    internal class ApiClient
    {
        private const string baseUrl = @"https://localhost:7257/api";

        public static bool PostItem<T>(T json, string url)
        {
            //const string baseUrl = @"https://localhost:7257/api";

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            // Pass the handler to httpclient(from you are calling api)
            

            url = baseUrl + url;
            HttpClient client = new HttpClient(clientHandler);
            using (var content = new StringContent(JsonConvert.SerializeObject(json), System.Text.Encoding.UTF8, "application/json"))
            {
                // sDebug.WriteLine(content.ToString);
                HttpResponseMessage result = client.PostAsync(url, content).Result;
                Console.WriteLine(result.StatusCode);
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    return true;
                string returnValue = result.Content.ReadAsStringAsync().Result;

                throw new Exception($"Failed to POST data: ({result.StatusCode}): {returnValue}");
            }
        }
    }
}
