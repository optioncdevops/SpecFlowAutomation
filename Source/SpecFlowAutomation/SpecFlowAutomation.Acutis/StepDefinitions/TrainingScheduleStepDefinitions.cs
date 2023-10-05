using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SpecFlowAutomation.Framework.AcutisPages;
using SpecFlowAutomation.Framework.AcutisPages.Administration;
using SpecFlowAutomation.Framework.JsonTestData;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowAutomation.Acutis.StepDefinitions
{
    [Binding]
    public class TrainingScheduleStepDefinitions
    {
        private readonly AcutisLoginPage loginPage;
        private readonly TrainingSchedule trainingSchedule;
        private readonly AcutisJsonDataObjects testData;
        public TrainingScheduleStepDefinitions(IWebDriver driver)
        {
            this.loginPage = new AcutisLoginPage(driver);
            this.trainingSchedule = new TrainingSchedule(driver);
            testData = (AcutisJsonDataObjects)JsonDataReader.GetJsonData("Acutis");

        }

        [Given(@"Launch the application with valid user credentials URL and UserName and the Password\.")]
        public void GivenLaunchTheApplicationWithValidUserCredentialsURLAndUserNameAndThePassword_()
        {
            if (testData.JsonLogin != null)
                loginPage.LoginProcess(testData.JsonLogin);
        }

        [Then(@"Navigate to Training Schedule")]
        public void ThenNavigateToTrainingSchedule()
        {
            trainingSchedule.TrainingScheduleProcess();
        }

        [Then(@"User should be able to logout from the application\.")]
        public void ThenUserShouldBeAbleToLogoutFromTheApplication_()
        {
            trainingSchedule.logout();
        }
    }
}
