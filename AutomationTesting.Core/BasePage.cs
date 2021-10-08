using OpenQA.Selenium;

namespace AutomationTesting.Core
{
    public abstract class BasePage
    {
        internal IWebDriver Driver { get; set; }

        protected Control CreateControl(Control control)
        {
            control.NativeControl = Driver.FindElement(By.XPath(control.XPath));
            return control;
        }
    }
}