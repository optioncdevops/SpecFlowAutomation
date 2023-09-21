using BoDi;
using SpecFlowAutomation.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowAutomation.Acutis.Hooks
{
    [Binding]
    public sealed class AcutisHooks
    {
        private readonly IObjectContainer container;
        public AcutisHooks(IObjectContainer container)
        {
            this.container = container;
        }
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            CommonExtentReports.BeforeTestRun();
        }
        [BeforeFeature]
        public static void BeforeFeature()
        {
            CommonExtentReports.BeforeFeature();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            CommonExtentReports.BeforeScenario(this.container);
        }
        [AfterStep]
        public void AfterStep()
        {
            CommonExtentReports.AfterStep(this.container);

        }
        [AfterScenario]
        public void AfterScenario()
        {
            CommonExtentReports.AfterScenario(this.container);
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            CommonExtentReports.AfterFeature();

        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            CommonExtentReports.AfterTestRun();
        }
    }
}