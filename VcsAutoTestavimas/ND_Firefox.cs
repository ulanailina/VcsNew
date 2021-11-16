using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VcsAutoTestavimas
{
    class ND_Firefox
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]

        public static void SetUp()
        {
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl("https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]

        public static void TearDown()
        {
            _driver.Quit();
        }

        [Test]

        public static void TestIsItFireFox()
        {
            string text = "Firefox 94";
            IWebElement resultText = _driver.FindElement(By.CssSelector(".simple-major"));
            Assert.IsTrue(resultText.Text.Contains(text), "It is not Firefox 94");
        }
    }
}
