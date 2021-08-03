using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ATFramework
{
    public class Test1
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
