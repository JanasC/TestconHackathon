using OpenQA.Selenium;
using PenkiosDioptrijos.Helpers;

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
            var Loginname = Driver.FindElement(LoginNameSelector);
            var Password = Driver.FindElement(PasswordSelector);
            Loginname.SendKeys("5dhackaton2@gmail.com");
            Password.SendKeys("Q!w2e3r4zxc");
            Password.Submit();
        }
        
    }
}
