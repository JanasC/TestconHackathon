using OpenQA.Selenium;
using System.Threading;

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
            Driver.FindElement(by).Click();
        }
    }
}
