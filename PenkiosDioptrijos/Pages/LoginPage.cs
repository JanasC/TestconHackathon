using OpenQA.Selenium;
using PenkiosDioptrijos.Helpers;

namespace Test
{
    public class LoginPage
    {
        private IWebDriver Driver;
        private ClickElementHelper _clickElementHelper;
        private TestLogger _testLogger;

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            _clickElementHelper = new ClickElementHelper(driver);
            _testLogger = new TestLogger();
        }

        public By LoginNameSelector = By.CssSelector("input#ap_email");
        public By PasswordSelector = By.CssSelector("input#ap_password");

        public void LoginToAmazon()
        {
            string LoginNameValue = "5dhackaton2@gmail.com";
            string PasswordValue = "Q!w2e3r4zxc";
            var Loginname = Driver.FindElement(LoginNameSelector);
            var Password = Driver.FindElement(PasswordSelector);
            Loginname.SendKeys(LoginNameValue);
            Password.SendKeys(PasswordValue);
            Password.Submit();
            _testLogger.LogMessage("Attempting login with: - User: " + LoginNameValue + " Password: " + PasswordValue);
        }
        
    }
}
