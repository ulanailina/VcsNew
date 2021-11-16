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
    class ND_SEB_Paskola
    {
        /*3) Parašyti testą, kuris atidaro puslapį  
         * ir patikrina, ar klaipėdietis be vaikų, uždirbantis 1000Eur (atskaičius mokesčius) ir neturintis įsipareigojimų, 
         * galėtų paimti 75000Еur paskolą.*/

        private static IWebDriver _driver;

        [OneTimeSetUp]

        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.seb.lt/privatiems/kreditai-ir-lizingas/kreditai/busto-kreditas-0#1");  
           // _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);  
            
        }

        [OneTimeTearDown]

        public static void TearDown()
        {
            // _driver.Quit();
        }

        [Test]

        public static void TestPaskola()
        {
           

            IWebElement skaiciuokle = _driver.FindElement(By.CssSelector("body > div.dialog-off-canvas-main-canvas > div.paragraph.paragraph--type--hero.paragraph--view-mode--full.mt-n6.mb-lg-7.mb-4 > div > div.d-flex.justify-content-center.mt-auto.mb-3.mb-lg-5.c-container > div > div > div:nth-child(2) > a"));
            skaiciuokle.Click();
            IWebElement pajamos = _driver.FindElement(By.Id("income"));
            pajamos.Clear();
            pajamos.SendKeys("1000");

           /* IWebElement city = _driver.FindElement(By.Id("city"));
            city.Click();*/
            
        }


    }
}
