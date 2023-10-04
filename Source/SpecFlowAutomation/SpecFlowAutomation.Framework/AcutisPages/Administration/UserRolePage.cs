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
    public class UserRolePage : BasePageObject
    {
        public UserRolePage(IWebDriver webDriver) : base(webDriver) { }
        public void CheckPageTitle()
        {
            //Assert.AreEqual("Customer Directory", ReadElementValuesByXPath("//*[text()='Customer Directory']")); 
        }
        public void ClickOnUserRole()
        {
            FindElementById(XPath_Menus.liAdministration);
            FindElementById(XPath_Menus.liUserRole);
        }
        public void ClickOnAddUserRole()
        {
            FindElementById(XPath_Button.btnAdd);
            Thread.Sleep(1000);
        }

        public void ClickOnRoleCancel()
        {
            FindElementByXPath(XPath_UserRole.btnRoleCancel);
            Thread.Sleep(1000);
        }

        public void ClickOnRoleSave()
        {
            FindElementByXPath(XPath_UserRole.btnRoleSave);
            Thread.Sleep(1000);
        }
        public void EnterUserRoleDetails(string RoleName, string Description)
        {
            FindElementById(XPath_UserRole.txtrolename, RoleName);
            FindElementById(XPath_UserRole.txtdiscription, Description);
            FindElementById(XPath_UserRole.ddllandingpage, "Tickets", "Select");
        }

        public void EditUserRoleDetails(string EditRoleName)
        {
            FindElementById(XPath_UserRole.txtrolename, EditRoleName);
        }
        public void UserRoleProcess()
        {
            ClickOnUserRole();
            ClickOnAddUserRole();
            ClickOnCancel();
            ClickOnAdd();
            EnterUserRoleDetails("TestRole", "Test Description");
            ClickOnSave();
            GridSearch("TestRole");
            ClickOnEdit();
            EditUserRoleDetails("TestRole Edit");
            ClickOnSave();
            ClickOnDelete();
            ClickDeleteConfirmNo();
            ClickOnDelete();
            ClickDeleteConfirmYes();
        }



    }
}
