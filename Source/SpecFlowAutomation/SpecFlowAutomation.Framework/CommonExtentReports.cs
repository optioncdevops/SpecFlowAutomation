using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports;
using BoDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpecFlowAutomation.Framework.CommonVariable;
using TechTalk.SpecFlow;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;

namespace SpecFlowAutomation.Framework
{
    public static class CommonExtentReports
    {

        private static ExtentTest featureName;
        public static ExtentTest scenario;

        static AventStack.ExtentReports.ExtentReports extent;

        static string reportpath = System.IO.Directory.GetParent(@"../../../").FullName
             + Path.DirectorySeparatorChar + "Result"
             + Path.DirectorySeparatorChar + "Result_" + DateTime.Now.ToString("ddmmyyyyHHmmss");


        public static void BeforeTestRun()
        {
            //Create dynamic feature name
            ExtentHtmlReporter htmlReport = new ExtentHtmlReporter(reportpath);
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlReport);



        }
        public static void BeforeFeature()
        {
            //Create dynamic feature name
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);

        }

        public static void BeforeScenario(IObjectContainer container)
        {
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            // the IWebDriver interface

            // Chrome Driver  Checking  
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            ChromeDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(60));
            container.RegisterInstanceAs<IWebDriver>(driver);


            //// Firefox Driver Checking  
            //FirefoxDriver firefoxDriver = new FirefoxDriver();
            //firefoxDriver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(60));
            //container.RegisterInstanceAs<IWebDriver>(firefoxDriver);

            //container.RegisterInstanceAs<ITestDataService>;


            // Firefox Driver Checking  
            EdgeDriver edgeDriver = new EdgeDriver();
            edgeDriver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(60));
            container.RegisterInstanceAs<IWebDriver>(edgeDriver);


        }

        public static void AfterStep(IObjectContainer container)
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null)
            {

                IWebDriver driver = container.Resolve<IWebDriver>();

                var scenarioContext = container.Resolve<ScenarioContext>();
                var featureTitle = container.Resolve<FeatureContext>().FeatureInfo.Title;
                string scenarioId = Guid.NewGuid().ToString();

                if (!Directory.Exists(Path.Combine(Path.Combine(Environment.CurrentDirectory, DefaultValue.ScreenShots))))
                    Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, DefaultValue.ScreenShots));
                try
                {
                    var ss = ((ITakesScreenshot)driver).GetScreenshot();
                    ss.SaveAsFile(Path.Combine(Environment.CurrentDirectory, DefaultValue.ScreenShots, featureTitle + "-" + scenarioId + DefaultValue.ScreenShotFormat), ScreenshotImageFormat.Png);
                }
                catch (Exception e)
                {
                    e.GetBaseException();
                }



                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if (stepType == "When")
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if (stepType == "And")
                {
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
            }

        }

        public static void AfterScenario(IObjectContainer container)
        {
            IWebDriver driver = container.Resolve<IWebDriver>();
            try
            {
                driver.Close();
                driver.Dispose();
            }
            catch (Exception e)
            {
                e.GetBaseException();
            }
        }

        public static void AfterFeature()
        {
            extent.Flush();

        }

        public static void AfterTestRun()
        {
            try
            {
                Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");
                foreach (var chromeDriverProcess in chromeDriverProcesses)
                {
                    chromeDriverProcess.Kill();
                }

                //Process[] FirefoxDriverProcesses = Process.GetProcessesByName("firefoxdriver");
                //foreach (var process in FirefoxDriverProcesses)
                //{
                //    process.Kill();
                //}
            }
            catch (Exception)
            {

            }
        }
    }


}
