using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpecFlowAutomation.Framework.CommonVariable;

namespace SpecFlowAutomation.Framework
{
    public class BasePageObject
    {
        protected readonly IWebDriver _webDriver;
        protected readonly IWait<IWebDriver> _wait;
        protected readonly int iWebDriverType = 1; // 1 - IWebDriver and  2 - IWait

        protected BasePageObject(IWebDriver webDriver)
        {
            PageFactory.InitElements(webDriver, this);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);
            _wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(300));
            _webDriver = webDriver;
        }

        public void OpenWebDriver(string url)
        {
            if (iWebDriverType == 1)
            {
                _webDriver.Navigate().GoToUrl(url);
                _webDriver.Manage().Window.Maximize();
            }
            else
            {
                _webDriver.Navigate().GoToUrl(url);
                _webDriver.Manage().Window.Maximize();
            }
        }

        #region   Commom Methods

        //Common method for converting the given date into MM/DD/YYYY format
        public string GetDateFormat(string sDate = "")
        {
            DateTime Date = Convert.ToDateTime(sDate);
            string currentDate = "";
            if (sDate.Equals("") || sDate.Equals(null))
            {
                currentDate = DateTime.Today.ToString("MM/dd/yyyy");
            }
            else
            {
                currentDate = Date.ToString("MM/dd/yyyy");
            }
            return currentDate;
        }

        //Common method for converting the given time into HH:MM TT format
        public string GetTimeFormat(string sTime = "")
        {
            DateTime Time = Convert.ToDateTime(sTime);
            string currentTime = "";
            if (sTime.Equals("") || sTime.Equals(null))
            {
                currentTime = DateTime.Now.ToString("hh:mm tt");
            }
            else
            {
                currentTime = Time.ToString("hh:mm tt");
            }
            return currentTime;
        }

        #endregion

        #region Find the Element By Id 

        /// <summary>
        ///  This method used to get the id from the active page and click the controls
        /// </summary>
        /// <param name="ID"> send the control id</param>
        public void FindElementById(string Id)
        {
            FindElementById(Id, "", "");
        }

        /// <summary>
        /// This method used to get the id from the active page and bind the value is passed
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Value"></param>
        public void FindElementById(string Id, string Value = "")
        {
            FindElementById(Id, Value, "SendKey");
        }

        /// <summary>
        /// This method used to get the id from the active page and bind the value is passed and then action to be performed
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Value"></param>
        /// <param name="Action"></param>
        public string FindElementById(string Id, string Value, string Action)
        {
            string ReturnValues = "";
            new CommonErrorLog().WriteLog(Id, Value, Action, 1);
            if (iWebDriverType == 1)
            {
                if (Action == "SendKey")
                {
                    _webDriver.FindElement(By.Id(Id)).Clear();
                    _webDriver.FindElement(By.Id(Id)).SendKeys(Value);
                }
                else if (Action == "Text")
                {
                    ReturnValues = _webDriver.FindElement(By.Id(Id)).Text;
                }
                else if (Action == "FileUpload")
                {
                    // Approach 01 : sendKeys
                    _webDriver.FindElement(By.Id(Id)).SendKeys(Value);

                    //// Approach 02 : AutoItX3 
                    //_webDriver.FindElement(By.Id(Id)).Click();
                    //AutoItX3 autoItX3 = new AutoItX3();
                    //autoItX3.WinActivate("Open");
                    //autoItX3.Send(Value);
                    //autoItX3.Send("ENTER");

                }
                else if (Action == "Date")
                {
                    _webDriver.FindElement(By.Id(Id)).Clear();
                    _webDriver.FindElement(By.Id(Id)).SendKeys(GetDateFormat(Value));
                }
                else if (Action == "Time")
                {
                    _webDriver.FindElement(By.Id(Id)).Clear();
                    _webDriver.FindElement(By.Id(Id)).SendKeys(GetTimeFormat(Value));
                }
                else if (Action == "Clear")
                {
                    _webDriver.FindElement(By.Id(Id)).Clear();
                }
                else if (Action == "MultiSelect")
                {
                    string[] valueList = Value.Split(',');
                    for (int count = 0; count < valueList.Length; ++count)
                    {
                        new SelectElement(_webDriver.FindElement(By.Id(Id))).SelectByValue(valueList[count]);
                    }
                }
                else if (Action == "Select")
                {
                    new SelectElement(_webDriver.FindElement(By.Id(Id))).SelectByValue(Value);
                }
                else
                    _webDriver.FindElement(By.Id(Id)).Click();
            }
            else
            {
                if (Action == "SendKey")
                {
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Id(Id))).Clear();
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Id(Id))).SendKeys(Value);
                }
                else if (Action == "Text")
                {
                    ReturnValues = _wait.Until(ExpectedConditions.ElementIsVisible(By.Id(Id))).Text;
                }
                else if (Action == "FileUpload")
                {
                    // Approach 01 : sendKeys 
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Id(Id))).SendKeys(Value);


                    // Approach 02 : AutoItX3 
                    //_wait.Until(ExpectedConditions.ElementIsVisible(By.Id(Id))).Click();
                    //AutoItX3 autoItX3 = new AutoItX3();
                    //autoItX3.WinActivate("Open");
                    //autoItX3.Send(Value);
                    //autoItX3.Send("ENTER");

                }
                else if (Action == "Date")
                {
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Id(Id))).Clear();
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Id(Id))).SendKeys(GetDateFormat(Value));
                }
                else if (Action == "Time")
                {
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Id(Id))).Clear();
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Id(Id))).SendKeys(GetTimeFormat(Value));
                }
                else if (Action == "Clear")
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Id(Id))).Clear();
                else if (Action == "MultiSelect")
                {
                    string[] valueList = Value.Split(',');
                    for (int count = 0; count < valueList.Length; ++count)
                    {
                        new SelectElement(_wait.Until(ExpectedConditions.ElementIsVisible(By.Id(Id)))).SelectByValue(valueList[count]);
                    }
                }
                else if (Action == "Select")
                    new SelectElement(_wait.Until(ExpectedConditions.ElementIsVisible(By.Id(Id)))).SelectByValue(Value);
                else
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Id(Id))).Click();

            }

            Thread.Sleep(1000);
            return ReturnValues;
        }


        #endregion

        #region Find the Element By Name 


        /// <summary>
        ///  This method used to get the id from the active page and click the controls
        /// </summary>
        /// <param name="Id"> send the control id</param>
        public void FindElementByName(string Name)
        {
            FindElementByName(Name, "", "");
        }

        /// <summary>
        /// This method used to get the id from the active page and bind the value is passed
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Value"></param>
        public void FindElementByName(string Name, string Value = "")
        {
            FindElementByName(Name, Value, "SendKey");
        }

        /// <summary>
        /// This method used to get the id from the active page and bind the value is passed and then action to be performed
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Value"></param>
        /// <param name="Action"></param>
        public string FindElementByName(string Name, string Value, string Action)
        {
            string ReturnValues = "";
            new CommonErrorLog().WriteLog(Name, Value, Action, 1);
            if (iWebDriverType == 1)
            {
                if (Action == "SendKey")
                {
                    _webDriver.FindElement(By.Name(Name)).Clear();
                    _webDriver.FindElement(By.Name(Name)).SendKeys(Value);
                }
                else if (Action == "Text")
                {
                    ReturnValues = _webDriver.FindElement(By.Id(Name)).Text;
                }
                else if (Action == "Date")
                {
                    _webDriver.FindElement(By.Name(Name)).Clear();
                    _webDriver.FindElement(By.Name(Name)).SendKeys(GetDateFormat(Value));
                }
                else if (Action == "Time")
                {
                    _webDriver.FindElement(By.Name(Name)).Clear();
                    _webDriver.FindElement(By.Name(Name)).SendKeys(GetTimeFormat(Value));
                }
                else if (Action == "Clear")
                    _webDriver.FindElement(By.Name(Name)).Clear();
                else if (Action == "MultiSelect")
                {
                    string[] valueList = Value.Split(',');
                    for (int count = 0; count < valueList.Length; ++count)
                    {
                        new SelectElement(_webDriver.FindElement(By.Name(Name))).SelectByValue(valueList[count]);
                    }
                }
                else if (Action == "Select")
                    new SelectElement(_webDriver.FindElement(By.Name(Name))).SelectByValue(Value);
                else
                    _webDriver.FindElement(By.Name(Name)).Click();
            }
            else
            {
                if (Action == "SendKey")
                {
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Name(Name))).Clear();
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Name(Name))).SendKeys(Value);
                }
                else if (Action == "Text")
                {
                    ReturnValues = _wait.Until(ExpectedConditions.ElementIsVisible(By.Name(Name))).Text;
                }
                else if (Action == "Date")
                {
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Name(Name))).Clear();
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Name(Name))).SendKeys(GetDateFormat(Value));
                }
                else if (Action == "Time")
                {
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Name(Name))).Clear();
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Name(Name))).SendKeys(GetTimeFormat(Value));
                }
                else if (Action == "Clear")
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Name(Name))).Clear();
                else if (Action == "MultiSelect")
                {
                    string[] valueList = Value.Split(',');
                    for (int count = 0; count < valueList.Length; ++count)
                    {
                        new SelectElement(_wait.Until(ExpectedConditions.ElementIsVisible(By.Name(Name)))).SelectByValue(valueList[count]);
                    }
                }
                else if (Action == "Select")
                    new SelectElement(_wait.Until(ExpectedConditions.ElementIsVisible(By.Name(Name)))).SelectByValue(Value);
                else
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.Name(Name))).Click();

            }

            return ReturnValues;
        }

        #endregion

        #region Find the Element By XPath 


        /// <summary>
        ///  This method used to get the id from the active page and click the controls
        /// </summary>
        /// <param name="ID"> send the control id</param>
        public void FindElementByXPath(string XPath)
        {
            FindElementByXPath(XPath, "", "");
        }

        /// <summary>
        /// This method used to get the id from the active page and bind the value is passed
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Value"></param>
        public void FindElementByXPath(string XPath, string Value = "")
        {
            FindElementByXPath(XPath, Value, "SendKey");
        }

        /// <summary>
        /// This method used to get the id from the active page and bind the value is passed and then action to be performed
        /// </summary>
        /// <param name="XPath"></param>
        /// <param name="Value"></param>
        /// <param name="Action"></param>
        public string FindElementByXPath(string XPath, string Value, string Action)
        {
            string ReturnValues = "";
            new CommonErrorLog().WriteLog(XPath, Value, Action, 1);
            if (iWebDriverType == 1)
            {
                if (Action == "SendKey")
                {
                    _webDriver.FindElement(By.XPath(XPath)).Clear();
                    _webDriver.FindElement(By.XPath(XPath)).SendKeys(Value);
                }
                else if (Action == "Text")
                {
                    ReturnValues = _webDriver.FindElement(By.XPath(XPath)).Text;
                }
                else if (Action == "Date")
                {
                    _webDriver.FindElement(By.XPath(XPath)).Clear();
                    _webDriver.FindElement(By.XPath(XPath)).SendKeys(GetDateFormat(Value));
                }
                else if (Action == "Time")
                {
                    _webDriver.FindElement(By.XPath(XPath)).Clear();
                    _webDriver.FindElement(By.XPath(XPath)).SendKeys(GetTimeFormat(Value));
                }
                else if (Action == "Clear")
                    _webDriver.FindElement(By.XPath(XPath)).Clear();
                else if (Action == "MultiSelect")
                {
                    string[] valueList = Value.Split(',');
                    for (int count = 0; count < valueList.Length; ++count)
                    {
                        new SelectElement(_webDriver.FindElement(By.XPath(XPath))).SelectByValue(valueList[count]);
                    }
                }
                else if (Action == "Enter")
                {
                    _webDriver.FindElement(By.XPath(XPath)).SendKeys(Keys.Enter);
                    _webDriver.FindElement(By.XPath(XPath)).SendKeys(Keys.Tab);
                }
                else if (Action == "Dropdown")
                {
                    _webDriver.FindElement(By.XPath(XPath)).SendKeys(Value);
                    _webDriver.FindElement(By.XPath(XPath)).SendKeys(Keys.Enter);
                    _webDriver.FindElement(By.XPath(XPath)).SendKeys(Keys.Tab);
                }

                else if (Action == "Select")
                    new SelectElement(_webDriver.FindElement(By.XPath(XPath))).SelectByValue(Value);
                //else if (Action == "ActionClass")
                //{
                //    Actions ac = new Actions(_webDriver);

                //    //WebElement live = _webDriver.findElement(By.XPath(XPath_Button.Student));
                //    //WebElement live1 = _webDriver.findElement(By.XPath(XPath_Button.Student));
                //    ac.moveToElement(live).build().perform();

                //    Thread.sleep(3000);
                //}
                else
                    _webDriver.FindElement(By.XPath(XPath)).Click();
            }
            else
            {
                if (Action == "SendKey")
                {
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath))).Clear();
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath))).SendKeys(Value);
                }
                else if (Action == "Date")
                {
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath))).Clear();
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath))).SendKeys(GetDateFormat(Value));
                }
                else if (Action == "Time")
                {
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath))).Clear();
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath))).SendKeys(GetTimeFormat(Value));
                }
                else if (Action == "Clear")
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath))).Clear();
                else if (Action == "MultiSelect")
                {
                    string[] valueList = Value.Split(',');
                    for (int count = 0; count < valueList.Length; ++count)
                    {
                        new SelectElement(_wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath)))).SelectByValue(valueList[count]);
                    }
                }
                else if (Action == "Enter")
                {
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath))).SendKeys(Keys.Enter);
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath))).SendKeys(Keys.Tab);
                }
                else if (Action == "Dropdown")
                {
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath))).SendKeys(Value);
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath))).SendKeys(Keys.Enter);
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath))).SendKeys(Keys.Tab);
                }
                else if (Action == "Select")
                    new SelectElement(_wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath)))).SelectByValue(Value);
                else
                    _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath))).Click();

            }

            Thread.Sleep(1000);
            return ReturnValues;
        }

        #endregion

        #region Find the Element By Link Text  

        public void FindElementByLinkText(string LinkText)
        {
            if (iWebDriverType == 1)
            {
                _webDriver.FindElement(By.LinkText(LinkText)).Click();
            }
            else
            {
                _wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(LinkText))).Click();
            }
        }


        #endregion

        #region  All the Button Click Events

        public void ClickOnAdd()
        {
            FindElementById(XPath_Button.btnAddUser);
        }
        public void ClickOnSave()
        {

            FindElementById(XPath_Button.btnSave);
        }
        public void ClickOnCancel()
        {
            FindElementById(XPath_Button.btnCancel);
        }
        public void GridSearch(string SearchValue)
        {
            FindElementByXPath("//*[@class='form-control input-small input-inline']", SearchValue);
        }
        public void GridSearch(string SearchXPathKey, string SearchValue)
        {
            FindElementByXPath(SearchXPathKey, SearchValue);
        }
        public void ClickOnEdit()
        {
            FindElementById(XPath_Button.btnEdit);
            //_webDriver.FindElement(By.XPath("(//*[@id='btnEdit'][1])")).Click(); 
        }
        public void ClickOnDelete()
        {
            FindElementById(XPath_Button.btnDelete);
        }
        public void ClickDeleteConfirmNo()
        {
            Thread.Sleep(1000);
            _webDriver.FindElement(By.XPath("//button[text()='No']")).Click();
            Thread.Sleep(1000);
        }
        public void ClickDeleteConfirmYes()
        {
            Thread.Sleep(1000);
            _webDriver.FindElement(By.XPath("//button[text()='Yes']")).Click();

            Thread.Sleep(1000);
        }
        public void ClickOnUpdate()
        {
            FindElementById(XPath_Button.btnUpdate);
            //_webDriver.FindElement(By.XPath("(//*[@id='btnEdit'][1])")).Click(); 
        }
        #endregion
        
    }

}
