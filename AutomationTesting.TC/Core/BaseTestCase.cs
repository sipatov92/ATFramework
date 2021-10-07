using System;
using AutomationTesting.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Core
{
    public class BaseTestCase
    {
        private static readonly Lazy<IWebDriver> _driver = new(() => new ChromeDriver());

        protected static IWebDriver Driver => _driver.Value;

        protected Configuration Page { get; set; }

        public const string BaseUrl = @"http://localhost/";

        [SetUp]
        public void Setup()
        {
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Page = new Configuration();
        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}