using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ATFramework
{
    public class Test3
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void Test()
        {
            driver.Navigate().GoToUrl(@"http://localhost:5000/");
            driver.FindElement(By.XPath("//a[@href='/key_presses']")).Click();
            var editbox = driver.FindElement(By.Id("target"));
            editbox.SendKeys("a");
            var result = driver.FindElement(By.Id("result"));
            Assert.True(result.Text.Equals("You entered: A"));
            editbox.SendKeys("b");
            Assert.True(result.Text.Equals("You entered: B"));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}