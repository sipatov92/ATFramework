using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace AutomationTesting.Core
{
    // public class BaseTestCaseRemoteDriver 
    // {
    //     protected RemoteWebDriver driver;
    //     public const string BaseUrl = @"http://172.17.0.1:5000/";
    //     
    //     [SetUp]
    //     public void Setup()
    //     {
    //         var capabilities = new DesiredCapabilities();
    //         capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
    //         capabilities.SetCapability(CapabilityType.BrowserVersion, "92.0");
    //         driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub/"), capabilities);
    //     }
    //
    //     [TearDown]
    //     public void TearDown()
    //     {
    //     }
    // }
}