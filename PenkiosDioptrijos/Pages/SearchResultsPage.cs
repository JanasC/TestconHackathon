using OpenQA.Selenium;
using PenkiosDioptrijos.Helpers;

namespace Test
{
    public class SearchResultsPage
    {
        private IWebDriver Driver;
        private ClickElementHelper _clickElementHelper;

        public SearchResultsPage(IWebDriver driver)
        {
            Driver = driver;
            _clickElementHelper = new ClickElementHelper(driver);
        }

        public By SearchBarSelector = By.CssSelector("input.twotabsearchtextbox");
        public By Playstation4ConsoleSelector = By.XPath("//span[text()='PlayStation 4  Consoles']");

        public By ShipToLithuaniaCheckBox = By.XPath("//span[text()='Ship to Lithuania']");
        public By FreeShippingByAmazonCheckBox = By.XPath("//span[text()='Free Shipping by Amazon']");
        public By FourStarsAndUpButton = By.XPath("//span[contains(.,'4 Stars & Up')]");
        public By IncludeOutofStock = By.XPath("//span[text()='Include Out of Stock']");
    }
}
