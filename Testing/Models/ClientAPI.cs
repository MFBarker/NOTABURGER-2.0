using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Testing.Models
{
    public class ClientAPI
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        static HttpClient client = new HttpClient();


        // Initializes the HttpClient 
        /// <summary>
        /// Sets the base uRI for HTTP requests. Change the port number to the port used in ther server app is used
        /// Sets the Accept header to "application/json". Setting this header tells the server to send data in JSON format
        /// </summary>
        /// <returns>async Task</returns>

        static async Task RunAsync()
        {
            // Update port # in the following line
            client.BaseAddress = new Uri("https://localhost:7162/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // GET request for a product
        static async Task<ProductInfo>

    }


}
