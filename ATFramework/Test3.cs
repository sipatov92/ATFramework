using Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ATFramework
{
    public class Test3 : BaseTestCase
    {
        [Test]
        public void Test()
        {
            driver.Navigate().GoToUrl(BaseUrl);
            driver.FindElement(By.XPath("//a[@href='/key_presses']")).Click();
            var editbox = driver.FindElement(By.Id("target"));
            editbox.SendKeys("a");
            var result = driver.FindElement(By.Id("result"));
            Assert.True(result.Text.Equals("You entered: A"));
            editbox.SendKeys("b");
            Assert.True(result.Text.Equals("You entered: B"));
        }
    }
}