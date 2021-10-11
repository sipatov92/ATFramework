using System.Threading;
using AutomationTesting.Core;

namespace AutomationTesting.POM
{
    public class MainPage : BasePage
    {
        public Control MenuItemAccount { get; set; }
        public Control ButtonRegister { get; set; }

        public override void Initialize()
        {
            MenuItemAccount = CreateControl("MenuItemAccount");
            ButtonRegister = CreateControl("ButtonRegister");
        }

        public MainPage ClickMenuItemAccount()
        {
            MenuItemAccount.Click();
            return this;
        }

        public void ClickButtonRegister()
        {
            Thread.Sleep(3000);
            ButtonRegister.Click();
        }
    }
}