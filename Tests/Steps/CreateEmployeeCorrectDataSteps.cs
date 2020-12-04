using RestSharp;
using RestSharp.Serialization.Json;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Tests.Models;

namespace Tests.Steps
{
    [Binding]
    public class CreateEmployeeCorrectDataSteps
    {
        CreateEmployee employee;

        string jsonBody;

        [When(@"Create request '(.*)' with POST method")]
        public void GivenCreateRequestWithPOSTMethod(string requestUrl)
        {
            SharedData.request = new RestSharp.RestRequest(requestUrl, Method.POST);
        }
        
        [When(@"I create a request boyd with following data")]
        public void WhenICreateARequestBoydWithFollowingData(Table table)
        {
            employee = table.CreateInstance<CreateEmployee>();

            var obj = new CreateEmployee()
            {
                Age = employee.Age,

                Name = employee.Name,

                Salary = employee.Salary
            };

            JsonSerializer serializer = new JsonSerializer();

            jsonBody = serializer.Serialize(obj);
        }
        
        [When(@"serelaized body to the API request")]
        public void WhenSerelaizedBodyToTheAPIRequest()
        {
            SharedData.request.AddJsonBody(jsonBody);
        }
        //
    }
}
