using OpenQA.Selenium;
using SpecFlowAutomation.Framework.AcutisPages;
using SpecFlowAutomation.Framework.AcutisPages.Administration;
using SpecFlowAutomation.Framework.JsonTestData;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowAutomation.Acutis.StepDefinitions
{
    [Binding]
    public class MenuNavigateStepDefinitions
    {

        private readonly AcutisLoginPage loginPage;
        private readonly UserDetailsPage userPage;
        private readonly MenuNavigationPage navigationPage;
        private readonly AcutisJsonDataObjects testData;

        public MenuNavigateStepDefinitions(IWebDriver driver)
        {
            this.loginPage = new AcutisLoginPage(driver);
            this.userPage = new UserDetailsPage(driver);
            this.navigationPage = new MenuNavigationPage(driver);
            testData = (AcutisJsonDataObjects)JsonDataReader.GetJsonData("Acutis");
        }

        [Given(@"Launch the application with valid user credentials '([^']*)' and '([^']*)' and the '([^']*)'")]
        public void GivenLaunchTheApplicationWithValidUserCredentialsAndAndThe(string uRL, string userName, string password)
        {
            if (testData.Login != null)
                loginPage.LoginProcess(testData.Login);
        }

        [Then(@"Navigate to all the School Menu Pages")]
        public void ThenNavigateToAllTheSchoolMenuPages()
        {
            navigationPage.NavigateToSchoolMenuPages();
        }

        [Then(@"Navigate to all the Dioceses Menu Pages")]
        public void ThenNavigateToAllTheDiocesesMenuPages()
        {
            throw new PendingStepException();
        }

        [Then(@"Navigate to all the Ticket Menu Pages")]
        public void ThenNavigateToAllTheTicketMenuPages()
        {
            navigationPage.NavigateToTicketMenuPages();
        }

        [Then(@"Navigate to Add Tickets to the process")]
        public void ThenNavigateToAddTicketsToTheProcess()
        {
            throw new PendingStepException();
        }

        [Then(@"Navigate to all the Administration Menu Pages")]
        public void ThenNavigateToAllTheAdministrationMenuPages()
        {
            navigationPage.NavigateToAdministrationMenuPages();
        }

        [Then(@"Navigate to all the Support Menu Pages")]
        public void ThenNavigateToAllTheSupportMenuPages()
        {
            navigationPage.NavigateToSupportMenuPages();
        }

        [Then(@"Navigate to all the Report Menu Pages")]
        public void ThenNavigateToAllTheReportMenuPages()
        {
            navigationPage.NavigateToReportMenuPages();
        }

        [Then(@"Navigate to all the Comment Menu Pages")]
        public void ThenNavigateToAllTheCommentMenuPages()
        {
            navigationPage.NavigateToCommentsMenuPages();
        }

        [Then(@"Navigate to all the Saint of the Day Menu Pages")]
        public void ThenNavigateToAllTheSaintOfTheDayMenuPages()
        {
            navigationPage.NavigateToSaintoftheDayMenuPages();
        }

        [Then(@"Navigate to all the Data Import Menu Pages")]
        public void ThenNavigateToAllTheDataImportMenuPages()
        {
          
            navigationPage.NavigateToDataImportMenuPages();
        }

        [Then(@"Navigate to User Details to the process")]
        public void ThenNavigateToUserDetailsToTheProcess()
        {
            userPage.UserDetailsProcess();
        }

        [Then(@"Navigate to Customer Directory to the process")]
        public void ThenNavigateToCustomerDirectoryToTheProcess()
        {
            throw new PendingStepException();
        }

        [Then(@"Navigate to School WorkLoad to the process")]
        public void ThenNavigateToSchoolWorkLoadToTheProcess()
        {
            throw new PendingStepException();
        }

        [Then(@"User should be able to logout from the application")]
        public void ThenUserShouldBeAbleToLogoutFromTheApplication()
        {
            navigationPage.NavigateToLogoutMenuPages();
        }
    }
}
