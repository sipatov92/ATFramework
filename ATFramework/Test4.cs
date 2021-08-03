using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using static SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace ATFramework
{

    [TestFixture]
    public class Test4
    {
        private IWebDriver driver;
        private WebDriverWait wait;


        [SetUp]
        public void StartUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
        }

        [Test]
        public void WI_1()
        {
            const string uri = "http://localhost:5000/dropdown";
            driver.Navigate().GoToUrl(uri);
            wait.Until(ElementExists(By.XPath("//h3[normalize-space(.)='Dropdown List']")));
            wait.Until(TextToBePresentInElement(driver.FindElement(By.XPath("//select[@id='dropdown']")),
                "Please select an option"));
            driver.FindElement(By.XPath("//select[@id='dropdown']")).Click();
            wait.Until(ElementIsVisible(By.XPath("//option[normalize-space(.)='Option 1']")));
            wait.Until(ElementIsVisible(By.XPath("//option[normalize-space(.)='Option 2']")));

            var js = (IJavaScriptExecutor) driver;
            js.ExecuteScript("dropdown.selectedIndex = 2");
            Assert.True(driver.FindElement(By.XPath("//option[@selected='selected']")).Text.Equals("Option 2"));
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}