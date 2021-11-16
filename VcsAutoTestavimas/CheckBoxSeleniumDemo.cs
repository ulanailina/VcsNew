using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VcsAutoTestavimas
{
    class CheckBoxSeleniumDemo              // NEUZBAIGTA
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]

        public static void SetUp()
        {
            _driver = new ChromeDriver();
            //_driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]

        public static void TearDown()
        {
             _driver.Quit();
        }

        [Test]

        public static void TestFirstCheckBox()
        {
            _driver.FindElement(By.Id("isAgeSelected")).Click();
            IWebElement text = _driver.FindElement(By.Id("txtAge"));
            Assert.IsTrue(text.Text.Equals("Success - Check box is checked"));
        }

        [Test]

        public static void TestAllCheckBoxes()
        {
            IWebElement checkBox = _driver.FindElement(By.CssSelector(".cb1-element"));
            if (checkBox.Selected)
                checkBox.Click();

            IReadOnlyCollection<IWebElement> allCheckBoxes = _driver.FindElements(By.CssSelector(".cb1-element"));
            foreach (IWebElement element in allCheckBoxes)
            {
                element.Click();
            }

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.Id("check1")).Displayed);
            IWebElement text = _driver.FindElement(By.Id("check1"));
            Assert.IsTrue(text.Text.Equals("Uncheck All"), "Tekstas kitoks");
        }

        [Test]

        public static void TestAllCheckBoxes2()
        {
            IWebElement checkBox = _driver.FindElement(By.CssSelector(".cb1-element"));
            if (checkBox.Selected)
                checkBox.Click();

            IReadOnlyCollection<IWebElement> allCheckBoxes = _driver.FindElements(By.CssSelector(".cb1-element"));
            foreach (IWebElement element in allCheckBoxes)
            {
                element.Click();
            }
            _driver.FindElement(By.Id("check1")).Click();
        }
    }
}
