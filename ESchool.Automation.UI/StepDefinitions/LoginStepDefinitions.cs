using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace ESchool.Automation.UI.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private IWebDriver driver;
        private IWebElement ele;


        public LoginStepDefinitions(IWebDriver _driver)
        {
            driver = _driver;
        }

        [Given(@"I am navigated to Login Page")]
        public void GivenIAmNavigatedToLoginPage()
        {
            Console.WriteLine("I am on Login Page");
            driver.Navigate().GoToUrl("https://eschoolzone.udeshatechnology.com/login");
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);   
        }

        [When(@"I enter Username")]
        public void WhenIEnterUsername()
        {
            ele = driver.FindElement(By.XPath("//input[@id='email']"));
            ele.SendKeys("admin");
            Thread.Sleep(2000);
        }

        [When(@"I enter Password")]
        public void WhenIEnterPassword()
        {
            ele = driver.FindElement(By.XPath("//input[@id='password']"));
            ele.SendKeys("codeastro.com");
            Thread.Sleep(2000);
        }

        [When(@"I click on Login Button")]
        public void WhenIClickOnLoginButton()
        {
            ele = driver.FindElement(By.XPath("//button[@id='submit']"));
            ele.Click();
            Thread.Sleep(2000); 
        }

        [Then(@"I am redirectd to Admin Dashboard")]
        public void ThenIAmRedirectdToAdminDashboard()
        {
            ele = driver.FindElement(By.XPath("//h1[contains(text(),'Home')]"));
            string getheader = ele.Text;
            Console.WriteLine("Dashboard Header Value is " + getheader);
            Thread.Sleep(2000);
        }
    }
}
