using NUnit.Framework;
using PenkiosDioptrijos;
using OpenQA.Selenium;
using System.Threading;
using System;

namespace Test
{
    public class MainPage
    {
        private IWebDriver Driver;
        public MainPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public By SearchFieldSelector = By.CssSelector("input.twotabsearchtextbox");
        public By SearchDropdownBoxSelector = By.CssSelector("select#searchDropdownBox");
        public By SearchButtonSelector = By.CssSelector("div.nav-right input");

        public void EnterSearch(string searchText)
        {
            Driver.FindElement(SearchFieldSelector).SendKeys(searchText);
        }
        
    }
}
