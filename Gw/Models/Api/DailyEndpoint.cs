using System.Threading.Tasks;

namespace Gw.Models
{
    public class DailiesEndpoint
    {
        public DailiesEndpoint()
        {
            string url = GwApi.apiUrl + "/achievements/daily";
        }

        public async Task<string> GetAll()
        {
            string responseBody = await GwApi.GetDailies();
            return responseBody;
        }
    }
}
