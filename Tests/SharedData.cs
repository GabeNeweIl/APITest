using RestSharp;

namespace Tests
{
    public class SharedData
    {
        public static RestClient client = new RestClient(BaseURL.BaseUrl);

        public static RestRequest request;

        public static IRestResponse response;
    }
}
