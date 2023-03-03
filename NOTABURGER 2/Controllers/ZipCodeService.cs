﻿using NOTABURGER_2.Interfaces;
using NOTABURGER_2.Models;
using System.Text.Json;

namespace NOTABURGER_2.Controllers
{
    public class ZipCodeService : IZipCodeService
    {
        private static readonly HttpClient client;


        static ZipCodeService()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("https://api.zippopotam.us/")
            };
        }

        public async Task<List<ZipModel>> GetLocation(int postalcode)
        {
            var url = string.Format("/us/{0}", postalcode);
            var result = new List<ZipModel>();
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                //result = JsonSerializer.Deserialize<ZipModel>(stringResponse,
                //    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);

            }

            return result;
        }
    }
}
