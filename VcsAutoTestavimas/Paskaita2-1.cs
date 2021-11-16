using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VcsAutoTestavimas
{
    class Paskaita2_1
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]

        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
            _driver.Manage().Window.Maximize();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);  // stabiliau dirba; laukia BET KOKIO elemento pries failinant 10sek

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement popUp = _driver.FindElement(By.Id("at-cv-lightbox-close"));
            wait.Until(d => popUp.Displayed);
            popUp.Click();
        }

        [OneTimeTearDown]

        public static void TearDown()
        {
           // _driver.Quit();
        }

        [TestCase("2", "2", "4", TestName = "2 plius 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 plius 3 = -2")]
        [TestCase("a", "b", "NaN", TestName = "a plius b = NaN")]

        public static void TestSum(string firstName, string secondName, string result)
        {

            IWebElement InputField1 = _driver.FindElement(By.Id("sum1"));
            IWebElement InputField2 = _driver.FindElement(By.Id("sum2"));
            InputField1.Clear();
            InputField1.SendKeys(firstName);
            InputField2.Clear();
            InputField2.SendKeys(secondName);

            _driver.FindElement(By.CssSelector("#gettotal > button")).Click();
            IWebElement resultFromPage = _driver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual(result, resultFromPage.Text, "Result is NOK");
        }
    }
}
