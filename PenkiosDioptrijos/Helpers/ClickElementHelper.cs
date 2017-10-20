using System;
using OpenQA.Selenium;

namespace PenkiosDioptrijos.Helpers
{
    public class ClickElement
    {
        private IWebDriver Driver;
        public ClickElement(IWebDriver driver)
        {
            Driver = driver;
        }

        public void ClickELement(By by)
        {
            Driver.FindElement(by).Click();
        }
    }
}
