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
    class BaigiamasisPVZ
    {

        [Test]

        public static void TestEurokosPage()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.eurokos.lt/";

            Thread.Sleep(5000);
            IWebElement Cookies = chrome.FindElement(By.CssSelector("#cookie_popup_container > div.e_cookie_info > div > div > div > a.eurokos_agree_btn.eurokos_agree_btn_1"));
            Cookies.Click();

            IWebElement button = chrome.FindElement(By.CssSelector("#header > div.header-top > div > div > div.header-links.pull-right.hidden-sm.hidden-xs > ul > li:nth-child(2) > a"));
            button.Click();

            IWebElement InputField1 = chrome.FindElement(By.Id("loginUser"));
            string login = "ulanaitee.lina@gmail.com";
            InputField1.SendKeys(login);

            IWebElement InputField2 = chrome.FindElement(By.Id("loginPwd"));
            string password = "Eurokos123";
            InputField2.SendKeys(password);

            IWebElement buttonlogin = chrome.FindElement(By.CssSelector("body > div.container > div > div.col-md-9.col-sm-12 > div > div:nth-child(3) > div > form > button"));
            button.Click();

        
        }
    }

}
