using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace ATF
{
    public class WebDriverWrapperFactory
    {
        private static readonly string defaultBrowser = "chrome";
        private WebDriverWrapper _webDriverWrapper;
        private IWebDriver _driver;


        public WebDriverWrapperFactory(string browserName)
        {
            _driver = ResolveBrowser(browserName);
            InitializeWebDriverWrapper(_driver);
        }

        public WebDriverWrapperFactory() : this(defaultBrowser)
        {
        }

        public WebDriverWrapper WebDriverWrapper
        {
            get
            {
                return _webDriverWrapper;
            }
        }

        private IWebDriver ResolveBrowser(string browserName)
        {
            switch (browserName)
            {
                case "chrome": return new ChromeDriver();
                case "firefox": return new FirefoxDriver();

                default:
                    throw new ArgumentException(String.Format("Browser with name {0} is not supported", browserName));
            }
        }

        private void InitializeWebDriverWrapper(IWebDriver driver)
        {
            _webDriverWrapper = new WebDriverWrapper(driver);
        }
    }
}
