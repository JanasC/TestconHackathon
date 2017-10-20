using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using static Test.TestLogger;

namespace PenkiosDioptrijos
{
    public class TestBase
    {
        
        private readonly IWebDriver Driver = new ChromeDriver();
        public IWebDriver GetDriverInstance()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.amazon.com/account");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            return Driver;
        }

        public void CleanUp()
        {
            LogMessage("Terminating Driver");
            Driver.Quit();
        }
    }
}
