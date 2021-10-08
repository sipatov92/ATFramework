using OpenQA.Selenium;

namespace AutomationTesting.Core
{
    public abstract class Control
    {
        internal IWebElement NativeControl { get; set; }
        public string XPath { get; set; }
        public string Css { get; set; }
    }
}