using System.Net.Http;
using System.Threading.Tasks;

namespace Gw.Models
{
    public class GwApi
    {
        static GwApi()
        {
            client = new HttpClient();
        }

        public static async Task<string> GetDailies() //no
        {
            string responseBody = await client.GetStringAsync(apiUrl);
            return responseBody;
        }

        public static readonly HttpClient client; //privs
        public static string apiUrl = "https://api.guildwars2.com/v2";
    }
}
