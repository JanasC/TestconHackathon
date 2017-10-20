using NUnit.Framework;
using PenkiosDioptrijos;
using OpenQA.Selenium;
using PenkiosDioptrijos.Helpers;

namespace Test
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class PlayStation4Test
    {
        private TestBase testBase = new TestBase();
        private ClickElementHelper _clickElementHelper;
        private IWebDriver driver;
        private MainPage _mainPage;
        private LoginPage _loginPage;
        private SearchResultsPage _searchResultsPage;
        private ProductPage _productPage;
        private BasketPage _basketPage;

        [SetUp]
        public void TestInitialize()
        {
            driver = testBase.GetDriverInstance();

            _mainPage = new MainPage(driver);
            _loginPage = new LoginPage(driver);
            _searchResultsPage = new SearchResultsPage(driver);
            _productPage = new ProductPage(driver);
            _basketPage = new BasketPage(driver);

            _loginPage.LoginToAmazon();
        }

        [Test, Order(1)]
        public void SearchForPlayStation4()
        {
            _mainPage.EnterSearch("PlayStation 4 pro console");
            _mainPage.RunSearch();
            _clickElementHelper.ClickElement(_searchResultsPage.Playstation4ConsoleSelector);
            _clickElementHelper.ClickElement(_searchResultsPage.ShipToLithuaniaCheckBox);
            _clickElementHelper.ClickElement(_searchResultsPage.FourStarsAndUpButton);
            _clickElementHelper.ClickElement(_searchResultsPage.FreeShippingByAmazonCheckBox);
            _clickElementHelper.ClickElement(_searchResultsPage.IncludeOutofStock);
        }

        [Test, Order(2)]
        [Ignore("For now")]
        public void AddToBasketPlayStation4()
        {
            _productPage.AddToCart();
        }

        [Test, Order(3)]
        [Ignore("For now")]
        public void PlaceOrderPlayStation4()
        {
            _basketPage.ProceedToCheckout();
            _basketPage.CancelOfferPopUp();
            _basketPage.DeliverToThisAdress();
        }


        [TearDown]
        public void Clean()
        {
            testBase.CleanUp();
        }
    }
}
