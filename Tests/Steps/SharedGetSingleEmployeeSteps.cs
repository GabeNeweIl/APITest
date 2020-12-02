using FluentAssertions;
using RestSharp;
using TechTalk.SpecFlow;

namespace Tests.Steps
{
    [Binding]
    public class SharedGetSingleEmployeeSteps
    {
        [Given(@"Create request '(.*)' with GET method")]
        public void GivenCreateRequestWithMethod(string requestUrl)
        {
            SharedData.request = new RestRequest(requestUrl, Method.GET);
        }
        
        [Given(@"Create URL segment '(.*)' with parameter '(.*)'")]
        public void GivenCreateURLSegmentWithParameter(string urlSegment, string value)
        {
            SharedData.request.AddUrlSegment(urlSegment, value);
        }
        
        [Given(@"Execute API")]
        public void GivenExecuteAPI()
        {
            SharedData.response = SharedData.client.Execute(SharedData.request);
        }
       
        [Then(@"returned status code will be '(.*)'")]
        public void ThenReturnedStatusCodeWillBe(int expectedCode)
        {
            SharedData.response.StatusCode.Should().Be(expectedCode);
        }
    }
}
