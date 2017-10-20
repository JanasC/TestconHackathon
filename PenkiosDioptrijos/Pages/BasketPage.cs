using NUnit.Framework;
using PenkiosDioptrijos;
using OpenQA.Selenium;
using System.Threading;
using System;

namespace Test
{
    public class BasketPage
    {
        public By SearchBarSelector = By.CssSelector("input.twotabsearchtextbox");
        private IWebDriver driver;

    }
}
