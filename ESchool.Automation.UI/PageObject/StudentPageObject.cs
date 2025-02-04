using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTW.Autoamtion.Core.UI.Utility;

namespace ESchool.Automation.UI.PageObject
{
    public class StudentPageObject:UIHelper
    {
        private IWebDriver driver;
        private string studentXpath = "//a/span[text()='Library']";
        private string addstudentxpath = "//a[contains(text(),'Manage Library')]";
        private string btnSavexpath = "//button[contains(text(),'Add')]";
        private string libraryheaderxpath = "//h1[contains(text(),'Manage Library')]";
        private string Selectclassxpath = "//select[@id='class_id']";
        public string selectsubxpath = "//select[@name='subject_id']";
        private string bookxpath = "//input[@id='name']";
        private string authorxpath = "//input[@id='author']";
        private string publicationxpath = "//input[@id='publication']";
        public StudentPageObject(IWebDriver driver):base(driver)
        {
            //this.driver = driver;
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

      //  UIHelper helper = new UIHelper();
        public void EnterUserName(string username)
        {
           // driver.FindElement(By.XPath(loginuserxpaht)).SendKeys(username);
           //SetText(loginuserxpaht, username);
        }

        public void ClickonLibrary()
        {
            //driver.FindElement(By.XPath(studentXpath)).Click();
            ClickOnElement(studentXpath);
        }
        public void ClickonManageLibrary()
        {
            //driver.FindElement(By.XPath(addstudentxpath)).Click();
            ClickOnElement(addstudentxpath);
        }
        public string GetHeaderText()
        {
            // return driver.FindElement(By.XPath(libraryheaderxpath)).Text;
            return GetText(libraryheaderxpath);
        }

        public void SelectClass(string clsvalue)
        {
            //SelectElement ele = new SelectElement(driver.FindElement(By.XPath(Selectclassxpath)));
            //ele.SelectByText(clsvalue);
            SelectByText(Selectclassxpath,clsvalue);
        }
        public void SelectSubject()
        {
          //  SelectElement ele = new SelectElement(driver.FindElement(By.XPath(selectsubxpath)));
           // ele.SelectByText("Computer Science");
            SelectByText(selectsubxpath, "Computer Science");
        }
        public void AddBookName(string bookname)
        {
          //  driver.FindElement(By.XPath(bookxpath)).SendKeys(bookname);
            SetText(bookxpath,bookname);
        }
        public void AddAuthor(string authorname)
        {
            // driver.FindElement(By.XPath(authorxpath)).SendKeys(authorname);
            SetText(authorxpath, authorname);
        }
        public void AddPublication(string publicationame)
        {
           // driver.FindElement(By.XPath(publicationxpath)).SendKeys(publicationame);
            SetText(publicationxpath, publicationame);
        }
        public void ClickOnSaveBtn()
        {
          //  driver.FindElement(By.XPath(btnSavexpath)).Click();
            ClickOnElement(btnSavexpath);
        }
    }
}
