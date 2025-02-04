using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Config;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESchool.Automation.UI.Support
{
    public class ExtentReport
    {
        public static ExtentReports extentReports;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;
        public static ExtentTest test;

        public static string dirpath= Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        
        public static void ExtentReportInit()
        {
            var htmlReport = new ExtentSparkReporter(dirpath+ @"\ExtentReport\EZone.html");
            htmlReport.Config.ReportName = "ESchoolZone Automation Report";
            htmlReport.Config.DocumentTitle = "ESchoolZone Automation Status Report";
            htmlReport.Config.Theme =Theme.Standard;

            extentReports = new ExtentReports();
            extentReports.AttachReporter(htmlReport);
            extentReports.AddSystemInfo("Application","EScoolZone");
            extentReports.AddSystemInfo("Browser", "Chrome");
            extentReports.AddSystemInfo("Environment", "Testing QA");
            extentReports.AddSystemInfo("OS", "Windows");

        }

        public static void ExtentReprtTearDown()
        {
            extentReports.Flush();
        }

        public string addScreenShot(IWebDriver driver, ScenarioContext scenariocontext)
        {
            ITakesScreenshot takesScreenshot=(ITakesScreenshot)driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string screenshotlocation = Path.Combine(dirpath + @"\ExtentReport\" + scenariocontext.ScenarioInfo.Title + ".png");
            screenshot.SaveAsFile(screenshotlocation);

            return screenshotlocation;
        }
    }
}
