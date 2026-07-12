
using TechTalk.SpecFlow;

namespace CSharpSpecFlowHealthcareExample.Hooks
{
    [Binding]
    public sealed class TestHooks
    {
        private readonly ScenarioContext _scenarioContext;

        public TestHooks(
            ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario(Order = 0)]
        public void BeforeEveryScenario()
        {
            Console.WriteLine(
                $"START: {_scenarioContext.ScenarioInfo.Title}");
        }

        [BeforeScenario("smoke", Order = 10)]
        public void BeforeSmokeScenario()
        {
            Console.WriteLine(
                "Preparing smoke test data.");
        }

        [AfterScenario(Order = 100)]
        public void AfterEveryScenario()
        {
            var status =
                _scenarioContext.TestError is null
                    ? "PASSED"
                    : "FAILED";

            Console.WriteLine(
                $"END: {_scenarioContext.ScenarioInfo.Title}; " +
                $"status={status}");
        }
    }
}
