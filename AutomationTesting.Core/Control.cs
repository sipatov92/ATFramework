using OpenQA.Selenium;

namespace AutomationTesting.Core
{
    public class Control
    {
        public IWebElement NativeControl { get; set; }
        public string XPath { get; set; }
        public string Css { get; set; }

        public virtual void Click() => NativeControl.Click();

        public virtual void SetValue(string value) => NativeControl.SendKeys(value);

        public virtual string GetValue() => NativeControl.Text;
    }
}