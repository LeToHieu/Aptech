using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;
using Newtonsoft.Json;
using Owin_C2009L_NguyenVanA.Models;

namespace Owin_C2009L_NguyenVanA
{
    internal class Program
    {
        private static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {            
            // Start OWIN host 
            using (WebApp.Start<Startup>(url: ApiClient.baseAddress))
            {

                Album album = new Album()
                {
                    Id = 5,
                    Title = "xx",
                    Genre = "genre1",
                    Price = 11.2233
                };
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine("1.Show all albums");
                Console.WriteLine("2.Insert album");
                Console.WriteLine("3.Update an album");
                Console.WriteLine("4.Delete an album");
                Console.WriteLine("5.Exit");
                //Console.WriteLine($"Server is started at : {PORT}");
                Console.ReadLine();
            }
        }
    }
}
