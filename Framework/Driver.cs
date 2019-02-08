using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Framework
{
    public class Driver
    {
        IWebDriver driver;
        public IWebDriver init(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    driver = BuildChromeDriver();
                    break;
                case Browser.Firefox:
                    driver = BuildFirefoxDriver();
                    break;
                default:
                    throw new ArgumentException($"{browser} is not locally supported.");
            }

            return driver;
        }

        private ChromeDriver BuildChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            var driverPath = System.Environment.CurrentDirectory;

            return new ChromeDriver(driverPath, options);
        }

        private FirefoxDriver BuildFirefoxDriver()
        {
            var driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}