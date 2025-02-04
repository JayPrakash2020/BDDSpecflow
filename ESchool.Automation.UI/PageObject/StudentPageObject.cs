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
    public class StudentPageObject : UIHelper
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
        public StudentPageObject(IWebDriver driver) : base(driver)
        {

        }

        public void ClickonLibrary()
        {
            ClickOnElement(studentXpath);
        }
        public void ClickonManageLibrary()
        {
            ClickOnElement(addstudentxpath);
        }
        public string GetHeaderText()
        {
            return GetText(libraryheaderxpath);
        }

        public void SelectClass(string clsvalue)
        {
            SelectByText(Selectclassxpath, clsvalue);
        }
        public void SelectSubject()
        {
            SelectByText(selectsubxpath, "Computer Science");
        }
        public void AddBookName(string bookname)
        { 
            SetText(bookxpath, bookname);
        }
        public void AddAuthor(string authorname)
        {
            SetText(authorxpath, authorname);
        }
        public void AddPublication(string publicationame)
        {
            SetText(publicationxpath, publicationame);
        }
        public void ClickOnSaveBtn()
        {
            ClickOnElement(btnSavexpath);
        }
    }
}