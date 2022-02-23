using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace Owin_C2009L_NguyenVanA
{
    internal class Program
    {
        private static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            const string SERVER_NAME = "localhost";
            const string PORT = "9000";
            string baseAddress = $"http://{SERVER_NAME}:{PORT}/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {

                string urlGetAllAlbum = $"{baseAddress}api/Album";
                var response = client.GetAsync(urlGetAllAlbum).Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                
                //Console.WriteLine($"Server is started at : {PORT}");
                Console.ReadLine();
            }
        }
    }
}
