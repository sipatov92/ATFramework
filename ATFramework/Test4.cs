using System;
using Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace ATFramework
{
    [TestFixture]
    public class Test4 : BaseTestCase
    {
        private WebDriverWait wait;

        [SetUp]
        public void StartUp()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
        }

        [Test]
        public void Test()
        {
            driver.Navigate().GoToUrl(BaseUrl);
            wait.Until(ElementExists(By.XPath("//h3[normalize-space(.)='Dropdown List']")));
            wait.Until(TextToBePresentInElement(driver.FindElement(By.XPath("//select[@id='dropdown']")),
                "Please select an option"));
            driver.FindElement(By.Id("dropdown")).Click();
            wait.Until(ElementIsVisible(By.XPath("//option[normalize-space(.)='Option 1']")));
            wait.Until(ElementIsVisible(By.XPath("//option[normalize-space(.)='Option 2']")));
            driver.FindElement(By.XPath("//option[normalize-space(.)='Option 2']")).Click();
            Assert.True(driver.FindElement(By.XPath("//option[@selected='selected']")).Text.Equals("Option 2"));
        }
    }
}