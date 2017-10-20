using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PenkiosDioptrijos.Helpers;
using static Test.TestLogger;

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
        public By ShowFiltersButtonSelector = By.CssSelector("span.s-top-nav-all-filter-expand-text");

        public void SelectCategory(string category)
        {
            var select = new SelectElement(Driver.FindElement(SearchDropdownBoxSelector));
            LogMessage("Attempting to select Category: "+ category + "For Element: "+ SearchDropdownBoxSelector);
            select.SelectByText(category);
        }

        public void EnterSearch(string searchText)
        {
            LogMessage("Attempting to search for: " + searchText + "For Element: " + SearchFieldSelector);
            Driver.FindElement(SearchFieldSelector).SendKeys(searchText);
        }

        public void RunSearch()
        {
            LogMessage("Attempting to execute search for Element: " + SearchFieldSelector);
            _clickElementHelper.ClickElement(SearchButtonSelector);
            try
            {
                _clickElementHelper.ClickElement(ShowFiltersButtonSelector);
            }
            catch
            {

            }

        }

        public void ExecuteSearch(string category, string searchText)
        {
            LogMessage("Attempting to search for: " + searchText + "For Catergory: " + category);
            SelectCategory(category);
            EnterSearch(searchText);
            RunSearch();
        }

    }
}
