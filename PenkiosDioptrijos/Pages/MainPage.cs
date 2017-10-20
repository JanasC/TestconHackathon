using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PenkiosDioptrijos.Helpers;

namespace Test
{
    public class MainPage
    {
        private IWebDriver Driver;
        private ClickElementHelper _clickElementHelper;

        public MainPage(IWebDriver driver)
        {
            Driver = driver;
            _clickElementHelper = new ClickElementHelper(driver);
        }

        public By SearchFieldSelector = By.Id("twotabsearchtextbox");
        public By SearchDropdownBoxSelector = By.CssSelector("select#searchDropdownBox");
        public By SearchButtonSelector = By.CssSelector("div.nav-right input");

        public void SelectCategory(string category)
        {
            var select = new SelectElement(Driver.FindElement(SearchDropdownBoxSelector));
            select.SelectByText(category);
        }

        public void EnterSearch(string searchText)
        {
            Driver.FindElement(SearchFieldSelector).SendKeys(searchText);
        }

        public void RunSearch()
        {
            _clickElementHelper.ClickElement(SearchButtonSelector);
        }

        public void ExecuteSearch(string category, string searchText)
        {
            SelectCategory(category);
            EnterSearch(searchText);
            RunSearch();
        }

    }
}
