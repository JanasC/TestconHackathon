﻿using NUnit.Framework;
using PenkiosDioptrijos;
using OpenQA.Selenium;
using System.Threading;
using System;
using OpenQA.Selenium.Support.UI;

namespace Test
{
    public class ProductPage
    {
        private IWebDriver Driver;
        public ProductPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public By AddToCartButtonSelector = By.CssSelector("div.nav-right input");

        public void AddToCart()
        {
            Driver.FindElement(AddToCartButtonSelector).Click();
        }

    }
}
