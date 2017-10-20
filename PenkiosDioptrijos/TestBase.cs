using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Firefox;
using System.Configuration;

namespace PenkiosDioptrijos
{
    public class TestBase
    {
        private IWebDriver Driver;

        public IWebDriver GetDriverInstance()
        {
            Driver = GetNewDriverInstance();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.amazon.com/account");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            return Driver;
        }

        public IWebDriver GetNewDriverInstance()
        {
            
            string browser = ConfigurationManager.AppSettings["Browser"];
            switch (browser)
            {
                case "Firefox":
                    Driver = new FirefoxDriver();
                    break;
                case "Chrome":
                    Driver = new ChromeDriver();
                    break;
                default:
                    break;
            }
            return Driver;
        }

        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
