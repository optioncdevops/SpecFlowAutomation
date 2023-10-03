using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpecFlowAutomation.Framework.AcutisPages.AcutisCommonVariable;
using static SpecFlowAutomation.Framework.CommonVariable;

namespace SpecFlowAutomation.Framework.AcutisPages.Administration
{
    public class UserDetailsPage : BasePageObject
    {
        public UserDetailsPage(IWebDriver webDriver) : base(webDriver) { }
        public void CheckPageTitle()
        {
            //Assert.AreEqual("Customer Directory", ReadElementValuesByXPath("//*[text()='Customer Directory']")); 
        }
        public void ClickOnUserDetails()
        {
            FindElementById(XPath_Menus.liAdministration);
            FindElementById(XPath_Menus.liUserDetails);
        }
        public void ClickOnAddUser()
        {
            FindElementById(XPath_Button.btnAddUser);
            Thread.Sleep(1000);
        }
        public void EnterUserDetails(string FirstName, string LastName, string Email, string EmailPwd)
        {
            FindElementById(XPath_UserDetails.txtfirstname, FirstName);
            FindElementById(XPath_UserDetails.txtlastname, LastName);
            FindElementById(XPath_UserDetails.txtemail, Email);
            FindElementById(XPath_UserDetails.txtpassword, EmailPwd);
            FindElementById(XPath_UserDetails.rolename, "1", "Select");
        }
        public new void ClickOnSave()
        {
            FindElementById(XPath_Button.btnSave);
        }
        public new void ClickOnCancel()
        {
            FindElementById(XPath_Button.btnCancel);
        }
        public void ClickOnUserEdit()
        {
            FindElementById(XPath_Button.btnEdit);
        }
        public void ClickOnUserDelete()
        {
            FindElementById(XPath_Button.btnDelete);
        }
        public void EditUserDetails(string EditFirstName, string EditLastName)
        {
            FindElementById(XPath_UserDetails.txtfirstname, EditFirstName);
            FindElementById(XPath_UserDetails.txtlastname, EditLastName);
        }
        public void UserDetailsProcess()
        {
            ClickOnUserDetails();
            ClickOnAddUser();
            ClickOnCancel();
            ClickOnAdd();
            EnterUserDetails("HpTest", "Hp LastName", "HpTest@gmail.com", "HpTest!123");
            ClickOnSave();
            GridSearch("HpTest@gmail.com");
            ClickOnUserEdit();
            EditUserDetails("HpTest Edit", "HpTest Edit Last");
            ClickOnSave();
            ClickOnUserDelete();
            ClickDeleteConfirmNo();
            ClickOnUserDelete();
            ClickDeleteConfirmYes();
        }
    }

}
