using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowAutomation.Framework.JsonTestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpecFlowAutomation.Framework.AcutisPages.AcutisCommonVariable;
using static SpecFlowAutomation.Framework.CommonVariable;

namespace SpecFlowAutomation.Framework.AcutisPages
{
  
    public class AcutisLoginPage : BasePageObject
    {
        public AcutisLoginPage(IWebDriver webDriver) : base(webDriver) { }

        public void SendLoginCredential(string Username, string Password)
        {
            FindElementById(XPath_Login.username, Username);
            FindElementById(XPath_Login.password, Password);

        }
        public void ClickOnLogin()
        {
            FindElementById(XPath_Button.Login);
            Thread.Sleep(1000);
        }
        public void ClickOnLogout()
        {
            FindElementById(XPath_Menus.liLogout);
        }

        public void CheckTitle()
        {
            string ss = _webDriver.FindElement(By.XPath("//*[@id='tblheader']")).Text; //FindElementByXPath("//*[@id='tblheader']","", "Text");
            Assert.AreEqual("TICKET STATISTICS", ss.ToString().Trim());
        }

        public void LoginProcess(JsonLogin jsonLogin)
        {
            OpenWebDriver(jsonLogin.URL);
            FindElementById(XPath_Login.username, jsonLogin.UserName);
            FindElementById(XPath_Login.password, jsonLogin.Password);
            FindElementById(XPath_Button.Login);

        }



    }

}
