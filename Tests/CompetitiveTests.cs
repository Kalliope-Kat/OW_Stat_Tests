using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Framework;
using OpenQA.Selenium.Firefox;
using Pages;

namespace Tests
{
    public class CompetitiveTests
    {
        IWebDriver driver = new Driver().init(Browser.Chrome);

        [SetUp]
        public void Setup()
        {   
            driver.Navigate().GoToUrl("https://overbuff.com/");
            OverbuffHome homePage = new OverbuffHome(driver);
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(false, "this is clearly not true...");
        }
    }
}