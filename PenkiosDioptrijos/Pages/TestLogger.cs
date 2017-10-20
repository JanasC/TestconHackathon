using NUnit.Framework;
using PenkiosDioptrijos;
using OpenQA.Selenium;
using System.Threading;
using System;
using OpenQA.Selenium.Support.UI;
using NUnit;

namespace Test
{
    public static class TestLogger
    {
        public static void LogMessage(string Message)
        {
            String TimeStamp = DateTime.Now.ToString("u");
            String Messsage = (TimeStamp + ": - " + Message + "\r\n");
            TestContext.Write(Messsage);
            Console.WriteLine(Messsage);
        }

    }
}
