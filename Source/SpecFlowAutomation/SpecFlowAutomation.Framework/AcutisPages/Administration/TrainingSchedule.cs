using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static SpecFlowAutomation.Framework.AcutisPages.AcutisCommonVariable;

namespace SpecFlowAutomation.Framework.AcutisPages.Administration
{
    public class TrainingSchedule : BasePageObject
    {
        public TrainingSchedule(IWebDriver webDriver) : base(webDriver)
        {
        }
        public void ClickOnTrainingSchedule()
        {
            FindElementById(XPath_Menus.liAdministration);
            FindElementById(XPath_Menus.liTrainingSchedule);
        }
        public void ClickOnAddTrainingSchedule()
        {
            FindElementByXPath(XPath_TrainingSchedule.btnAddTrainingSchedule);
            Thread.Sleep(1000);
        }
        public void EnterTrainingSchedule(string txtname,string txtduration,string txtdescription,string txturl)
        {
            FindElementById(XPath_TrainingSchedule.txtname,txtname);
            FindElementById(XPath_TrainingSchedule.txtduration, txtduration);
            FindElementById(XPath_TrainingSchedule.txtDescription, txtdescription);
            FindElementById(XPath_TrainingSchedule.txturl, txturl);
            FindElementById(XPath_TrainingSchedule.ddltriner,"1",CommonVariable.DefaultValue.Select);
        }
        public void EditTrainingSchedule(string txtname)
        {
            FindElementById(XPath_TrainingSchedule.txtname, txtname);
        }
        public void TrainingScheduleProcess()
        {
            ClickOnTrainingSchedule();
            ClickOnAddTrainingSchedule();
            EnterTrainingSchedule("sample training","2","sample description","https://sampleurl.com");
            ClickOnSave();
            Thread.Sleep(2000);
            GridSearch("sample training");
            ClickOnEdit();
            EditTrainingSchedule("edit training schedule");
            ClickOnSave();
            GridSearch("edit training schedule");
            ClickOnDelete();
            ClickDeleteConfirmNo();
            ClickOnDelete();
            ClickDeleteConfirmYes();
            Thread.Sleep(3000);
        }
        public void logout()
        {
            FindElementById(XPath_Menus.liLogout);
        }
    }
}
