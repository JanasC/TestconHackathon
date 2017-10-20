using NUnit.Framework;
using PenkiosDioptrijos;
using OpenQA.Selenium;
using System.Threading;
using System;

namespace Test
{
    public class SearchResultsPage
    {
        private IWebDriver Driver;
        public SearchResultsPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public By SearchBarSelector = By.CssSelector("input.twotabsearchtextbox");
        public By Playstation4ConsoleSelector = By.LinkText("a-link-normal s-ref-text-link");

    }
}
