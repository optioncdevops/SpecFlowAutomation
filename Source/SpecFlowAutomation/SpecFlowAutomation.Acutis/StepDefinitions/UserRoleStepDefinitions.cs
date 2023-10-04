using OpenQA.Selenium;
using SpecFlowAutomation.Framework.AcutisPages.Administration;
using SpecFlowAutomation.Framework.JsonTestData;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowAutomation.Acutis.StepDefinitions
{
    [Binding]
    public class UserRoleStepDefinitions
    {
        private readonly UserRolePage userRolePage;

        public UserRoleStepDefinitions(IWebDriver driver)
        {
            this.userRolePage = new UserRolePage(driver);
        }



        [When(@"Click on Administration menu and selct User Role Sub menu")]
        public void WhenClickOnAdministrationMenuAndSelctUserRoleSubMenu()
        {
            userRolePage.ClickOnUserRole();
        }

        [When(@"User Role page should be opened and click on Addnewrole button")]
        public void WhenUserRolePageShouldBeOpenedAndClickOnAddnewroleButton()
        {
            userRolePage.ClickOnAddUserRole();
        }

        [When(@"Click on Role Cancel button")]
        public void WhenClickOnRoleCancelButton()
        {
            userRolePage.ClickOnRoleCancel();
        }

        [When(@"New user role page should be opened and enter the basic info of User Role Name and Description")]
        public void WhenNewUserRolePageShouldBeOpenedAndEnterTheBasicInfoOfUserRoleNameAndDescription()
        {
            userRolePage.EnterUserRoleDetails(Description: userRolePage.jsonData.UserRole.Description, RoleName: userRolePage.jsonData.UserRole.RoleName);
        }
        [When(@"click on Role save button and the record should be saved")]
        public void WhenClickOnRoleSaveButtonAndTheRecordShouldBeSaved()
        {
            userRolePage.ClickOnRoleSave();
        }

        [When(@"Search User Role Name and Click on Edit button and update the fields Edit User Role Name  and  click on save button")]
        public void WhenSearchUserRoleNameAndClickOnEditButtonAndUpdateTheFieldsEditUserRoleNameAndClickOnSaveButton()
        {
            userRolePage.GridSearch(userRolePage.jsonData.UserRole.RoleName);
            userRolePage.ClickOnEdit();
            userRolePage.EditUserRoleDetails(userRolePage.jsonData.UserRole.RoleName);
            userRolePage.ClickOnRoleSave();
        }
        [When(@"Click on Delete Button to delete the records")]
        public void WhenClickOnDeleteButtonToDeleteTheRecords()
        {
            userRolePage.ClickOnDelete();
        }

        [Then(@"Click on Delete Button to delete the records")]
        public void ThenClickOnDeleteButtonToDeleteTheRecords()
        {
            userRolePage.ClickOnDelete();
        }
    }
}
