using System;
using NUnit.Framework;

namespace AutomationTesting.Core
{
    public class BaseTestCase : BasePage
    {
        private const string BaseUrl = @"http://localhost/";

        [SetUp]
        public void Setup()
        {
            BaseDriver.Driver.Navigate().GoToUrl(BaseUrl);
            BaseDriver.Driver.Manage().Window.Maximize();
            BaseDriver.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown() => BaseDriver.Driver.Quit();
    }
}