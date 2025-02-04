using ESchool.Automation.UI.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace ESchool.Automation.UI.StepDefinitions
{
    [Binding]
    public class ParentStepDefinitions
    {
        private IWebDriver driver;
       // private IWebElement ele;
        ParentsPageObject parentPage;

        public ParentStepDefinitions(IWebDriver _driver)
        {
            driver = _driver;
            parentPage = new ParentsPageObject(driver);
        }
        [When(@"I click on ""([^""]*)""")]
        public void WhenIClickOn(string tabname)
        {
            Console.WriteLine("Clcik on  " + tabname);
            parentPage.ClickOnMainMenu(tabname);
        }

        [When(@"I click on ""([^""]*)"" sub menu")]
        public void WhenIClick(string subtabname)
        {
            Console.WriteLine("Clcik on  " + subtabname);
            parentPage.ClickOnSubMenu(subtabname);
        }

        [Then(@"I am able to see ""([^""]*)"" Page")]
        public void ThenIAmAbleToSeePage(string headername)
        {
            Console.WriteLine("Clcik on  " + headername);
            parentPage.VerifyHeader(headername);
        }

        [Then(@"I am adding parents details '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)'")]
        public void ThenIAmAddingParentsDetails(string fullname, string username, string email, string dob, string address, string contactno, string gender)
        {
            Console.WriteLine(fullname + username + email +dob+ address+ contactno +gender);
            parentPage.AddParentDetails(fullname , username , email , dob , address , contactno , gender);
        }
        [When(@"I click on ""([^""]*)"" button")]
        public void WhenIClickOnButton(string btntext)
        {
            parentPage.ClickOnParentButton(btntext);
        }

    }
}
