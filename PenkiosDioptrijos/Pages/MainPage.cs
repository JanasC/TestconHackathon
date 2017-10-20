using NUnit.Framework;
using PenkiosDioptrijos;
using OpenQA.Selenium;
using System.Threading;
using System;
using OpenQA.Selenium.Support.UI;

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

        public void SelectCategory(string category)
        {
            var select = new SelectElement(Driver.FindElement(SearchDropdownBoxSelector));
            select.SelectByText(category);
        }

        public void EnterSearch(string searchText)
        {
            Driver.FindElement(SearchFieldSelector).SendKeys(searchText);
        }

        public void RunSearch()
        {
            Driver.FindElement(SearchButtonSelector).Click();
        }

    }
}
