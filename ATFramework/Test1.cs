using NUnit.Framework;
using OpenQA.Selenium;
using Core;

namespace ATFramework
{
    public class Test1 : BaseTestCaseRemoteDriver
    {
        
        [Test]
        public void Test()
        {
            driver.Navigate().GoToUrl(BaseUrl);
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