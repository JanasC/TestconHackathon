using OpenQA.Selenium;

namespace Test
{
    public class ProductPage
    {
        private IWebDriver Driver;
        public ProductPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public By AddToCartButtonSelector = By.CssSelector("div.nav-right input");
        public By ContinueToCartButtonSelector = By.CssSelector("form#smartShelfFormContinue input#smartShelfAddToCartNative");
        public By ProceedToCheckoutButtonSelector = By.CssSelector("input.a-button-input[name=proceedToCheckout]");
        
        public void AddToCart()
        {
            Driver.FindElement(AddToCartButtonSelector).Click();
            Driver.FindElement(ContinueToCartButtonSelector).Click();
        }

        public void ProceedToCheckout()
        {
            Driver.FindElement(ProceedToCheckoutButtonSelector).Click();
        }
    }
}
