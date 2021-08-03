using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ATFramework
{
    public class Test1
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
            driver.FindElement(By.XPath("//a[@href='/add_remove_elements/']")).Click();
            driver.FindElement(By.XPath("//button[@onclick='addElement()']")).Click();
            var buttonDelete = driver.FindElement(By.XPath("//button[@onclick='deleteElement()']"));
            Assert.True(buttonDelete.Displayed, "Button Delete is not Displayed");
            buttonDelete.Click();
            try
            {
                Assert.False(buttonDelete.Displayed, "Button Delete is Displayed");
            }
            catch (StaleElementReferenceException e)
            {
                driver.Quit();
            }
        }
    }
}
