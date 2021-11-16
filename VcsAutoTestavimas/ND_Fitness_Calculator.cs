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
    class ND_Fitness_Calculator
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]

        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.active.com/fitness/calculators/pace");
           // _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(By.CssSelector(".optanon-allow-all.accept-cookies-button")).Click();

        }

        [OneTimeTearDown]

        public static void TearDown()
        {
            // _driver.Quit();
        }

        [Test]

        public static void TestCalculator()        // nieko tokio, jeigu selektoriai tokie ilgi?
        {
            IWebElement hours = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(2) > div > label:nth-child(1) > input[type=number]"));
            hours.SendKeys("1");
            IWebElement minutes = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(2) > div > label:nth-child(2) > input[type=number]"));
            minutes.SendKeys("5");
            IWebElement distance = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > label > input[type=number]"));
            distance.SendKeys("13");

            IWebElement kilometers = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > span > span > span.selectboxit-arrow-container > i"));
            kilometers.Click();
            IWebElement kmChoose = _driver.FindElement(By.XPath("/html/body/div[6]/div[5]/div[3]/div/div/div[2]/div/div/div[1]/div/form/div[3]/div/span/span/span[2]"));
            kmChoose.Click();






           /* IWebElement kilometer = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > span > span > span.selectboxit-arrow-container"));
            kilometer.GetAttribute("Kilometers");*/

            //IWebElement selectElem = _driver.FindElement(By.ClassName("selectboxit-arrow-container")); // обращаемся к списку по его классу, если нет ни id, ни class, то обращайтесь по XPath или CssSelector
            //SelectElement select = new SelectElement(selectElem);
            //System.Collections.Generic.IList<OpenQA.Selenium.IWebElement> options = select.Options;
            //select.SelectByText("Kilometers");
            
            //</OpenQA.Selenium.IWebElement>;
            

            
            
            /*<OpenQA.Selenium.IWebElement>
                
                openqa.selenium.iwebelement> options = select.Options;
            select.SelectByText("18%");
</ openqa.selenium.iwebelement >*/


        }
    }
}
