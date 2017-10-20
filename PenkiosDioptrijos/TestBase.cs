using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing.Imaging;
using System.IO;
using static Test.TestLogger;

namespace PenkiosDioptrijos
{
    public class TestBase
    {
        
        private readonly IWebDriver Driver = new ChromeDriver();
        public IWebDriver GetDriverInstance()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.amazon.com/account");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            return Driver;
        }


        private void CreateIfMissing(string path)
        {
            bool folderExists = Directory.Exists(path);
            if (!folderExists)
                Directory.CreateDirectory(path);
        }
        public void TakeScreenShot()
        {
            string currentDate = DateTime.Now.ToString("ddd, ddMMMyyyy HHmm");
            ITakesScreenshot screenshotHandler = Driver as ITakesScreenshot;
            Screenshot screenshot = screenshotHandler.GetScreenshot();
            string dir = @"C:\TestResults\";
            screenshot.SaveAsFile(dir + currentDate + "Screenshot" + ".png", ScreenshotImageFormat.Png);
        }
       
        public void CleanUp()
        {
            TakeScreenShot();
            LogMessage("Terminating Driver");
            Driver.Quit();
        }
    }
}
