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

        public By LoginNameSelector = By.CssSelector("input#ap_email");
        public By PasswordSelector = By.CssSelector("input#ap_password");

        public void LoginToAmazon()
        {
            var Loginname = Driver.FindElement(LoginNameSelector);
            var Password = Driver.FindElement(PasswordSelector);
            Console.WriteLine("Finding elements...");
            Loginname.SendKeys("5dhackaton@gmail.com");
            Password.SendKeys("Q!w2e3r4123");
            Password.Submit();
        }
        
    }
}
