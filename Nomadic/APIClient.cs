using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Nomadic
{
    class APIClient
    {
        private const string UrlBase = "https://nomadicserver.000webhostapp.com/scripts/"; 
        public static async Task SignInUser(string inEmail, string inPassword)
        {
            using var client = new HttpClient();
            var user = new
            {
                email = inEmail,
                password = inPassword
            };
            string json = JsonSerializer.Serialize(user);
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json"); 

            var response = await client.PostAsync(UrlBase + "userSignIn.php", data);
            var res = await response.Content.ReadAsStringAsync();
            Trace.WriteLine(res);
            client.Dispose();
            //if(response == "hei fra nomadic server")
            //{
            //    Trace.WriteLine("Det fungerer");
            //}
            //else
            //{
            //    Trace.WriteLine("Det fungerer ikke");
            //}
        }
    }

    
}
