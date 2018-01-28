using NUnit.Framework;
using PageObjects;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class NavigationMenuTest : BaseTest
    {
        [Test]
        public void CheckTitles()
        {
            List<string> menuOptions = new List<string>()
            {
                "News",
                "Documentation",
                "Contact"
            };
            var homePage = PageObjectFactory.GetPage<NUnitHomePage>();
            homePage.Open();

            foreach (var menuOption in menuOptions)
            {
                homePage.OpenMenu(menuOption.ToLower());
                string actualResult = homePage.GetTitle();
                Assert.IsTrue(actualResult.Contains(menuOption));
            }        
        }
    }
}
