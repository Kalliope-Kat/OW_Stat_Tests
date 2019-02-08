using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages
{
    public class OverbuffHome
    {
        private IWebDriver driver;
        public OverbuffHome(IWebDriver driver) 
        {
            this.driver = driver;
        }

        public void FindPlayer(string blizzardID)
        {
            var wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 30));
            //focus the find player field
            var playerField = wait.Until(driver => driver.FindElement(By.Name("q")));
            playerField.Click();

            //enter blizzardID
            playerField.SendKeys(blizzardID);
            var submitButton = driver.FindElement(By.XPath(".//button"));
            submitButton.Click();
            Thread.Sleep(10000);
        }
    }
}