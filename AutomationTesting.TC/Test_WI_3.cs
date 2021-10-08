using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using System;
using AutomationTesting.Core;

namespace AutomationTesting.TC
{
    public class Test_WI_3 : BaseTestCase
    {
        [Test]

        public void Test()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Random rnd = new Random();
            var name = "Alex" + rnd.Next(1, 999);
            var desc = "This item is full shit this is old model" + rnd.Next(1, 999);
            var success = "Thank you for your review. It has been submitted to the webmaster for approval.";

            Driver.Navigate().GoToUrl(BaseUrl);
            Thread.Sleep(5000);
            Driver.FindElement(By.XPath("//a[contains(@href, 'macbook')]")).Click();
            Driver.FindElement(By.XPath("//a[@href = '#tab-review']")).Click();
            Driver.FindElement(By.XPath("//input[@name = 'name']")).SendKeys(name);
            if ((string)js.ExecuteScript($"return document.getElementsByName('name')[0].value") != name)
            {
                Driver.Quit();
                Assert.Fail();
            }
            Driver.FindElement(By.XPath("//textarea[@name = 'text']")).SendKeys(desc);
            if ((string)js.ExecuteScript($"return document.getElementById('input-review').value") != desc)
            {
                Driver.Quit();
                Assert.Fail();
            }
            Driver.FindElement(By.XPath("//input[@type = 'radio' and @value = '1']")).Click();
            if (Driver.FindElement(By.XPath("//input[@type = 'radio' and @value = '1']")).Selected != true)
            {
                Driver.Quit();
                Assert.Fail();
            }
            Driver.FindElement(By.XPath("//button[normalize-space(.) = 'Continue']")).Click();
            Driver.FindElement(By.XPath($"//div[normalize-space(.) = '{success}']"));
            Driver.Quit();
        }
    }
}