using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace Core
{
    public class BaseTestCaseRemoteDriver 
    {
        protected RemoteWebDriver driver;
        public const string BaseUrl = @"http://172.33.0.1:5000/";
        
        [SetUp]
        public void Setup()
        {
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), new ChromeOptions().ToCapabilities());            
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}