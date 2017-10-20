using NUnit.Framework;
using PenkiosDioptrijos;
using OpenQA.Selenium;
using System.Threading;
using System;

namespace Test
{
    [TestFixture]
    public class UnitTests
    {
        private TestBase testBase = new TestBase();
        private IWebDriver driver;
        private MainPage _mainPage;
        private LoginPage _loginPage;
        private SearchResultsPage _searchResultsPage;

        [SetUp]
        public void TestInitialize()
        {
            driver = testBase.GetDriverInstance();
            Console.WriteLine("Instance opened...");
            _mainPage = new MainPage(driver);
            _loginPage = new LoginPage(driver);
            _searchResultsPage = new SearchResultsPage(driver);
        }

        [Test]
        public void TestMethod()
        {
            var inputElement = driver.FindElement(By.Id("lst-ib"));
            Console.WriteLine("Finding elements...");
            inputElement.SendKeys("Google");
            inputElement.Submit();
            Thread.Sleep(5000);
        }

        [Test]
        public void LoginToAmazonPage()
        {
            _loginPage.LoginToAmazon();
        }

        [Test]
        public void SearchForPlayStation4()
        {
            _mainPage.EnterSearch("PlayStation 4 pro console");
        }

        [TearDown]
        public void Clean()
        {
            testBase.CleanUp();
        }
    }
}
