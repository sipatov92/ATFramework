using System;
using System.Threading;
using Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ATFramework
{
    public class Test_WI_1 : BaseTestCase
    {
        [Test]
        public void Test()
        {
            Random rnd = new Random();
            var firstName = "Abba" + rnd.Next(1,50);
            var lastName = "Tarantino" + rnd.Next(1,50);
            var email = "new" + rnd.Next(1,50) + "@gmail.com";
            var telephone = rnd.Next(1,5000).ToString();
            var password = "Qwerty1!";
            driver.Navigate().GoToUrl(BaseUrl);
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//a//span[.='My Account']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//ul[contains(@class,'dropdown-menu')]//a[.='Register']")).Click();
            driver.FindElement(By.XPath("//input[@name='firstname']")).SendKeys(firstName);
            driver.FindElement(By.XPath("//input[@name='lastname']")).SendKeys(lastName);
            driver.FindElement(By.XPath("//input[@name='email']")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@name='telephone']")).SendKeys(telephone);
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys(password);
            driver.FindElement(By.XPath("//input[@name='confirm']")).SendKeys(password);
            driver.FindElement(By.XPath("//div[@class='col-sm-10']//label[text() and normalize-space(.)='No']")).Click();
            driver.FindElement(By.XPath("//input[@name='agree']")).Click();
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
            Thread.Sleep(3000);
        }
    }
}