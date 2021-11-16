using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VcsAutoTestavimas.Page;

namespace VcsAutoTestavimas.Test
{
    public class SeleniumInputTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]

        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-first-form-demo.html");
           // _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement popUp = _driver.FindElement(By.Id("at-cv-lightbox-close"));
            wait.Until(d => popUp.Displayed);
            popUp.Click();
        }

        [OneTimeTearDown]

        public static void TearDown()
        {
            //_driver.Quit();
        }

        [Test]

        public void SeleniumInputTestFirstBlock()
        {
            SeleniumInputPage page = new SeleniumInputPage(_driver);

            
            string myText = "Labuka Labuka";

            page.InsertText(myText);
            page.ClickShowMessageButton();
            page.CheckResult(myText);

        }

       
    }
}
