using Core;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace ATFramework
{
    public class Test2 : BaseTestCase
    {
        private IWebDriver driver;
 
        [Test]
        public void Test()
        {
            driver.Navigate().GoToUrl(BaseUrl);
            driver.FindElement(By.XPath("//a[@href='/horizontal_slider']")).Click();
            var column1 = driver.FindElement(By.XPath("//input[@type='range']"));
            new Actions(driver).ClickAndHold(column1).MoveByOffset(2, 0).Release().Build().Perform();
            Assert.True(driver.FindElement(By.XPath("//span[@id='range']")).Text.Equals("2.5"));
        }
    }
}