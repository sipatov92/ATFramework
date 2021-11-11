using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTesting.Core
{
    internal static class BaseDriver
    {
        private static readonly Lazy<IWebDriver> _driver = new(() => new ChromeDriver());
        internal static IWebDriver Driver => _driver.Value;
    }
}