using System.Threading;
using AutomationTesting.Core;

namespace AutomationTesting.POM
{
    public class MainPage : BasePage
    {
        public Control MenuItemAccount { get; set; }
        public Control ButtonRegister { get; set; }

        private Control MenuItemAccountControl => CreateControl("MenuItemAccount");
        private Control ButtonRegisterControl => CreateControl("ButtonRegister");
        
        public MainPage ClickMenuItemAccount()
        {
            MenuItemAccountControl.Click();
            return this;
        }

        public MainPage ClickButtonRegister()
        {
            Thread.Sleep(3000);
            ButtonRegisterControl.Click();
            return this;
        }
    }
}