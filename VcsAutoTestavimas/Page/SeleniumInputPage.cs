using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VcsAutoTestavimas.Page
{
    public class SeleniumInputPage
    {
        private static IWebDriver _driver;

        IWebElement _inputField => _driver.FindElement(By.Id("user-message"));
        IWebElement _button => _driver.FindElement(By.CssSelector("#get-input > button"));
        IWebElement _text => _driver.FindElement(By.Id("display"));

        public SeleniumInputPage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }

        public void InsertText(string text)
        {
            _inputField.Clear();
            _inputField.SendKeys(text);
        }

        public void ClickShowMessageButton()
        {
            _button.Click();
        }

        public void CheckResult(string expectedResult)
        {
            Assert.AreEqual(expectedResult, _text, "Tekstas neatsirado");
        }

    }
}
