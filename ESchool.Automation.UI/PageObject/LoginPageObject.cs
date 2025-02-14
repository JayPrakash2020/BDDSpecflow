﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTW.Autoamtion.Core.UI.Utility;

namespace ESchool.Automation.UI.PageObject
{
    public class LoginPageObject : UIHelper
    {
        private IWebDriver driver;
        private string loginuserxpaht = "//input[@id='email']";
        private string passwordxpath = "//input[@id='password']";
        private string loginbtnxpath = "//button[@id='submit']";
        private string dasboardheaderxpath = "//h1[contains(text(),'Home')]";
        public LoginPageObject(IWebDriver driver) : base(driver)
        {

        }


        public void EnterUserName(string username)
        {
            SetText(loginuserxpaht, username);
        }
        public void EnterPassword(string password)
        {
            SetText(passwordxpath, password);
        }
        public void ClickonLogin()
        {
            ClickOnElement(loginbtnxpath);
        }
        public void VerifyHeaderText()
        {
            Console.WriteLine(GetText(dasboardheaderxpath));
        }
    }
}