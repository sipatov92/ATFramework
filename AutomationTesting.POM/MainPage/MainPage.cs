using AutomationTesting.Core;
using OpenQA.Selenium;

namespace AutomationTesting.POM.MainPage
{
    public class MainPage : BasePage
    {
        public CustomControl MenuItemAccount { get; set; }
        public CustomControl ButtonRegister { get; set; }
        
        public IWebElement MenuItemAccountControl => CreateControl(MenuItemAccount).NativeControl;
        public IWebElement ButtonRegisterControl => CreateControl(ButtonRegister).NativeControl;
    }
    
}