using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace DataLayer
{
    public class Class1
    {
        private void TestSomething()
        {
            IWebDriver driver = new ChromeDriver ();
            IWebDriver driver2 = new FirefoxDriver();

            driver.Navigate().GoToUrl("https://program.uffiliates.com/en/auth/login");

            driver.FindElement(by: By.TagName("html"));

        }
    }
}
