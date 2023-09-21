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
            loginPage.OpenWebDriver("https://viper.allnewoptionc.com");
        }

        [Given(@"Enter the UserName and the Password")]
        public void GivenEnterTheUserNameAndThePassword()
        {
            
            loginPage.SendLoginCredential("jclement@optionc.com", "password");

        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.ClickOnLogin();
        }

        [Then(@"The Dashboard should be opened")]
        public void ThenTheDashboardShouldBeOpened()
        {
            
        }
    }
}
