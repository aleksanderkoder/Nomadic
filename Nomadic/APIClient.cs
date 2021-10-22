using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Nomadic
{
    class APIClient
    {
        private const string UrlBase = "https://nomadicserver.000webhostapp.com/scripts/"; 
        public static async Task<APIResponse> SignInUser(string inEmail, string inPassword)
        {
            APIResponse result = new APIResponse();
            result.Status = "false";
            result.Message = "Error"; 

            using var client = new HttpClient();

            var user = new 
            {
                email = inEmail,
                password = inPassword
            };
            //var postResponse = await client.PostAsJsonAsync(UrlBase + "userSignIn.php", user);
            //Trace.WriteLine(await postResponse.Content.ReadFromJsonAsync<Response>());
            string json = JsonConvert.SerializeObject(user);
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(UrlBase + "userSignIn.php", data);
                var res = await response.Content.ReadAsStringAsync();
                try
                {
                    result = JsonConvert.DeserializeObject<APIResponse>(res);
                } catch(JsonReaderException e)
                {
                    Trace.WriteLine("ERROR: " + e.Message); 
                    result.Message = "Error deserializing API response!"; 
                }
            } catch(HttpRequestException e)
            {
                Trace.WriteLine(e.Message); 
            }
            
            client.Dispose();
            return result; 
             
        }
    }
    public class APIResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

}
