using Newtonsoft.Json;

namespace NOTABURGER_2.Models
{
    internal class API
    {
        static string url = "https://api.zippopotam.us/us/84102";

        static public async void LoadData()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(url).Result;


            response.EnsureSuccessStatusCode();
            var responseBody = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject(responseBody);

            Console.WriteLine(result);
        }

    }
    //public class API : Controller
    //{
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }
    //}
}
