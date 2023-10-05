using OpenQA.Selenium;
using SpecFlowAutomation.Framework.AcutisPages;
using SpecFlowAutomation.Framework.AcutisPages.Administration;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowAutomation.Acutis.StepDefinitions.Administration
{
    [Binding]
    public class UserDetailStepDefinitions
    {


        private readonly UserDetailsPage userDetails;

        public UserDetailStepDefinitions(IWebDriver driver)
        {
            userDetails = new UserDetailsPage(driver);
        }


        [When(@"Click on Administration menu and selct User Detail Sub menu")]
        public void WhenClickOnAdministrationMenuAndSelctUserDetailSubMenu()
        {
            userDetails.ClickOnUserDetails();
        }

        [When(@"UserDetail page should be opened and click on Addnewuser button")]
        public void WhenUserDetailPageShouldBeOpenedAndClickOnAddnewuserButton()
        {
            userDetails.ClickOnAddUser();
            userDetails.ClickOnCancel();
            userDetails.ClickOnAddUser();
        }

        [When(@"New user page should be opened and enter the basic info of FirstName, LastName, Username and password and user typen")]
        public void WhenNewUserPageShouldBeOpenedAndEnterTheBasicInfoOfFirstNameLastNameUsernameAndPasswordAndUserTypen()
        {
            userDetails.EnterUserDetails(userDetails.jsonData.UserDetails.FirstName, userDetails.jsonData.UserDetails.LastName, userDetails.jsonData.UserDetails.UserName, userDetails.jsonData.UserDetails.Password);

        }

        [When(@"click on save button and the record should be saved")]
        public void WhenClickOnSaveButtonAndTheRecordShouldBeSaved()
        {
            userDetails.ClickOnSave();
        }

        [When(@"Search Username and Click on Edit button and update the fields EditFirstName and EditLastName and click on save button")]
        public void WhenSearchUsernameAndClickOnEditButtonAndUpdateTheFieldsEditFirstNameAndEditLastNameAndClickOnSaveButton()
        {
            userDetails.GridSearch(userDetails.jsonData.UserDetails.UserName);
            userDetails.ClickOnEdit();
            userDetails.EditUserDetails(userDetails.jsonData.UserDetails.EditFirstName, userDetails.jsonData.UserDetails.EditLastName);
            userDetails.ClickOnSave();
        }

        [When(@"Search Username and Click on Delete Button")]
        public void WhenSearchUsernameAndClickOnDeleteButton()
        {
            //userDetails.GridSearch(userDetails.jsonData.UserDetails.UserName);
            userDetails.ClickOnDelete();

        }

        [Then(@"Delete Alert Confirm box should open and Click on the No button")]
        public void ThenDeleteAlertConfirmBoxShouldOpenAndClickOnTheNoButton()
        {
            userDetails.ClickDeleteConfirmNo();
        }

        [Then(@"Search Username and Click on Delete Button to delete the records")]
        public void ThenSearchUsernameAndClickOnDeleteButtonToDeleteTheRecords()
        {
            //userDetails.GridSearch(userDetails.jsonData.UserDetails.UserName);
            userDetails.ClickOnDelete();
        }

        [Then(@"Delete Alert Confirm Box should open and Click on the Yes button")]
        public void ThenDeleteAlertConfirmBoxShouldOpenAndClickOnTheYesButton()
        {
            userDetails.ClickDeleteConfirmYes();

        }
    }
}
