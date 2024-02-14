using System.Net.Http;
using System.Threading.Tasks;

namespace RestApiAutomationFramework.Utils
{
    public class HttpClientHelper
    {
        private readonly HttpClient _httpClient;

        public HttpClientHelper()
        {
            _httpClient = new HttpClient();
        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            return await _httpClient.GetAsync(url);
        }

        // Add more methods for POST, PUT, DELETE requests as needed
    }
}
