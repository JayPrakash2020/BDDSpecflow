using ESchool.Automation.UI.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace ESchool.Automation.UI.StepDefinitions
{
    [Binding]
    public class StudentStepDefinitions
    {
        StudentPageObject studPageObject;
        private IWebDriver driver;
        public StudentStepDefinitions(IWebDriver _driver)
        {
            driver = _driver;
            studPageObject = new StudentPageObject(driver);
        }

        [When(@"I click on Library")]
        public void WhenIClickOnLibrary()
        {
            studPageObject.ClickonLibrary();
        }

        [When(@"I click on Manage Library")]
        public void WhenIClickOnManageLibrary()
        {
            studPageObject.ClickonManageLibrary();
        }

        [Then(@"I am able to see Manage Libary Page")]
        public void ThenIAmAbleToSeeManageLibaryPage()
        {
            Assert.AreEqual("Manage Library SMS",studPageObject.GetHeaderText(),"Not matched with Header");
        }

        [Then(@"I am adding student details ""([^""]*)"" ""([^""]*)"" ""([^""]*)"" ""([^""]*)""")]
        public void ThenIAmAddingStudentDetails(string classname, string bookname, string authornmae, string publication)
        {
            studPageObject.SelectClass(classname);
            Thread.Sleep(3000);
            studPageObject.SelectSubject();
            Thread.Sleep(2000);
            studPageObject.AddBookName(bookname);
            Thread.Sleep(3000);
            studPageObject.AddAuthor(authornmae);
            Thread.Sleep(3000);
            studPageObject.AddPublication(publication);
            Thread.Sleep(3000);
        }
        [When(@"I click on Save Button")]
        public void WhenIClickOnSaveButton()
        {
            studPageObject.ClickOnSaveBtn();
            Thread.Sleep(3000);
        }



    }
}
