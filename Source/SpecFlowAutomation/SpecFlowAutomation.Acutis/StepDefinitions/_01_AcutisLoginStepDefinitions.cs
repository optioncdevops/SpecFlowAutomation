using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SpecFlowAutomation.Framework.AcutisPages;
using SpecFlowAutomation.Framework.JsonTestData;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowAutomation.Acutis.StepDefinitions
{
    [Binding]
    public class _01_AcutisLoginStepDefinitions
    {
        private readonly AcutisLoginPage loginPage;

        public _01_AcutisLoginStepDefinitions(IWebDriver driver)
        {
            this.loginPage = new AcutisLoginPage(driver);
        }

        [Given(@"Launch the application with URL")]
        public void GivenLaunchTheApplicationWithURL()
        {
            loginPage.OpenWebDriver(loginPage.jsonData.JsonLogin.URL.ToString());
        }

        [Given(@"Enter the UserName and the Password")]
        public void GivenEnterTheUserNameAndThePassword()
        {
            
            loginPage.SendLoginCredential(loginPage.jsonData.JsonLogin.UserName.ToString(), loginPage.jsonData.JsonLogin.Password.ToString());
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.ClickOnLogin();
        }

        [Then(@"The Dashboard should be opened")]
        public void ThenTheDashboardShouldBeOpened()
        {
            loginPage.CheckTitle();
        }

        [Given(@"Launch the application with valid user credentials URL and UserName and the Password")]
        public void GivenLaunchTheApplicationWithValidUserCredentialsURLAndUserNameAndThePassword()
        {
            loginPage.OpenWebDriver(loginPage.jsonData.JsonLogin.URL.ToString());
            loginPage.SendLoginCredential(loginPage.jsonData.JsonLogin.UserName.ToString(), loginPage.jsonData.JsonLogin.Password.ToString());
            loginPage.ClickOnLogin();
            loginPage.CheckTitle();
        }

    }
}
