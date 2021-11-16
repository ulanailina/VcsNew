using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VcsAutoTestavimas
{
    class WebDriver
    {
        public static IWebElement IWebElement { get; private set; }

        [Test]

        public static void TestChromeDriver()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://login.yahoo.com/";
            //chrome.Quit();
        }
        [Test]

        public static void TestFirefoxDriver()
        {
            IWebDriver firefox = new FirefoxDriver();
            firefox.Url = "https://login.yahoo.com/";
            //firefox.Quit();
        }

        [Test]

        public static void TestYahooPage()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://login.yahoo.com/";
            IWebElement loginInputField = chrome.FindElement(By.Id ("login-username"));
            loginInputField.SendKeys("ulanaite");
            //chrome.Quit();
        }

        [Test]

        public static void TestSeleniumPage()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            IWebElement InputField = chrome.FindElement(By.Id("user-message"));
            string myText = "Labuka Labuka";
            InputField.SendKeys(myText);

            Thread.Sleep(5000);
            IWebElement popUp = chrome.FindElement(By.Id("at-cv-lightbox-close"));
            popUp.Click();

            IWebElement button = chrome.FindElement(By.CssSelector("#get-input > button"));
            button.Click();
            IWebElement result = chrome.FindElement(By.Id("display"));
            Assert.AreEqual(myText, result.Text, "Tekstas neatsirado");

            //chrome.Quit();
        }

        [Test]

        public static void TestMaximaPage()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.maxima.lt/";
            //chrome.Quit();
        }

       /* Tools>Options>TextEditor>C#>Advanced i r pažymėti varnelę
            “Display all hints while pressing Alt+F1”*/


    }
}
