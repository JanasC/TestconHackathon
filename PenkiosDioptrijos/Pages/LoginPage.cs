using OpenQA.Selenium;
using PenkiosDioptrijos.Helpers;
using System.Configuration;
using static Test.TestLogger;

namespace Test
{
    public class LoginPage
    {
        private IWebDriver Driver;
        private ClickElementHelper _clickElementHelper;

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            _clickElementHelper = new ClickElementHelper(driver);
        }

        public By LoginNameSelector = By.CssSelector("input#ap_email");
        public By PasswordSelector = By.CssSelector("input#ap_password");

        public void LoginToAmazon()
        {
            string LoginNameValue = ConfigurationManager.AppSettings["UserName"];
            string PasswordValue = ConfigurationManager.AppSettings["Password"];
            var Loginname = Driver.FindElement(LoginNameSelector);
            var Password = Driver.FindElement(PasswordSelector);
            Loginname.SendKeys(LoginNameValue);
            Password.SendKeys(PasswordValue);
            Password.Submit();
            LogMessage("Attempting login with: - User: " + LoginNameValue + " Password: " + PasswordValue);
        }
        
    }
}
