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
        public By DeliverToThisAdressSelector = By.XPath("//span/a[text()[contains(.,'Deliver to this address')]]");

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

        public void DeliverToThisAdress()
        {
            _clickElementHelper.ClickElement(DeliverToThisAdressSelector);
        }
    }
}
