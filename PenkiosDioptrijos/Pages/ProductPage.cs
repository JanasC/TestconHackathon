using OpenQA.Selenium;
using PenkiosDioptrijos.Helpers;
using static Test.TestLogger;

namespace Test
{
    public class ProductPage
    {
        private IWebDriver Driver;
        private ClickElementHelper _clickElementHelper;

        public ProductPage(IWebDriver driver)
        {
            Driver = driver;
            _clickElementHelper = new ClickElementHelper(driver);
        }

        public By AddToCartButtonSelector = By.CssSelector("div.nav-right input");
        public By ContinueToCartButtonSelector = By.CssSelector("form#smartShelfFormContinue input#smartShelfAddToCartNative");

        public void AddToCart()
        {
            LogMessage("Adding to Cart Using: " + AddToCartButtonSelector);
            _clickElementHelper.ClickElement(AddToCartButtonSelector);
            LogMessage("Clicking Button: " + ContinueToCartButtonSelector);
            _clickElementHelper.ClickElement(ContinueToCartButtonSelector);
        }

    }
}
