using NUnit.Framework;
using PenkiosDioptrijos;
using OpenQA.Selenium;
using System.Threading;
using System;
using OpenQA.Selenium.Support.UI;
using NUnit;

namespace Test
{
    public class TestLogger
    {
        public TestLogger(string Message)
        {
            String TimeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            TestContext.Write(TimeStamp + ": - " + Message);


        }

    }
}
