using OpenQA.Selenium;
using System;

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
        public By PopUpHeaderTitleSelector = By.CssSelector("h4.a-popover-header-content");
        public By NoThanksButtonSelector = By.CssSelector("button#siNoCoverage-announce");

        public void ProceedToCheckout()
        {
            Driver.FindElement(ProceedToCheckoutButtonSelector).Click();
        }

        public void CancelOfferPopUp()
        {
            try
            {
                Driver.FindElement(NoThanksButtonSelector).Click();
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Offer not shown");
            }
        }
    }
}
