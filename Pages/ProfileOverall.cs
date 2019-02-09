using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages
{
    public class ProfileOverall
    {
        private IWebDriver driver;
        public ProfileOverall(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Goto()
        {
            //search results -- select the right profile card
            var profileCard = driver.FindElement(By.XPath("//a[contains(@href, '/players/pc/Katalysm-1137')]"));
            profileCard.Click();
            Thread.Sleep(10000);
        }
    }
}