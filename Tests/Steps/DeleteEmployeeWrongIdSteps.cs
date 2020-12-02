using TechTalk.SpecFlow;

namespace Tests.Steps
{
    [Binding]
    public class DeleteEmployeeWrongIdSteps
    {
        [Given(@"Create URL segment '(.*)' with parameter ""(.*)""")]
        public void GivenCreateURLSegmentWithParameter(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
