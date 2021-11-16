using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VcsAutoTestavimas
{
    class ND1

    {
        
        [Test]

        public static void TestSeleniumPage()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            IWebElement InputField1 = chrome.FindElement(By.Id("sum1"));
            string sk1 = "2";
            InputField1.SendKeys(sk1);

            IWebElement InputField2 = chrome.FindElement(By.Id("sum2"));
            string sk2 = "2";
            InputField2.SendKeys(sk2);

            Thread.Sleep(5000);
            IWebElement popUp = chrome.FindElement(By.Id("at-cv-lightbox-close"));
            popUp.Click();

            IWebElement button = chrome.FindElement(By.CssSelector("#gettotal > button"));
            button.Click();

            IWebElement result = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("4", result.Text, "2+2 nera 4");
        }

        [Test]

        public static void TestSeleniumPage1()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            IWebElement InputField1 = chrome.FindElement(By.Id("sum1"));
            string sk3 = "-5";
            InputField1.SendKeys(sk3);

            IWebElement InputField2 = chrome.FindElement(By.Id("sum2"));
            string sk4 = "3";
            InputField2.SendKeys(sk4);

            Thread.Sleep(5000);
            IWebElement popUp = chrome.FindElement(By.Id("at-cv-lightbox-close"));
            popUp.Click();

            IWebElement button = chrome.FindElement(By.CssSelector("#gettotal > button"));
            button.Click();

            IWebElement result = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("-2", result.Text, "-5+3 nera -2");
        }

        [Test]

        public static void TestSeleniumPage2()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            IWebElement InputField1 = chrome.FindElement(By.Id("sum1"));
            string ska = "a";
            InputField1.SendKeys(ska);

            IWebElement InputField2 = chrome.FindElement(By.Id("sum2")); 
            string skb = "b";
            InputField2.SendKeys(skb);

            Thread.Sleep(5000);
            IWebElement popUp = chrome.FindElement(By.Id("at-cv-lightbox-close"));
            popUp.Click();

            IWebElement button = chrome.FindElement(By.CssSelector("#gettotal > button"));
            button.Click();

            IWebElement result = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("NaN", result.Text, "a ir b nera skaiciai");
        }
    }
}
