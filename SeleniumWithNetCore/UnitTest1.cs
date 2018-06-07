using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumWithNetCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


            IWebDriver driver = new ChromeDriver();
            IWebDriver driver2 = new FirefoxDriver();

            driver.Navigate().GoToUrl("https://program.uffiliates.com/en/auth/login");

            driver.FindElement(by: By.TagName("html"));

        }
    }
}
