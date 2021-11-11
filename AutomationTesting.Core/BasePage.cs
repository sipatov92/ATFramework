using System.Collections.Generic;
using AutomationTesting.Common;
using OpenQA.Selenium;

namespace AutomationTesting.Core
{
    public abstract class BasePage
    {
        private IWebDriver Driver { get; set; }

        internal Dictionary<string, Control> ControlRegistry { get; set; }

        protected Control CreateControl(string name)
        {
            Control control = ControlRegistry[name];

            control.NativeControl = Driver.FindElement(By.XPath(control.XPath));

            return control;
        }

        public TPage CreatePage<TPage>() where TPage : BasePage, new()
        {
            var page = Configuration.Deserialize<TPage>();
            page.Driver = BaseDriver.Driver;
            return page;
        }
    }
}