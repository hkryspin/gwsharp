using Gw.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gw.Controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var r = GetDailies();
            var data = Dailies.FromJson(r.Result);

            return View(data);
        }

        static async Task<string> GetDailies()
        {
            var uri = "https://api.guildwars2.com/v2/achievements/daily";

            HttpClient client = new HttpClient();

            string responseBody = await client.GetStringAsync(uri);
            return responseBody;
        }
    }
}