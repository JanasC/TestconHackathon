using OpenQA.Selenium;

namespace Test
{
    public class BasketPage
    {
        private IWebDriver Driver;
        public BasketPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public By ProceedToCheckoutButtonSelector = By.CssSelector("input.a-button-input[name=proceedToCheckout]");

        public void ProceedToCheckout()
        {
            Driver.FindElement(ProceedToCheckoutButtonSelector).Click();
        }
    }
}
