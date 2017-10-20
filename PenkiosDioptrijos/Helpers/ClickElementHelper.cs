using OpenQA.Selenium;

namespace PenkiosDioptrijos.Helpers
{
    public class ClickElementHelper
    {
        private IWebDriver Driver;
        public ClickElementHelper(IWebDriver driver)
        {
            Driver = driver;
        }

        public void ClickELement(By by)
        {
            Driver.FindElement(by).Click();
        }
    }
}
