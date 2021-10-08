using System;
using System.Threading;
using AutomationTesting.Core;
using AutomationTesting.POM.MainPage;
using AutomationTesting.POM.RegisterAccountPage;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTesting.TC
{
    public class Test_WI_1 : BaseTestCase
    {
        [Test]
        public void Test()
        {
            MainPage mainPage = CreatePage<MainPage>();
            RegisterAccountPage registerAccountPage = CreatePage<RegisterAccountPage>();
            


            Random rnd = new Random();
            var firstName = "Abba" + rnd.Next(1, 50);
            var lastName = "Tarantino" + rnd.Next(1, 50);
            var email = "new" + rnd.Next(1, 50) + "@gmail.com";
            var telephone = rnd.Next(1, 5000).ToString();
            var password = "Qwerty1!";
            Driver.Navigate().GoToUrl(BaseUrl);
            Thread.Sleep(4000);
            mainPage.MenuItemAccountControl.Click();
            Thread.Sleep(2000);
            mainPage.ButtonRegisterControl.Click();
            registerAccountPage.EditFirstNameControl.SendKeys(firstName);
            // Driver.FindElement(By.XPath(registerAccountPage.EditFirstName.XPath)).SendKeys(firstName);
            // Driver.FindElement(By.XPath(registerAccountPage.EditLastName.XPath)).SendKeys(lastName);
            // Driver.FindElement(By.XPath(registerAccountPage.EditEmail.XPath)).SendKeys(email);
            // Driver.FindElement(By.XPath(registerAccountPage.EditTelephone.XPath)).SendKeys(telephone);
            // Driver.FindElement(By.XPath(registerAccountPage.EditPassword.XPath)).SendKeys(password);
            // Driver.FindElement(By.XPath(registerAccountPage.EditConfirmPassword.XPath)).SendKeys(password);
            // Driver.FindElement(By.XPath(registerAccountPage.RadioButtonNo.XPath))
            //     .Click();
            // Driver.FindElement(By.XPath(registerAccountPage.ButtonAgree.XPath)).Click();
            // Driver.FindElement(By.XPath(registerAccountPage.ButtonContinue.XPath)).Click();
            Thread.Sleep(3000);
        }
    }
}