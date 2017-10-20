using NUnit.Framework;
using PenkiosDioptrijos;
using OpenQA.Selenium;
using PenkiosDioptrijos.Helpers;

namespace Test
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class PlayStation4CameraTest
    {
        /*  Search field:
 *  1) Playstation 4 camera
 *  
 *  Filter: 
 *  
 *  1) Ships to Lithuania
 *  2) De:select - Availability: Include Out of Stock
 *  
 *  Sort:
 *  1) By price - 'Relevance'
 *  
 *  Select item which have Amazon`s Choice
 *  //span[@class='a-badge-text' and contains(text(),'Amazon')]/../../../../../../../..
 * 
 * !!!!Save to variables price and delivery date!!!!
 */
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
        public void SearchForCamera()
        {
            _mainPage.EnterSearch("PlayStation 4 camera");
            _mainPage.RunSearch();
            _clickElementHelper.ClickElement(_searchResultsPage.ShipToLithuaniaCheckBox);
            _clickElementHelper.ClickElement(_searchResultsPage.IncludeOutofStock);
        }

        [Test, Order(2)]
        [Ignore("For now")]
        public void AddToBasketCamera()
        {
            _productPage.AddToCart();
        }

        [Test, Order(3)]
        [Ignore("For now")]
        public void PlaceOrderCamera()
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
