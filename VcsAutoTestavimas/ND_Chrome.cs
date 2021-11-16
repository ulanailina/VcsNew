using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VcsAutoTestavimas
{
    class ND_Chrome
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]

        public static void SetUp()
        {
            _driver.Navigate().GoToUrl("https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]

        public static void TearDown()
        {
            _driver.Quit();
        }

        [Test]

        public static void TestIsItChrome()
        {
            string text = "Chrome";
            IWebElement resultText = _driver.FindElement(By.CssSelector("#primary-detection > div"));
            Assert.IsTrue(resultText.Text.Contains(text), "It is not Chrome");
        }

        [Test]

        public static void TestIsItFireFox()
        {
            string text = "Firefox";
            IWebElement resultText = _driver.FindElement(By.CssSelector("#primary-detection > div"));
            Assert.IsTrue(resultText.Text.Contains(text), "It is not Chrome");
        }



       /* [TestCase("Chrome", "Chrome", TestName = "TestChrome")]
        [TestCase("Firefox", "Firefox", TestName = "TestFirefox")]

        public static void TestBrowser(string browser, string text)
        {
            IWebElement textOnPage = _driver.FindElement(By.CssSelector("#primary-detection > div"));
            _driver = new ChromeDriver();

            if ()
            {
                Assert.IsTrue(textOnPage.Text.Contains(text), "It is not Chrome");
            }

            else if ()
            {
                Assert.IsTrue(textOnPage.Text.Contains(text), "It is not Firefox");
            }

            else
            {

            }
        }*/
    }
}
