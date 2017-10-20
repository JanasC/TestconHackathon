using OpenQA.Selenium;
using Test;

namespace PenkiosDioptrijos.Helpers
{
    public class ClickElementHelper
    {
        private IWebDriver Driver;
        private TestLogger _testLogger;
        public ClickElementHelper(IWebDriver driver)

        {
            Driver = driver;
        }

        public void ClickElement(By by)
        {
            _testLogger = new TestLogger();
            _testLogger.LogMessage("Clicking Element: "+ by);
            Driver.FindElement(by).Click();
        }
    }
}
