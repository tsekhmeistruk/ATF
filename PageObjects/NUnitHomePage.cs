using ATF;
using OpenQA.Selenium;
using System;

namespace PageObjects
{
    public class NUnitHomePage : BasePage
    {
        private string _url = @"http://nunit.org/";
        private string menuOptionXpath = "//a[@href='/{0}/']";

        public NUnitHomePage(WebDriverWrapper driver) : base (driver)
        {
        }

        public void Open()
        {
            Driver.OpenPage(_url);
        }
        public void OpenMenu(string menuOption)
        {
            Driver.Click(By.XPath(String.Format(menuOptionXpath, menuOption)));
        }
    }
}
