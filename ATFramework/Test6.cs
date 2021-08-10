using System;
using System.Threading;
using Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ATFramework
{
    public class Test6 : BaseTestCase
    {
        [Test]
        public void Test()
        {
            var value = new Random().Next(1, 9999).ToString();

            Console.WriteLine("Step: 1");
            driver.Navigate().GoToUrl(BaseUrl);
            Console.WriteLine("Step: 2");
            var menuItemInputs = driver.FindElement(By.XPath("//a[text() and normalize-space(.)='Inputs']"));
            Assert.AreEqual(true, menuItemInputs.Displayed, "Verify menuItemInputs is displayed");
            menuItemInputs.Click();
            Console.WriteLine("Step: 3");
            IWebElement titleMenuInputs = driver.FindElement(By.XPath("//H3[normalize-space(.)='Inputs']"));
            Assert.AreEqual(true, titleMenuInputs.Displayed, "Verify titleMenuInputs exists");
            Console.WriteLine("Step: 4");
            IWebElement editNumber = driver.FindElement(By.XPath("//input[@type='number']"));
            editNumber.SendKeys(value.ToString());
            Assert.IsTrue(editNumber.GetProperty("value").Contains(value), "No such text");
            Thread.Sleep(5000);
        }
    }
}