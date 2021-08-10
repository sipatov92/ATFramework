using System;
using System.Threading;
using Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace ATFramework
{
    public class Test5 : BaseTestCase
    {
        [Test]
        public void Test()
        {
            Console.WriteLine("Step: 1");
            driver.Navigate().GoToUrl(BaseUrl);
            Console.WriteLine("Step: 2");
            IWebElement menuItemDragAndDrop = driver.FindElement(By.XPath("//a[normalize-space(.)='Drag and Drop']"));
            Assert.AreEqual(true, menuItemDragAndDrop.Displayed, "Verify menuItemDragAndDrop is enabled");
            Console.WriteLine("Step: 3");
            menuItemDragAndDrop.Click();
            IWebElement titleMenuDragAndDrop = driver.FindElement(By.XPath("//H3[normalize-space(.)='Drag and Drop']"));
            Assert.AreEqual(true, titleMenuDragAndDrop.Displayed, "Verify menuItemDragAndDrop exists");
            Console.WriteLine("Step: 4");
            var elA = driver.FindElement(By.XPath("//*[@id='column-a']"));
            var elB = driver.FindElement(By.XPath("//*[@id='column-b']"));
            Actions action = new Actions(driver);
            action.DragAndDrop(elB, elA).Build().Perform();
            //this step doesn't work
            Thread.Sleep(5000);
        }
    }
}