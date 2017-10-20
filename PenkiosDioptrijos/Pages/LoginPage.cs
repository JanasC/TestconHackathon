using NUnit.Framework;
using PenkiosDioptrijos;
using OpenQA.Selenium;
using System.Threading;
using System;

namespace Test
{
    public class LoginPage
    {
        private IWebDriver Driver;
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public By SearchFieldSelector = By.CssSelector("input.twotabsearchtextbox");
        public By SearchDropdownBoxSelector = By.CssSelector("select#searchDropdownBox");
        public By SearchButtonSelector = By.CssSelector("div.nav-right input");

        public void LoginToAmazon()
        {
            var Loginname = Driver.FindElement(By.XPath("//input[@id='ap_email']"));
            var Password = Driver.FindElement(By.XPath("//input[@id='ap_password']"));
            Console.WriteLine("Finding elements...");
            Loginname.SendKeys("5dhackaton@gmail.com");
            Password.SendKeys("Q!w2e3r4123");
            Password.Submit();
        }
        
    }
}
