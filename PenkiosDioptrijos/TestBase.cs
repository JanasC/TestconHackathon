using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing.Imaging;
using System.IO;
using static Test.TestLogger;
using OpenQA.Selenium.Firefox;
using System.Configuration;

namespace PenkiosDioptrijos
{
    public class TestBase
    {
        private IWebDriver Driver;

        public IWebDriver GetDriverInstance()
        {
            Driver = GetNewDriverInstance();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["DefaultURL"]);
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
       
        public IWebDriver GetNewDriverInstance()
        {
            
            string browser = ConfigurationManager.AppSettings["Browser"];
            switch (browser)
            {
                case "Firefox":
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
                    service.FirefoxBinaryPath = ConfigurationManager.AppSettings["FireFoxBinary"];
                    Driver = new FirefoxDriver(service);
                    break;
                case "Chrome":
                    Driver = new ChromeDriver();
                    break;
                default:
                    break;
            }
            return Driver;
        }

        public void CleanUp()
        {
            TakeScreenShot();
            LogMessage("Terminating Driver");
            Driver.Quit();
        }
    }
}
