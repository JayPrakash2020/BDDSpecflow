using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ESchool.Automation.UI.Support
{
    [Binding]
    public sealed class GlobalHooks : ExtentReport
    {
        private readonly IObjectContainer _container;
        public GlobalHooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Running Before Test Run...");
            ExtentReportInit();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("Running After Test Run...");
            ExtentReprtTearDown();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featurecontext)
        {
            Console.WriteLine("Running Before Feature...");
            _feature = extentReports.CreateTest<Feature>(featurecontext.FeatureInfo.Title);

        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("Running after feature ...");
        }

        [BeforeScenario("@utw")]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("I am running for Login COde");
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario(ScenarioContext scenariocontext)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _container.RegisterInstanceAs<IWebDriver>(driver);

            _scenario = _feature.CreateNode<Scenario>(scenariocontext.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();
            if (driver != null)
            {
                driver.Quit();
            }
        }

        [AfterStep]
        public void AfterStep(ScenarioContext scenariocontext)
        {
            Console.WriteLine("Running After Scenario");

            string stepType = scenariocontext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepName = scenariocontext.StepContext.StepInfo.Text;

            var driver = _container.Resolve<IWebDriver>();

            if (scenariocontext.TestError == null) // when scenario passed
            {
                if (stepType == "Given")
                {
                    _scenario.CreateNode<Given>(stepName);
                }
                else if (stepType == "When")
                {
                    _scenario.CreateNode<When>(stepName);
                }
                else if (stepType == "Then")
                {
                    _scenario.CreateNode<Then>(stepName);
                }
                else if (stepType == "And")
                {
                    _scenario.CreateNode<And>(stepName);
                }
            }
            // when scenario fails
            if(scenariocontext.TestError!=null)
            {
                if (stepType == "Given")
                {
                    _scenario.CreateNode<Given>(stepName).Fail(scenariocontext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenShot(driver,scenariocontext)).Build());
                }
                else if (stepType == "When")
                {
                    _scenario.CreateNode<When>(stepName).Fail(scenariocontext.TestError.Message,MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenShot(driver, scenariocontext)).Build());
                }
                else if (stepType == "Then")
                {
                    _scenario.CreateNode<Then>(stepName).Fail(scenariocontext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenShot(driver, scenariocontext)).Build());
                }
                else if (stepType == "And")
                {
                    _scenario.CreateNode<And>(stepName).Fail(scenariocontext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenShot(driver, scenariocontext)).Build());
                }
            }
        }
    }
}