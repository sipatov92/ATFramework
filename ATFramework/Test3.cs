using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ATFramework
{
    public class Test3
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"http://localhost:5000/");
            driver.FindElement(By.XPath("//a[@href='/key_presses']")).Click();
            var editbox = driver.FindElement(By.Id("target"));
            editbox.SendKeys("a");
            var result = driver.FindElement(By.Id("result"));
            Assert.True(result.Text.Equals("You entered: A"));
            editbox.SendKeys("b");
            Assert.True(result.Text.Equals("You entered: B"));
            driver.Quit();
        }
    }
}