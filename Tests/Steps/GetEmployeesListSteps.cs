using FluentAssertions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TechTalk.SpecFlow;
using Tests.Models;

namespace Tests.Steps
{
    [Binding]
    public class GetEmployeesListSteps
    {
        Employee[] employees;

        [When(@"Deserialize the employees api content")]
        public void WhenDeserializeTheEmployeeApiContent()
        {
            var obj = JObject.Parse(SharedData.response.Content);

            employees = JsonConvert.DeserializeObject<Employee[]>(obj["data"].ToString());
        }
        
        [Then(@"I should get list of (.*) employees")]
        public void ThenIShouldGetListOfEmployees(int expectedCount)
        {
            employees.Length.Should().Be(expectedCount);
        }
        //
    }
}
