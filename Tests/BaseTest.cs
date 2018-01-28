using ATF;
using NUnit.Framework;
using PageObjects;

namespace Tests
{
    [TestFixture]
    public class BaseTest
    {
        private WebDriverWrapper _driver;
        private WebDriverWrapperFactory _driverFactory;
        protected PageObjectFactory PageObjectFactory;


        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driverFactory = new WebDriverWrapperFactory();
            _driver = _driverFactory.WebDriverWrapper;
            PageObjectFactory = new PageObjectFactory(_driver);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Dispose();
        }
    }
}
