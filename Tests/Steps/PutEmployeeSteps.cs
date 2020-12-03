using RestSharp;
using TechTalk.SpecFlow;

namespace Tests.Steps
{
    [Binding]
    public class PutEmployeeSteps
    {
        [Given(@"Create request '(.*)' with PUT method")]
        public void GivenCreateRequestWithPUTMethod(string requestUrl)
        {
            SharedData.request = new RestRequest(requestUrl, Method.PUT);
        }
    }
    //
}
