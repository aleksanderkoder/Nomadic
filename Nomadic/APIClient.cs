using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Nomadic
{
    class APIClient
    {
        public static async Task SignInUser(string email, string password)
        {
            using var client = new HttpClient();
            var response = await client.GetStringAsync("https://nomadicserver.000webhostapp.com/scripts/test.php");
            Trace.WriteLine(response); 
            if(response == "hei fra nomadic server")
            {
                Trace.WriteLine("Det fungerer");
            }
            else
            {
                Trace.WriteLine("Det fungerer ikke");
            }
        }
    }

    
}
