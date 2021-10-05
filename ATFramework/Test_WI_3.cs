using NUnit.Framework;
using OpenQA.Selenium;
using Core;
using System.Threading;
using System;

namespace ATFramework
{
    public class Test_WI_3 : BaseTestCase
    {
        [Test]

        public void Test()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Random rnd = new Random();
            var name = "Alex" + rnd.Next(1, 999);
            var desc = "This item is full shit this is old model" + rnd.Next(1, 999);
            var success = "Thank you for your review. It has been submitted to the webmaster for approval.";

            driver.Navigate().GoToUrl(BaseUrl);
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//a[contains(@href, 'macbook')]")).Click();
            driver.FindElement(By.XPath("//a[@href = '#tab-review']")).Click();
            driver.FindElement(By.XPath("//input[@name = 'name']")).SendKeys(name);
            if ((string)js.ExecuteScript($"return document.getElementsByName('name')[0].value") != name)
            {
                driver.Quit();
                Assert.Fail();
            }
            driver.FindElement(By.XPath("//textarea[@name = 'text']")).SendKeys(desc);
            if ((string)js.ExecuteScript($"return document.getElementById('input-review').value") != desc)
            {
                driver.Quit();
                Assert.Fail();
            }
            driver.FindElement(By.XPath("//input[@type = 'radio' and @value = '1']")).Click();
            if (driver.FindElement(By.XPath("//input[@type = 'radio' and @value = '1']")).Selected != true)
            {
                driver.Quit();
                Assert.Fail();
            }
            driver.FindElement(By.XPath("//button[normalize-space(.) = 'Continue']")).Click();
            driver.FindElement(By.XPath($"//div[normalize-space(.) = '{success}']"));
            driver.Quit();
        }
    }
}