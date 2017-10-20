using NUnit.Framework;
using PenkiosDioptrijos;
using OpenQA.Selenium;
using PenkiosDioptrijos.Helpers;
using System.Threading;

namespace Test
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class PlayStation4CameraTest
    {
        private TestBase testBase = new TestBase();
        private ClickElementHelper _clickElementHelper;
        private IWebDriver driver;
        private MainPage _mainPage;
        private LoginPage _loginPage;
        private SearchResultsPage _searchResultsPage;
        private ProductPage _productPage;
        private BasketPage _basketPage;

        [OneTimeSetUp]
        public void TestInitialize()
        {
            driver = testBase.GetDriverInstance();

            _mainPage = new MainPage(driver);
            _loginPage = new LoginPage(driver);
            _searchResultsPage = new SearchResultsPage(driver);
            _productPage = new ProductPage(driver);
            _basketPage = new BasketPage(driver);
            _clickElementHelper = new ClickElementHelper(driver);

            _loginPage.LoginToAmazon();
        }

        [Test, Order(1)]
        public void SearchForCamera()
        {
            _mainPage.EnterSearch("PlayStation 4 camera");
            _mainPage.RunSearch();
            _clickElementHelper.ClickElement(_searchResultsPage.ShipToLithuaniaCheckBox);
        }

        [Test, Order(2)]
        public void SelectCamera()
        {
            _clickElementHelper.ClickElement(_searchResultsPage.SelectCamera);
        }

       [Test, Order(3)]
       public void AddToBasketCamera()
       {
           _productPage.AddToCart();
       }

        [OneTimeTearDown]
        public void Clean()
        {
            testBase.CleanUp();
        }
    }
}
