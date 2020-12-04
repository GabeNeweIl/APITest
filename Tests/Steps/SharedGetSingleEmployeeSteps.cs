using FluentAssertions;
using RestSharp;
using System.Threading;
using TechTalk.SpecFlow;

namespace Tests.Steps
{
    [Binding]
    public class SharedGetSingleEmployeeSteps
    {
        [When(@"Create request '(.*)' with GET method")]
        public void GivenCreateRequestWithMethod(string requestUrl)
        {
            SharedData.request = new RestRequest(requestUrl, Method.GET);
        }
        
        [When(@"Create URL segment '(.*)' with parameter '(.*)'")]
        public void GivenCreateURLSegmentWithParameter(string urlSegment, string value)
        {
            SharedData.request.AddUrlSegment(urlSegment, value);
        }
        
        [When(@"Execute API")]
        public void GivenExecuteAPI()
        {
            SharedData.response = SharedData.client.Execute(SharedData.request);

            if (SharedData.response.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                GivenExecuteAPI();
        }
       
        [Then(@"returned status code will be '(.*)'")]
        public void ThenReturnedStatusCodeWillBe(int expectedCode)
        {
            if (SharedData.response.StatusCode != System.Net.HttpStatusCode.TooManyRequests)
                SharedData.response.StatusCode.Should().Be(expectedCode);

            else
                GivenExecuteAPI();
        }
    }
    //
}
