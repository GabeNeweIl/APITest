using RestSharp;
using TechTalk.SpecFlow;

namespace Tests.Steps
{
    [Binding]
    public class DeleteEmployeeSteps
    {
        [Given(@"Create request '(.*)' with DELETE method")]
        public void GivenCreateRequestWithDELETEMethod(string requestUrl)
        {
            SharedData.request = new RestRequest(requestUrl, Method.DELETE);
        }
    }
}
