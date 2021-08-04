using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Core
{
    public class BaseTestCase 
    {
        public RemoteWebDriver driver;
        


        [SetUp]
        public void Setup()
        {
            var capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
            capabilities.SetCapability(CapabilityType.BrowserVersion, "latest");
            capabilities.SetCapability(CapabilityType.Timeouts, 60);
            driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4444/wd/hub"), capabilities);
            // driver.Manage().Window.Maximize();
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}