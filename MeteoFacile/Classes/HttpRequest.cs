using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MeteoFacile.Classes
{
    // https://learn.microsoft.com/it-it/dotnet/api/system.net.http.httpclient?view=net-8.0
    internal class HttpRequest
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<(HttpStatusCode StatusCode, string Response)> Get(string url)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                return (response.StatusCode, await response.Content.ReadAsStringAsync());
            }
            catch (HttpRequestException ex)
            {
                return (HttpStatusCode.NotFound, ex.Message);
            }

        }
    }
}
