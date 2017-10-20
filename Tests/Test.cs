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

        [SetUp]
        public void TestInitialize()
        {
            driver = testBase.GetDriverInstance();
            Console.WriteLine("Instance opened...");
            _mainPage = new MainPage(driver);
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

        [TearDown]
        public void Clean()
        {
            testBase.CleanUp();
        }
    }
}
