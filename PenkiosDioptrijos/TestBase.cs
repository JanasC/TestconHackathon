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
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["DefaultURL"]);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            return Driver;
        }

        public IWebDriver GetNewDriverInstance()
        {
            
            string browser = ConfigurationManager.AppSettings["Browser"];
            switch (browser)
            {
                case "Firefox":
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
                    service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                    Driver = new FirefoxDriver(service);
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
