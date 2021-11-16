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
    class VT_pasibandymui
    {
        [NUnit.Framework.TestFixture]
        public class UntitledTest
        {
            private IWebDriver driver;
            public IDictionary<string, object> vars { get; private set; }
            private IJavaScriptExecutor js;

            [SetUp]
            public void SetUp()
            {
                driver = new ChromeDriver();
                js = (IJavaScriptExecutor)driver;
                vars = new Dictionary<string, object>();
            }

            [TearDown]
            protected void TearDown()
            {
                //driver.Quit();
            }

            [Test]
            public void untitled()
            {
                driver.Navigate().GoToUrl("http://vartutechnika.lt/");
                driver.Manage().Window.Size = new System.Drawing.Size(883, 802);
                driver.FindElement(By.Id("doors_width")).Click();
                driver.FindElement(By.Id("doors_width")).SendKeys("2000");
                driver.FindElement(By.Id("doors_height")).SendKeys("2500");
                driver.FindElement(By.Id("automatika")).Click();
            }
        }

    }
}
