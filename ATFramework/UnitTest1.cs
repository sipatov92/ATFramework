using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace ATFramework
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://habr.com/");
            Assert.IsTrue(driver.Url.Contains("habr.com"), "Что-то не так =(");
            driver.Quit();
        }
    }
}
