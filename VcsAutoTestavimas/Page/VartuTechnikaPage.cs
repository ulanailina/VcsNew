using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VcsAutoTestavimas.Page
{
    public class VartuTechnikaPage
    {

        private static IWebDriver _driver;

        private IWebElement _widthInput => _driver.FindElement(By.Id("doors_width"));
        private IWebElement _heightInput => _driver.FindElement(By.Id("doors_height"));
        private IWebElement _autoCheckBox => _driver.FindElement(By.Id("automatika"));
        private IWebElement _montavimoCheckBox => _driver.FindElement(By.Id("darbai"));
        private IWebElement _calculateButton => _driver.FindElement(By.Id("calc_submit"));
        private IWebElement _resultBox => _driver.FindElement(By.CssSelector("#calc_result > div"));


        public VartuTechnikaPage(IWebDriver webDriver)
        {
            _driver = webDriver;
        }
    }
}
