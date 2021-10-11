using System;
using System.Threading;
using AutomationTesting.Core;
using AutomationTesting.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTesting.TC
{
    public class Test_WI_1 : BaseTestCase
    {
        [Test]
        public void Test()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
            MainPage mainPage = CreatePage<MainPage>();
            


            #region MyRegion
            
            Random rnd = new Random();
            var firstName = "Abba" + rnd.Next(1, 50);
            var lastName = "Tarantino" + rnd.Next(1, 50);
            var email = "new" + rnd.Next(1, 50) + "@gmail.com";
            var telephone = rnd.Next(1, 5000).ToString();
            var password = "Qwerty1!";
            
            #endregion
            
            
            
            // mainPage.MenuItemAccountControl.Click();
            Thread.Sleep(2000);
            mainPage.ClickMenuItemAccount().ClickButtonRegister();
            CreatePage<RegisterAccountPage>();

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
            // Thread.Sleep(3000);
        }
    }
}