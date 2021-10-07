using System;
using System.Threading;
using AutomationTesting.POM.MainPage;
using AutomationTesting.POM.RegisterAccountPage;
using Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTesting.TC
{
    public class Test_WI_1 : BaseTestCase
    {
        [Test]
        public void Test()
        {
            var mainPage = Page.Deserializer<MainPage>();
            var registerAccountPage = Page.Deserializer<RegisterAccountPage>();


            Random rnd = new Random();
            var firstName = "Abba" + rnd.Next(1, 50);
            var lastName = "Tarantino" + rnd.Next(1, 50);
            var email = "new" + rnd.Next(1, 50) + "@gmail.com";
            var telephone = rnd.Next(1, 5000).ToString();
            var password = "Qwerty1!";
            driver.Navigate().GoToUrl(BaseUrl);
            Thread.Sleep(4000);
            driver.FindElement(By.XPath(mainPage.MenuItemAccount.XPath)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(mainPage.ButtonRegister.XPath)).Click();
            driver.FindElement(By.XPath(registerAccountPage.EditFirstName.XPath)).SendKeys(firstName);
            driver.FindElement(By.XPath(registerAccountPage.EditLastName.XPath)).SendKeys(lastName);
            driver.FindElement(By.XPath(registerAccountPage.EditEmail.XPath)).SendKeys(email);
            driver.FindElement(By.XPath(registerAccountPage.EditTelephone.XPath)).SendKeys(telephone);
            driver.FindElement(By.XPath(registerAccountPage.EditPassword.XPath)).SendKeys(password);
            driver.FindElement(By.XPath(registerAccountPage.EditConfirmPassword.XPath)).SendKeys(password);
            driver.FindElement(By.XPath(registerAccountPage.RadioButtonNo.XPath))
                .Click();
            driver.FindElement(By.XPath(registerAccountPage.ButtonAgree.XPath)).Click();
            driver.FindElement(By.XPath(registerAccountPage.ButtonContinue.XPath)).Click();
            Thread.Sleep(3000);
        }
    }
}