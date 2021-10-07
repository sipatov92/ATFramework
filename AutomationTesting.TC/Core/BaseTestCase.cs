using System;
using AutomationTesting.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Core
{
    public class BaseTestCase
    {
        protected IWebDriver driver;
        protected Configuration Page { get; set; }

        public const string BaseUrl = @"http://localhost/";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Page = new Configuration();
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}