using ATF;
using System;
using System.Collections.Generic;

namespace PageObjects
{
    public class PageObjectFactory
    {
        WebDriverWrapper driver;
        public PageObjectFactory(WebDriverWrapper driver)
        {
            this.driver = driver;
        }

        private delegate BasePage BasePageConstructor(WebDriverWrapper wedDriverWrapper);

        private static readonly Dictionary<Type, BasePageConstructor>
                pageConstructors = new Dictionary<Type, BasePageConstructor>
                {
                    { typeof(NUnitHomePage), (webDriverWrapper) => new NUnitHomePage(webDriverWrapper) }
                };

        public T GetPage<T>() where T : BasePage
        {
            T page = (T)pageConstructors[typeof(T)](driver);
            return page;
        }
    }
}
