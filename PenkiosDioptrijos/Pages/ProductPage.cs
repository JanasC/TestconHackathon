using OpenQA.Selenium;
using PenkiosDioptrijos.Helpers;

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
            _clickElementHelper.ClickElement(AddToCartButtonSelector);
            _clickElementHelper.ClickElement(ContinueToCartButtonSelector);
        }

    }
}
