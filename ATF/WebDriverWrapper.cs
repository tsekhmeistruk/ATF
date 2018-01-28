using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace ATF
{
    public class WebDriverWrapper : IDisposable
    {
        private double defaultTimeout = 10; 
        private IWebDriver driver;
        private WebDriverWait wait;
        private IJavaScriptExecutor js;

        public WebDriverWrapper(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(defaultTimeout));
            js = driver as IJavaScriptExecutor;
        }

        public void Click(By by)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(by));
            driver.FindElement(by).Click();
        }

        public void OpenPage(string URL)
        {
            driver.Navigate().GoToUrl(URL);
        }

        public string GetTitle()
        {
            return driver.Title;
        }

        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
