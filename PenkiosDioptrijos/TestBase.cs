using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace PenkiosDioptrijos
{
    public class TestBase
    {
        private readonly IWebDriver Driver = new ChromeDriver();
        public IWebDriver GetDriverInstance()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.amazon.com/account");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return Driver;
        }

        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
