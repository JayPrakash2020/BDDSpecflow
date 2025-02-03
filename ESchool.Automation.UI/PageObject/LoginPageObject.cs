using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTW.Autoamtion.Core.UI.Utility;

namespace ESchool.Automation.UI.PageObject
{
    public class LoginPageObject:UIHelper
    {
        private IWebDriver driver;
        private string loginuserxpaht = "//input[@id='email']";
        private string passwordxpath = "//input[@id='password']";
        private string loginbtnxpath = "//button[@id='submit']";
        private string dasboardheaderxpath = "//h1[contains(text(),'Home')]";
        public LoginPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        UIHelper helper = new UIHelper();
        public void EnterUserName(string username)
        {
            driver.FindElement(By.XPath(loginuserxpaht)).SendKeys(username);
           // helper.SetText(loginuserxpaht, username);
        }
        public void EnterPassword(string password)
        {
            driver.FindElement(By.XPath(passwordxpath)).SendKeys(password);
            // helper.SetText(passwordxpath, password);
        }
        public void ClickonLogin()
        {
            driver.FindElement(By.XPath(loginbtnxpath)).Click();
            // helper.ClickOnElement(loginbtnxpath);
        }
        public void VerifyHeaderText()
        {
           Console.WriteLine( driver.FindElement(By.XPath(dasboardheaderxpath)).Text);
            ///Console.WriteLine(helper.GetText(dasboardheaderxpath));
        }
    }
}
