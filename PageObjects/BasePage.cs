using ATF;
using System;

namespace PageObjects
{
    public abstract class BasePage : IDisposable
    {
        protected WebDriverWrapper Driver;
        public BasePage(WebDriverWrapper driver)
        {
            Driver = driver;
        }

        public string GetTitle()
        {
            return Driver.GetTitle();
        }

        public void Dispose()
        {
            Driver.Dispose();
        }
    }
}
