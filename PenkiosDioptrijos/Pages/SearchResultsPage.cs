using OpenQA.Selenium;

namespace Test
{
    public class SearchResultsPage
    {
        private IWebDriver Driver;
        public SearchResultsPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public By SearchBarSelector = By.CssSelector("input.twotabsearchtextbox");
        public By Playstation4ConsoleSelector = By.LinkText("a-link-normal s-ref-text-link");

        public By ShipToLithuaniaCheckBox = By.XPath("//span[text()='Ship to Lithuania']/../../input");
        public By FreeShippingByAmazonCheckBox = By.XPath("//span[text()='Free Shipping by Amazon']/../../input");
        public By FourStarsAndUpButton = By.XPath("//span[contains(.,'4 Stars & Up')]");
    }
}
