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

        private Configuration Configuration { get; set; }

        protected const string BaseUrl = @"http://localhost/";

        [SetUp]
        public void Setup()
        {
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Configuration = new Configuration();
        }

        public TPage CreatePage<TPage>() where TPage : BasePage
        {
            TPage page = Configuration.Deserialize<TPage>();
            page.Driver = Driver;
            page.Initialize();
            return page;
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}