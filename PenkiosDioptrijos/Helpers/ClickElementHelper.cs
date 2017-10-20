using OpenQA.Selenium;
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
            LogMessage("Clicking Element: "+ by);
            Driver.FindElement(by).Click();
        }
    }
}
