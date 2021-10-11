using System.Collections.Generic;
using OpenQA.Selenium;

namespace AutomationTesting.Core
{
    public abstract class BasePage
    {
        internal IWebDriver Driver { get; set; }

        internal Dictionary<string, Control> ControlRegistry { get; set; }

        public abstract void Initialize();

        protected Control CreateControl(string name)
        {
            Control control = ControlRegistry[name];

            control.NativeControl = Driver.FindElement(By.XPath(control.XPath));

            return control;
        }
    }
}