using OpenQA.Selenium;
using PenkiosDioptrijos.Helpers;
using System;

namespace Test
{
    public class BasketPage
    {
        private IWebDriver Driver;
        private ClickElementHelper _clickElementHelper;

        public BasketPage(IWebDriver driver)
        {
            Driver = driver;
            _clickElementHelper = new ClickElementHelper(driver);
        }

        public By ProceedToCheckoutButtonSelector = By.CssSelector("input.a-button-input[name=proceedToCheckout]");
        public By PopUpHeaderTitleSelector = By.CssSelector("h4.a-popover-header-content");
        public By NoThanksButtonSelector = By.CssSelector("button#siNoCoverage-announce");

        public void ProceedToCheckout()
        {
            _clickElementHelper.ClickElement(ProceedToCheckoutButtonSelector);
        }

        public void CancelOfferPopUp()
        {
            try
            {
                _clickElementHelper.ClickElement(NoThanksButtonSelector);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Offer not shown");
            }
        }
    }
}
