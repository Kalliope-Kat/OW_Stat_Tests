using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Framework;
using OpenQA.Selenium.Firefox;
using Pages;

namespace Tests
{
    public class OverallHomeTests
    {
        IWebDriver driver = new Driver().init(Browser.Chrome);

        [SetUp]
        public void Setup()
        {   
            driver.Navigate().GoToUrl("https://overbuff.com/");
            OverbuffHome homePage = new OverbuffHome(driver);
            homePage.FindPlayer("Katalysm#1137");
            ProfileOverall profileOverall = new ProfileOverall(driver);
            profileOverall.Goto();
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
            Assert.IsTrue(true);
        }
    }
}