using RestSharp;
using static Core.ConfigurationManager;

namespace Core
{
    public class ApiClient
    {
        private readonly RestClient _client;

        public ApiClient()
        {
            _client = new RestClient(BaseUrl);
        }

        public RestResponse Get() 
        {
            var request = new RestRequest(BaseUrl, Method.Get);
            
            return _client.Execute(request);
        }
    }
}
