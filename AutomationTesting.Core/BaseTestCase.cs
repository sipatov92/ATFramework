using System;
using AutomationTesting.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTesting.Core
{
    public class BaseTestCase
    {
        private static readonly Lazy<IWebDriver> _driver = new(() => new ChromeDriver());

        protected static IWebDriver Driver => _driver.Value;

        protected Configuration Configuration { get; set; }

        public const string BaseUrl = @"http://localhost/";

        [SetUp]
        public void Setup()
        {
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Configuration = new Configuration();
        }

        public TPage CreatePage<TPage>() where TPage : BasePage
        {
            TPage basePage = Configuration.Deserialize<TPage>();
            basePage.Driver = Driver;
            return basePage;
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}