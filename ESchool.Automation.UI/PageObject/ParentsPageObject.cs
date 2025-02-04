using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTW.Autoamtion.Core.UI.Utility;

namespace ESchool.Automation.UI.PageObject
{
    public class ParentsPageObject:UIHelper
    {
        public ParentsPageObject(IWebDriver driver):base(driver)
        {

        }

        public void ClickOnMainMenu(string menutext)
        {
            string menuxpath =$"//a//span[text()='{menutext}']";
            ClickOnElement(menuxpath);
        }

        public void ClickOnSubMenu(string submenutext)
        {
            string submenuxpath = $"//a[contains(text(),'{submenutext}')]";
            ClickOnElement(submenuxpath);
        }
        public void VerifyHeader(string headername)
        {
            string headerxpath = $"//h1[contains(text(),'{headername}')]";
            Console.WriteLine("Header is " + headername);
        }
        public void AddParentDetails(string Fullname, string username, string email, string dob, string address, string contactno, string gender)
        {
            SetText("//input[@name='full_name']",Fullname);
            SetText("//input[@name='username']", username);
            SetText("//input[@name='email']", email);
            SetText("//input[@name='dob']", dob + Keys.Escape);
            SetText("//input[@name='address']", address);
            SetText("//input[@name='contact']", contactno);
            ClickOnElement($"//input[@value='{gender}']");
            Thread.Sleep(5000);
        }

        public void ClickOnParentButton(string btntext)
        {
            ClickOnElement($"//button[text()='{btntext}']");
        }
    }
}
