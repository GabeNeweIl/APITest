using RestSharp;

namespace Tests
{
    public static class SharedData
    {
        public static RestClient client = new RestClient(BaseURL.BaseUrl);

        public static RestRequest request;

        public static IRestResponse response;
    }
}
