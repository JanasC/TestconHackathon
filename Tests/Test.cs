using NUnit.Framework;
using PenkiosDioptrijos;
using OpenQA.Selenium;
using System.Threading;
using System;
using PenkiosDioptrijos.Helpers;

namespace Test
{
    [TestFixture]
    public class UnitTests
    {
        private TestBase testBase = new TestBase();
        private ClickElementHelper _clickElementHelper;
        private IWebDriver driver;
        private MainPage _mainPage;
        private LoginPage _loginPage;
        private SearchResultsPage _searchResultsPage;

        [SetUp]
        public void TestInitialize()
        {
            driver = testBase.GetDriverInstance();

            _mainPage = new MainPage(driver);
            _loginPage = new LoginPage(driver);
            _searchResultsPage = new SearchResultsPage(driver);

        }

        [Test]
        public void LoginToAmazonPage()
        {
            _loginPage.LoginToAmazon();
        }

        [Test]
        [Ignore("For now")]
        public void SearchForPlayStation4()
        {
            _mainPage.EnterSearch("PlayStation 4 pro console");

        }

        [Test]
        [Ignore("For now")]
        public void AddToBasketPlayStation4()
        {
        }

        [Test]
        [Ignore("For now")]
        public void PlaceOrderPlayStation4()
        {
        }


        [TearDown]
        public void Clean()
        {
            testBase.CleanUp();
        }
    }
}
