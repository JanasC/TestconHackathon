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

        public void AddToCart()
        {
            Driver.FindElement(AddToCartButtonSelector).Click();
        }
    }
}
