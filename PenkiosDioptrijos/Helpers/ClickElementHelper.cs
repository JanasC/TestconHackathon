using OpenQA.Selenium;
using System.Threading;
using Test;
using static Test.TestLogger;

namespace PenkiosDioptrijos.Helpers
{
    public class ClickElementHelper
    {
        private IWebDriver Driver;
        public ClickElementHelper(IWebDriver driver)

        {
            Driver = driver;
        }

        public void ClickElement(By by)
        {
            Thread.Sleep(1500);
            LogMessage("Clicking Element: "+ by);
            Driver.FindElement(by).Click();
        }
    }
}
