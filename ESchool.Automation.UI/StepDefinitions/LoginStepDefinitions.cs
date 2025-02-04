using AventStack.ExtentReports;
using ESchool.Automation.UI.PageObject;
using ESchool.Automation.UI.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace ESchool.Automation.UI.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions:ExtentReport
    {
        private IWebDriver driver;
        private IWebElement ele;
        LoginPageObject loginPageObject;

        public LoginStepDefinitions(IWebDriver _driver)
        {
            driver = _driver;
            loginPageObject = new LoginPageObject(driver);
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
            loginPageObject.EnterUserName("admin");
            Thread.Sleep(2000);
        }

        [When(@"I enter Password")]
        public void WhenIEnterPassword()
        {
            loginPageObject.EnterPassword("codeastro.com");
            Thread.Sleep(2000);
        }

        [When(@"I click on Login Button")]
        public void WhenIClickOnLoginButton()
        {
            loginPageObject.ClickonLogin();
            Thread.Sleep(2000); 
        }

        [Then(@"I am redirectd to Admin Dashboard")]
        public void ThenIAmRedirectdToAdminDashboard()
        {
            loginPageObject.VerifyHeaderText();
            Thread.Sleep(2000);
        }
    }
}
