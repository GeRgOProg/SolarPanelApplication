using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarPanelAppWF
{
    class Controller
    {
        public static User currentUser { get; set; }

        private static string port = "51488";
        public static string APIURL = "http://localhost:" + port + "/";
        

        public static Task<int> InsertPart(string name, double unitprice, int sum, int maxperstorag)
        {
            return Task.Run(async () =>
            {
                HttpClient client = new HttpClient();
                var values = new Dictionary<string, string>
              {
                  { "name" , name },
                  { "unitPrice", unitprice.ToString() },
                  { "sum", sum.ToString() },
                  { "maxPerStorage", maxperstorag.ToString() },
              };

                var content = new FormUrlEncodedContent(values);

                HttpResponseMessage response = await client.PostAsync($"{APIURL}newPart", content);

                var responseString = await response.Content.ReadAsStringAsync();

                var responseDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseString);
                int responseCode = Convert.ToInt32(responseDict["responseCode"]);

                return responseCode;

            });
        }




        public static string Login(string username, string password)
        {
            string url = $"{APIURL}login/{username}/{password}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            // Set credentials to use for this request.
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Get the stream associated with the response.
            Stream receiveStream = response.GetResponseStream();
            // Pipes the stream to a higher level stream reader with the required
            // encoding format.
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            string JSON = readStream.ReadToEnd();
            response.Close();
            readStream.Close();

            currentUser = JsonConvert.DeserializeObject<User>(JSON);


            if (currentUser.errorCode == 0)
            {
                return "OK";
            }
            else if (currentUser.errorCode == 500)
            {

                return "SQL ERROR!";
            }
            else
            {
                return "OTHER ERROR!";
            }
        }

        public static List<Part> GetParts()
        {
            string url = $"{APIURL}getParts";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            // Set credentials to use for this request.
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Get the stream associated with the response.
            Stream receiveStream = response.GetResponseStream();
            // Pipes the stream to a higher level stream reader with the required
            // encoding format.
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            string JSON = readStream.ReadToEnd();
            response.Close();
            readStream.Close();

            

            List<Part> parts = JsonConvert.DeserializeObject<List<Part>>(JSON);

            return parts;
        }

        public static Task<int> modifyUnitPrice(string name, string newPrice)
        {
            return Task.Run(async () =>
            {
                HttpClient client = new HttpClient();
                var values = new Dictionary<string, string>
              {
                  { "name" , name },
                  { "newPrice", newPrice}
              };

                var content = new FormUrlEncodedContent(values);

                HttpResponseMessage response = await client.PostAsync($"{APIURL}updatePrice", content);

                var responseString = await response.Content.ReadAsStringAsync();

                var responseDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseString);
                int responseCode = Convert.ToInt32(responseDict["responseCode"]);

                return responseCode;

            });
        }


        
    }
}
