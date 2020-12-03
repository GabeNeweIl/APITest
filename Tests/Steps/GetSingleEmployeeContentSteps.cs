using FluentAssertions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Tests.Models;

namespace Tests.Steps
{
    [Binding]
    public class GetSingleEmployeeContentSteps
    {
        Employee employee;

        [When(@"Deserialize the employee api content")]
        public void GivenDeserializeTheEmployeeApiContent()
        {
            var obj = JObject.Parse(SharedData.response.Content);

            employee = JsonConvert.DeserializeObject<Employee>(obj["data"].ToString());
        }
        
        [Then(@"The employee should have the following values")]
        public void ThenTheEmployeeShouldHaveTheFollowingValues(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            Employee expectedEmployee = new Employee()
            {
                id = (int)data.id,

                employee_name = (string)data.employee_name,

                employee_salary = (uint)data.employee_salary,

                employee_age = (uint)data.employee_age
            };

            expectedEmployee.Should().BeEquivalentTo(employee);
        }
    }
}
